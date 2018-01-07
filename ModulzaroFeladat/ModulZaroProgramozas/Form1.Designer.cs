namespace ModulZaroProgramozas
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
            this.btnBeolvasás_3F = new System.Windows.Forms.Button();
            this.openFileDialog_3F = new System.Windows.Forms.OpenFileDialog();
            this.treeViewNaplo_4F = new System.Windows.Forms.TreeView();
            this.label_5F = new System.Windows.Forms.Label();
            this.label_Mennyiseg_5F = new System.Windows.Forms.Label();
            this.label_maxMAC_6F = new System.Windows.Forms.Label();
            this.label_MACmax_6F = new System.Windows.Forms.Label();
            this.label_minMAC_7F = new System.Windows.Forms.Label();
            this.label_MACmin_7F = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBeolvasás_3F
            // 
            this.btnBeolvasás_3F.Location = new System.Drawing.Point(303, 12);
            this.btnBeolvasás_3F.Name = "btnBeolvasás_3F";
            this.btnBeolvasás_3F.Size = new System.Drawing.Size(115, 54);
            this.btnBeolvasás_3F.TabIndex = 0;
            this.btnBeolvasás_3F.Text = "Fájl beolvasás";
            this.btnBeolvasás_3F.UseVisualStyleBackColor = true;
            this.btnBeolvasás_3F.Click += new System.EventHandler(this.btnBeolvasás_3F_Click);
            // 
            // treeViewNaplo_4F
            // 
            this.treeViewNaplo_4F.Location = new System.Drawing.Point(12, 12);
            this.treeViewNaplo_4F.Name = "treeViewNaplo_4F";
            this.treeViewNaplo_4F.Size = new System.Drawing.Size(278, 216);
            this.treeViewNaplo_4F.TabIndex = 1;
            // 
            // label_5F
            // 
            this.label_5F.AutoSize = true;
            this.label_5F.Location = new System.Drawing.Point(13, 245);
            this.label_5F.Name = "label_5F";
            this.label_5F.Size = new System.Drawing.Size(142, 13);
            this.label_5F.TabIndex = 2;
            this.label_5F.Text = "Összes adatmennyiség [GB]:";
            // 
            // label_Mennyiseg_5F
            // 
            this.label_Mennyiseg_5F.AutoSize = true;
            this.label_Mennyiseg_5F.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_Mennyiseg_5F.Location = new System.Drawing.Point(159, 243);
            this.label_Mennyiseg_5F.Name = "label_Mennyiseg_5F";
            this.label_Mennyiseg_5F.Size = new System.Drawing.Size(17, 17);
            this.label_Mennyiseg_5F.TabIndex = 3;
            this.label_Mennyiseg_5F.Text = "0";
            // 
            // label_maxMAC_6F
            // 
            this.label_maxMAC_6F.AutoSize = true;
            this.label_maxMAC_6F.Location = new System.Drawing.Point(13, 276);
            this.label_maxMAC_6F.Name = "label_maxMAC_6F";
            this.label_maxMAC_6F.Size = new System.Drawing.Size(165, 13);
            this.label_maxMAC_6F.TabIndex = 4;
            this.label_maxMAC_6F.Text = "Legtöbbet forgalmazó gép [MAC]:";
            // 
            // label_MACmax_6F
            // 
            this.label_MACmax_6F.AutoSize = true;
            this.label_MACmax_6F.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MACmax_6F.Location = new System.Drawing.Point(17, 295);
            this.label_MACmax_6F.Name = "label_MACmax_6F";
            this.label_MACmax_6F.Size = new System.Drawing.Size(14, 17);
            this.label_MACmax_6F.TabIndex = 5;
            this.label_MACmax_6F.Text = "-";
            // 
            // label_minMAC_7F
            // 
            this.label_minMAC_7F.AutoSize = true;
            this.label_minMAC_7F.Location = new System.Drawing.Point(12, 322);
            this.label_minMAC_7F.Name = "label_minMAC_7F";
            this.label_minMAC_7F.Size = new System.Drawing.Size(226, 13);
            this.label_minMAC_7F.TabIndex = 6;
            this.label_minMAC_7F.Text = "500Mb-nál kevesebbet forgalmazó gép [MAC]:";
            // 
            // label_MACmin_7F
            // 
            this.label_MACmin_7F.AutoSize = true;
            this.label_MACmin_7F.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_MACmin_7F.Location = new System.Drawing.Point(17, 338);
            this.label_MACmin_7F.Name = "label_MACmin_7F";
            this.label_MACmin_7F.Size = new System.Drawing.Size(14, 17);
            this.label_MACmin_7F.TabIndex = 7;
            this.label_MACmin_7F.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 384);
            this.Controls.Add(this.label_MACmin_7F);
            this.Controls.Add(this.label_minMAC_7F);
            this.Controls.Add(this.label_MACmax_6F);
            this.Controls.Add(this.label_maxMAC_6F);
            this.Controls.Add(this.label_Mennyiseg_5F);
            this.Controls.Add(this.label_5F);
            this.Controls.Add(this.treeViewNaplo_4F);
            this.Controls.Add(this.btnBeolvasás_3F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBeolvasás_3F;
        private System.Windows.Forms.OpenFileDialog openFileDialog_3F;
        private System.Windows.Forms.TreeView treeViewNaplo_4F;
        private System.Windows.Forms.Label label_5F;
        private System.Windows.Forms.Label label_Mennyiseg_5F;
        private System.Windows.Forms.Label label_maxMAC_6F;
        private System.Windows.Forms.Label label_MACmax_6F;
        private System.Windows.Forms.Label label_minMAC_7F;
        private System.Windows.Forms.Label label_MACmin_7F;
    }
}

