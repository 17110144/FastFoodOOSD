using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.PresentationLayer.UCSytem;
using FastFood.Forms;

namespace FastFood.Forms
{
    public partial class frm_Main : Form
    {
        public static string NguoiDungID;

        bool checkPer;

        static frm_Main _obj;
        UC_Home _Home = new UC_Home();
        UC_Order _Order = new UC_Order();
        UC_Product _Product = new UC_Product();
        UC_Personnel _Personnel = new UC_Personnel();
        UC_Noti _Noti = new UC_Noti();
        UC_Salary _Salary = new UC_Salary();
        UC_System _System = new UC_System();

        public frm_Main(string NguoiDungID_Login)
        {
            InitializeComponent();

            //addControlsToPanel(_Home);
            //NguoiDungID = NguoiDungID_Login;

            //_Order.Visible = false;
            //_Personnel.Visible = false;
            //_Product.Visible = false;
            //_Salary.Visible = false;
            //_System.Visible = false;
        }

        public static frm_Main Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new frm_Main(NguoiDungID);
                }
                return _obj;
            }
        }

        public Panel pnlContainer
        {
            get { return panelControls; }
            set { panelControls = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                NguoiDungID = null;
                this.Dispose();
            }
        }
        // Function di chuyển side menu
        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }
        //khi chọn menu sẽ add UC_Controls tương ứng
        private void addControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelControls.Controls.Clear();
            panelControls.Controls.Add(c);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
            addControlsToPanel(_Home);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnOrder);
            if (_Order.Visible == true)
            {
                addControlsToPanel(_Order);
            }
            else
            {
                addControlsToPanel(_Noti);
            }

        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnProduct);
            if (_Product.Visible == true)
            {
                addControlsToPanel(_Product);
            }
            else
            {
                addControlsToPanel(_Noti);
            }
        }
        private void btnPersonnel_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnPersonnel);
            if (_Personnel.Visible == true)
            {
                addControlsToPanel(_Personnel);
            }
            else
            {
                addControlsToPanel(_Noti);
            }
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSalary);
            if (_Salary.Visible == true)
            {
                addControlsToPanel(_Salary);
            }
            else
            {
                addControlsToPanel(_Noti);
            }
        }


        private void btnSystem_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnSystem);
            if (_System.Visible == true)
            {
                addControlsToPanel(_System);
            }
            else
            {
                addControlsToPanel(_Noti);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnLogout);
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                NguoiDungID = null;
                this.Dispose();
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {
            using (frm_About about = new frm_About())
            {
                about.ShowDialog();
            }
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            _loadPermission();
            _obj = this;
        }

        private void _loadPermission()
        {
          bool   checkedPer = true;
          //  checkPer = (BusinessLayer.cls_Employess._checkPermission(NguoiDungID) == true) ? true : false;

            if (checkPer == false)
            {
                DataTable dt = BusinessLayer.cls_Employess._ListPermission(NguoiDungID);
                foreach (DataRow dr in dt.Rows)
                {
                    switch (dr["URL"].ToString())
                    {
                        case "SystemManager":
                            _System.Visible = true;
                            break;
                        case "EmployessManager":
                            _Personnel.Visible = true;
                            break;
                        case "SalaryManager":
                            _Salary.Visible = true;
                            break;
                        case "ProductManager":
                            _Product.Visible = true;
                            break;
                        case "Order":
                            _Order.Visible = true;
                            break;
                    }
                }
            }
            else
            {
                _Order.Visible = true;
                _Personnel.Visible = true;
                _Product.Visible = true;
                _Salary.Visible = true;
                _System.Visible = true;
            }

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            using (frm_ChangePassword changePassword = new frm_ChangePassword())
            {
                //frm_Main.Opacity = 50;
                changePassword.ShowDialog();
            }
        }
    }
}
