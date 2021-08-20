namespace resturant_project
{
    partial class allproducts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_pro = new System.Windows.Forms.Label();
            this.price_pro = new System.Windows.Forms.Label();
            this.apic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.apic)).BeginInit();
            this.SuspendLayout();
            // 
            // name_pro
            // 
            this.name_pro.Location = new System.Drawing.Point(0, 96);
            this.name_pro.Name = "name_pro";
            this.name_pro.Size = new System.Drawing.Size(92, 23);
            this.name_pro.TabIndex = 1;
            this.name_pro.Text = "label1";
            this.name_pro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price_pro
            // 
            this.price_pro.Location = new System.Drawing.Point(82, 96);
            this.price_pro.Name = "price_pro";
            this.price_pro.Size = new System.Drawing.Size(73, 23);
            this.price_pro.TabIndex = 2;
            this.price_pro.Text = "label2";
            this.price_pro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // apic
            // 
            this.apic.Location = new System.Drawing.Point(0, 3);
            this.apic.Name = "apic";
            this.apic.Size = new System.Drawing.Size(156, 90);
            this.apic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apic.TabIndex = 0;
            this.apic.TabStop = false;
            this.apic.Click += new System.EventHandler(this.apic_Click);
            // 
            // allproducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.price_pro);
            this.Controls.Add(this.name_pro);
            this.Controls.Add(this.apic);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "allproducts";
            this.Size = new System.Drawing.Size(158, 129);
            this.Load += new System.EventHandler(this.allproducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox apic;
        private System.Windows.Forms.Label name_pro;
        private System.Windows.Forms.Label price_pro;
    }
}
