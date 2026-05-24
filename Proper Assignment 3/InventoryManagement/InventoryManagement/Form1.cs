namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // ProductService.LoadFromCSV("./Products/products.csv");
        }

        private void ShowScreen(UserControl newScreen)
        {
            // Loop through existing controls and dispose them to free memory
            foreach (Control ctrl in pnlContent.Controls)
            {
                ctrl.Dispose();
            }

            pnlContent.Controls.Clear();
            newScreen.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newScreen);
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Inventory());
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
