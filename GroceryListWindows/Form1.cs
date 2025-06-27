using GroceryListBusinessLogic;

namespace GroceryListWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string item = textBox1.Text.Trim();

            if (!string.IsNullOrWhiteSpace(item))
            {
                listBox1.Items.Add(item);
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please enter an item to add.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedItem = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(selectedItem);
                MessageBox.Show($"Removed: {selectedItem}");
            }
            else
            {
                MessageBox.Show("Select an item to remove from the list.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                var confirm = MessageBox.Show("Clear all items?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    listBox1.Items.Clear();
                    MessageBox.Show("All items cleared.");
                }
            }
            else
            {
                MessageBox.Show("The list is already empty.");
            }

        }
    }
}
