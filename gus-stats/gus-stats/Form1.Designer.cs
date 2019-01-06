namespace gus_stats
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBoxApi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelTopic = new System.Windows.Forms.Label();
            this.comboBoxTopic = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSubtopic = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxValue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxRange = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "GUS Api BDL Status";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(13, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "GUS Api Regon Status";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(13, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "GUS Api Teryt Status";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // comboBoxApi
            // 
            this.comboBoxApi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.comboBoxApi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxApi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxApi.ForeColor = System.Drawing.Color.White;
            this.comboBoxApi.FormattingEnabled = true;
            this.comboBoxApi.Items.AddRange(new object[] {
            "BDL",
            "Regon",
            "Teryt"});
            this.comboBoxApi.Location = new System.Drawing.Point(326, 10);
            this.comboBoxApi.Name = "comboBoxApi";
            this.comboBoxApi.Size = new System.Drawing.Size(311, 21);
            this.comboBoxApi.TabIndex = 3;
            this.comboBoxApi.DropDownClosed += new System.EventHandler(this.comboBoxApiClosed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(206, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Wybierz wyszukiwarkę";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(322, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Argumenty";
            this.label2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(505, 231);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(611, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(505, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(505, 283);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(611, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(611, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(325, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(97, 42);
            this.button4.TabIndex = 12;
            this.button4.Text = "Szukaj";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 317);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(633, 233);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // labelTopic
            // 
            this.labelTopic.AutoSize = true;
            this.labelTopic.ForeColor = System.Drawing.Color.White;
            this.labelTopic.Location = new System.Drawing.Point(206, 42);
            this.labelTopic.Name = "labelTopic";
            this.labelTopic.Size = new System.Drawing.Size(74, 13);
            this.labelTopic.TabIndex = 15;
            this.labelTopic.Text = "Wybierz temat";
            this.labelTopic.Visible = false;
            // 
            // comboBoxTopic
            // 
            this.comboBoxTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.comboBoxTopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxTopic.ForeColor = System.Drawing.Color.White;
            this.comboBoxTopic.FormattingEnabled = true;
            this.comboBoxTopic.Location = new System.Drawing.Point(326, 39);
            this.comboBoxTopic.Name = "comboBoxTopic";
            this.comboBoxTopic.Size = new System.Drawing.Size(311, 21);
            this.comboBoxTopic.TabIndex = 14;
            this.comboBoxTopic.Visible = false;
            this.comboBoxTopic.TextChanged += new System.EventHandler(this.comboBoxTopicClosed);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(206, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Wybierz sub-temat";
            this.label7.Visible = false;
            // 
            // comboBoxSubtopic
            // 
            this.comboBoxSubtopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.comboBoxSubtopic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxSubtopic.ForeColor = System.Drawing.Color.White;
            this.comboBoxSubtopic.FormattingEnabled = true;
            this.comboBoxSubtopic.Location = new System.Drawing.Point(326, 68);
            this.comboBoxSubtopic.Name = "comboBoxSubtopic";
            this.comboBoxSubtopic.Size = new System.Drawing.Size(311, 21);
            this.comboBoxSubtopic.TabIndex = 16;
            this.comboBoxSubtopic.Visible = false;
            this.comboBoxSubtopic.TextChanged += new System.EventHandler(this.comboBoxSubtopicClosed);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(206, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Wybierz zmienna";
            this.label6.Visible = false;
            // 
            // comboBoxValue
            // 
            this.comboBoxValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.comboBoxValue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxValue.ForeColor = System.Drawing.Color.White;
            this.comboBoxValue.FormattingEnabled = true;
            this.comboBoxValue.Location = new System.Drawing.Point(326, 97);
            this.comboBoxValue.Name = "comboBoxValue";
            this.comboBoxValue.Size = new System.Drawing.Size(311, 21);
            this.comboBoxValue.TabIndex = 18;
            this.comboBoxValue.Visible = false;
            this.comboBoxValue.TextChanged += new System.EventHandler(this.comboBoxValueClosed);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(206, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Wybierz zakres";
            this.label8.Visible = false;
            // 
            // comboBoxRange
            // 
            this.comboBoxRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(70)))));
            this.comboBoxRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRange.ForeColor = System.Drawing.Color.White;
            this.comboBoxRange.FormattingEnabled = true;
            this.comboBoxRange.Location = new System.Drawing.Point(326, 125);
            this.comboBoxRange.Name = "comboBoxRange";
            this.comboBoxRange.Size = new System.Drawing.Size(311, 21);
            this.comboBoxRange.TabIndex = 20;
            this.comboBoxRange.Visible = false;
            this.comboBoxRange.TextChanged += new System.EventHandler(this.comboBoxRangeClosed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(657, 562);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxRange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxSubtopic);
            this.Controls.Add(this.labelTopic);
            this.Controls.Add(this.comboBoxTopic);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxApi);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBoxApi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelTopic;
        private System.Windows.Forms.ComboBox comboBoxTopic;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSubtopic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxRange;
    }
}

