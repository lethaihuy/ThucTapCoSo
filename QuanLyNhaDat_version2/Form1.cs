using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace QuanLyNhaDat_version2
{
    public partial class Form1 : Form
    {
        DataTable dtDanhSachNhaDat = new DataTable("ThuaDat");
        string flag = "";
        int index;
        public KetNoi kn;

        List<ThuaDat> listThuaDat;
        public Form1()
        {
            InitializeComponent();

        }

        public DataTable CreateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("diaChi");
            dt.Columns.Add("dienTich");
            dt.Columns.Add("chuSoHuu");
            dt.Columns.Add("loaiNha");
            dt.Columns.Add("mucDichSuDung");
            dt.Columns.Add("giaTien");
            return dt;
        }

        private void btnNapDuLieu_Click(object sender, EventArgs e)
        {
            ImportExcel();
            AutoNumber();
        }

        void KhoaControls()
        {
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            txtChuSoHuu.ReadOnly = true;
            txtDienTich.ReadOnly = true;
            txtGiaTien.ReadOnly = true;
            txtDiaChi.ReadOnly = true;
            cbLoaiNha.Enabled = false;
            cbMucDichSuDung.Enabled = false;
            btnThem.Focus();
        }

        void MoKhoaControls()
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            txtChuSoHuu.ReadOnly = false;
            txtDienTich.ReadOnly = false;
            txtGiaTien.ReadOnly = false;
            txtDiaChi.ReadOnly = false;
            cbLoaiNha.Enabled = true;
            cbMucDichSuDung.Enabled = true;
        }

        void ResetForm()
        {
            txtChuSoHuu.ResetText();
            txtDienTich.ResetText();
            txtGiaTien.ResetText();
            cbLoaiNha.ResetText();
            cbMucDichSuDung.ResetText();
            txtDiaChi.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ẩn column đầu tiên(header column)
            dgvDanhSachNhaDat.RowHeadersVisible = false;

            LoadQuanLenCombobox();
            //LoadPhuongTheoQuan();
            KhoaControls();
            dtDanhSachNhaDat = CreateTable();
            //LoadData();
            AutoNumber();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MoKhoaControls();
            this.ResetForm();
            this.flag = "add";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thửa đất này ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                foreach (DataGridViewRow row in dgvDanhSachNhaDat.SelectedRows)
                {
                    dgvDanhSachNhaDat.Rows.Remove(row);
                }
                AutoNumber();
                dgvDanhSachNhaDat.RefreshEdit();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MoKhoaControls();
            this.flag = "edit";
        }

        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChuSoHuu.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDienTich.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin điện tích", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDienTich.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtChuSoHuu.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin chủ sở hữu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtChuSoHuu.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbLoaiNha.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin loại nhà", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbLoaiNha.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(cbMucDichSuDung.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin Mục đích sử dụng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMucDichSuDung.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtGiaTien.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin Giá tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGiaTien.Focus();
                return false;
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.flag == "add")
            {
                if (CheckData())
                {
                    string diaChi = txtDiaChi.Text + ", " + cbPhuong.Text + ", " + cbQuan.Text;
                    dtDanhSachNhaDat.Rows.Add(diaChi, txtDienTich.Text, txtChuSoHuu.Text, cbLoaiNha.Text, cbMucDichSuDung.Text, txtGiaTien.Text);
                    dgvDanhSachNhaDat.DataSource = dtDanhSachNhaDat;
                    AutoNumber();
                    dgvDanhSachNhaDat.RefreshEdit();
                    this.ResetForm();
                    KhoaControls();
                }
            }
            else if (flag == "edit")
            {
                if (CheckData())
                {
                    string diaChi = txtDiaChi.Text + ", " + cbPhuong.SelectedValue + ", " + cbQuan.SelectedValue;

                    dgvDanhSachNhaDat.Rows[index].Cells[1].Value = diaChi;
                    dgvDanhSachNhaDat.Rows[index].Cells[2].Value = txtDienTich.Text;
                    dgvDanhSachNhaDat.Rows[index].Cells[3].Value = txtChuSoHuu.Text;
                    dgvDanhSachNhaDat.Rows[index].Cells[4].Value = cbLoaiNha.SelectedItem;
                    dgvDanhSachNhaDat.Rows[index].Cells[5].Value = cbMucDichSuDung.SelectedItem;
                    dgvDanhSachNhaDat.Rows[index].Cells[6].Value = txtGiaTien.Text;
                    this.ResetForm();
                    KhoaControls();
                }
            }
        }

        private void dgvDanhSachNhaDat_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                index = dgvDanhSachNhaDat.CurrentCell.RowIndex;
                //DataTable dt = (DataTable)dgvDanhSachNhaDat.DataSource;

                string diaChi = dgvDanhSachNhaDat.Rows[index].Cells[1].Value.ToString();
                string[] str = diaChi.Split(',');

                txtDiaChi.Text = str[0];
                cbPhuong.Text = str[1];
                cbQuan.Text = str[2];
                txtDienTich.Text = dgvDanhSachNhaDat.Rows[index].Cells[2].Value.ToString();
                txtChuSoHuu.Text = dgvDanhSachNhaDat.Rows[index].Cells[3].Value.ToString();
                cbLoaiNha.Text = dgvDanhSachNhaDat.Rows[index].Cells[4].Value.ToString();
                cbMucDichSuDung.Text = dgvDanhSachNhaDat.Rows[index].Cells[5].Value.ToString();
                txtGiaTien.Text = dgvDanhSachNhaDat.Rows[index].Cells[6].Value.ToString();

            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.ResetForm();
            this.KhoaControls();
        }

        private void btnMoFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fOpen = new OpenFileDialog();

            fOpen.Filter = "Excel file |*.xls;*.xlsx";
            fOpen.FilterIndex = 1;
            fOpen.RestoreDirectory = true;
            fOpen.Multiselect = false;
            fOpen.Title = "Chọn file excel";

            if (fOpen.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = fOpen.FileName;
            }
        }

        void LoadData()
        {
            kn = new KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.con;
            cmd.CommandText = "select diaChi, dienTich, chuSoHuu, loaiNha, mucDichSuDung, giaTien from ThuaDat";
            kn.Connect();
            SqlDataReader dr = cmd.ExecuteReader();
            dtDanhSachNhaDat.Load(dr);
            dgvDanhSachNhaDat.DataSource = dtDanhSachNhaDat;
            kn.con.Close();
        }



        public List<Quan> LayDanhSachQuan()
        {
            List<Quan> dsQuan = new List<Quan>();
            kn = new KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.con;
            cmd.CommandText = "select * from Quan";
            kn.Connect();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow row in dt.Rows)
            {
                Quan quan = new Quan(row);
                dsQuan.Add(quan);
            }
            kn.con.Close();
            return dsQuan;
        }

        void LoadQuanLenCombobox()
        {
            List<Quan> dsQuan = LayDanhSachQuan();
            cbQuan.DataSource = dsQuan;
            cbQuan.DisplayMember = "tenQuan";
            cbQuan.ValueMember = "tenQuan";
        }

        public List<Phuong> LayDanhSachPhuongTheoIDQuan(int idQuan)
        {
            List<Phuong> ds = new List<Phuong>();
            kn = new KetNoi();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = kn.con;
            cmd.CommandText = "select * from Phuong where thuocQuan = " + idQuan;
            kn.Connect();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            foreach (DataRow item in dt.Rows)
            {
                Phuong p = new Phuong(item);
                ds.Add(p);
            }
            return ds;
        }


        public void LoadPhuongTheoQuan(int idQuan)
        {
            List<Phuong> dsPhuong = LayDanhSachPhuongTheoIDQuan(idQuan);
            cbPhuong.DataSource = dsPhuong;
            cbPhuong.DisplayMember = "tenPhuong";
            cbPhuong.ValueMember = "tenPhuong";
        }

        public void ThemDLVaoSQL()
        {
            try
            {
                kn = new KetNoi();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = kn.con;
                kn.Connect();
                int kq = 0;
                for (int i = 0; i < dgvDanhSachNhaDat.Rows.Count - 1; i++)
                {
                    string query = String.Format("Insert ThuaDat(diaChi, dienTich, chuSoHuu, loaiNha, mucDichSuDung, giaTien) values(N'{0}', {1} , N'{2}', N'{3}', N'{4}', {5})", dgvDanhSachNhaDat.Rows[i].Cells[1].Value, dgvDanhSachNhaDat.Rows[i].Cells[2].Value, dgvDanhSachNhaDat.Rows[i].Cells[3].Value, dgvDanhSachNhaDat.Rows[i].Cells[4].Value, dgvDanhSachNhaDat.Rows[i].Cells[5].Value, dgvDanhSachNhaDat.Rows[i].Cells[6].Value);

                    cmd.CommandText = query;
                    kq = cmd.ExecuteNonQuery();
                }

                if (kq > 0)
                {
                    MessageBox.Show("Lưu thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Không thành công", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnLuuSQL_Click(object sender, EventArgs e)
        {
            ThemDLVaoSQL();
        }


        void ImportExcel()
        {
            try
            {
                String constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + txtFilename.Text + ";Extended Properties='Excel 12.0 XML;HDR=YES;';";

                OleDbConnection con = new OleDbConnection(constr);
                OleDbCommand oconn = new OleDbCommand("Select * From [Sheet1$]", con);
                con.Open();

                OleDbDataAdapter sda = new OleDbDataAdapter(oconn);
                dtDanhSachNhaDat = new DataTable();
                sda.Fill(dtDanhSachNhaDat);
                dgvDanhSachNhaDat.DataSource = dtDanhSachNhaDat;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataView dv = dtDanhSachNhaDat.DefaultView;

            dv.RowFilter = string.Format("diaChi like '%{0}%'", txtTimKiem.Text);
            dgvDanhSachNhaDat.DataSource = dv.ToTable();
            AutoNumber();
        }

        private void AutoNumber()
        {
            try
            {
                for (int i = 0; i < dgvDanhSachNhaDat.Rows.Count - 1; i++)
                {
                    dgvDanhSachNhaDat.Rows[i].Cells["stt"].Value = i + 1;
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void cbQuan_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
            {
                return;
            }
            Quan selectQuan = cb.SelectedItem as Quan;
            int id = selectQuan.Id;
            LoadPhuongTheoQuan(id);
        }


        void Heapify(DataGridView dgv, int n, int index)
        {
            int left = 2 * (index + 1) - 1;
            int right = 2 * (index + 1);

            int max = index;
            if (left < n)
            {
                //Cắt Chuỗi
                string[] diaChi = dgv.Rows[left].Cells[1].Value.ToString().Split(',');
                string[] soNha1 = diaChi[0].Trim().Split('/');

                string[] diaChiIndex = dgv.Rows[index].Cells[1].Value.ToString().Split(',');
                string[] soNha2 = diaChiIndex[0].Trim().Split('/');

                if (GetMaxSoNha(soNha1, soNha2) > 0)
                {
                    max = left;
                }
            }
            if (right < n)
            {
                string[] diaChi = dgv.Rows[right].Cells[1].Value.ToString().Split(',');
                string[] soNha1 = diaChi[0].Trim().Split('/');

                string[] diaChiMax = dgv.Rows[max].Cells[1].Value.ToString().Split(',');
                string[] soNha2 = diaChiMax[0].Trim().Split('/');

                if (GetMaxSoNha(soNha1, soNha2) > 0)
                {
                    max = right;
                }
            }

            if (max != index)
            {
                for (int i = 1; i < dgv.Columns.Count; i++)
                {
                    Swap(dgv[i, index].Value, dgv[i, max].Value);
                }
                Heapify(dgv, n, max);
            }
        }

        void Swap(object a, object b)
        {
            object temp = a;
            a = b;
            b = temp;
        }

        public int GetMaxSoNha(string[] a, string[] b)
        {
            int so1;
            int so2;
            int lenght = a.Length < b.Length ? a.Length : b.Length;

            for (int i = 0; i < lenght; i++)
            {

                if (!int.TryParse(a[i], out so1) || !int.TryParse(b[i], out so2))
                {
                    so1 = TachSo(a[i]);
                    so2 = TachSo(b[i]);
                    if (so1 > so2)
                    {
                        return 1;
                    }
                    if (so1 < so2)
                    {
                        return -1;
                    }

                    if (so1 == so2 && i == lenght - 1)
                    {
                        if (string.Compare(a[i], b[i]) > 0)
                        {
                            return 1;
                        }
                        if (string.Compare(a[i], b[i]) == 0)
                        {
                            return 0;
                        }
                        if (string.Compare(a[i], b[i]) < 0)
                        {
                            return -11;
                        }
                    }
                }
                else
                {
                    if (int.Parse(a[i]) > int.Parse(b[i]))
                    {
                        return 1;
                    }
                    if (int.Parse(a[i]) == int.Parse(b[i]))
                    {
                        return 0;
                    }
                    if (int.Parse(a[i]) < int.Parse(b[i]))
                    {
                        return -1;
                    }
                    if (so1 == so2 && i == lenght - 1)
                    {
                        if (a.Length > b.Length)
                        {
                            return 1;
                        }
                        if (a.Length < b.Length)
                        {
                            return -1;
                        }
                        if (a.Length == b.Length)
                        {
                            return 0;
                        }
                    }
                }
            }
            return -2;
        }

        public int TachSo(string str)
        {
            int i = 1;
            string[] numbers = Regex.Split(str, @"\D+");
            foreach (string value in numbers)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    i = int.Parse(value);
                }
            }
            return i;
        }

        public void SapXepTheoHeapSort(DataGridView dgv)
        {
            int count = dgv.Rows.Count - 1;
            for (int i = (count / 2 - 1); i >= 0; i--)
            {
                Heapify(dgv, count, i);
            }
            for (int i = count; i > 0; i--)
            {
                for (int j = 1; j < dgv.Columns.Count; j++)
                {
                    Swap(dgv[j, i].Value, dgv[j, 0].Value);
                }
                count--;
                Heapify(dgv, count, 0);
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            SapXepTheoHeapSort(dgvDanhSachNhaDat);
            dgvDanhSachNhaDat.DataSource = dgvDanhSachNhaDat;
            dgvDanhSachNhaDat.RefreshEdit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            DataView dv = dtDanhSachNhaDat.DefaultView;
            dv.RowFilter = string.Format("diaChi like '%{0}%'", txtTimKiem.Text);
            dgvDanhSachNhaDat.DataSource = dv.ToTable();
            //dgvDanhSachNhaDat.SelectAll();
           
            foreach (DataGridViewRow row in dgvDanhSachNhaDat.SelectedRows)
            {
                dgvDanhSachNhaDat.Rows.Remove(row);
            }

            dgvDanhSachNhaDat.DataSource = dtDanhSachNhaDat;
            dgvDanhSachNhaDat.RefreshEdit();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            string filePath = "";
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
            dialog.ShowDialog();

            if (dialog.FileName != "")
            {
                filePath = dialog.FileName;
            }

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;

            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;

            worksheet.Cells[1, 1].Value = "Danh sách các thửa đất";
            worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, dgvDanhSachNhaDat.Columns.Count]].Merge();
            worksheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            worksheet.Cells[1, 1].Font.Bold = true;

            for (int i = 2; i < dgvDanhSachNhaDat.Columns.Count + 2; i++)
            {
                worksheet.Cells[2, i - 1] = dgvDanhSachNhaDat.Columns[i - 2].HeaderText;
                worksheet.Cells[2, i - 1].Font.Bold = true;
            }

            for (int i = 0; i < dgvDanhSachNhaDat.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgvDanhSachNhaDat.Columns.Count; j++)
                {
                    worksheet.Cells[i + 3, j + 1] = dgvDanhSachNhaDat.Rows[i].Cells[j].Value.ToString();
                }
            }

            workbook.SaveAs(dialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

            //app.Quit();
        }
    }
}