namespace project_8_To_do_list
{
    partial class clsCalculatePercentage
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
            this.cmbbCategory = new Guna.UI2.WinForms.Guna2ComboBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.guna2RadialGauge1 = new Guna.UI2.WinForms.Guna2RadialGauge();
            this.cmbbDate = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCalcuat = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // cmbbCategory
            // 
            this.cmbbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbbCategory.BorderColor = System.Drawing.Color.Black;
            this.cmbbCategory.BorderRadius = 22;
            this.cmbbCategory.BorderThickness = 4;
            this.cmbbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbCategory.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbbCategory.FocusedState.Parent = this.cmbbCategory;
            this.cmbbCategory.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbbCategory.FormattingEnabled = true;
            this.cmbbCategory.HoverState.Parent = this.cmbbCategory;
            this.cmbbCategory.ItemHeight = 60;
            this.cmbbCategory.ItemsAppearance.Parent = this.cmbbCategory;
            this.cmbbCategory.Location = new System.Drawing.Point(12, 81);
            this.cmbbCategory.Name = "cmbbCategory";
            this.cmbbCategory.ShadowDecoration.Parent = this.cmbbCategory;
            this.cmbbCategory.Size = new System.Drawing.Size(294, 66);
            this.cmbbCategory.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 553);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // guna2RadialGauge1
            // 
            this.guna2RadialGauge1.ArrowColor = System.Drawing.Color.Maroon;
            this.guna2RadialGauge1.ArrowThickness = 8;
            this.guna2RadialGauge1.BackColor = System.Drawing.Color.MediumPurple;
            this.guna2RadialGauge1.Font = new System.Drawing.Font("Verdana", 8.2F);
            this.guna2RadialGauge1.ForeColor = System.Drawing.Color.Black;
            this.guna2RadialGauge1.Location = new System.Drawing.Point(484, 149);
            this.guna2RadialGauge1.MinimumSize = new System.Drawing.Size(30, 30);
            this.guna2RadialGauge1.Name = "guna2RadialGauge1";
            this.guna2RadialGauge1.Size = new System.Drawing.Size(323, 323);
            this.guna2RadialGauge1.TabIndex = 2;
            // 
            // cmbbDate
            // 
            this.cmbbDate.BackColor = System.Drawing.Color.Transparent;
            this.cmbbDate.BorderColor = System.Drawing.Color.Black;
            this.cmbbDate.BorderRadius = 22;
            this.cmbbDate.BorderThickness = 4;
            this.cmbbDate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmbbDate.FocusedColor = System.Drawing.Color.Empty;
            this.cmbbDate.FocusedState.Parent = this.cmbbDate;
            this.cmbbDate.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbDate.ForeColor = System.Drawing.Color.Black;
            this.cmbbDate.FormattingEnabled = true;
            this.cmbbDate.HoverState.Parent = this.cmbbDate;
            this.cmbbDate.ItemHeight = 60;
            this.cmbbDate.Items.AddRange(new object[] {
            "Today",
            "This Week",
            "This Month"});
            this.cmbbDate.ItemsAppearance.Parent = this.cmbbDate;
            this.cmbbDate.Location = new System.Drawing.Point(507, 81);
            this.cmbbDate.Name = "cmbbDate";
            this.cmbbDate.ShadowDecoration.Parent = this.cmbbDate;
            this.cmbbDate.Size = new System.Drawing.Size(294, 66);
            this.cmbbDate.StartIndex = 1;
            this.cmbbDate.TabIndex = 3;
            // 
            // btnCalcuat
            // 
            this.btnCalcuat.BorderRadius = 19;
            this.btnCalcuat.BorderThickness = 3;
            this.btnCalcuat.CheckedState.Parent = this.btnCalcuat;
            this.btnCalcuat.CustomImages.Parent = this.btnCalcuat;
            this.btnCalcuat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnCalcuat.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcuat.ForeColor = System.Drawing.Color.Black;
            this.btnCalcuat.HoverState.Parent = this.btnCalcuat;
            this.btnCalcuat.Location = new System.Drawing.Point(298, 473);
            this.btnCalcuat.Name = "btnCalcuat";
            this.btnCalcuat.ShadowDecoration.Parent = this.btnCalcuat;
            this.btnCalcuat.Size = new System.Drawing.Size(175, 68);
            this.btnCalcuat.TabIndex = 4;
            this.btnCalcuat.Text = "Calculat";
            this.btnCalcuat.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // clsCalculatePercentage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(813, 553);
            this.Controls.Add(this.btnCalcuat);
            this.Controls.Add(this.cmbbDate);
            this.Controls.Add(this.guna2RadialGauge1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.cmbbCategory);
            this.Name = "clsCalculatePercentage";
            this.Text = "clsCalculatePercentage";
            this.Load += new System.EventHandler(this.clsCalculatePercentage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbbCategory;
        private System.Windows.Forms.Splitter splitter1;
        private Guna.UI2.WinForms.Guna2RadialGauge guna2RadialGauge1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbDate;
        private Guna.UI2.WinForms.Guna2Button btnCalcuat;
    }
}