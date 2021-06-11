using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo1.BLL;
using demo1.ViewModel;
namespace demo1
{
    public partial class Form_Detail : Form
    {
        public delegate void MyDel(int idlop, string namesv);
        public MyDel mydel;
        public string _MSSV;
        public Form_Detail(string mssv)
        {
            InitializeComponent();
            _MSSV = mssv;
            if (_MSSV != "") LoadData();
        }
        //Load Data
        private void AddToCbb()
        {
            List<CbbItem> cbbItems = SV_MNG.Instance.AddCbbLSH();
            cbb_LopSH.DataSource = cbbItems;
        }
        private void LoadData()
        {
            SVViewModel sVViewModel = SV_MNG.Instance.GetSVByID(_MSSV);
            tb_MSSV.Text = sVViewModel.MSSV;
            tb_TenSV.Text = sVViewModel.HoTenSV;
            for (int i = 0; i < cbb_LopSH.Items.Count; i++)
            {
                if (cbb_LopSH.Items[i].ToString() == sVViewModel.TenLop)
                {
                    cbb_LopSH.SelectedIndex = i;
                    break;
                }
            }
            dtp.Value = sVViewModel.NgaySinh;
            if (sVViewModel.GioiTinh) { rbtn_Nam.Checked = true; }
            else { rbtn_Nu.Checked = true; }
        }
        //Check Data 
        private int CheckData()
        {
            if (tb_TenSV.Text == "") { return 1; }
            if (cbb_LopSH.SelectedItem == null) { return 2; }
            if (dtp.Value >= DateTime.Now) { return 3; }
            if (rbtn_Nam.Checked == false && rbtn_Nu.Checked == false) { return 4; }
            return 0;
        }
        //Events
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            switch(CheckData())
            {
                case 0:
                    SVViewModel sVViewModel = new SVViewModel
                    {
                        MSSV = tb_MSSV.Text,
                        HoTenSV = tb_TenSV.Text,
                        TenLop = ((CbbItem)cbb_LopSH.SelectedItem).Text,
                        NgaySinh = dtp.Value
                    };
                    if (rbtn_Nam.Checked) { sVViewModel.GioiTinh = true; }
                    else { sVViewModel.GioiTinh = false; }
                    if (_MSSV == "")
                    {
                        if (SV_MNG.Instance.AddSV(sVViewModel))
                        {
                            mydel(0, "");
                            this.Close();
                        }  
                        else
                        {
                            MessageBox.Show("Added error");
                        }    
                    }   
                    else
                    {
                        if (SV_MNG.Instance.EditSV(sVViewModel))
                        {
                            mydel(0, "");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Edited error");
                        }
                    }    
                    break;
                case 1:
                    MessageBox.Show("Bạn chưa nhập họ tên");
                    break;
                case 2:
                    MessageBox.Show("Bạn chưa chọn lớp");
                    break;
                case 3:
                    MessageBox.Show("Bạn chưa nhập ngày sinh");
                    break;
                case 4:
                    MessageBox.Show("Bạn chưa chọn giới tính");
                    break;
                default:
                    break;
            }
        }
    }
}
