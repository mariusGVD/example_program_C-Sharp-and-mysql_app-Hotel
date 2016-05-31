namespace AppHotel
{
    partial class FormDadesClient
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDadesDni = new System.Windows.Forms.Label();
            this.txtDadesNom = new System.Windows.Forms.Label();
            this.txtDadesCognom = new System.Windows.Forms.Label();
            this.txtDadesTel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtDadesTel);
            this.groupBox1.Controls.Add(this.txtDadesCognom);
            this.groupBox1.Controls.Add(this.txtDadesNom);
            this.groupBox1.Controls.Add(this.txtDadesDni);
            this.groupBox1.Location = new System.Drawing.Point(38, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 290);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dades del client ";
            // 
            // txtDadesDni
            // 
            this.txtDadesDni.AutoSize = true;
            this.txtDadesDni.Location = new System.Drawing.Point(7, 67);
            this.txtDadesDni.Name = "txtDadesDni";
            this.txtDadesDni.Size = new System.Drawing.Size(71, 13);
            this.txtDadesDni.TabIndex = 0;
            this.txtDadesDni.Text = "DNI del client";
            // 
            // txtDadesNom
            // 
            this.txtDadesNom.AutoSize = true;
            this.txtDadesNom.Location = new System.Drawing.Point(7, 111);
            this.txtDadesNom.Name = "txtDadesNom";
            this.txtDadesNom.Size = new System.Drawing.Size(74, 13);
            this.txtDadesNom.TabIndex = 1;
            this.txtDadesNom.Text = "Nom del client";
            // 
            // txtDadesCognom
            // 
            this.txtDadesCognom.AutoSize = true;
            this.txtDadesCognom.Location = new System.Drawing.Point(7, 161);
            this.txtDadesCognom.Name = "txtDadesCognom";
            this.txtDadesCognom.Size = new System.Drawing.Size(91, 13);
            this.txtDadesCognom.TabIndex = 2;
            this.txtDadesCognom.Text = "Cognom del client";
            // 
            // txtDadesTel
            // 
            this.txtDadesTel.AutoSize = true;
            this.txtDadesTel.Location = new System.Drawing.Point(7, 208);
            this.txtDadesTel.Name = "txtDadesTel";
            this.txtDadesTel.Size = new System.Drawing.Size(88, 13);
            this.txtDadesTel.TabIndex = 3;
            this.txtDadesTel.Text = "Telefon del client";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(147, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(147, 104);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(147, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(147, 201);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppHotel.Properties.Resources.usuario;
            this.pictureBox1.Location = new System.Drawing.Point(306, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 208);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormDadesClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 359);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDadesClient";
            this.Text = "FormDadesClient";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txtDadesDni;
        private System.Windows.Forms.Label txtDadesTel;
        private System.Windows.Forms.Label txtDadesCognom;
        private System.Windows.Forms.Label txtDadesNom;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}