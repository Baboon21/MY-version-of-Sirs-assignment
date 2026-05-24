using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InventoryManagement
{

    public partial class UC_Inventory : UserControl
    {

        string filePath = "./Products/products.csv";

        // Inside UC_Inventory.cs
        private BindingList<Product> _inventoryList = new BindingList<Product>();
        private BindingSource _bindingSource = new BindingSource();

        public UC_Inventory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Inventory_Load(object sender, EventArgs e)
        {

            string path = filePath;

            // 1. Load the data into a temporary list

            var tempData = ProductService.LoadFromCSV(path);

            // 2. Clear the BindingList and add the loaded data
            _inventoryList.Clear();
            foreach (var item in tempData)
            {
                _inventoryList.Add(item);
            }

            // 3. Bind the BindingList to the grid
            grdvProducts.DataSource = _inventoryList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate inputs before proceeding
            if (!ValidateInput())
                return;

            // 2. Create the new product
            int newId = _inventoryList.Count + 1000;
            string name = txtName.Text;
            string brand = txtBrand.Text;
            decimal price = decimal.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);


            //application of oobject-oriented programming principles by creating a new instance of the Product class to represent the new product being added to the inventory. This encapsulates the product's properties and behaviors within a single object, making it easier to manage and manipulate the product data throughout the application.
            Product newProduct = new Product(newId, name, brand, price, quantity);

            // 3. Add the new product to the BindingList (which will automatically update the grid)
            _inventoryList.Add(newProduct);

            // 4. Refresh the grid to show the new item
            //what this does in simple terms is that it tells the grid to re-read the data from the BindingList and update its display. This is necessary because when adding a new product to the BindingList, the grid may not automatically reflect the change until it is notified to refresh.
            //By calling _bindingSource.ResetBindings(false),we can make sure that the grid updates immediately to show the newly added product without needing to rebind the entire data source, which can be more efficient and provide a smoother user experience.
            _bindingSource.ResetBindings(false);

            // 5. Clear fields for the next entry

            //User doesn't have to clear fields adding convenience.
            ClearFields();
        }
        private bool ValidateInput()
        {
            // Check if Name contains invalid special characters like #, $, @
            // This regex allows only letters, numbers, and spaces
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Product Name contains invalid characters.");
                return false;
            }

            // Check if Price is a positive decimal
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return false;
            }

            // Check if Quantity is a positive integer
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.");
                return false;
            }

            return true;
        }
        private void ClearFields()
        {
            txtID.Clear();
            txtName.Clear();
            txtBrand.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }

        private void btnDelProd_Click(object sender, EventArgs e)
        {
            // Get the search term from the delete textbox
            string searchTerm = txtDelProd.Text.Trim();

            // Validate that the search term is not empty
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Please enter a Product ID or Name to delete.");
                return;
            }
            // Find the product in the BindingList
            // This checks if the ID matches OR if the Name matches (ignoring case)
            Product productToDelete = _inventoryList.FirstOrDefault(p =>
                p.ProductID.ToString() == searchTerm ||
                p.ProductName.Equals(searchTerm, StringComparison.OrdinalIgnoreCase));


            if (productToDelete != null)
            {
                // Confirm deletion with the user
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {productToDelete.ProductName}?",
                    "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Remove from the BindingList (the grid will update automatically)
                    _inventoryList.Remove(productToDelete);



                    txtDelProd.Clear();
                    MessageBox.Show("Product deleted successfully.");
                }
            }
            else
            {
                MessageBox.Show("No product found matching that ID or Name.");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. Check if a Product ID is present to identify the record
            if (!int.TryParse(txtID.Text, out int idToUpdate))
            {
                MessageBox.Show("Please select a product from the grid to update.");
                return;
            }

            // 2. Find the product in the BindingList using the ID
            var productToUpdate = _inventoryList?.FirstOrDefault(p => p.ProductID == idToUpdate);
            if (productToUpdate == null)
            {
                MessageBox.Show("Selected product not found.");
                return;
            }

            if (!ValidateInputs())
                return;

            // 3. Parse numeric inputs safely
            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Please enter a valid price.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            // 4. Update the object properties (excluding ProductID)
            productToUpdate.ProductName = txtName.Text.Trim();
            productToUpdate.ProductBrand = txtBrand.Text.Trim();
            productToUpdate.ProductPrice = price;
            productToUpdate.ProductQuantity = quantity;

            // 5. Refresh the grid to show the updated data
            _bindingSource?.ResetBindings(false);
            grdvProducts.Refresh();
            // 6. Clear input fields
            ClearFields();
            MessageBox.Show("Product updated successfully in the list.");
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
        private bool ValidateInputs()
        {
            // Check if Name contains invalid special characters like #, $, @
            // This regex allows only letters, numbers, and spaces
            if (!Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9 ]+$"))
            {
                MessageBox.Show("Product Name contains invalid characters.");
                return false;
            }

            // Check if Price is a positive decimal
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Please enter a valid positive price.");
                return false;
            }

            // Check if Quantity is a positive integer
            if (!int.TryParse(txtQuantity.Text, out int qty) || qty < 0)
            {
                MessageBox.Show("Please enter a valid positive quantity.");
                return false;
            }

            return true;
        }
    }
}
