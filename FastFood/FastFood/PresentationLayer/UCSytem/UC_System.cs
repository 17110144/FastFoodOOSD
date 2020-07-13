﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.Forms;
using FastFood.PresentationLayer.UCFunction;

namespace FastFood.PresentationLayer.UCSytem
{
    public partial class UC_System : UserControl
    {
        public UC_System()
        {
            InitializeComponent();
        }
        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            using (frm_ChangePassword changePassword = new frm_ChangePassword())
            {
                changePassword.ShowDialog();
            }
        }


        private void btnQuanLyNguoiDung_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_UserManager"))
            {
                UC_UserManager userManager = new UC_UserManager();
                userManager.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(userManager);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_UserManager"].BringToFront();
        }

        private void btnPhanQuyenNguoiDung_Click(object sender, EventArgs e)
        {
            using (frm_UserPermission userPermission = new frm_UserPermission())
            {
                userPermission.ShowDialog();
            }
        }
    }
}
