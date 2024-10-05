using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_8_To_do_list
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
            CreatNewDataTable();
            createcombobox();
        }

        public bool AddItemToComboBox(string item)
        {

            if(cmbbCategory.Items.Count>=5)
            {
                MessageBox.Show("You Cannot Add New Category", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                a++;
                i = a;
                cmbbCategory.Items.Add(item);
                CreatNewDataTable();
                return true;
            }
            return false;
        }

        public bool RemoveItemToComboBox(string item)
        {
  

            if(string.IsNullOrEmpty(item))
            {
                return false;
            }

            for(int i=0;i<cmbbCategory.Items.Count;i++)
            {
                if (cmbbCategory.Items[i].ToString().ToLower()== item.ToLower())
                {
                    cmbbCategory.Items.Remove(item);
                    return true;
                }
            }


              

            return false;
        }


        public DateTime timenow = DateTime.Now;
        public DataTable[] datatabl = new DataTable[5];
        public byte i = 0;
        byte a = 0;
        public DataView dataView;
        string status = "Pending";
        string Category = "Personal";


        public Guna2DataGridView GetGridView ()
        {
            return guna2DataGridView;
        }

        public Guna2ComboBox Getcombobox()
        {
            return cmbbCategory;
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            cmbbCategory_SelectedIndexChanged(sender, e);
            datatabl[i].Rows.Add(0, "Add Task", Category, timenow.ToShortDateString(),
                    timenow.AddDays(1).ToShortDateString(), status);

            searchabout(Category, "Category");

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            cmbbCategory_SelectedIndexChanged(sender, e);
            if (guna2DataGridView.Rows.Count == 0)
            {
                MessageBox.Show("No Tasks", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure ", "Wrong", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
                {
                    datatabl[i].Rows.RemoveAt(guna2DataGridView.CurrentCell.RowIndex);
                    dataView = new DataView(datatabl[i]);
                    guna2DataGridView.DataSource = dataView;
                    guna2DataGridView.Refresh();
                }
                else
                {
                    return;
                }
            }

        }

        public bool checksearch(string item, string srerchvalue)
        {

            if (string.IsNullOrEmpty(item))
            {

                return true;

            }

            if (item.Length < srerchvalue.Length)
            {
                return false;
            }

            for (int i = 0; i < srerchvalue.Length; i++)
            {


                if (srerchvalue[i] != item[i])
                {
                    return false;
                }

            }

            return true;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue1 = txtbSearch.Text;
            cmbbCategory_SelectedIndexChanged(sender, e);
            searchabout(searchValue1, "Description");

        }

        public void searchabout(string searchValue, string columnName)
        {

            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("Checked", typeof(bool));
            dataTable1.Columns.Add("Description", typeof(string));
            dataTable1.Columns.Add("Category", typeof(string));
            dataTable1.Columns.Add("Start Date", typeof(DateTime));
            dataTable1.Columns.Add("End Date", typeof(DateTime));
            dataTable1.Columns.Add("Status", typeof(string));
          
            foreach (DataRow row in datatabl[i].Rows)
            {
                // استخراج القيمة من العمود الذي حددته  
                var cellValue = row[columnName].ToString().ToUpper();
               
                if (checksearch(cellValue, searchValue.ToUpper()))
                {
                    object [] rowValues = new object[dataTable1.Columns.Count];
                    for (int i = 0; i < dataTable1.Columns.Count; i++)
                    {
                        rowValues[i] = row.ItemArray[i];
                    }

                    dataTable1.Rows.Add(rowValues);
                }
            }

            dataView = new DataView(dataTable1);
            guna2DataGridView.DataSource = dataView;
        }

        public void createcombobox()
        {
            cmbbCategory.Items.Add("Personal");
            cmbbCategory.Location = new System.Drawing.Point(8, 61);
            cmbbCategory.ForeColor = System.Drawing.Color.Black;
            cmbbCategory.Font = new Font("Tohama", 16);
            cmbbCategory.StartIndex = 0;
            cmbbCategory.BorderRadius = 22;
            this.Controls.Add(cmbbCategory);

        }

        private void guna2DataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {



            if (e.ColumnIndex == guna2DataGridView.Columns["Description"].Index
                && e.RowIndex >= 0)
            {

                datatabl[i].Rows[e.RowIndex]["Description"] = guna2DataGridView[1, e.RowIndex].Value;
          
            }

            else if (e.ColumnIndex == guna2DataGridView.Columns[3].Index
                && e.RowIndex >= 0)
            {
                datatabl[i].Rows[e.RowIndex][3] = guna2DataGridView[3, e.RowIndex].Value;
            }

           else if (e.ColumnIndex == guna2DataGridView.Columns[4].Index
                && e.RowIndex >= 0)
            {
                datatabl[i].Rows[e.RowIndex][4] = guna2DataGridView[4, e.RowIndex].Value;
            }


            if (e.ColumnIndex == guna2DataGridView.Columns["Checked"].Index
                && e.RowIndex >= 0)
            {
                bool isChecked = Convert.ToBoolean(guna2DataGridView[0,
                e.RowIndex].Value);

              // bool isChecked = Convert.ToBoolean(guna2DataGridView.CurrentCell.Value);

                if (isChecked)
                {
                    guna2DataGridView[5, e.RowIndex].Value = "Complete";
                }

                if (!isChecked)
                {

                    guna2DataGridView[5, e.RowIndex].Value = "Pending";
                }

                if (datatabl != null)
                {
                    datatabl[i].Rows[e.RowIndex]["Checked"] = isChecked ? true : false;
                    datatabl[i].Rows[e.RowIndex]["Status"] = isChecked ? "Complete" : "Pending";
                }

                guna2DataGridView.Refresh();
            }


        }

        private void CmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbbCategory_SelectedIndexChanged(sender, e);
            if (CmbStatusFilter.SelectedIndex == 0)
            {
                dataView = new DataView(datatabl[i]);
                guna2DataGridView.DataSource = dataView;
                return;
            }

            if (CmbStatusFilter.SelectedIndex == 1)
            {
                searchabout("Pending", "Status");
                return;
            }
            if (CmbStatusFilter.SelectedIndex == 2)
            {
                searchabout("Complete", "Status");
                return;
            }


        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            clsTimer main = new clsTimer();
            main.Show();
        }

        private void btnManageCatogery_Click(object sender, EventArgs e)
        {
            cls_Manage_Category main = new cls_Manage_Category(this);
            main.Show();
        }

       public void CreatNewDataTable()
        {
        
                datatabl[i] = new DataTable($"DataTable_{i + 1}");

                datatabl[i].Columns.Add("Checked", typeof(bool));
                datatabl[i].Columns.Add("Description", typeof(string));
                datatabl[i].Columns.Add("Category", typeof(string));
                datatabl[i].Columns.Add("Start Date", typeof(string));
                datatabl[i].Columns.Add("End Date", typeof(string));
                datatabl[i].Columns.Add("Status", typeof(string));
            
        }

        private void cmbbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbbCategory.SelectedIndex == 0)
            {
                i = 0;
                searchabout("Personal", "Category");
                Category = cmbbCategory.Items[0].ToString();
                return;
            }

            if (cmbbCategory.SelectedIndex == 1)
            {  
                i = 1;
                searchabout(cmbbCategory.Items[1].ToString(), "Category");
                Category = cmbbCategory.Items[1].ToString();
                return;
            }
            else if (cmbbCategory.SelectedIndex == 2)
            {
                i = 2;
                searchabout(cmbbCategory.Items[2].ToString(), "Category");
                Category = cmbbCategory.Items[2].ToString();
                return;
            }
            else if (cmbbCategory.SelectedIndex == 3)
            {  
                i = 3;
                searchabout(cmbbCategory.Items[3].ToString(), "Category");
                Category = cmbbCategory.Items[3].ToString();
                return;
            }
            else if (cmbbCategory.SelectedIndex == 4)
            { 
                i = 4;
                searchabout(cmbbCategory.Items[4].ToString(), "Category");
                Category = cmbbCategory.Items[4].ToString();
                return;
            }
            else if (cmbbCategory.SelectedIndex == 5)
            { 
                i = 5;
                searchabout(cmbbCategory.Items[5].ToString(), "Category");
                Category = cmbbCategory.Items[5].ToString();
                return;
            }

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {      
            clsCalculatePercentage maine= new clsCalculatePercentage(this);
            maine.Show();
        }

        private void guna2TextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtbSearch.Text == "Search Item...")
                txtbSearch.Text = "";
        }

        private void btnExite_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
