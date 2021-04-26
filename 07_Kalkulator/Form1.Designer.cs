namespace _07_Kalkulator
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
            this.txtBilSatu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBilDua = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnKurang = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnKali = new System.Windows.Forms.Button();
            this.btnBagi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHasil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBilSatu
            // 
            this.txtBilSatu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBilSatu.Location = new System.Drawing.Point(15, 48);
            this.txtBilSatu.Name = "txtBilSatu";
            this.txtBilSatu.Size = new System.Drawing.Size(193, 38);
            this.txtBilSatu.TabIndex = 0;
            this.txtBilSatu.TextChanged += new System.EventHandler(this.txtBilSatu_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bilangan Pertama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bilangan Kedua";
            // 
            // txtBilDua
            // 
            this.txtBilDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBilDua.Location = new System.Drawing.Point(15, 135);
            this.txtBilDua.Name = "txtBilDua";
            this.txtBilDua.Size = new System.Drawing.Size(193, 38);
            this.txtBilDua.TabIndex = 3;
            this.txtBilDua.TextChanged += new System.EventHandler(this.txtBilDua_TextChanged);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(15, 281);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(54, 51);
            this.btnTambah.TabIndex = 5;
            this.btnTambah.Text = "+";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnKurang
            // 
            this.btnKurang.Location = new System.Drawing.Point(86, 281);
            this.btnKurang.Name = "btnKurang";
            this.btnKurang.Size = new System.Drawing.Size(54, 51);
            this.btnKurang.TabIndex = 6;
            this.btnKurang.Text = "-";
            this.btnKurang.UseVisualStyleBackColor = true;
            this.btnKurang.Click += new System.EventHandler(this.btnKurang_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(228, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 212);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnKali
            // 
            this.btnKali.Location = new System.Drawing.Point(157, 281);
            this.btnKali.Name = "btnKali";
            this.btnKali.Size = new System.Drawing.Size(54, 51);
            this.btnKali.TabIndex = 9;
            this.btnKali.Text = "x";
            this.btnKali.UseVisualStyleBackColor = true;
            this.btnKali.Click += new System.EventHandler(this.btnKali_Click);
            // 
            // btnBagi
            // 
            this.btnBagi.Location = new System.Drawing.Point(228, 281);
            this.btnBagi.Name = "btnBagi";
            this.btnBagi.Size = new System.Drawing.Size(54, 51);
            this.btnBagi.TabIndex = 10;
            this.btnBagi.Text = "/";
            this.btnBagi.UseVisualStyleBackColor = true;
            this.btnBagi.Click += new System.EventHandler(this.btnBagi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Hasil";
            // 
            // txtHasil
            // 
            this.txtHasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHasil.Location = new System.Drawing.Point(15, 222);
            this.txtHasil.Name = "txtHasil";
            this.txtHasil.Size = new System.Drawing.Size(193, 38);
            this.txtHasil.TabIndex = 11;
            this.txtHasil.TextChanged += new System.EventHandler(this.txtHasil_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 379);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHasil);
            this.Controls.Add(this.btnBagi);
            this.Controls.Add(this.btnKali);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnKurang);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBilDua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBilSatu);
            this.Name = "Form1";
            this.Text = "07_Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBilSatu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBilDua;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnKurang;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnKali;
        private System.Windows.Forms.Button btnBagi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHasil;
    }
}

