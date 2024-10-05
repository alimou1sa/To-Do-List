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
    public partial class cls_Manage_Category : Form
    {
           private Mainform form1;
           private clsCalculatePercentage form2;


        public cls_Manage_Category(Mainform form1)
        {
           InitializeComponent();
           this.form1 = form1;
        
           btnAddCategory.Click += AddItemButton_Click;

        }
       
        bool checkisnull()
        {

            ErrorProvider noty = new ErrorProvider();

            if (string.IsNullOrEmpty(guna2TextBox1.Text))
            {

                noty.SetError(guna2TextBox1, "Text Should have a value!");

                guna2TextBox1.Focus();

              return true;
            }
           return false;
          
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
                if (checkisnull())
                {
                   return;
                }
             
                if(!form1.AddItemToComboBox(guna2TextBox1.Text))
                {
                 return;
                }

                if (MessageBox.Show("Add Up", guna2TextBox1.Text + " Added") == DialogResult.OK)
                {
                    guna2TextBox1.Text = "";
                    guna2TextBox1.Focus();
                }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
     
            if (checkisnull())
            {
                return;
            }

            if (!form1.RemoveItemToComboBox(guna2TextBox1.Text))

            {
                MessageBox.Show("You Cannot find this Category", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("it has been successfully Removed",
                             guna2TextBox1.Text + " remover") == DialogResult.OK)
                {
                    guna2TextBox1.Text = "";
                    guna2TextBox1.Focus();
                }
            }
                
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
