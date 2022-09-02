
namespace seller
{
    partial class 上架
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(上架));
            this.ofd_product = new System.Windows.Forms.OpenFileDialog();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbl_now_id = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_srch = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_show_format = new System.Windows.Forms.Button();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_newpic = new System.Windows.Forms.Button();
            this.btn_newformat = new System.Windows.Forms.Button();
            this.btn_fake_upload = new System.Windows.Forms.Button();
            this.alter = new System.Windows.Forms.Button();
            this.dele = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.picb_product = new System.Windows.Forms.PictureBox();
            this.btn_openpic = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_style = new System.Windows.Forms.TextBox();
            this.cmb_shipper = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_region = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_smtype = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.txt_adfee = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.color = new System.Windows.Forms.Label();
            this.richTextBox_descript = new System.Windows.Forms.RichTextBox();
            this.txt_pdname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_product)).BeginInit();
            this.SuspendLayout();
            // 
            // ofd_product
            // 
            this.ofd_product.FileName = "openFileDialog1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.splitContainer1.Panel1.Controls.Add(this.lbl_now_id);
            this.splitContainer1.Panel1.Controls.Add(this.btn_search);
            this.splitContainer1.Panel1.Controls.Add(this.txt_srch);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1292, 734);
            this.splitContainer1.SplitterDistance = 99;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // lbl_now_id
            // 
            this.lbl_now_id.AutoSize = true;
            this.lbl_now_id.Font = new System.Drawing.Font("標楷體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_now_id.Location = new System.Drawing.Point(344, 53);
            this.lbl_now_id.Name = "lbl_now_id";
            this.lbl_now_id.Size = new System.Drawing.Size(138, 27);
            this.lbl_now_id.TabIndex = 2;
            this.lbl_now_id.Text = "會員編號:";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search.BackgroundImage")));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_search.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_search.Location = new System.Drawing.Point(691, 29);
            this.btn_search.Margin = new System.Windows.Forms.Padding(2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(39, 31);
            this.btn_search.TabIndex = 1;
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.search_clk);
            // 
            // txt_srch
            // 
            this.txt_srch.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_srch.Location = new System.Drawing.Point(497, 29);
            this.txt_srch.Margin = new System.Windows.Forms.Padding(2);
            this.txt_srch.Multiline = true;
            this.txt_srch.Name = "txt_srch";
            this.txt_srch.Size = new System.Drawing.Size(234, 32);
            this.txt_srch.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView3);
            this.splitContainer2.Panel1.Controls.Add(this.label10);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btn_show_format);
            this.splitContainer2.Panel2.Controls.Add(this.btn_upload);
            this.splitContainer2.Panel2.Controls.Add(this.btn_newpic);
            this.splitContainer2.Panel2.Controls.Add(this.btn_newformat);
            this.splitContainer2.Panel2.Controls.Add(this.btn_fake_upload);
            this.splitContainer2.Panel2.Controls.Add(this.alter);
            this.splitContainer2.Panel2.Controls.Add(this.dele);
            this.splitContainer2.Panel2.Controls.Add(this.refresh);
            this.splitContainer2.Panel2.Controls.Add(this.picb_product);
            this.splitContainer2.Panel2.Controls.Add(this.btn_openpic);
            this.splitContainer2.Panel2.Controls.Add(this.label4);
            this.splitContainer2.Panel2.Controls.Add(this.label9);
            this.splitContainer2.Panel2.Controls.Add(this.txt_unitprice);
            this.splitContainer2.Panel2.Controls.Add(this.label8);
            this.splitContainer2.Panel2.Controls.Add(this.txt_quantity);
            this.splitContainer2.Panel2.Controls.Add(this.label7);
            this.splitContainer2.Panel2.Controls.Add(this.txt_style);
            this.splitContainer2.Panel2.Controls.Add(this.cmb_shipper);
            this.splitContainer2.Panel2.Controls.Add(this.label6);
            this.splitContainer2.Panel2.Controls.Add(this.cmb_region);
            this.splitContainer2.Panel2.Controls.Add(this.label5);
            this.splitContainer2.Panel2.Controls.Add(this.cmb_smtype);
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.count);
            this.splitContainer2.Panel2.Controls.Add(this.txt_adfee);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.color);
            this.splitContainer2.Panel2.Controls.Add(this.richTextBox_descript);
            this.splitContainer2.Panel2.Controls.Add(this.txt_pdname);
            this.splitContainer2.Size = new System.Drawing.Size(1292, 632);
            this.splitContainer2.SplitterDistance = 415;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(22, 413);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(214, 24);
            this.label11.TabIndex = 53;
            this.label11.Text = "目前已有商品_圖片";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(17, 459);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(395, 115);
            this.dataGridView3.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(22, 199);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 24);
            this.label10.TabIndex = 51;
            this.label10.Text = "目前已有商品_細項";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(17, 238);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(395, 115);
            this.dataGridView2.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "目前已有商品_概覽";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(395, 114);
            this.dataGridView1.TabIndex = 48;
            // 
            // btn_show_format
            // 
            this.btn_show_format.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_show_format.Location = new System.Drawing.Point(210, 486);
            this.btn_show_format.Name = "btn_show_format";
            this.btn_show_format.Size = new System.Drawing.Size(75, 23);
            this.btn_show_format.TabIndex = 77;
            this.btn_show_format.Text = "秀規格";
            this.btn_show_format.UseVisualStyleBackColor = false;
            this.btn_show_format.Click += new System.EventHandler(this.btn_show_format_Click);
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_upload.Location = new System.Drawing.Point(210, 444);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 76;
            this.btn_upload.Text = "上架圖片";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_newpic
            // 
            this.btn_newpic.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_newpic.Location = new System.Drawing.Point(103, 534);
            this.btn_newpic.Name = "btn_newpic";
            this.btn_newpic.Size = new System.Drawing.Size(75, 23);
            this.btn_newpic.TabIndex = 75;
            this.btn_newpic.Text = "新增圖片";
            this.btn_newpic.UseVisualStyleBackColor = false;
            this.btn_newpic.Click += new System.EventHandler(this.btn_newpic_Click);
            // 
            // btn_newformat
            // 
            this.btn_newformat.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_newformat.Location = new System.Drawing.Point(103, 486);
            this.btn_newformat.Name = "btn_newformat";
            this.btn_newformat.Size = new System.Drawing.Size(75, 23);
            this.btn_newformat.TabIndex = 74;
            this.btn_newformat.Text = "新增規格";
            this.btn_newformat.UseVisualStyleBackColor = false;
            this.btn_newformat.Click += new System.EventHandler(this.btn_newformat_Click);
            // 
            // btn_fake_upload
            // 
            this.btn_fake_upload.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_fake_upload.Location = new System.Drawing.Point(646, 534);
            this.btn_fake_upload.Name = "btn_fake_upload";
            this.btn_fake_upload.Size = new System.Drawing.Size(109, 30);
            this.btn_fake_upload.TabIndex = 73;
            this.btn_fake_upload.Text = "預覽(尚未加入)";
            this.btn_fake_upload.UseVisualStyleBackColor = false;
            this.btn_fake_upload.Click += new System.EventHandler(this.btn_fake_upload_Click);
            // 
            // alter
            // 
            this.alter.BackColor = System.Drawing.Color.LightSalmon;
            this.alter.Location = new System.Drawing.Point(642, 472);
            this.alter.Name = "alter";
            this.alter.Size = new System.Drawing.Size(75, 23);
            this.alter.TabIndex = 72;
            this.alter.Text = "修改";
            this.alter.UseVisualStyleBackColor = false;
            this.alter.Click += new System.EventHandler(this.alter_Click);
            // 
            // dele
            // 
            this.dele.BackColor = System.Drawing.Color.LightSalmon;
            this.dele.Location = new System.Drawing.Point(521, 472);
            this.dele.Name = "dele";
            this.dele.Size = new System.Drawing.Size(75, 23);
            this.dele.TabIndex = 71;
            this.dele.Text = "刪除";
            this.dele.UseVisualStyleBackColor = false;
            this.dele.Click += new System.EventHandler(this.dele_Click);
            // 
            // refresh
            // 
            this.refresh.BackColor = System.Drawing.Color.LightSalmon;
            this.refresh.Location = new System.Drawing.Point(103, 444);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(75, 23);
            this.refresh.TabIndex = 70;
            this.refresh.Text = "新增商品";
            this.refresh.UseVisualStyleBackColor = false;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // picb_product
            // 
            this.picb_product.BackColor = System.Drawing.Color.OrangeRed;
            this.picb_product.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picb_product.Location = new System.Drawing.Point(172, 282);
            this.picb_product.Name = "picb_product";
            this.picb_product.Size = new System.Drawing.Size(214, 120);
            this.picb_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picb_product.TabIndex = 69;
            this.picb_product.TabStop = false;
            // 
            // btn_openpic
            // 
            this.btn_openpic.Location = new System.Drawing.Point(52, 312);
            this.btn_openpic.Name = "btn_openpic";
            this.btn_openpic.Size = new System.Drawing.Size(75, 23);
            this.btn_openpic.TabIndex = 68;
            this.btn_openpic.Text = "瀏覽";
            this.btn_openpic.UseVisualStyleBackColor = true;
            this.btn_openpic.Click += new System.EventHandler(this.btn_product_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(50, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 67;
            this.label4.Text = "商品圖片";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(400, 301);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 24);
            this.label9.TabIndex = 66;
            this.label9.Text = "單價";
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_unitprice.Location = new System.Drawing.Point(530, 298);
            this.txt_unitprice.Multiline = true;
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.Size = new System.Drawing.Size(191, 42);
            this.txt_unitprice.TabIndex = 65;
            this.txt_unitprice.TextChanged += new System.EventHandler(this.txt_unitprice_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(400, 237);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 24);
            this.label8.TabIndex = 64;
            this.label8.Text = "庫存";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_quantity.Location = new System.Drawing.Point(530, 234);
            this.txt_quantity.Multiline = true;
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(191, 39);
            this.txt_quantity.TabIndex = 63;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(400, 174);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 24);
            this.label7.TabIndex = 62;
            this.label7.Text = "樣式";
            // 
            // txt_style
            // 
            this.txt_style.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_style.Location = new System.Drawing.Point(530, 172);
            this.txt_style.Multiline = true;
            this.txt_style.Name = "txt_style";
            this.txt_style.Size = new System.Drawing.Size(191, 36);
            this.txt_style.TabIndex = 61;
            this.txt_style.TextChanged += new System.EventHandler(this.txt_style_TextChanged);
            // 
            // cmb_shipper
            // 
            this.cmb_shipper.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_shipper.FormattingEnabled = true;
            this.cmb_shipper.Location = new System.Drawing.Point(530, 110);
            this.cmb_shipper.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_shipper.Name = "cmb_shipper";
            this.cmb_shipper.Size = new System.Drawing.Size(191, 30);
            this.cmb_shipper.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(400, 98);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 22);
            this.label6.TabIndex = 59;
            this.label6.Text = "物流";
            // 
            // cmb_region
            // 
            this.cmb_region.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_region.FormattingEnabled = true;
            this.cmb_region.Location = new System.Drawing.Point(531, 61);
            this.cmb_region.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_region.Name = "cmb_region";
            this.cmb_region.Size = new System.Drawing.Size(191, 30);
            this.cmb_region.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(400, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 57;
            this.label5.Text = "商品所在地";
            // 
            // cmb_smtype
            // 
            this.cmb_smtype.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cmb_smtype.FormattingEnabled = true;
            this.cmb_smtype.Location = new System.Drawing.Point(531, 18);
            this.cmb_smtype.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_smtype.Name = "cmb_smtype";
            this.cmb_smtype.Size = new System.Drawing.Size(191, 30);
            this.cmb_smtype.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(400, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 55;
            this.label3.Text = "商品分類";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.count.Location = new System.Drawing.Point(52, 90);
            this.count.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(82, 24);
            this.count.TabIndex = 52;
            this.count.Text = "廣告費";
            // 
            // txt_adfee
            // 
            this.txt_adfee.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_adfee.Location = new System.Drawing.Point(172, 85);
            this.txt_adfee.Multiline = true;
            this.txt_adfee.Name = "txt_adfee";
            this.txt_adfee.Size = new System.Drawing.Size(214, 42);
            this.txt_adfee.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(52, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 50;
            this.label2.Text = "商品描述";
            // 
            // color
            // 
            this.color.AutoSize = true;
            this.color.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.color.Location = new System.Drawing.Point(50, 26);
            this.color.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(106, 24);
            this.color.TabIndex = 49;
            this.color.Text = "商品名稱";
            // 
            // richTextBox_descript
            // 
            this.richTextBox_descript.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.richTextBox_descript.Location = new System.Drawing.Point(172, 155);
            this.richTextBox_descript.Margin = new System.Windows.Forms.Padding(2);
            this.richTextBox_descript.Name = "richTextBox_descript";
            this.richTextBox_descript.Size = new System.Drawing.Size(214, 78);
            this.richTextBox_descript.TabIndex = 48;
            this.richTextBox_descript.Text = "";
            // 
            // txt_pdname
            // 
            this.txt_pdname.Font = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_pdname.Location = new System.Drawing.Point(172, 23);
            this.txt_pdname.Multiline = true;
            this.txt_pdname.Name = "txt_pdname";
            this.txt_pdname.Size = new System.Drawing.Size(214, 40);
            this.txt_pdname.TabIndex = 47;
            // 
            // 上架
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 734);
            this.Controls.Add(this.splitContainer1);
            this.Name = "上架";
            this.Text = "上架商品";
            this.Load += new System.EventHandler(this.上架_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picb_product)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog ofd_product;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.TextBox txt_adfee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label color;
        private System.Windows.Forms.RichTextBox richTextBox_descript;
        private System.Windows.Forms.TextBox txt_pdname;
        private System.Windows.Forms.ComboBox cmb_shipper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_region;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_smtype;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_quantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_style;
        private System.Windows.Forms.PictureBox picb_product;
        private System.Windows.Forms.Button btn_openpic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button alter;
        private System.Windows.Forms.Button dele;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_srch;
        private System.Windows.Forms.Button btn_fake_upload;
        private System.Windows.Forms.Button btn_newformat;
        private System.Windows.Forms.Label lbl_now_id;
        private System.Windows.Forms.Button btn_newpic;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_show_format;
    }
}