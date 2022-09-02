using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seller
{
    public partial class 上架 : Form
    {
        public string account;
        public 上架()
        {
            InitializeComponent();
        }

        public 上架(string acc)
        {
            InitializeComponent();
            account = acc;
        }
       
        iSpanProjectEntities6 isp4 = new iSpanProjectEntities6();

        private void 上架_Load(object sender, EventArgs e)
        {

            
            var m = from b in isp4.SmallTypes
                    select b;

            foreach (var st in m)
            {
                this.cmb_smtype.Items.Add(st.SmallTypeName);
            }

            var q = from a in isp4.RegionLists
                    select a;

            foreach(var pd in q)
            {
                this.cmb_region.Items.Add(pd.RegionName);
            }

            var p = from c in isp4.Shippers
                    select c;

            foreach(var sp in p)
            {
                this.cmb_shipper.Items.Add(sp.ShipperName);
            }

            renew();
        }

        void renew() {
            var q = (from p in isp4.MemberAccounts
                     where p.MemberAcc.ToString() == account.ToString()
                     select p).ToList();

            int memid = q[0].MemberID;

            var s = from d in isp4.Products
                    where d.MemberID == memid
                    select d;

            dataGridView1.DataSource = s.ToList();

        }

        private void btn_product_Click(object sender, EventArgs e)
        {
            if(this.ofd_product.ShowDialog() == DialogResult.OK)
            {
                this.picb_product.Image = Image.FromFile(this.ofd_product.FileName);
            }
        }
        int product_id;

        List<商品細項> pd_detail = new List<商品細項>();
        List<商品圖> pd_pic = new List<商品圖>();

       

        private void btn_show_format_Click(object sender, EventArgs e)
        {
            foreach(商品細項 detail in pd_detail)
            {
                dataGridView2.DataSource += detail.Style.ToString();
                dataGridView2.DataSource += detail.Quantity.ToString();
                dataGridView2.DataSource += detail.UnitPrice.ToString();
            }


            //for(int i = 0; i < pd_detail.Count; i++)    // 將內容加入到datagridview
            //{
            //    dataGridView2.DataSource += pd_detail[i].Style.ToString();
            //    dataGridView2.DataSource += pd_detail[i].Quantity.ToString();
            //    dataGridView2.DataSource += pd_detail[i].UnitPrice.ToString();
            //}
        }

      

        

        private void btn_newformat_Click(object sender, EventArgs e)    //可以將輸入規格加入list中儲存  根據現在所點擊的productid加入品項規格
        {
            
            format();
            renew();    //秀出產品
            show_detail();
        }
        void show_detail() {//從儲存的list中抓出要印的值           要做判別現在產品所點擊的productid

            
            //foreach(商品細項 prd in pd_detail)
            //{
            //    dataGridView2.DataSource += prd.ToString();
            //}

            ////dataGridView2.DataSource = s.ToList();

            dataGridView2.DataSource = pd_detail;
        }


        void pic()
        {
            商品圖 pdpic = new 商品圖();

            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.picb_product.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();

            pdpic.picture = bytes;

        }


        private void btn_newpic_Click(object sender, EventArgs e)
        {
            
            pic();
            renew();
        }

        private void btn_upload_Click(object sender, EventArgs e)
        {
            //this.isp4.Products.Add();
            //this.isp4.ProductDetails.Add();
            //this.isp4.ProductPics()
        }

        private void refresh_Click(object sender, EventArgs e)//新增商品
        {

            Product pd = new Product();
            

            var q = (from p in isp4.MemberAccounts
                    where p.MemberAcc == account
                    select p).ToList();
            pd.MemberID = q[0].MemberID;
           
            pd.ProductName = txt_pdname.Text;
            pd.Description = richTextBox_descript.Text;
            pd.AdFee = Convert.ToDecimal(txt_adfee.Text);

            var s = (from t in isp4.SmallTypes
                    where t.SmallTypeName == cmb_smtype.Text
                    select t).ToList();
            pd.SmallTypeID = s[0].SmallTypeID;
            

            var v = (from r in isp4.RegionLists
                    where r.RegionName == cmb_region.Text
                    select r).ToList();
            pd.RegionID = v[0].RegionID;
            

            var m = (from n in isp4.Shippers
                    where n.ShipperName == cmb_shipper.Text
                    select n).ToList();
            pd.ShipperID = m[0].ShipperID;
            

            this.isp4.Products.Add(pd);
            this.isp4.SaveChanges();
            product_id = pd.ProductID;

            //format();
            renew();


        }

       

        private void dele_Click(object sender, EventArgs e)
        {

            int pdid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

            var del = (from a in isp4.ProductDetails
                       where a.ProductID == pdid
                       select a).FirstOrDefault();

            var delll = (from c in isp4.ProductPics
                         where c.ProductID == pdid
                         select c
                        ).FirstOrDefault();

            isp4.ProductDetails.Remove(del);
            isp4.ProductPics.Remove(delll);

            this.isp4.SaveChanges();


            var de = (from b in isp4.Products
                      where b.ProductID == pdid
                      select b).FirstOrDefault();

            isp4.Products.Remove(de);

            this.isp4.SaveChanges();

            renew();
         
        }

        private void alter_Click(object sender, EventArgs e)
        {
         
            int pdid = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);

            var a = from b in isp4.ProductDetails
                    where b.ProductID == pdid
                    select b;

            foreach(var pdtt in a)
            {
                pdtt.Style = txt_style.Text;
                pdtt.Quantity = Convert.ToInt32(txt_quantity.Text);
                pdtt.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
            }

            var c = from d in isp4.ProductPics
                    where d.ProductID == pdid
                    select d;


            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.picb_product.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();
            foreach (var ppic in c)
            {
                ppic.picture = bytes;
            }
            this.isp4.SaveChanges();


            var j = (from s in isp4.SmallTypes
                    where s.SmallTypeName == cmb_smtype.Text
                    select s).ToList();
            

            var i = (from t in isp4.RegionLists
                    where t.RegionName == cmb_region.Text
                    select t).ToList();

            var x = (from z in isp4.Shippers
                    where z.ShipperName == cmb_shipper.Text
                    select z).ToList();

            var g = from f in isp4.Products
                    where f.ProductID == pdid
                    select f;

           
            foreach(var prds in g)
            {
                prds.ProductName = txt_pdname.Text;
                prds.Description = richTextBox_descript.Text;
                prds.AdFee = Convert.ToDecimal(txt_adfee.Text);
                prds.SmallTypeID = j[0].SmallTypeID;
                prds.RegionID = i[0].RegionID;
                prds.ShipperID = x[0].ShipperID;
            }

            this.isp4.SaveChanges();


            renew();
        }

    
     
        //暫存上傳

        #region
        private void btn_fake_upload_Click(object sender, EventArgs e)
        {
            商品圖 pdpic = new 商品圖();
            商品細項 pdt = new 商品細項();


            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            this.picb_product.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] bytes = ms.GetBuffer();

            pdpic.picture = bytes;
            pd_pic.Add(pdpic);

            pdt.Style = txt_style.Text;
            pdt.Quantity = Convert.ToInt32(txt_quantity.Text);
            pdt.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
            
            renew();
        }
        #endregion
        private void search_clk(object sender, EventArgs e)     //要重新清空背景顏色
        {
            foreach(DataGridViewRow r in dataGridView1.Rows)
            {
                foreach(DataGridViewCell c in r.Cells)
                {
                    if (c.Value == null) continue;
                    if (c.Value.ToString().ToUpper().Contains(txt_srch.Text.ToUpper()))
                    {
                        c.Style.BackColor = Color.Yellow;
                    }
                    if (c.Value.ToString().Contains(txt_srch.Text))
                    {
                        c.Style.BackColor = Color.Yellow;
                    }
                }
            }
        }


        void format()
        {

            product_id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["ProductID"].Value);
            商品細項 pd_dtail = new 商品細項();
            pd_dtail.ProductID = product_id;
            pd_dtail.Style = txt_style.Text;
            pd_dtail.Quantity = Convert.ToInt32(txt_quantity.Text);
            pd_dtail.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
            pd_detail.Add(pd_dtail);
        }


        private void txt_style_TextChanged(object sender, EventArgs e)
        {
            商品細項 pd_dtail = new 商品細項();
            pd_dtail.Style = txt_style.Text;
        }

        private void txt_quantity_TextChanged(object sender, EventArgs e)
        {
            商品細項 pd_dtail = new 商品細項();
            pd_dtail.Quantity = Convert.ToInt32(txt_quantity.Text);
        }

        private void txt_unitprice_TextChanged(object sender, EventArgs e)
        {
            商品細項 pd_dtail = new 商品細項();
            pd_dtail.UnitPrice = Convert.ToDecimal(txt_unitprice.Text);
        }
    }
}
