namespace CalendarLinker
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EndHour = new System.Windows.Forms.ComboBox();
            this.EndMin = new System.Windows.Forms.ComboBox();
            this.BegMin = new System.Windows.Forms.ComboBox();
            this.BegHour = new System.Windows.Forms.ComboBox();
            this.outputURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(621, 45);
            this.dateTimePicker1.MaxDate = new System.DateTime(2039, 11, 21, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 11, 21, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2019, 11, 21, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(621, 118);
            this.dateTimePicker2.MaxDate = new System.DateTime(2039, 11, 21, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(2019, 11, 21, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 20);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.Value = new System.DateTime(2019, 11, 21, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(13, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(588, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Название";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(13, 45);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(588, 135);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Описание мероприятия";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(13, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(588, 20);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Место проведения";
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 182);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Начало";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(618, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Конец";
            // 
            // EndHour
            // 
            this.EndHour.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.EndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndHour.FormattingEnabled = true;
            this.EndHour.Location = new System.Drawing.Point(621, 141);
            this.EndHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndHour.Name = "EndHour";
            this.EndHour.Size = new System.Drawing.Size(52, 21);
            this.EndHour.TabIndex = 9;
            this.EndHour.SelectedIndexChanged += new System.EventHandler(this.EndHour_SelectedIndexChanged);
            // 
            // EndMin
            // 
            this.EndMin.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.EndMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EndMin.FormattingEnabled = true;
            this.EndMin.Location = new System.Drawing.Point(682, 141);
            this.EndMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EndMin.MaxDropDownItems = 5;
            this.EndMin.Name = "EndMin";
            this.EndMin.Size = new System.Drawing.Size(52, 21);
            this.EndMin.TabIndex = 10;
            this.EndMin.SelectedIndexChanged += new System.EventHandler(this.EndMin_SelectedIndexChanged);
            // 
            // BegMin
            // 
            this.BegMin.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.BegMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BegMin.FormattingEnabled = true;
            this.BegMin.Location = new System.Drawing.Point(682, 68);
            this.BegMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BegMin.Name = "BegMin";
            this.BegMin.Size = new System.Drawing.Size(52, 21);
            this.BegMin.TabIndex = 12;
            this.BegMin.SelectedIndexChanged += new System.EventHandler(this.BegMin_SelectedIndexChanged);
            // 
            // BegHour
            // 
            this.BegHour.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.BegHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BegHour.FormattingEnabled = true;
            this.BegHour.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.BegHour.Location = new System.Drawing.Point(621, 68);
            this.BegHour.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BegHour.Name = "BegHour";
            this.BegHour.Size = new System.Drawing.Size(52, 21);
            this.BegHour.TabIndex = 11;
            this.BegHour.SelectedIndexChanged += new System.EventHandler(this.BegHour_SelectedIndexChanged);
            // 
            // outputURL
            // 
            this.outputURL.Location = new System.Drawing.Point(13, 220);
            this.outputURL.Multiline = true;
            this.outputURL.Name = "outputURL";
            this.outputURL.ReadOnly = true;
            this.outputURL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputURL.Size = new System.Drawing.Size(721, 63);
            this.outputURL.TabIndex = 13;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(745, 294);
            this.Controls.Add(this.outputURL);
            this.Controls.Add(this.BegMin);
            this.Controls.Add(this.BegHour);
            this.Controls.Add(this.EndMin);
            this.Controls.Add(this.EndHour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = global::CalendarLinker.Properties.Settings.Default.Hello;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox EndHour;
        private System.Windows.Forms.ComboBox EndMin;
        private System.Windows.Forms.ComboBox BegMin;
        private System.Windows.Forms.TextBox outputURL;
        private System.Windows.Forms.ComboBox BegHour;
    }
}

