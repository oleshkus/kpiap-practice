
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedText = listBox1.SelectedItem.ToString();
                string result = selectedText.Replace('�', '*');
                lbResult.Text = "���������: " + result;
            }
            else
            {
                lbResult.Text = "����������, �������� ������ �� ������";
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
