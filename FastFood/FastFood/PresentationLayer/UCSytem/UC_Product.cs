using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastFood.PresentationLayer.UCFunction;
using FastFood.Forms;

namespace FastFood.PresentationLayer.UCSytem
{
    public partial class UC_Product : UserControl
    {
        public UC_Product()
        {
            InitializeComponent();
        }
        private void btnQuanLyMonAn_Click(object sender, EventArgs e)
        {
            //if (!frm_main.instance.pnlcontainer.controls.containskey("uc_foodmanager"))
            //{
            //    uc_foodmanager foodmanager = new uc_foodmanager();
            //    foodmanager.dock = dockstyle.fill;
            //    frm_main.instance.pnlcontainer.controls.add(foodmanager);
            //}
            //frm_main.instance.pnlcontainer.controls["uc_foodmanager"].bringtofront();
        }

        private void btnQuanLyNuocUong_Click(object sender, EventArgs e)
        {
            if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_DrinkManager"))
            {
                UC_DrinkManager drinkManager = new UC_DrinkManager();
                drinkManager.Dock = DockStyle.Fill;
                frm_Main.Instance.pnlContainer.Controls.Add(drinkManager);

            }
            frm_Main.Instance.pnlContainer.Controls["UC_DrinkManager"].BringToFront();
        }

        private void btnQuanLySP_Click(object sender, EventArgs e)
        {
            //if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_ProductType"))
            //{
            //    UC_ProductType productType = new UC_ProductType();
            //    productType.Dock = DockStyle.Fill;
            //    frm_Main.Instance.pnlContainer.Controls.Add(productType);
            //}
            //frm_Main.Instance.pnlContainer.Controls["UC_ProductType"].BringToFront();
        }

        private void btnQuanLyNCC_Click(object sender, EventArgs e)
        {
            //if (!frm_Main.Instance.pnlContainer.Controls.ContainsKey("UC_NCCManager"))
            //{
            //    UC_NCCManager nCCManager = new UC_NCCManager();
            //    nCCManager.Dock = DockStyle.Fill;
            //    frm_Main.Instance.pnlContainer.Controls.Add(nCCManager);
            //}
            //frm_Main.Instance.pnlContainer.Controls["UC_NCCManager"].BringToFront();
        }
    }
}
