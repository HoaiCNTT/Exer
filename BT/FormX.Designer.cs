namespace BT
{
    partial class FormX
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
            this.giaodien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // giaodien
            // 
            this.giaodien.Location = new System.Drawing.Point(148, 74);
            this.giaodien.Name = "giaodien";
            this.giaodien.Size = new System.Drawing.Size(75, 23);
            this.giaodien.TabIndex = 0;
            this.giaodien.Text = "Giao dien";
            this.giaodien.UseVisualStyleBackColor = true;
            this.giaodien.Click += new System.EventHandler(this.giaodien_Click);
            // 
            // FormX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.giaodien);
            this.Name = "FormX";
            this.Text = "FormX";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button giaodien;
    }
}