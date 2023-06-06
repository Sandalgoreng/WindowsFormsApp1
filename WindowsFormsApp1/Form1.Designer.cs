namespace WindowsFormsApp1
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.tanggalhari = new System.Windows.Forms.DateTimePicker();
            this.namadokter = new System.Windows.Forms.ComboBox();
            this.namapasien = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataharga = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl88 = new System.Windows.Forms.Label();
            this.tanggallahir = new System.Windows.Forms.DateTimePicker();
            this.alamatpas = new System.Windows.Forms.MaskedTextBox();
            this.notelppas = new System.Windows.Forms.MaskedTextBox();
            this.idpas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataharga)).BeginInit();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(616, 325);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(105, 22);
            this.maskedTextBox1.TabIndex = 29;
            // 
            // tanggalhari
            // 
            this.tanggalhari.Location = new System.Drawing.Point(264, 326);
            this.tanggalhari.Name = "tanggalhari";
            this.tanggalhari.Size = new System.Drawing.Size(200, 22);
            this.tanggalhari.TabIndex = 28;
            // 
            // namadokter
            // 
            this.namadokter.FormattingEnabled = true;
            this.namadokter.Location = new System.Drawing.Point(399, 93);
            this.namadokter.Name = "namadokter";
            this.namadokter.Size = new System.Drawing.Size(322, 24);
            this.namadokter.TabIndex = 27;
            // 
            // namapasien
            // 
            this.namapasien.FormattingEnabled = true;
            this.namapasien.Location = new System.Drawing.Point(18, 93);
            this.namapasien.Name = "namapasien";
            this.namapasien.Size = new System.Drawing.Size(177, 24);
            this.namapasien.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 723);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 39);
            this.button1.TabIndex = 19;
            this.button1.Text = "PRINT";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataharga
            // 
            this.dataharga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataharga.Location = new System.Drawing.Point(9, 428);
            this.dataharga.Name = "dataharga";
            this.dataharga.RowHeadersWidth = 51;
            this.dataharga.RowTemplate.Height = 24;
            this.dataharga.Size = new System.Drawing.Size(725, 259);
            this.dataharga.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(396, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "PERSCRIBING PHYSICIANS\'S INFORMATION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(613, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "AMOUNT DUE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(329, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "DATE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(6, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "PATIENT ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(15, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "PATIENT INFORMATION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(6, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(728, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "_________________________________________________________________________________" +
    "______________________";
            // 
            // lbl88
            // 
            this.lbl88.AutoSize = true;
            this.lbl88.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl88.Location = new System.Drawing.Point(12, 9);
            this.lbl88.Name = "lbl88";
            this.lbl88.Size = new System.Drawing.Size(392, 35);
            this.lbl88.TabIndex = 10;
            this.lbl88.Text = "MEDICAL BILLING INVOICE";
            // 
            // tanggallahir
            // 
            this.tanggallahir.Location = new System.Drawing.Point(18, 123);
            this.tanggallahir.Name = "tanggallahir";
            this.tanggallahir.Size = new System.Drawing.Size(200, 22);
            this.tanggallahir.TabIndex = 30;
            // 
            // alamatpas
            // 
            this.alamatpas.Location = new System.Drawing.Point(18, 155);
            this.alamatpas.Name = "alamatpas";
            this.alamatpas.Size = new System.Drawing.Size(177, 22);
            this.alamatpas.TabIndex = 31;
            // 
            // notelppas
            // 
            this.notelppas.Location = new System.Drawing.Point(18, 183);
            this.notelppas.Name = "notelppas";
            this.notelppas.Size = new System.Drawing.Size(177, 22);
            this.notelppas.TabIndex = 31;
            // 
            // idpas
            // 
            this.idpas.AutoSize = true;
            this.idpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idpas.ForeColor = System.Drawing.SystemColors.InfoText;
            this.idpas.Location = new System.Drawing.Point(6, 331);
            this.idpas.Name = "idpas";
            this.idpas.Size = new System.Drawing.Size(91, 16);
            this.idpas.TabIndex = 14;
            this.idpas.Text = "PATIENT ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 703);
            this.Controls.Add(this.notelppas);
            this.Controls.Add(this.alamatpas);
            this.Controls.Add(this.tanggallahir);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.tanggalhari);
            this.Controls.Add(this.namadokter);
            this.Controls.Add(this.namapasien);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataharga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idpas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl88);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataharga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DateTimePicker tanggalhari;
        private System.Windows.Forms.ComboBox namadokter;
        private System.Windows.Forms.ComboBox namapasien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataharga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl88;
        private System.Windows.Forms.DateTimePicker tanggallahir;
        private System.Windows.Forms.MaskedTextBox alamatpas;
        private System.Windows.Forms.MaskedTextBox notelppas;
        private System.Windows.Forms.Label idpas;
    }
}

