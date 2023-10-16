using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Xml.Linq;
using System.Collections;
using System.Threading;

namespace Giao_dien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (ID.Text != "" || date.Text != "")
            {
                int idx = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows.RemoveAt(idx);
            }
            else
            {
                MessageBox.Show("Khong co dong de xoa ", "Error", MessageBoxButtons.OK);
                return;
            }
        }
        void Show(GroupBox box)
        {
            RadioButton check = null;
            foreach (RadioButton item in Box3.Controls)
            {
                if (item != null)
                {
                    if (item.Checked)
                    {
                        check = item;
                        break;
                    }
                }
            }
            if (check != null)
                box.Text = check.Text;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Show(Box3);
            dataGridView1.Rows.Add(ID.Text, Name.Text, date.Value, Box3.Text, Address.Text, Phone.Text, Email.Text);
            if (ID.Text == "" || Name.Text == "")
            {
                MessageBox.Show("Khong duoc bo trong", "Error", MessageBoxButtons.OK);
                return;
            }
        }
        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            ID.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            Name.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
            date.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
            Box3.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
            Address.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
            Phone.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();
            Email.Text = dataGridView1.Rows[idx].Cells[6].Value.ToString();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            int l = ID.TextLength;
            if (l > 10)
            {
                MessageBox.Show("Do dai khong hop le", "Error", MessageBoxButtons.OK);
                return;
            }
        }

        private void Phone_TextChanged(object sender, EventArgs e)
        {
            int l = ID.TextLength;
            if (l >10 )
            {
                MessageBox.Show("Do dai khong hop le", "Error", MessageBoxButtons.OK);
                return;
            }
        }
        private void DataGridView1_SelectedIndexChanged(object sender,EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                ID.Text = dataGridView1.SelectedRows[0].ToString();
                Name.Text = dataGridView1.SelectedRows[1].ToString();
                date.Text = dataGridView1.SelectedRows[2].ToString();
                Box3.Text = dataGridView1.SelectedRows[3].ToString();
                Address.Text = dataGridView1.SelectedRows[4].ToString();
                Phone.Text = dataGridView1.SelectedRows[5].ToString();
                Email.Text = dataGridView1.SelectedRows[6].ToString();
            }    
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            if (ID.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã học sinh cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ID.Focus();
            }
            else
            {
                //string id = ID.Text;
                //string name = Name.Text;
                //DateTime birth = date.Value;
                //string gt = Box3.Text;
                //string dc = Address.Text;
                //string dt = Phone.Text;
                //string mail = Email.Text;
                dataGridView1.Update();
             
            }      
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            image.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open Image";
            dialog.Filter = "JPEG files (*.jpg)| *.jpg";
            if (dialog.ShowDialog() == DialogResult.OK)
                image.ImageLocation = dialog.FileName;
        }

        public void DialogShow()
        {
            throw new NotImplementedException();
        }
    }
}
