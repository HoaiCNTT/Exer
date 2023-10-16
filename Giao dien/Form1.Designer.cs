namespace Giao_dien
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
            this.Box1 = new System.Windows.Forms.GroupBox();
            this.Box3 = new System.Windows.Forms.GroupBox();
            this.Male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.Email = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Box2 = new System.Windows.Forms.GroupBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.image = new System.Windows.Forms.PictureBox();
            this.ảnh = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.Box1.SuspendLayout();
            this.Box3.SuspendLayout();
            this.Box2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // Box1
            // 
            this.Box1.Controls.Add(this.Box3);
            this.Box1.Controls.Add(this.date);
            this.Box1.Controls.Add(this.Email);
            this.Box1.Controls.Add(this.Phone);
            this.Box1.Controls.Add(this.Address);
            this.Box1.Controls.Add(this.Name);
            this.Box1.Controls.Add(this.ID);
            this.Box1.Controls.Add(this.label7);
            this.Box1.Controls.Add(this.label6);
            this.Box1.Controls.Add(this.label5);
            this.Box1.Controls.Add(this.label4);
            this.Box1.Controls.Add(this.label3);
            this.Box1.Controls.Add(this.label2);
            this.Box1.Controls.Add(this.label1);
            this.Box1.Location = new System.Drawing.Point(12, 12);
            this.Box1.Name = "Box1";
            this.Box1.Size = new System.Drawing.Size(527, 279);
            this.Box1.TabIndex = 0;
            this.Box1.TabStop = false;
            this.Box1.Text = "Thông tin";
            // 
            // Box3
            // 
            this.Box3.Controls.Add(this.Male);
            this.Box3.Controls.Add(this.Female);
            this.Box3.Location = new System.Drawing.Point(335, 77);
            this.Box3.Name = "Box3";
            this.Box3.Size = new System.Drawing.Size(130, 45);
            this.Box3.TabIndex = 15;
            this.Box3.TabStop = false;
            this.Box3.Text = "Chọn";
            // 
            // Male
            // 
            this.Male.AutoSize = true;
            this.Male.Location = new System.Drawing.Point(6, 19);
            this.Male.Name = "Male";
            this.Male.Size = new System.Drawing.Size(57, 20);
            this.Male.TabIndex = 13;
            this.Male.TabStop = true;
            this.Male.Text = "Nam";
            this.Male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Location = new System.Drawing.Point(69, 19);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(45, 20);
            this.Female.TabIndex = 14;
            this.Female.TabStop = true;
            this.Female.Text = "Nữ";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(134, 167);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 12;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(335, 40);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(100, 22);
            this.Email.TabIndex = 11;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(335, 234);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(100, 22);
            this.Phone.TabIndex = 10;
            this.Phone.TextChanged += new System.EventHandler(this.Phone_TextChanged);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(90, 234);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(100, 22);
            this.Address.TabIndex = 9;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(93, 96);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(100, 22);
            this.Name.TabIndex = 8;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(93, 40);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 22);
            this.ID.TabIndex = 7;
            this.ID.TextChanged += new System.EventHandler(this.ID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(238, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Liên lạc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ Tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã ID";
            // 
            // Box2
            // 
            this.Box2.Controls.Add(this.Button4);
            this.Box2.Controls.Add(this.Button3);
            this.Box2.Controls.Add(this.Button2);
            this.Box2.Controls.Add(this.Button1);
            this.Box2.Location = new System.Drawing.Point(991, 25);
            this.Box2.Name = "Box2";
            this.Box2.Size = new System.Drawing.Size(194, 243);
            this.Box2.TabIndex = 1;
            this.Box2.TabStop = false;
            this.Box2.Text = "Chức năng";
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(63, 204);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(75, 23);
            this.Button4.TabIndex = 3;
            this.Button4.Text = "Thoát";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(63, 148);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(75, 23);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "Xóa";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(63, 89);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(75, 23);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Sửa";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(63, 36);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(75, 23);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Thêm";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 317);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(948, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Date";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "GioiTinh";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Phone";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Email";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.image);
            this.groupBox1.Controls.Add(this.ảnh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(613, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình";
            // 
            // image
            // 
            this.image.Image = global::Giao_dien.Properties.Resources.Screenshot__7_;
            this.image.Location = new System.Drawing.Point(40, 55);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(123, 146);
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            // 
            // ảnh
            // 
            this.ảnh.Location = new System.Drawing.Point(179, 71);
            this.ảnh.Name = "ảnh";
            this.ảnh.Size = new System.Drawing.Size(75, 23);
            this.ảnh.TabIndex = 1;
            this.ảnh.Text = "Chọn ảnh\r\n";
            this.ảnh.UseVisualStyleBackColor = true;
            this.ảnh.Click += new System.EventHandler(this.Button5_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ảnh";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Box2);
            this.Controls.Add(this.Box1);
            //this.Name = "Form1";
            this.Text = "Form1";
            this.Box1.ResumeLayout(false);
            this.Box1.PerformLayout();
            this.Box3.ResumeLayout(false);
            this.Box3.PerformLayout();
            this.Box2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Box1;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.RadioButton Male;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Phone;
        private System.Windows.Forms.TextBox Address;
#pragma warning disable CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.TextBox Name;
#pragma warning restore CS0108 // Member hides inherited member; missing new keyword
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Box2;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox Box3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button ảnh;
        private System.Windows.Forms.Label label8;
    }
}

