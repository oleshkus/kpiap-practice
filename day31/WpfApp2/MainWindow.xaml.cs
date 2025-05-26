using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows;
using System.Text;

namespace WpfApp2;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly SqlConnection connection;
    private SqlDataAdapter toursAdapter;
    private SqlDataAdapter touristsAdapter;
    private DataTable toursTable;
    private DataTable touristsTable;

    public MainWindow()
    {
        InitializeComponent();
        connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\TourDB.mdf;Integrated Security=True");
        toursAdapter = new SqlDataAdapter();
        touristsAdapter = new SqlDataAdapter();
        toursTable = new DataTable();
        touristsTable = new DataTable();
        InitializeDatabase();
    }

    private void InitializeDatabase()
    {
        try
        {
            using var cmd = new SqlCommand(
                """
                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tours')
                CREATE TABLE Tours (
                    Id INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(100),
                    Country NVARCHAR(100),
                    Price DECIMAL(18,2)
                );

                IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Tourists')
                CREATE TABLE Tourists (
                    Id INT IDENTITY(1,1) PRIMARY KEY,
                    FullName NVARCHAR(100),
                    Passport NVARCHAR(20),
                    Phone NVARCHAR(20)
                );
                """, connection);
            
            connection.Open();
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка инициализации базы данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }

    private void btnLoadTours_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            connection.Open();
            toursAdapter = new SqlDataAdapter("SELECT * FROM Tours", connection);
            toursTable.Clear();
            toursAdapter.Fill(toursTable);
            toursGrid.ItemsSource = toursTable.DefaultView;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки туров: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }

    private void btnLoadTourists_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            connection.Open();
            touristsAdapter = new SqlDataAdapter("SELECT * FROM Tourists", connection);
            touristsTable.Clear();
            touristsAdapter.Fill(touristsTable);
            touristsGrid.ItemsSource = touristsTable.DefaultView;
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка загрузки туристов: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }

    private void btnSave_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            connection.Open();
            
            var builder = new SqlCommandBuilder(toursAdapter);
            toursAdapter.Update(toursTable);
            
            builder = new SqlCommandBuilder(touristsAdapter);
            touristsAdapter.Update(touristsTable);
            
            MessageBox.Show("Изменения сохранены успешно!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }

    private void btnAddTour_Click(object sender, RoutedEventArgs e)
    {
        var newRow = toursTable.NewRow();
        newRow["Name"] = "Новый тур";
        newRow["Country"] = "Страна";
        newRow["Price"] = 0.0m;
        toursTable.Rows.Add(newRow);
    }

    private void btnDeleteTour_Click(object sender, RoutedEventArgs e)
    {
        if (toursGrid.SelectedItem == null)
        {
            MessageBox.Show("Выберите тур для удаления!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный тур?", 
            "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            
        if (result == MessageBoxResult.Yes)
        {
            var row = ((DataRowView)toursGrid.SelectedItem).Row;
            row.Delete();
        }
    }

    private void btnAddTourist_Click(object sender, RoutedEventArgs e)
    {
        var newRow = touristsTable.NewRow();
        newRow["FullName"] = "Новый турист";
        newRow["Passport"] = "Паспорт";
        newRow["Phone"] = "Телефон";
        touristsTable.Rows.Add(newRow);
    }

    private void btnEditTourist_Click(object sender, RoutedEventArgs e)
    {
        if (touristsGrid.SelectedItem == null)
        {
            MessageBox.Show("Выберите туриста для редактирования!", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        var row = ((DataRowView)touristsGrid.SelectedItem).Row;
        // Здесь можно добавить диалог редактирования
        MessageBox.Show("Редактирование туриста", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
    }

    private void btnShowData_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            connection.Open();
            var sb = new StringBuilder();

            // Получаем данные о турах
            using (var cmd = new SqlCommand("SELECT * FROM Tours", connection))
            using (var reader = cmd.ExecuteReader())
            {
                sb.AppendLine("=== ТУРЫ ===");
                while (reader.Read())
                {
                    sb.AppendLine($"ID: {reader["Id"]}");
                    sb.AppendLine($"Название: {reader["Name"]}");
                    sb.AppendLine($"Страна: {reader["Country"]}");
                    sb.AppendLine($"Цена: {reader["Price"]}");
                    sb.AppendLine();
                }
            }

            // Получаем данные о туристах
            using (var cmd = new SqlCommand("SELECT * FROM Tourists", connection))
            using (var reader = cmd.ExecuteReader())
            {
                sb.AppendLine("=== ТУРИСТЫ ===");
                while (reader.Read())
                {
                    sb.AppendLine($"ID: {reader["Id"]}");
                    sb.AppendLine($"ФИО: {reader["FullName"]}");
                    sb.AppendLine($"Паспорт: {reader["Passport"]}");
                    sb.AppendLine($"Телефон: {reader["Phone"]}");
                    sb.AppendLine();
                }
            }

            MessageBox.Show(sb.ToString(), "Данные в базе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Ошибка при чтении данных: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}