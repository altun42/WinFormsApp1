namespace WinFormsApp1
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.basvurubtn = new System.Windows.Forms.Button();
            this.yöneticibtn = new System.Windows.Forms.Button();
            this.üyebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(249, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(658, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "MAKÜ ŞİRKETİNE HOŞGELDİNİZ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(454, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 223);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // basvurubtn
            // 
            this.basvurubtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.basvurubtn.Location = new System.Drawing.Point(103, 179);
            this.basvurubtn.Name = "basvurubtn";
            this.basvurubtn.Size = new System.Drawing.Size(229, 92);
            this.basvurubtn.TabIndex = 2;
            this.basvurubtn.Text = "Başvuru Girişi";
            this.basvurubtn.UseVisualStyleBackColor = true;
            this.basvurubtn.Click += new System.EventHandler(this.basvurubtn_Click);
            // 
            // yöneticibtn
            // 
            this.yöneticibtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yöneticibtn.Location = new System.Drawing.Point(800, 179);
            this.yöneticibtn.Name = "yöneticibtn";
            this.yöneticibtn.Size = new System.Drawing.Size(229, 92);
            this.yöneticibtn.TabIndex = 3;
            this.yöneticibtn.Text = "Yönetici Girişi";
            this.yöneticibtn.UseVisualStyleBackColor = true;
            this.yöneticibtn.Click += new System.EventHandler(this.yöneticibtn_Click);
            // 
            // üyebtn
            // 
            this.üyebtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.üyebtn.Location = new System.Drawing.Point(454, 350);
            this.üyebtn.Name = "üyebtn";
            this.üyebtn.Size = new System.Drawing.Size(250, 92);
            this.üyebtn.TabIndex = 4;
            this.üyebtn.Text = "Üye Ol";
            this.üyebtn.UseVisualStyleBackColor = true;
            this.üyebtn.Click += new System.EventHandler(this.üyebtn_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 558);
            this.Controls.Add(this.üyebtn);
            this.Controls.Add(this.yöneticibtn);
            this.Controls.Add(this.basvurubtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button basvurubtn;
        private Button yöneticibtn;
        private Button üyebtn;
    }
}