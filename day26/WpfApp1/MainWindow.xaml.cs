﻿using System;
using System.Windows;
using System.Xml.Linq;
using Microsoft.Win32;
using System.Linq;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        private string xmlFilePath = "";
        private XDocument xmlDoc;

        public MainWindow()
        {
            InitializeComponent();
            UpdateButtons();
        }


        private void ShowAllEntries()
        {
            if (xmlDoc == null) return;
            InfoTextBlock.Text = string.Join("\n", xmlDoc.Root.Elements("Entry")
                .Select(x => $"Фамилия: {x.Element("Surname")?.Value}, Дата рождения: {x.Element("BirthDate")?.Value}, Телефон: {x.Element("Phone")?.Value}"));
        }

        private void UpdateButtons()
        {
            bool enabled = !string.IsNullOrEmpty(xmlFilePath);
            AddButton.IsEnabled = enabled;
            SearchButton.IsEnabled = enabled;
            DeleteButton.IsEnabled = enabled;
        }

        private void OpenButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "XML files (*.xml)|*.xml";
                if (dlg.ShowDialog() == true)
                {
                    xmlFilePath = dlg.FileName;
                    FilePathTextBox.Text = xmlFilePath;
                    xmlDoc = XDocument.Load(xmlFilePath);
                    ShowAllEntries();
                    UpdateButtons();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при открытии файла:\n" + ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Здесь предполагается, что у вас есть TextBox'ы: SurnameTextBox, BirthDateTextBox, PhoneTextBox
            if (xmlDoc == null) return;
            XElement newEntry = new XElement("Entry",
                new XElement("Surname", SurnameTextBox.Text),
                new XElement("BirthDate", BirthDateTextBox.Text),
                new XElement("Phone", PhoneTextBox.Text)
            );
            xmlDoc.Root.Add(newEntry);
            xmlDoc.Save(xmlFilePath);
            ShowAllEntries();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (xmlDoc == null) return;
            string del = DeleteTextBox.Text.Trim();
            var toDelete = xmlDoc.Root.Elements("Entry")
                .Where(x => (string)x.Element("Surname") == del)
                .ToList();
            foreach (var entry in toDelete)
                entry.Remove();
            xmlDoc.Save(xmlFilePath);
            ShowAllEntries();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            if (xmlDoc == null) return;
            string search = SearchTextBox.Text.Trim();
            var found = xmlDoc.Root.Elements("Entry")
                .Where(x => (string)x.Element("Surname") == search)
                .ToList();
            if (found.Count > 0)
            {
                InfoTextBlock.Text = string.Join("\n", found.Select(x =>
                    $"Фамилия: {x.Element("Surname")?.Value}, Дата рождения: {x.Element("BirthDate")?.Value}, Телефон: {x.Element("Phone")?.Value}"));
            }
            else
            {
                InfoTextBlock.Text = "Запись не найдена.";
            }
        }
    }
}