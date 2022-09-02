using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seller
{
    public partial class 賣家中心 : Form
    {
        public string account;
        public 賣家中心()
        {
            InitializeComponent();
        }

        public 賣家中心(string acc)
        {
            InitializeComponent();
            account = acc;
        }

        iSpanProjectEntities6 isp = new iSpanProjectEntities6();
        private void 賣家中心_Load(object sender, EventArgs e)
        {
            label2.Text = account;
            label4.Text = account;
            int mem_id = 0;

            var j = from i in isp.MemberAccounts
                    where i.MemberAcc == account
                    select i;

            foreach(var a in j)
            {
                mem_id = a.MemberID;
            }

            var q = from a in isp.Products
                    where a.MemberID == mem_id
                    select a;

            lbl_sel_count.Text = q.Count().ToString();


        }

        private void lklb_upload_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            上架 sel = new 上架(account);
            sel.Show();
        }
    }
}
