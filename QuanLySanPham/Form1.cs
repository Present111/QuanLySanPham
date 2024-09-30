using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLySanPham
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            // Xóa phần nền và vẽ lại tiêu đề
            e.Graphics.Clear(box.BackColor);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black,
                                  new PointF((box.Width - e.Graphics.MeasureString(box.Text, box.Font).Width) / 2, 0));

            // Thiết lập bút vẽ với màu xanh đậm và độ dày viền
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                // Điều chỉnh tọa độ vẽ viền để bao quanh GroupBox chính xác
                e.Graphics.DrawRectangle(pen, 0, 6, box.Width - 1, box.Height - 7);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            // Xóa phần nền và vẽ lại tiêu đề
            e.Graphics.Clear(box.BackColor);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black,
                                  new PointF((box.Width - e.Graphics.MeasureString(box.Text, box.Font).Width) / 2, 0));

            // Thiết lập bút vẽ với màu xanh đậm và độ dày viền
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                // Điều chỉnh tọa độ vẽ viền để bao quanh GroupBox chính xác
                e.Graphics.DrawRectangle(pen, 0, 6, box.Width - 1, box.Height - 7);
            }
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            // Xóa phần nền và vẽ lại tiêu đề
            e.Graphics.Clear(box.BackColor);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black,
                                  new PointF((box.Width - e.Graphics.MeasureString(box.Text, box.Font).Width) / 2, 0));

            // Thiết lập bút vẽ với màu xanh đậm và độ dày viền
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                // Điều chỉnh tọa độ vẽ viền để bao quanh GroupBox chính xác
                e.Graphics.DrawRectangle(pen, 0, 6, box.Width - 1, box.Height - 7);
            }
        }

        private void label7_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            // Thiết lập bút vẽ với màu xanh đậm và độ dày viền
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                // Vẽ viền xung quanh Label
                e.Graphics.DrawRectangle(pen, 0, 0, lbl.Width - 1, lbl.Height);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;

            // Xóa phần nền và vẽ lại tiêu đề
            e.Graphics.Clear(box.BackColor);
            e.Graphics.DrawString(box.Text, box.Font, Brushes.Black,
                                  new PointF((box.Width - e.Graphics.MeasureString(box.Text, box.Font).Width) / 2, 0));

            // Thiết lập bút vẽ với màu xanh đậm và độ dày viền
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                // Điều chỉnh tọa độ vẽ viền để bao quanh GroupBox chính xác
                e.Graphics.DrawRectangle(pen, 0, 6, box.Width - 1, box.Height - 7);
            }
        }

        private void label8_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            // Thiết lập bút vẽ với màu xanh đậm và độ dày viền
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                // Vẽ viền xung quanh Label
                e.Graphics.DrawRectangle(pen, 0, 0, lbl.Width - 1, lbl.Height);
            }
        }

        private void label9_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            // Thiết lập bút vẽ với màu xanh đậm và độ dày viền
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                // Vẽ viền xung quanh Label
                e.Graphics.DrawRectangle(pen, 0, 0, lbl.Width - 1, lbl.Height);
            }
        }

        private void label10_Paint(object sender, PaintEventArgs e)
        {
            Label lbl = sender as Label;

            // Thiết lập bút vẽ với màu xanh đậm và độ dày viền
            using (Pen pen = new Pen(Color.DarkBlue, 2))
            {
                // Vẽ viền xung quanh Label
                e.Graphics.DrawRectangle(pen, 0, 0, lbl.Width - 1, lbl.Height);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
