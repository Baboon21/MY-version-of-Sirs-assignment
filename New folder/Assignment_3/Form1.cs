using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Orders());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Home());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInv_Click(object sender, EventArgs e)
        {
            ShowScreen(new UC_Inventory());
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
    }
}
