namespace RezerwacjaHoteli
{
    partial class Wyszukiwarka
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wyszukiwarka));
            this.Jeden_radioButton = new System.Windows.Forms.RadioButton();
            this.Kilka_radioButton = new System.Windows.Forms.RadioButton();
            this.Z_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Do_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Typ_cmb = new System.Windows.Forms.ComboBox();
            this.Miejsca_cmb = new System.Windows.Forms.ComboBox();
            this.szukaj_but = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Jeden_radioButton
            // 
            this.Jeden_radioButton.AutoSize = true;
            this.Jeden_radioButton.Location = new System.Drawing.Point(324, 24);
            this.Jeden_radioButton.Name = "Jeden_radioButton";
            this.Jeden_radioButton.Size = new System.Drawing.Size(96, 17);
            this.Jeden_radioButton.TabIndex = 0;
            this.Jeden_radioButton.TabStop = true;
            this.Jeden_radioButton.Text = "Na jeden dzien";
            this.Jeden_radioButton.UseVisualStyleBackColor = true;
            this.Jeden_radioButton.CheckedChanged += new System.EventHandler(this.Jeden_radioButton_CheckedChanged);
            // 
            // Kilka_radioButton
            // 
            this.Kilka_radioButton.AutoSize = true;
            this.Kilka_radioButton.Location = new System.Drawing.Point(41, 24);
            this.Kilka_radioButton.Name = "Kilka_radioButton";
            this.Kilka_radioButton.Size = new System.Drawing.Size(81, 17);
            this.Kilka_radioButton.TabIndex = 1;
            this.Kilka_radioButton.TabStop = true;
            this.Kilka_radioButton.Text = "Na kilka dni";
            this.Kilka_radioButton.UseVisualStyleBackColor = true;
            this.Kilka_radioButton.CheckedChanged += new System.EventHandler(this.Kilka_radioButton_CheckedChanged);
            // 
            // Z_dateTimePicker
            // 
            this.Z_dateTimePicker.Location = new System.Drawing.Point(38, 97);
            this.Z_dateTimePicker.Name = "Z_dateTimePicker";
            this.Z_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Z_dateTimePicker.TabIndex = 2;
            // 
            // Do_dateTimePicker
            // 
            this.Do_dateTimePicker.Location = new System.Drawing.Point(321, 96);
            this.Do_dateTimePicker.Name = "Do_dateTimePicker";
            this.Do_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.Do_dateTimePicker.TabIndex = 3;
            // 
            // Typ_cmb
            // 
            this.Typ_cmb.FormattingEnabled = true;
            this.Typ_cmb.Items.AddRange(new object[] {
            "2 gwiazdy",
            "3 gwiazdy",
            "4 gwiazdy",
            "5 gwiazd"});
            this.Typ_cmb.Location = new System.Drawing.Point(38, 188);
            this.Typ_cmb.Name = "Typ_cmb";
            this.Typ_cmb.Size = new System.Drawing.Size(121, 21);
            this.Typ_cmb.TabIndex = 4;
            // 
            // Miejsca_cmb
            // 
            this.Miejsca_cmb.FormattingEnabled = true;
            this.Miejsca_cmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.Miejsca_cmb.Location = new System.Drawing.Point(321, 188);
            this.Miejsca_cmb.Name = "Miejsca_cmb";
            this.Miejsca_cmb.Size = new System.Drawing.Size(121, 21);
            this.Miejsca_cmb.TabIndex = 5;
            // 
            // szukaj_but
            // 
            this.szukaj_but.Location = new System.Drawing.Point(324, 253);
            this.szukaj_but.Name = "szukaj_but";
            this.szukaj_but.Size = new System.Drawing.Size(75, 23);
            this.szukaj_but.TabIndex = 6;
            this.szukaj_but.Text = "Szukaj";
            this.szukaj_but.UseVisualStyleBackColor = true;
            this.szukaj_but.Click += new System.EventHandler(this.szukaj_but_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Z";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Do";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Typ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ilosc miejsc";
            // 
            // Wyszukiwarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(551, 311);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szukaj_but);
            this.Controls.Add(this.Miejsca_cmb);
            this.Controls.Add(this.Typ_cmb);
            this.Controls.Add(this.Do_dateTimePicker);
            this.Controls.Add(this.Z_dateTimePicker);
            this.Controls.Add(this.Kilka_radioButton);
            this.Controls.Add(this.Jeden_radioButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Wyszukiwarka";
            this.Text = "Wyszukiwarka";
            this.Load += new System.EventHandler(this.Wyszukiwarka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Jeden_radioButton;
        private System.Windows.Forms.RadioButton Kilka_radioButton;
        private System.Windows.Forms.DateTimePicker Z_dateTimePicker;
        private System.Windows.Forms.DateTimePicker Do_dateTimePicker;
        private System.Windows.Forms.ComboBox Typ_cmb;
        private System.Windows.Forms.ComboBox Miejsca_cmb;
        private System.Windows.Forms.Button szukaj_but;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

