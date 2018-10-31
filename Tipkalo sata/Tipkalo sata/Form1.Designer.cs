namespace Tipkalo_sata
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
            this.tbSati = new System.Windows.Forms.TextBox();
            this.tbMinute = new System.Windows.Forms.TextBox();
            this.tbSekunde = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbSati = new System.Windows.Forms.RadioButton();
            this.rbMinute = new System.Windows.Forms.RadioButton();
            this.rbSekunde = new System.Windows.Forms.RadioButton();
            this.btn1 = new System.Windows.Forms.Button();
            this.cbStart = new System.Windows.Forms.CheckBox();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSati
            // 
            this.tbSati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSati.Location = new System.Drawing.Point(493, 40);
            this.tbSati.Name = "tbSati";
            this.tbSati.ReadOnly = true;
            this.tbSati.Size = new System.Drawing.Size(37, 26);
            this.tbSati.TabIndex = 2;
            // 
            // tbMinute
            // 
            this.tbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMinute.Location = new System.Drawing.Point(554, 40);
            this.tbMinute.Name = "tbMinute";
            this.tbMinute.ReadOnly = true;
            this.tbMinute.Size = new System.Drawing.Size(37, 26);
            this.tbMinute.TabIndex = 3;
            // 
            // tbSekunde
            // 
            this.tbSekunde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSekunde.Location = new System.Drawing.Point(617, 40);
            this.tbSekunde.Name = "tbSekunde";
            this.tbSekunde.ReadOnly = true;
            this.tbSekunde.Size = new System.Drawing.Size(37, 26);
            this.tbSekunde.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sati :     Minute :  Sekunde";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 48);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dekrement\r\n\r\n\r\n";
            // 
            // rbSati
            // 
            this.rbSati.AutoSize = true;
            this.rbSati.Enabled = false;
            this.rbSati.Location = new System.Drawing.Point(504, 73);
            this.rbSati.Name = "rbSati";
            this.rbSati.Size = new System.Drawing.Size(14, 13);
            this.rbSati.TabIndex = 7;
            this.rbSati.TabStop = true;
            this.rbSati.UseVisualStyleBackColor = true;
            // 
            // rbMinute
            // 
            this.rbMinute.AutoSize = true;
            this.rbMinute.Enabled = false;
            this.rbMinute.Location = new System.Drawing.Point(567, 73);
            this.rbMinute.Name = "rbMinute";
            this.rbMinute.Size = new System.Drawing.Size(14, 13);
            this.rbMinute.TabIndex = 8;
            this.rbMinute.TabStop = true;
            this.rbMinute.UseVisualStyleBackColor = true;
            // 
            // rbSekunde
            // 
            this.rbSekunde.AutoSize = true;
            this.rbSekunde.Enabled = false;
            this.rbSekunde.Location = new System.Drawing.Point(628, 73);
            this.rbSekunde.Name = "rbSekunde";
            this.rbSekunde.Size = new System.Drawing.Size(14, 13);
            this.rbSekunde.TabIndex = 9;
            this.rbSekunde.TabStop = true;
            this.rbSekunde.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 41);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(32, 26);
            this.btn1.TabIndex = 10;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // cbStart
            // 
            this.cbStart.AutoSize = true;
            this.cbStart.Location = new System.Drawing.Point(12, 13);
            this.cbStart.Name = "cbStart";
            this.cbStart.Size = new System.Drawing.Size(75, 17);
            this.cbStart.TabIndex = 11;
            this.cbStart.Text = "Start/Stop";
            this.cbStart.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(12, 73);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(32, 26);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(12, 105);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(32, 26);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 137);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(32, 26);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(12, 169);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(32, 26);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Blinkanje sata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Blinkanje minuta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Blinkanje sekundi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Inkrement";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 225);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.cbStart);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.rbSekunde);
            this.Controls.Add(this.rbMinute);
            this.Controls.Add(this.rbSati);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSekunde);
            this.Controls.Add(this.tbMinute);
            this.Controls.Add(this.tbSati);
            this.Name = "Form1";
            this.Text = "Tipkalo sata";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbSati;
        private System.Windows.Forms.TextBox tbMinute;
        private System.Windows.Forms.TextBox tbSekunde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSati;
        private System.Windows.Forms.RadioButton rbMinute;
        private System.Windows.Forms.RadioButton rbSekunde;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.CheckBox cbStart;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

