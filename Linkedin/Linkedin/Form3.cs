using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Linkedin
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            InitializeListView();
            LoadHypotheticalData();
            listView1.ItemActivate += ListView1_ItemActivate;

            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Centered Form";

            this.FormBorderStyle = FormBorderStyle.FixedDialog; // 


        }

        private void InitializeListView()
        {
            // Set the view to show details.
            listView1.View = View.Details;
            // Allow the user to rearrange columns.
            listView1.AllowColumnReorder = true;
            // Display check boxes.
            listView1.CheckBoxes = false;
            // Select the item and subitems when selection is made.
            listView1.FullRowSelect = true;
            // Display grid lines.
            listView1.GridLines = true;
            // Sort the items in the list in ascending order.
            listView1.Sorting = SortOrder.Ascending;

            // Define columns in the ListView with increased width for better fit
            listView1.Columns.Add("Author Name", 450, HorizontalAlignment.Left); // Increased width
            listView1.Columns.Add("Category", 450, HorizontalAlignment.Left); // Increased width
            listView1.Columns.Add("No of Posts", -2, HorizontalAlignment.Left);

            // Customize font and appearance
            listView1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }


        private void LoadHypotheticalData()
        {
            // Add items to the ListView
            string[,] data = new string[,]
            {
                { "Jacob Weaver", "Science", "100+" },
{ "Morgan Bailey", "Entertainment", "78" },
{ "Chris Taylor", "Politics", "98" },
{ "Pat Jordan", "Sports", "69" },
{ "Kim Lee", "Education", "38" },
{ "Jamie Parker", "Technology", "119" },
{ "Casey Smith", "Health", "58" },
{ "Drew Morgan", "Finance", "127" },
{ "Jordan Pat", "Lifestyle", "86" },
{ "Taylor Chris", "Art", "180" },
{ "Johnson Alex", "Entertainment", "130" },
{ "Parker Jamie", "Politics", "160" },
{ "Lee Kim", "Sports", "478" },
{ "Jordan Casey", "Education", "189" },
{ "Morgan Drew", "Technology", "140" },
{ "Pat Jordan", "Health", "147" },
{ "Smith Casey", "Finance", "157" },
{ "Taylor Jamie", "Lifestyle", "102" },
{ "Bailey Kim", "Art", "129" }

            };

            for (int i = 0; i < data.GetLength(0); i++)
            {
                ListViewItem item = new ListViewItem(data[i, 0]);
                item.SubItems.Add(data[i, 1]);
                item.SubItems.Add(data[i, 2]);
                listView1.Items.Add(item);
            }
        }



        private void ListView1_ItemActivate(object sender, EventArgs e)
        {
            // Create a new instance of Form4
            Form4 form4 = new Form4();

            // Optionally, you can pass data to Form4 based on the selected item
            // For example, to pass the first column's value (Author Name):
            if (listView1.SelectedItems.Count > 0)
            {
                string authorName = listView1.SelectedItems[0].Text; // Get the text of the first column of the selected item
                form4.Text = authorName; // This is an example of setting the title of Form4 to the author's name
                                         // If Form4 has a property or method to set data, use it here
                                         // form4.SetAuthorName(authorName); // Example method to set data in Form4
            }

            // Show Form4
            this.Hide();
            form4.Show();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
