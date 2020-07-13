using System;
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
    public partial class UC_Salary : UserControl
    {
        public UC_Salary()
        {
            InitializeComponent();
        }

        private void btnQuanLyChucDanh_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_SalaryManager"))
            {
                UC_SalaryManager salaryManager = new UC_SalaryManager();
                salaryManager.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(salaryManager);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_SalaryManager"].BringToFront();
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_TimeSheetManager"))
            {
                UC_TimeSheetManager timeSheetManager = new UC_TimeSheetManager();
                timeSheetManager.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(timeSheetManager);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_TimeSheetManager"].BringToFront();
        }

        private void btnBangKeLuong_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_PayrollManager"))
            {
                UC_PayrollManager payrollManager = new UC_PayrollManager();
                payrollManager.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(payrollManager);
            }
            frm_Main.Instance.pnlContainer.Controls["UC_PayrollManager"].BringToFront();
        }
    }
}
