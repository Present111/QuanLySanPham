﻿using System;
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
            dataGridView1.ReadOnly = true;
            dataGridView3.ReadOnly = true;
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
            // Lấy dữ liệu từ các ô nhập liệu
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            int soLuong = int.Parse(txtSoLuong.Text);
            decimal donGia = decimal.Parse(txtDonGia.Text);
            string xuatXu = txtXuatXu.Text;
            DateTime ngayHetHan = dtimeNgayHetHan.Value;

            // Kết nối cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Câu lệnh SQL để thêm sản phẩm
                    string sql = "INSERT INTO SanPham (MaSP, TenSP, SoLuong, DonGia, XuatXu, NgayHetHan) " +
                                 "VALUES (@MaSP, @TenSP, @SoLuong, @DonGia, @XuatXu, @NgayHetHan)";

                    // Tạo đối tượng SqlCommand
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        // Thêm tham số vào câu lệnh SQL
                        cmd.Parameters.AddWithValue("@MaSP", maSP);
                        cmd.Parameters.AddWithValue("@TenSP", tenSP);
                        cmd.Parameters.AddWithValue("@SoLuong", soLuong);
                        cmd.Parameters.AddWithValue("@DonGia", donGia);
                        cmd.Parameters.AddWithValue("@XuatXu", xuatXu);
                        cmd.Parameters.AddWithValue("@NgayHetHan", ngayHetHan);

                        // Thực thi câu lệnh SQL
                        cmd.ExecuteNonQuery();
                    }

                    // Thông báo lưu thành công
                    MessageBox.Show("Lưu sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Tải lại dữ liệu vào DataGridView
                    LoadData();
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }
        // Hàm tải dữ liệu vào DataGridView
        private void LoadData()
        {
            // Xóa dữ liệu cũ trong DataTable
            dt.Clear();

            // Kết nối cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                try
                {
                    // Mở kết nối
                    conn.Open();

                    // Tạo câu lệnh SQL
                    string sql = "SELECT MaSP, TenSP, SoLuong, DonGia, XuatXu, NgayHetHan FROM SanPham";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        SqlDataAdapter adt = new SqlDataAdapter(cmd);
                        adt.Fill(dt);
                    }

                    // Gán DataTable làm nguồn dữ liệu cho DataGridView
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Lấy mã sản phẩm (hoặc một giá trị duy nhất khác) từ hàng được chọn
                string maSP = dataGridView1.SelectedRows[0].Cells["MaSP"].Value.ToString();

                // Xác nhận lại việc xóa hàng
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa hàng đã chọn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Xóa hàng khỏi cơ sở dữ liệu
                    using (SqlConnection conn = new SqlConnection(connectstring))
                    {
                        try
                        {
                            conn.Open();
                            string sql = "DELETE FROM SanPham WHERE MaSP = @MaSP";

                            using (SqlCommand cmd = new SqlCommand(sql, conn))
                            {
                                cmd.Parameters.AddWithValue("@MaSP", maSP);
                                cmd.ExecuteNonQuery();
                            }

                            MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Xóa hàng khỏi DataGridView
                            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            // Chuyển dữ liệu từ DataGridView vào danh sách sản phẩm
            List<SanPham> danhSachSanPham = new List<SanPham>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSP"].Value != null) // Kiểm tra tránh các hàng trống
                {
                    SanPham sanPham = new SanPham
                    {
                        MaSP = row.Cells["MaSP"].Value.ToString(),
                        TenSP = row.Cells["TenSP"].Value.ToString(),
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                        DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
                        XuatXu = row.Cells["XuatXu"].Value.ToString(),
                        NgayHetHan = Convert.ToDateTime(row.Cells["NgayHetHan"].Value)
                    };
                    danhSachSanPham.Add(sanPham);
                }
            }

            // Sử dụng LINQ để tìm sản phẩm có đơn giá cao nhất
            var sanPhamCoDonGiaCaoNhat = danhSachSanPham.OrderByDescending(p => p.DonGia).FirstOrDefault();

            // Kiểm tra nếu tìm thấy sản phẩm có đơn giá cao nhất
            if (sanPhamCoDonGiaCaoNhat != null)
            {
                // Tạo một danh sách chỉ chứa sản phẩm có đơn giá cao nhất
                List<SanPham> sanPhamCaoNhatList = new List<SanPham> { sanPhamCoDonGiaCaoNhat };

                // Thiết lập lại cột và thuộc tính DataPropertyName cho dataGridView2
                dataGridView3.AutoGenerateColumns = false;
                dataGridView3.Columns.Clear();
                dataGridView3.Columns.Add("MaSP", "Mã SP");
                dataGridView3.Columns.Add("TenSP", "Tên SP");
                dataGridView3.Columns.Add("SoLuong", "Số Lượng");
                dataGridView3.Columns.Add("DonGia", "Đơn Giá");
                dataGridView3.Columns.Add("XuatXu", "Xuất xứ");
                dataGridView3.Columns.Add("NgayHetHan", "Ngày hết hạn");

                dataGridView3.Columns["MaSP"].DataPropertyName = "MaSP";
                dataGridView3.Columns["TenSP"].DataPropertyName = "TenSP";
                dataGridView3.Columns["SoLuong"].DataPropertyName = "SoLuong";
                dataGridView3.Columns["DonGia"].DataPropertyName = "DonGia";
                dataGridView3.Columns["XuatXu"].DataPropertyName = "XuatXu";
                dataGridView3.Columns["NgayHetHan"].DataPropertyName = "NgayHetHan";

                // Gán dữ liệu cho dataGridView2
                dataGridView3.DataSource = sanPhamCaoNhatList;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView3.DataSource = null;
            // Chuyển dữ liệu từ DataGridView1 vào danh sách sản phẩm
            List<SanPham> danhSachSanPham = new List<SanPham>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSP"].Value != null) // Kiểm tra tránh các hàng trống
                {
                    SanPham sanPham = new SanPham
                    {
                        MaSP = row.Cells["MaSP"].Value.ToString(),
                        TenSP = row.Cells["TenSP"].Value.ToString(),
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                        DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
                        XuatXu = row.Cells["XuatXu"].Value.ToString(),
                        NgayHetHan = Convert.ToDateTime(row.Cells["NgayHetHan"].Value)
                    };
                    danhSachSanPham.Add(sanPham);
                }
            }

            // Sử dụng LINQ to Objects để tìm sản phẩm có xuất xứ từ Nhật Bản
            var sanPhamTuNhatBan = danhSachSanPham.Where(p => p.XuatXu.Equals("Nhật Bản", StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            // Kiểm tra nếu tìm thấy sản phẩm từ Nhật Bản
            if (sanPhamTuNhatBan != null)
            {
                // Tạo một danh sách chứa sản phẩm từ Nhật Bản
                List<SanPham> sanPhamNhatBanList = new List<SanPham> { sanPhamTuNhatBan };

                // Thiết lập lại cột và thuộc tính DataPropertyName cho dataGridView3
                dataGridView3.AutoGenerateColumns = false;
                dataGridView3.Columns.Clear();
                dataGridView3.Columns.Add("MaSP", "Mã SP");
                dataGridView3.Columns.Add("TenSP", "Tên SP");
                dataGridView3.Columns.Add("SoLuong", "Số Lượng");
                dataGridView3.Columns.Add("DonGia", "Đơn Giá");
                dataGridView3.Columns.Add("XuatXu", "Xuất xứ");
                dataGridView3.Columns.Add("NgayHetHan", "Ngày hết hạn");

                dataGridView3.Columns["MaSP"].DataPropertyName = "MaSP";
                dataGridView3.Columns["TenSP"].DataPropertyName = "TenSP";
                dataGridView3.Columns["SoLuong"].DataPropertyName = "SoLuong";
                dataGridView3.Columns["DonGia"].DataPropertyName = "DonGia";
                dataGridView3.Columns["XuatXu"].DataPropertyName = "XuatXu";
                dataGridView3.Columns["NgayHetHan"].DataPropertyName = "NgayHetHan";

                // Gán dữ liệu cho dataGridView3
                dataGridView3.DataSource = sanPhamNhatBanList;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào từ Nhật Bản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Đặt dataGridView3 về null trước khi hiển thị kết quả mới
            dataGridView3.DataSource = null;

            // Chuyển dữ liệu từ DataGridView1 vào danh sách sản phẩm
            List<SanPham> danhSachSanPham = new List<SanPham>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSP"].Value != null) // Kiểm tra tránh các hàng trống
                {
                    SanPham sanPham = new SanPham
                    {
                        MaSP = row.Cells["MaSP"].Value.ToString(),
                        TenSP = row.Cells["TenSP"].Value.ToString(),
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                        DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
                        XuatXu = row.Cells["XuatXu"].Value.ToString(),
                        NgayHetHan = Convert.ToDateTime(row.Cells["NgayHetHan"].Value)
                    };
                    danhSachSanPham.Add(sanPham);
                }
            }

            // Lọc danh sách các sản phẩm quá hạn so với ngày hôm nay
            var sanPhamQuaHan = danhSachSanPham.Where(p => p.NgayHetHan < DateTime.Today).ToList();

            // Kiểm tra nếu có sản phẩm quá hạn
            if (sanPhamQuaHan.Count > 0)
            {
                // Thiết lập lại cột và thuộc tính DataPropertyName cho dataGridView3
                dataGridView3.AutoGenerateColumns = false;
                dataGridView3.Columns.Clear();
                dataGridView3.Columns.Add("MaSP", "Mã SP");
                dataGridView3.Columns.Add("TenSP", "Tên SP");
                dataGridView3.Columns.Add("SoLuong", "Số Lượng");
                dataGridView3.Columns.Add("DonGia", "Đơn Giá");
                dataGridView3.Columns.Add("XuatXu", "Xuất xứ");
                dataGridView3.Columns.Add("NgayHetHan", "Ngày hết hạn");

                dataGridView3.Columns["MaSP"].DataPropertyName = "MaSP";
                dataGridView3.Columns["TenSP"].DataPropertyName = "TenSP";
                dataGridView3.Columns["SoLuong"].DataPropertyName = "SoLuong";
                dataGridView3.Columns["DonGia"].DataPropertyName = "DonGia";
                dataGridView3.Columns["XuatXu"].DataPropertyName = "XuatXu";
                dataGridView3.Columns["NgayHetHan"].DataPropertyName = "NgayHetHan";

                // Gán danh sách sản phẩm quá hạn cho dataGridView3
                dataGridView3.DataSource = sanPhamQuaHan;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào quá hạn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Đặt dataGridView3 về null trước khi hiển thị kết quả mới
            dataGridView3.DataSource = null;

            // Lấy giá trị từ txtDGmin và txtDGmax
            decimal donGiaMin, donGiaMax;

            // Kiểm tra nếu giá trị đầu vào là hợp lệ
            if (!decimal.TryParse(txtDGmin.Text, out donGiaMin) || !decimal.TryParse(txtDGmax.Text, out donGiaMax))
            {
                MessageBox.Show("Vui lòng nhập giá trị hợp lệ cho Đơn Giá Min và Đơn Giá Max.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chuyển dữ liệu từ DataGridView1 vào danh sách sản phẩm
            List<SanPham> danhSachSanPham = new List<SanPham>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSP"].Value != null) // Kiểm tra tránh các hàng trống
                {
                    SanPham sanPham = new SanPham
                    {
                        MaSP = row.Cells["MaSP"].Value.ToString(),
                        TenSP = row.Cells["TenSP"].Value.ToString(),
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                        DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
                        XuatXu = row.Cells["XuatXu"].Value.ToString(),
                        NgayHetHan = Convert.ToDateTime(row.Cells["NgayHetHan"].Value)
                    };
                    danhSachSanPham.Add(sanPham);
                }
            }

            // Sử dụng LINQ to Objects để tìm các sản phẩm có đơn giá trong khoảng a đến b
            var sanPhamTrongKhoang = danhSachSanPham.Where(p => p.DonGia >= donGiaMin && p.DonGia <= donGiaMax).ToList();

            // Kiểm tra nếu tìm thấy sản phẩm trong khoảng
            if (sanPhamTrongKhoang.Count > 0)
            {
                // Thiết lập lại cột và thuộc tính DataPropertyName cho dataGridView3
                dataGridView3.AutoGenerateColumns = false;
                dataGridView3.Columns.Clear();
                dataGridView3.Columns.Add("MaSP", "Mã SP");
                dataGridView3.Columns.Add("TenSP", "Tên SP");
                dataGridView3.Columns.Add("SoLuong", "Số Lượng");
                dataGridView3.Columns.Add("DonGia", "Đơn Giá");
                dataGridView3.Columns.Add("XuatXu", "Xuất xứ");
                dataGridView3.Columns.Add("NgayHetHan", "Ngày hết hạn");

                dataGridView3.Columns["MaSP"].DataPropertyName = "MaSP";
                dataGridView3.Columns["TenSP"].DataPropertyName = "TenSP";
                dataGridView3.Columns["SoLuong"].DataPropertyName = "SoLuong";
                dataGridView3.Columns["DonGia"].DataPropertyName = "DonGia";
                dataGridView3.Columns["XuatXu"].DataPropertyName = "XuatXu";
                dataGridView3.Columns["NgayHetHan"].DataPropertyName = "NgayHetHan";

                // Gán danh sách sản phẩm trong khoảng đơn giá vào dataGridView3
                dataGridView3.DataSource = sanPhamTrongKhoang;
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào trong khoảng đơn giá này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Lấy giá trị xuất xứ từ ô txt
            string xuatXuCanXoa = txt.Text.Trim();

            if (string.IsNullOrEmpty(xuatXuCanXoa))
            {
                MessageBox.Show("Vui lòng nhập xuất xứ để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bước 1: Xóa dữ liệu khỏi cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM SanPham WHERE XuatXu = @XuatXu";
                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@XuatXu", xuatXuCanXoa);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Đã xóa {rowsAffected} sản phẩm có xuất xứ '{xuatXuCanXoa}' khỏi cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show($"Không có sản phẩm nào có xuất xứ '{xuatXuCanXoa}' trong cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm khỏi cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Bước 2: Xóa dữ liệu khỏi DataGridView
            // Chuyển dữ liệu từ DataGridView1 vào danh sách sản phẩm
            List<SanPham> danhSachSanPham = new List<SanPham>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSP"].Value != null) // Kiểm tra tránh các hàng trống
                {
                    SanPham sanPham = new SanPham
                    {
                        MaSP = row.Cells["MaSP"].Value.ToString(),
                        TenSP = row.Cells["TenSP"].Value.ToString(),
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                        DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
                        XuatXu = row.Cells["XuatXu"].Value.ToString(),
                        NgayHetHan = Convert.ToDateTime(row.Cells["NgayHetHan"].Value)
                    };
                    danhSachSanPham.Add(sanPham);
                }
            }

            // Sử dụng LINQ to Objects để tạo danh sách sản phẩm không có xuất xứ cần xóa
            var danhSachConLai = danhSachSanPham.Where(p => !p.XuatXu.Equals(xuatXuCanXoa, StringComparison.OrdinalIgnoreCase)).ToList();

            // Cập nhật lại DataGridView1 với danh sách sản phẩm còn lại
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachConLai;

            // Thiết lập lại DataPropertyName cho các cột (nếu cần)
            dataGridView1.Columns["MaSP"].DataPropertyName = "MaSP";
            dataGridView1.Columns["TenSP"].DataPropertyName = "TenSP";
            dataGridView1.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dataGridView1.Columns["DonGia"].DataPropertyName = "DonGia";
            dataGridView1.Columns["XuatXu"].DataPropertyName = "XuatXu";
            dataGridView1.Columns["NgayHetHan"].DataPropertyName = "NgayHetHan";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Chuyển dữ liệu từ DataGridView1 vào danh sách sản phẩm
            List<SanPham> danhSachSanPham = new List<SanPham>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSP"].Value != null) // Kiểm tra tránh các hàng trống
                {
                    SanPham sanPham = new SanPham
                    {
                        MaSP = row.Cells["MaSP"].Value.ToString(),
                        TenSP = row.Cells["TenSP"].Value.ToString(),
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                        DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
                        XuatXu = row.Cells["XuatXu"].Value.ToString(),
                        NgayHetHan = Convert.ToDateTime(row.Cells["NgayHetHan"].Value)
                    };
                    danhSachSanPham.Add(sanPham);
                }
            }

            // Sử dụng LINQ to Objects để kiểm tra xem có sản phẩm nào quá hạn
            bool coSanPhamQuaHan = danhSachSanPham.Any(p => p.NgayHetHan < DateTime.Today);

            // Hiển thị kết quả bằng MessageBox
            if (coSanPhamQuaHan)
            {
                MessageBox.Show("Có sản phẩm quá hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có sản phẩm nào quá hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            // Bước 1: Chuyển dữ liệu từ DataGridView1 vào danh sách sản phẩm
            List<SanPham> danhSachSanPham = new List<SanPham>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSP"].Value != null) // Kiểm tra tránh các hàng trống
                {
                    SanPham sanPham = new SanPham
                    {
                        MaSP = row.Cells["MaSP"].Value.ToString(),
                        TenSP = row.Cells["TenSP"].Value.ToString(),
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                        DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
                        XuatXu = row.Cells["XuatXu"].Value.ToString(),
                        NgayHetHan = Convert.ToDateTime(row.Cells["NgayHetHan"].Value)
                    };
                    danhSachSanPham.Add(sanPham);
                }
            }

            // Bước 2: Lọc danh sách các sản phẩm quá hạn
            var sanPhamQuaHan = danhSachSanPham.Where(p => p.NgayHetHan < DateTime.Today).ToList();

            if (sanPhamQuaHan.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào quá hạn để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Bước 3: Xóa các sản phẩm quá hạn khỏi cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                try
                {
                    conn.Open();

                    foreach (var sanPham in sanPhamQuaHan)
                    {
                        string sql = "DELETE FROM SanPham WHERE MaSP = @MaSP";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaSP", sanPham.MaSP);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm khỏi cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Bước 4: Xóa sản phẩm quá hạn khỏi DataGridView
            var danhSachConLai = danhSachSanPham.Where(p => p.NgayHetHan >= DateTime.Today).ToList();

            // Cập nhật lại DataGridView1 với danh sách sản phẩm còn lại
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachConLai;

            // Thiết lập lại DataPropertyName cho các cột (nếu cần)
            dataGridView1.Columns["MaSP"].DataPropertyName = "MaSP";
            dataGridView1.Columns["TenSP"].DataPropertyName = "TenSP";
            dataGridView1.Columns["SoLuong"].DataPropertyName = "SoLuong";
            dataGridView1.Columns["DonGia"].DataPropertyName = "DonGia";
            dataGridView1.Columns["XuatXu"].DataPropertyName = "XuatXu";
            dataGridView1.Columns["NgayHetHan"].DataPropertyName = "NgayHetHan";

            MessageBox.Show($"Đã xóa {sanPhamQuaHan.Count} sản phẩm quá hạn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Bước 1: Chuyển tất cả dữ liệu từ DataGridView1 vào danh sách sản phẩm
            List<SanPham> danhSachSanPham = new List<SanPham>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["MaSP"].Value != null) // Kiểm tra tránh các hàng trống
                {
                    SanPham sanPham = new SanPham
                    {
                        MaSP = row.Cells["MaSP"].Value.ToString(),
                        TenSP = row.Cells["TenSP"].Value.ToString(),
                        SoLuong = Convert.ToInt32(row.Cells["SoLuong"].Value),
                        DonGia = Convert.ToDecimal(row.Cells["DonGia"].Value),
                        XuatXu = row.Cells["XuatXu"].Value.ToString(),
                        NgayHetHan = Convert.ToDateTime(row.Cells["NgayHetHan"].Value)
                    };
                    danhSachSanPham.Add(sanPham);
                }
            }

            // Kiểm tra xem danh sách có sản phẩm nào không
            if (danhSachSanPham.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Bước 2: Xóa toàn bộ sản phẩm trong cơ sở dữ liệu
            using (SqlConnection conn = new SqlConnection(connectstring))
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM SanPham"; // Câu lệnh SQL để xóa toàn bộ sản phẩm

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Đã xóa toàn bộ sản phẩm khỏi cơ sở dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa sản phẩm khỏi cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Bước 3: Xóa dữ liệu khỏi dataGridView1
            dataGridView1.DataSource = null; // Đặt nguồn dữ liệu về null để xóa tất cả sản phẩm hiển thị
        }
    }
}
