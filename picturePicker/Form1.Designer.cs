namespace picturePicker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.car_list = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radio_1981 = new System.Windows.Forms.RadioButton();
            this.radio_1971 = new System.Windows.Forms.RadioButton();
            this.radio_1961 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.car_year = new System.Windows.Forms.CheckBox();
            this.car_name = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gt = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.detail_input = new System.Windows.Forms.Label();
            this.ford_1961 = new System.Windows.Forms.PictureBox();
            this.ferrari_1971 = new System.Windows.Forms.PictureBox();
            this.ford_1971 = new System.Windows.Forms.PictureBox();
            this.ferrari_1981 = new System.Windows.Forms.PictureBox();
            this.bmw_1981 = new System.Windows.Forms.PictureBox();
            this.bmw_1971 = new System.Windows.Forms.PictureBox();
            this.bmw_1961 = new System.Windows.Forms.PictureBox();
            this.ford_69 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gt)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ford_1961)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferrari_1971)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ford_1971)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferrari_1981)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmw_1981)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmw_1971)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmw_1961)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ford_69)).BeginInit();
            this.SuspendLayout();
            // 
            // car_list
            // 
            this.car_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_list.FormattingEnabled = true;
            this.car_list.ItemHeight = 25;
            this.car_list.Items.AddRange(new object[] {
            "bmw",
            "ford",
            "ferrari"});
            this.car_list.Location = new System.Drawing.Point(19, 21);
            this.car_list.Name = "car_list";
            this.car_list.Size = new System.Drawing.Size(90, 79);
            this.car_list.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radio_1981);
            this.groupBox1.Controls.Add(this.radio_1971);
            this.groupBox1.Controls.Add(this.radio_1961);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(33, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 190);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Year";
            // 
            // radio_1981
            // 
            this.radio_1981.AutoSize = true;
            this.radio_1981.Location = new System.Drawing.Point(20, 139);
            this.radio_1981.Name = "radio_1981";
            this.radio_1981.Size = new System.Drawing.Size(79, 26);
            this.radio_1981.TabIndex = 2;
            this.radio_1981.TabStop = true;
            this.radio_1981.Text = "1981";
            this.radio_1981.UseVisualStyleBackColor = true;
            // 
            // radio_1971
            // 
            this.radio_1971.AutoSize = true;
            this.radio_1971.Location = new System.Drawing.Point(20, 84);
            this.radio_1971.Name = "radio_1971";
            this.radio_1971.Size = new System.Drawing.Size(79, 26);
            this.radio_1971.TabIndex = 1;
            this.radio_1971.TabStop = true;
            this.radio_1971.Text = "1871";
            this.radio_1971.UseVisualStyleBackColor = true;
            // 
            // radio_1961
            // 
            this.radio_1961.AutoSize = true;
            this.radio_1961.Location = new System.Drawing.Point(20, 36);
            this.radio_1961.Name = "radio_1961";
            this.radio_1961.Size = new System.Drawing.Size(79, 26);
            this.radio_1961.TabIndex = 0;
            this.radio_1961.TabStop = true;
            this.radio_1961.Text = "1961";
            this.radio_1961.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.car_year);
            this.groupBox2.Controls.Add(this.car_name);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(33, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 148);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Model";
            // 
            // car_year
            // 
            this.car_year.AutoSize = true;
            this.car_year.Location = new System.Drawing.Point(20, 103);
            this.car_year.Name = "car_year";
            this.car_year.Size = new System.Drawing.Size(78, 26);
            this.car_year.TabIndex = 1;
            this.car_year.Text = "Year";
            this.car_year.UseVisualStyleBackColor = true;
            // 
            // car_name
            // 
            this.car_name.AutoSize = true;
            this.car_name.Location = new System.Drawing.Point(20, 44);
            this.car_name.Name = "car_name";
            this.car_name.Size = new System.Drawing.Size(87, 26);
            this.car_name.TabIndex = 0;
            this.car_name.Text = "Name";
            this.car_name.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(526, 618);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 101);
            this.button1.TabIndex = 3;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("Ravie", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(873, 618);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 101);
            this.button2.TabIndex = 4;
            this.button2.Text = "NEW";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gt
            // 
            this.gt.ErrorImage = null;
            this.gt.Image = ((System.Drawing.Image)(resources.GetObject("gt.Image")));
            this.gt.InitialImage = null;
            this.gt.Location = new System.Drawing.Point(470, 21);
            this.gt.Name = "gt";
            this.gt.Size = new System.Drawing.Size(622, 418);
            this.gt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gt.TabIndex = 5;
            this.gt.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.detail_input);
            this.groupBox3.Location = new System.Drawing.Point(470, 462);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(619, 147);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // detail_input
            // 
            this.detail_input.Location = new System.Drawing.Point(38, 30);
            this.detail_input.Name = "detail_input";
            this.detail_input.Size = new System.Drawing.Size(544, 100);
            this.detail_input.TabIndex = 0;
            // 
            // ford_1961
            // 
            this.ford_1961.ErrorImage = null;
            this.ford_1961.Image = ((System.Drawing.Image)(resources.GetObject("ford_1961.Image")));
            this.ford_1961.InitialImage = null;
            this.ford_1961.Location = new System.Drawing.Point(467, 21);
            this.ford_1961.Name = "ford_1961";
            this.ford_1961.Size = new System.Drawing.Size(622, 418);
            this.ford_1961.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ford_1961.TabIndex = 7;
            this.ford_1961.TabStop = false;
            // 
            // ferrari_1971
            // 
            this.ferrari_1971.ErrorImage = null;
            this.ferrari_1971.Image = ((System.Drawing.Image)(resources.GetObject("ferrari_1971.Image")));
            this.ferrari_1971.InitialImage = null;
            this.ferrari_1971.Location = new System.Drawing.Point(467, 21);
            this.ferrari_1971.Name = "ferrari_1971";
            this.ferrari_1971.Size = new System.Drawing.Size(622, 418);
            this.ferrari_1971.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ferrari_1971.TabIndex = 8;
            this.ferrari_1971.TabStop = false;
            // 
            // ford_1971
            // 
            this.ford_1971.ErrorImage = null;
            this.ford_1971.Image = ((System.Drawing.Image)(resources.GetObject("ford_1971.Image")));
            this.ford_1971.InitialImage = null;
            this.ford_1971.Location = new System.Drawing.Point(467, 21);
            this.ford_1971.Name = "ford_1971";
            this.ford_1971.Size = new System.Drawing.Size(622, 418);
            this.ford_1971.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ford_1971.TabIndex = 9;
            this.ford_1971.TabStop = false;
            // 
            // ferrari_1981
            // 
            this.ferrari_1981.ErrorImage = null;
            this.ferrari_1981.Image = ((System.Drawing.Image)(resources.GetObject("ferrari_1981.Image")));
            this.ferrari_1981.InitialImage = null;
            this.ferrari_1981.Location = new System.Drawing.Point(467, 21);
            this.ferrari_1981.Name = "ferrari_1981";
            this.ferrari_1981.Size = new System.Drawing.Size(622, 418);
            this.ferrari_1981.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ferrari_1981.TabIndex = 10;
            this.ferrari_1981.TabStop = false;
            // 
            // bmw_1981
            // 
            this.bmw_1981.ErrorImage = null;
            this.bmw_1981.Image = ((System.Drawing.Image)(resources.GetObject("bmw_1981.Image")));
            this.bmw_1981.InitialImage = null;
            this.bmw_1981.Location = new System.Drawing.Point(467, 21);
            this.bmw_1981.Name = "bmw_1981";
            this.bmw_1981.Size = new System.Drawing.Size(622, 418);
            this.bmw_1981.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bmw_1981.TabIndex = 11;
            this.bmw_1981.TabStop = false;
            // 
            // bmw_1971
            // 
            this.bmw_1971.ErrorImage = null;
            this.bmw_1971.Image = ((System.Drawing.Image)(resources.GetObject("bmw_1971.Image")));
            this.bmw_1971.InitialImage = null;
            this.bmw_1971.Location = new System.Drawing.Point(467, 21);
            this.bmw_1971.Name = "bmw_1971";
            this.bmw_1971.Size = new System.Drawing.Size(622, 418);
            this.bmw_1971.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bmw_1971.TabIndex = 12;
            this.bmw_1971.TabStop = false;
            // 
            // bmw_1961
            // 
            this.bmw_1961.ErrorImage = null;
            this.bmw_1961.Image = ((System.Drawing.Image)(resources.GetObject("bmw_1961.Image")));
            this.bmw_1961.InitialImage = null;
            this.bmw_1961.Location = new System.Drawing.Point(467, 21);
            this.bmw_1961.Name = "bmw_1961";
            this.bmw_1961.Size = new System.Drawing.Size(622, 418);
            this.bmw_1961.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bmw_1961.TabIndex = 13;
            this.bmw_1961.TabStop = false;
            // 
            // ford_69
            // 
            this.ford_69.ErrorImage = null;
            this.ford_69.Image = ((System.Drawing.Image)(resources.GetObject("ford_69.Image")));
            this.ford_69.InitialImage = null;
            this.ford_69.Location = new System.Drawing.Point(467, 21);
            this.ford_69.Name = "ford_69";
            this.ford_69.Size = new System.Drawing.Size(622, 418);
            this.ford_69.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ford_69.TabIndex = 14;
            this.ford_69.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 725);
            this.Controls.Add(this.ford_69);
            this.Controls.Add(this.ford_1961);
            this.Controls.Add(this.ferrari_1981);
            this.Controls.Add(this.bmw_1961);
            this.Controls.Add(this.bmw_1971);
            this.Controls.Add(this.bmw_1981);
            this.Controls.Add(this.ford_1971);
            this.Controls.Add(this.ferrari_1971);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gt);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.car_list);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gt)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ford_1961)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferrari_1971)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ford_1971)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ferrari_1981)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmw_1981)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmw_1971)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bmw_1961)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ford_69)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox car_list;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_1981;
        private System.Windows.Forms.RadioButton radio_1971;
        private System.Windows.Forms.RadioButton radio_1961;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox car_year;
        private System.Windows.Forms.CheckBox car_name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox gt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label detail_input;
        private System.Windows.Forms.PictureBox ford_1961;
        private System.Windows.Forms.PictureBox ferrari_1971;
        private System.Windows.Forms.PictureBox ford_1971;
        private System.Windows.Forms.PictureBox ferrari_1981;
        private System.Windows.Forms.PictureBox bmw_1981;
        private System.Windows.Forms.PictureBox bmw_1971;
        private System.Windows.Forms.PictureBox bmw_1961;
        private System.Windows.Forms.PictureBox ford_69;
    }
}

