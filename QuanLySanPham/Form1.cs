using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySanPham
{

    public partial class Form1 : Form
    {
        string connectstring = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QuanLySanPham;Integrated Security=True;TrustServerCertificate=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt=new DataTable();
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
            // Tạo kết nối
            conn = new SqlConnection(connectstring);

            try
            {
                // Đặt AutoGenerateColumns thành false
                dataGridView1.AutoGenerateColumns = false;

                // Thiết lập DataPropertyName cho mỗi cột
                dataGridView1.Columns["MaSP"].DataPropertyName = "MaSP";
                dataGridView1.Columns["TenSP"].DataPropertyName = "TenSP";
                dataGridView1.Columns["SoLuong"].DataPropertyName = "SoLuong";
                dataGridView1.Columns["DonGia"].DataPropertyName = "DonGia";
                dataGridView1.Columns["XuatXu"].DataPropertyName = "XuatXu";
                dataGridView1.Columns["NgayHetHan"].DataPropertyName = "NgayHetHan";

                // Mở kết nối
                conn.Open();

                // Tạo câu lệnh SQL
                cmd = new SqlCommand("SELECT MaSP, TenSP, SoLuong, DonGia, XuatXu, NgayHetHan FROM SanPham", conn);

                // Tạo SqlDataAdapter để điền dữ liệu vào DataTable
                adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);

                // Gán DataTable làm nguồn dữ liệu cho DataGridView
                dataGridView1.DataSource = dt;

                // Đóng kết nối
                conn.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi
                MessageBox.Show("Lỗi: " + ex.Message);
            }
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
