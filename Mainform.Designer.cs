namespace project_8_To_do_list
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddTask = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.txtbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CmbStatusFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTimer = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageCategory = new Guna.UI2.WinForms.Guna2Button();
            this.cmbbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2Button();
            this.btnExite = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddTask.BorderRadius = 11;
            this.btnAddTask.BorderThickness = 3;
            this.btnAddTask.CheckedState.Parent = this.btnAddTask;
            this.btnAddTask.CustomImages.Parent = this.btnAddTask;
            this.btnAddTask.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddTask.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAddTask.HoverState.Parent = this.btnAddTask;
            this.btnAddTask.Location = new System.Drawing.Point(996, 74);
            this.btnAddTask.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.PressedColor = System.Drawing.Color.Aqua;
            this.btnAddTask.ShadowDecoration.Parent = this.btnAddTask;
            this.btnAddTask.Size = new System.Drawing.Size(224, 57);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add Tasks";
            this.btnAddTask.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDelete.BorderRadius = 11;
            this.btnDelete.BorderThickness = 3;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDelete.Font = new System.Drawing.Font("Verdana", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(996, 11);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PressedColor = System.Drawing.Color.Aqua;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(224, 57);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "      Delete taske";
            this.btnDelete.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // txtbSearch
            // 
            this.txtbSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtbSearch.BorderColor = System.Drawing.Color.Black;
            this.txtbSearch.BorderRadius = 22;
            this.txtbSearch.BorderThickness = 3;
            this.txtbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbSearch.DefaultText = "Search Item...";
            this.txtbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSearch.DisabledState.Parent = this.txtbSearch;
            this.txtbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbSearch.FillColor = System.Drawing.SystemColors.Highlight;
            this.txtbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearch.FocusedState.Parent = this.txtbSearch;
            this.txtbSearch.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.txtbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbSearch.HoverState.Parent = this.txtbSearch;
            this.txtbSearch.Location = new System.Drawing.Point(344, 76);
            this.txtbSearch.Margin = new System.Windows.Forms.Padding(7);
            this.txtbSearch.Name = "txtbSearch";
            this.txtbSearch.PasswordChar = '\0';
            this.txtbSearch.PlaceholderText = "";
            this.txtbSearch.SelectedText = "";
            this.txtbSearch.SelectionStart = 14;
            this.txtbSearch.ShadowDecoration.Parent = this.txtbSearch;
            this.txtbSearch.Size = new System.Drawing.Size(325, 59);
            this.txtbSearch.TabIndex = 3;
            this.txtbSearch.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.txtbSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.guna2TextBox1_MouseClick);
            // 
            // guna2DataGridView
            // 
            this.guna2DataGridView.AllowUserToAddRows = false;
            this.guna2DataGridView.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.guna2DataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.guna2DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.guna2DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView.ColumnHeadersHeight = 44;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.guna2DataGridView.EnableHeadersVisualStyles = false;
            this.guna2DataGridView.GridColor = System.Drawing.Color.Blue;
            this.guna2DataGridView.Location = new System.Drawing.Point(239, 136);
            this.guna2DataGridView.MultiSelect = false;
            this.guna2DataGridView.Name = "guna2DataGridView";
            this.guna2DataGridView.RowHeadersVisible = false;
            this.guna2DataGridView.RowHeadersWidth = 51;
            this.guna2DataGridView.RowTemplate.Height = 26;
            this.guna2DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView.Size = new System.Drawing.Size(990, 544);
            this.guna2DataGridView.TabIndex = 4;
            this.guna2DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.FeterRiver;
            this.guna2DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(244)))));
            this.guna2DataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView.ThemeStyle.BackColor = System.Drawing.Color.RoyalBlue;
            this.guna2DataGridView.ThemeStyle.GridColor = System.Drawing.Color.Blue;
            this.guna2DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.guna2DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView.ThemeStyle.HeaderStyle.Height = 44;
            this.guna2DataGridView.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(234)))), ((int)(((byte)(247)))));
            this.guna2DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView.ThemeStyle.RowsStyle.Height = 26;
            this.guna2DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(186)))), ((int)(((byte)(231)))));
            this.guna2DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.guna2DataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView_CellValueChanged);
            // 
            // CmbStatusFilter
            // 
            this.CmbStatusFilter.BackColor = System.Drawing.Color.Transparent;
            this.CmbStatusFilter.BorderColor = System.Drawing.Color.Black;
            this.CmbStatusFilter.BorderRadius = 22;
            this.CmbStatusFilter.BorderThickness = 3;
            this.CmbStatusFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CmbStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbStatusFilter.FillColor = System.Drawing.SystemColors.Highlight;
            this.CmbStatusFilter.FocusedColor = System.Drawing.Color.Empty;
            this.CmbStatusFilter.FocusedState.Parent = this.CmbStatusFilter;
            this.CmbStatusFilter.Font = new System.Drawing.Font("Segoe UI Emoji", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbStatusFilter.ForeColor = System.Drawing.Color.Black;
            this.CmbStatusFilter.FormattingEnabled = true;
            this.CmbStatusFilter.HoverState.Parent = this.CmbStatusFilter;
            this.CmbStatusFilter.ItemHeight = 42;
            this.CmbStatusFilter.Items.AddRange(new object[] {
            "All",
            "Pending",
            "Completed"});
            this.CmbStatusFilter.ItemsAppearance.Parent = this.CmbStatusFilter;
            this.CmbStatusFilter.Location = new System.Drawing.Point(678, 77);
            this.CmbStatusFilter.Name = "CmbStatusFilter";
            this.CmbStatusFilter.ShadowDecoration.Parent = this.CmbStatusFilter;
            this.CmbStatusFilter.Size = new System.Drawing.Size(314, 48);
            this.CmbStatusFilter.StartIndex = 0;
            this.CmbStatusFilter.TabIndex = 3;
            this.CmbStatusFilter.SelectedIndexChanged += new System.EventHandler(this.CmbStatusFilter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(352, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search Item";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(670, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 46);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filtering";
            // 
            // btnTimer
            // 
            this.btnTimer.BorderRadius = 15;
            this.btnTimer.BorderThickness = 2;
            this.btnTimer.CheckedState.Parent = this.btnTimer;
            this.btnTimer.CustomImages.Parent = this.btnTimer;
            this.btnTimer.Font = new System.Drawing.Font("Rockwell Extra Bold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimer.ForeColor = System.Drawing.Color.Black;
            this.btnTimer.HoverState.Parent = this.btnTimer;
            this.btnTimer.Location = new System.Drawing.Point(8, 39);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.ShadowDecoration.Parent = this.btnTimer;
            this.btnTimer.Size = new System.Drawing.Size(226, 63);
            this.btnTimer.TabIndex = 8;
            this.btnTimer.Text = "Timer";
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.BorderRadius = 15;
            this.btnManageCategory.BorderThickness = 2;
            this.btnManageCategory.CheckedState.Parent = this.btnManageCategory;
            this.btnManageCategory.CustomImages.Parent = this.btnManageCategory;
            this.btnManageCategory.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCategory.ForeColor = System.Drawing.Color.Black;
            this.btnManageCategory.HoverState.Parent = this.btnManageCategory;
            this.btnManageCategory.Location = new System.Drawing.Point(8, 142);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.ShadowDecoration.Parent = this.btnManageCategory;
            this.btnManageCategory.Size = new System.Drawing.Size(226, 63);
            this.btnManageCategory.TabIndex = 10;
            this.btnManageCategory.Text = "Manage Categories";
            this.btnManageCategory.Click += new System.EventHandler(this.btnManageCatogery_Click);
            // 
            // cmbbCategory
            // 
            this.cmbbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbbCategory.BorderColor = System.Drawing.Color.Black;
            this.cmbbCategory.BorderRadius = 22;
            this.cmbbCategory.BorderThickness = 3;
            this.cmbbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbCategory.FillColor = System.Drawing.SystemColors.Highlight;
            this.cmbbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbbCategory.FocusedState.Parent = this.cmbbCategory;
            this.cmbbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbbCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbbCategory.FormattingEnabled = true;
            this.cmbbCategory.HoverState.Parent = this.cmbbCategory;
            this.cmbbCategory.ItemHeight = 42;
            this.cmbbCategory.ItemsAppearance.Parent = this.cmbbCategory;
            this.cmbbCategory.Location = new System.Drawing.Point(-1, 86);
            this.cmbbCategory.Name = "cmbbCategory";
            this.cmbbCategory.ShadowDecoration.Parent = this.cmbbCategory;
            this.cmbbCategory.Size = new System.Drawing.Size(328, 48);
            this.cmbbCategory.TabIndex = 11;
            this.cmbbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbbCategory_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 46);
            this.label3.TabIndex = 12;
            this.label3.Text = "Category";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BorderRadius = 15;
            this.btnCalculate.BorderThickness = 2;
            this.btnCalculate.CheckedState.Parent = this.btnCalculate;
            this.btnCalculate.CustomImages.Parent = this.btnCalculate;
            this.btnCalculate.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.HoverState.Parent = this.btnCalculate;
            this.btnCalculate.Location = new System.Drawing.Point(8, 245);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.ShadowDecoration.Parent = this.btnCalculate;
            this.btnCalculate.Size = new System.Drawing.Size(226, 63);
            this.btnCalculate.TabIndex = 13;
            this.btnCalculate.Text = "Calculate ";
            this.btnCalculate.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // btnExite
            // 
            this.btnExite.BorderRadius = 15;
            this.btnExite.BorderThickness = 2;
            this.btnExite.CheckedState.Parent = this.btnExite;
            this.btnExite.CustomImages.Parent = this.btnExite;
            this.btnExite.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExite.ForeColor = System.Drawing.Color.Black;
            this.btnExite.HoverState.Parent = this.btnExite;
            this.btnExite.Location = new System.Drawing.Point(8, 348);
            this.btnExite.Name = "btnExite";
            this.btnExite.ShadowDecoration.Parent = this.btnExite;
            this.btnExite.Size = new System.Drawing.Size(226, 63);
            this.btnExite.TabIndex = 14;
            this.btnExite.Text = "Exite";
            this.btnExite.Click += new System.EventHandler(this.btnExite_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 33;
            this.guna2Panel1.BorderThickness = 7;
            this.guna2Panel1.Controls.Add(this.btnExite);
            this.guna2Panel1.Controls.Add(this.btnTimer);
            this.guna2Panel1.Controls.Add(this.btnCalculate);
            this.guna2Panel1.Controls.Add(this.btnManageCategory);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Brown;
            this.guna2Panel1.FillColor = System.Drawing.Color.Purple;
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 191);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(241, 490);
            this.guna2Panel1.TabIndex = 18;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.guna2DateTimePicker1.BorderRadius = 13;
            this.guna2DateTimePicker1.BorderThickness = 2;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.Teal;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(7, 140);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(226, 45);
            this.guna2DateTimePicker1.TabIndex = 19;
            this.guna2DateTimePicker1.TabStop = false;
            this.guna2DateTimePicker1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 10, 3, 13, 9, 50, 246);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.BlueViolet;
            this.ClientSize = new System.Drawing.Size(1233, 684);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbbCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbStatusFilter);
            this.Controls.Add(this.guna2DataGridView);
            this.Controls.Add(this.txtbSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TO DO LIST";
            this.Load += new System.EventHandler(this.Mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnAddTask;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2TextBox txtbSearch;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView;
        private Guna.UI2.WinForms.Guna2ComboBox CmbStatusFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnTimer;
        private Guna.UI2.WinForms.Guna2Button btnManageCategory;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbCategory;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnCalculate;
        private Guna.UI2.WinForms.Guna2Button btnExite;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
    }
}