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
    public partial class Form_MNG : Form
    {
        public Form_MNG()
        {
            InitializeComponent();
            AddCbbLSH();
        }
        /***** LSH *****/
        private void AddCbbLSH()
        {
            List<CbbItem> cbbItems = new List<CbbItem>();
            cbbItems.Add(new CbbItem { Value = 0, Text = "Tất cả" });
            foreach (CbbItem cbbItem in SV_MNG.Instance.AddCbbLSH())
            {
                cbbItems.Add(cbbItem);
            }
            cbb_LopSH.DataSource = cbbItems;
        }
        /***** SV *****/
        private void Show(int idlop, string nameSV)
        {
            dgv.DataSource = SV_MNG.Instance.GetAllSV(idlop, nameSV);
        }
        /***** EVENTS *****/
        private void btn_Search_Click(object sender, EventArgs e)
        {
            dgv.DataSource = SV_MNG.Instance.GetAllSV(((CbbItem)cbb_LopSH.SelectedItem).Value, tb_Search.Text);
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            Show(((CbbItem)cbb_LopSH.SelectedItem).Value, "");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Form_Detail f = new Form_Detail("");
            f.mydel = new Form_Detail.MyDel(Show);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgv.SelectedRows;
            if (rowCollection.Count == 1)
            {
                string MSSV = rowCollection[0].Cells["MSSV"].Value.ToString();
                Form_Detail f = new Form_Detail(MSSV);
                this.Hide();
                f.mydel = new Form_Detail.MyDel(Show);
                f.ShowDialog();
                this.Show();
            }   
            else
            {
                MessageBox.Show("Bạn chưa chọn hoặc chọn nhiều hơn 1 SV để edit!");
            }    
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rowCollection = dgv.SelectedRows;
            if (rowCollection.Count == 0)
            {
                MessageBox.Show("Bạn chưa chọn để xóa!");
            }    
            else
            {
                List<string> MSSV_Del = new List<string>(); 
                foreach(DataGridViewRow r in rowCollection)
                {
                    MSSV_Del.Add(r.Cells["MSSV"].Value.ToString());
                }    
                if (SV_MNG.Instance.DeleteSV(MSSV_Del))
                {
                    Show(0, "");
                }    
                else
                {
                    MessageBox.Show("Error!");
                }    
            }    
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            string val = cbb_Sort.SelectedItem.ToString();
            int idlop = ((CbbItem)cbb_LopSH.SelectedItem).Value;
            string search = tb_Search.Text;
            List<SVViewModel> sVViewModels = null;
            switch (val)
            {
                case "MSSV":
                    sVViewModels = SV_MNG.Instance.Sort(idlop, search, SVViewModel.Compare_MSSV);
                    break;
                case "Họ Tên SV":
                    sVViewModels = SV_MNG.Instance.Sort(idlop, search, SVViewModel.Compare_HoTenSV);
                    break;
                case "Tên Lớp":
                    sVViewModels = SV_MNG.Instance.Sort(idlop, search, SVViewModel.Compare_TenLop);
                    break;
                case "Giới tính":
                    sVViewModels = SV_MNG.Instance.Sort(idlop, search, SVViewModel.Compare_GioiTinh);
                    break;
                case "Ngày Sinh":
                    sVViewModels = SV_MNG.Instance.Sort(idlop, search, SVViewModel.Compare_NgaySinh);
                    break;
                default:
                    break;
            }
            dgv.DataSource = sVViewModels;
        }
    }
}
