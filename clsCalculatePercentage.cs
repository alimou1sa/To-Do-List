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
    public partial class clsCalculatePercentage : Form
    {

        private Mainform form1;
        public clsCalculatePercentage(Mainform form1)
        {
            this.form1 = form1;
            InitializeComponent();
            createCombobox();
        }

        void createCombobox()
        {
            for (int i = 0; i < form1.Getcombobox().Items.Count; i++)
            {
                this.cmbbCategory.Items.Add(form1.Getcombobox().Items[i]);
            }
        }

        DataTable TaskFilter(string searchValue, string columnName,DataTable datatabl)
        {

            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("Checked", typeof(bool));
            dataTable1.Columns.Add("Description", typeof(string));
            dataTable1.Columns.Add("Category", typeof(string));
            dataTable1.Columns.Add("Start Date", typeof(string));
            dataTable1.Columns.Add("End Date", typeof(string));
            dataTable1.Columns.Add("Status", typeof(string));

            foreach (DataRow row in datatabl.Rows)
            {
                // استخراج القيمة من العمود الذي حددته  
                var cellValue = row[columnName].ToString().ToUpper();

                if (form1.checksearch(cellValue, searchValue.ToUpper()))
                {
                    object[] rowValues = new object[dataTable1.Columns.Count];
                    for (int i = 0; i < dataTable1.Columns.Count; i++)
                    {
                        rowValues[i] = row.ItemArray[i];
                    }

                    dataTable1.Rows.Add(rowValues);
                }
            }

            return dataTable1;
        }

        DataTable countCategory( DataTable datatabl,short days)
        {
            DateTime timeNow = DateTime.Now;
            TimeSpan dif = new TimeSpan(days, 0, 0, 0);
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("Checked", typeof(bool));
            dataTable1.Columns.Add("Description", typeof(string));
            dataTable1.Columns.Add("Category", typeof(string));
            dataTable1.Columns.Add("Start Date", typeof(string));
            dataTable1.Columns.Add("End Date", typeof(string));
            dataTable1.Columns.Add("Status", typeof(string));

            foreach (DataRow row in datatabl.Rows)
            {
                // استخراج القيمة من العمود الذي حددته  
                var startDate = Convert.ToDateTime(row[3]);
                var endDate = Convert.ToDateTime(row[4]);


                if ((endDate.Subtract(startDate)<=dif)&&(timeNow>=startDate&&timeNow<=endDate))
                {

                object[] rowValues = new object[dataTable1.Columns.Count];
                    for (int i = 0; i < dataTable1.Columns.Count; i++)
                    {
                        rowValues[i] = row.ItemArray[i];
                    }

                    dataTable1.Rows.Add(rowValues);

                }

                
            }
            return dataTable1;
        }


        short TaskDate()
        {

            if(cmbbDate.SelectedIndex==0)
            {
                return 1;
                
            }

            if (cmbbDate.SelectedIndex == 1)
            {
                return 7;
            }

            if (cmbbDate.SelectedIndex == 2)
            {
                return 30;
            }
            return 1;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbbCategory.SelectedIndex == 0)
            {
               form1.i = 0;
                return;
            }

            if (cmbbCategory.SelectedIndex == 1)
            {
                form1.i = 1;
                return;
            }
            else if (cmbbCategory.SelectedIndex == 2)

            { 
                form1.i = 2;
            return;
            }
            else if (cmbbCategory.SelectedIndex == 3)
            {
                form1.i = 3;
                return;
            }
            else if (cmbbCategory.SelectedIndex == 4)
            {
                form1.i = 4;
                return;
            }
            else if (cmbbCategory.SelectedIndex == 5)
            {
                form1.i = 5;
                return;
            }

        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2ComboBox1_SelectedIndexChanged(sender, e);

            if (cmbbCategory.SelectedIndex==-1)
            {
                MessageBox.Show("You must choose the category ");
                return;
            }


            DataTable DateFilter = new DataTable();
            DateFilter = countCategory(form1.datatabl[form1.i], TaskDate());

            DataTable StatusFilter = new DataTable();
            StatusFilter = TaskFilter("Complete", "Status", DateFilter);


        
                if (Convert.ToInt32(form1.datatabl[form1.i].Rows.Count) == 0)
                {
                    MessageBox.Show("You must Add a Task ");
                    return;
                }

            if ((Convert.ToInt32(StatusFilter.Rows.Count) == 0) || (Convert.ToInt32(DateFilter.Rows.Count) == 0))
            {
                guna2RadialGauge1.Value = 0;
                return;
            }

            guna2RadialGauge1.Value =( Convert.ToInt32(
                StatusFilter.Rows.Count)*100) / Convert.ToInt32(DateFilter.Rows.Count);

      
        }

        private void clsCalculatePercentage_Load(object sender, EventArgs e)
        {

        }
    }
}
