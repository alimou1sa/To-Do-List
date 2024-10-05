namespace project_8_To_do_list
{
    partial class clsTimer
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
            this.components = new System.ComponentModel.Container();
            this.nudHours = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtbTitel = new Guna.UI2.WinForms.Guna2TextBox();
            this.nudMinutes = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnstart = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.nudSecond = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnStop = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // nudHours
            // 
            this.nudHours.BackColor = System.Drawing.Color.Transparent;
            this.nudHours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudHours.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudHours.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudHours.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudHours.DisabledState.Parent = this.nudHours;
            this.nudHours.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudHours.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudHours.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudHours.FocusedState.Parent = this.nudHours;
            this.nudHours.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudHours.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudHours.Location = new System.Drawing.Point(499, 52);
            this.nudHours.Margin = new System.Windows.Forms.Padding(5);
            this.nudHours.Name = "nudHours";
            this.nudHours.ShadowDecoration.Parent = this.nudHours;
            this.nudHours.Size = new System.Drawing.Size(122, 58);
            this.nudHours.TabIndex = 0;
            // 
            // txtbTitel
            // 
            this.txtbTitel.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.txtbTitel.BackColor = System.Drawing.Color.Purple;
            this.txtbTitel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbTitel.DefaultText = "";
            this.txtbTitel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtbTitel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtbTitel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbTitel.DisabledState.Parent = this.txtbTitel;
            this.txtbTitel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtbTitel.FillColor = System.Drawing.SystemColors.Highlight;
            this.txtbTitel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbTitel.FocusedState.Parent = this.txtbTitel;
            this.txtbTitel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbTitel.ForeColor = System.Drawing.Color.Black;
            this.txtbTitel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbTitel.HoverState.Parent = this.txtbTitel;
            this.txtbTitel.Location = new System.Drawing.Point(13, 52);
            this.txtbTitel.Margin = new System.Windows.Forms.Padding(4);
            this.txtbTitel.Name = "txtbTitel";
            this.txtbTitel.PasswordChar = '\0';
            this.txtbTitel.PlaceholderText = "";
            this.txtbTitel.SelectedText = "";
            this.txtbTitel.ShadowDecoration.Parent = this.txtbTitel;
            this.txtbTitel.Size = new System.Drawing.Size(435, 82);
            this.txtbTitel.TabIndex = 2;
            // 
            // nudMinutes
            // 
            this.nudMinutes.BackColor = System.Drawing.Color.Transparent;
            this.nudMinutes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudMinutes.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudMinutes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudMinutes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudMinutes.DisabledState.Parent = this.nudMinutes;
            this.nudMinutes.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudMinutes.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudMinutes.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudMinutes.FocusedState.Parent = this.nudMinutes;
            this.nudMinutes.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMinutes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudMinutes.Location = new System.Drawing.Point(499, 159);
            this.nudMinutes.Margin = new System.Windows.Forms.Padding(5);
            this.nudMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.ShadowDecoration.Parent = this.nudMinutes;
            this.nudMinutes.Size = new System.Drawing.Size(122, 58);
            this.nudMinutes.TabIndex = 3;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(23, 159);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(63, 72);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "0";
            // 
            // btnstart
            // 
            this.btnstart.BorderRadius = 33;
            this.btnstart.CheckedState.Parent = this.btnstart;
            this.btnstart.CustomImages.Parent = this.btnstart;
            this.btnstart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.ForeColor = System.Drawing.Color.White;
            this.btnstart.HoverState.Parent = this.btnstart;
            this.btnstart.Location = new System.Drawing.Point(54, 355);
            this.btnstart.Name = "btnstart";
            this.btnstart.ShadowDecoration.Parent = this.btnstart;
            this.btnstart.Size = new System.Drawing.Size(119, 81);
            this.btnstart.TabIndex = 5;
            this.btnstart.Text = "Start";
            this.btnstart.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // nudSecond
            // 
            this.nudSecond.BackColor = System.Drawing.Color.Transparent;
            this.nudSecond.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudSecond.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudSecond.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudSecond.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudSecond.DisabledState.Parent = this.nudSecond;
            this.nudSecond.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudSecond.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudSecond.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudSecond.FocusedState.Parent = this.nudSecond;
            this.nudSecond.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSecond.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.nudSecond.Location = new System.Drawing.Point(499, 274);
            this.nudSecond.Margin = new System.Windows.Forms.Padding(5);
            this.nudSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.ShadowDecoration.Parent = this.nudSecond;
            this.nudSecond.Size = new System.Drawing.Size(122, 58);
            this.nudSecond.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(502, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hours";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(501, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 34);
            this.label3.TabIndex = 8;
            this.label3.Text = "Minutes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(502, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seconds";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Viner Hand ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 48);
            this.label5.TabIndex = 10;
            this.label5.Text = "Titel";
            // 
            // btnStop
            // 
            this.btnStop.BorderRadius = 33;
            this.btnStop.CheckedState.Parent = this.btnStop;
            this.btnStop.CustomImages.Parent = this.btnStop;
            this.btnStop.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.HoverState.Parent = this.btnStop;
            this.btnStop.Location = new System.Drawing.Point(284, 355);
            this.btnStop.Name = "btnStop";
            this.btnStop.ShadowDecoration.Parent = this.btnStop;
            this.btnStop.Size = new System.Drawing.Size(119, 81);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "Stop";
            this.btnStop.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // clsTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(654, 487);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudSecond);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.nudMinutes);
            this.Controls.Add(this.txtbTitel);
            this.Controls.Add(this.nudHours);
            this.Name = "clsTimer";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.clsTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown nudHours;
        private Guna.UI2.WinForms.Guna2TextBox txtbTitel;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudMinutes;
        private System.Windows.Forms.Label lblTime;
        private Guna.UI2.WinForms.Guna2Button btnstart;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudSecond;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button btnStop;
    }
}