using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }            
        private string role;
        private string name;

        public Form1(string userRole, string userName)
        {
            InitializeComponent();
            role = userRole;
            name = userName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào {name} ({role})";

            if (role != "Admin")
            {
                btnQuanLyNhanVien.Visible = false;
                btnThongKe.Visible = false;
            }
        }

        private void btncalamviec_Click(object sender, EventArgs e)
        {
            WorkDay formWorkDay = new WorkDay();
            formWorkDay.ShowDialog();
            if (frmLogin.u.User_role != "Admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnQuanLyNhanVien_Click(object sender, EventArgs e)
        {

            if (frmLogin.u.User_role != "Admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (frmLogin.u.User_role != "Admin")
            {
                MessageBox.Show("Bạn không có quyền truy cập vào chức năng này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnquanlibanpv_Click(object sender, EventArgs e)
        {
            Table formTable = new Table();
            formTable.ShowDialog();
           
        }

        
    }
}