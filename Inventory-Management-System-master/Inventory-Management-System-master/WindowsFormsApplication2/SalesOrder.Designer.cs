namespace WindowsFormsApplication2
{
    partial class SalesOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesOrder));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbUnit = new System.Windows.Forms.ComboBox();
            this.mtbQuantity = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.review = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.printToolStripButton = new System.Windows.Forms.Button();
            this.order = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnPO = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAvail = new System.Windows.Forms.TextBox();
            this.txtCstName = new System.Windows.Forms.TextBox();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.totalcus = new System.Windows.Forms.TextBox();
            this.cbMtrlName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sale = new System.Windows.Forms.TextBox();
            this.pri = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCnfrm = new System.Windows.Forms.Button();
            this.btnAddM = new System.Windows.Forms.Button();
            this.btnAddC = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1028, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "اسم الزبون";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1009, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "اسم المنتج ";
            // 
            // cbUnit
            // 
            this.cbUnit.FormattingEnabled = true;
            this.cbUnit.Location = new System.Drawing.Point(758, 307);
            this.cbUnit.Name = "cbUnit";
            this.cbUnit.Size = new System.Drawing.Size(186, 21);
            this.cbUnit.TabIndex = 37;
            // 
            // mtbQuantity
            // 
            this.mtbQuantity.Location = new System.Drawing.Point(758, 261);
            this.mtbQuantity.Mask = "00000";
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.Size = new System.Drawing.Size(186, 20);
            this.mtbQuantity.TabIndex = 36;
            this.mtbQuantity.Text = "1";
            this.mtbQuantity.ValidatingType = typeof(int);
            this.mtbQuantity.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtbQuantity_MaskInputRejected);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1009, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "الكميه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1009, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 19);
            this.label5.TabIndex = 39;
            this.label5.Text = "سعر الشركه";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.review);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.printToolStripButton);
            this.groupBox1.Controls.Add(this.order);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.btnCnfrm);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnPO);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.btnAddM);
            this.groupBox1.Controls.Add(this.btnAddC);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(11, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 671);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // review
            // 
            this.review.Location = new System.Drawing.Point(599, 79);
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(108, 38);
            this.review.TabIndex = 70;
            this.review.Text = "مراجعه الحساب";
            this.review.UseVisualStyleBackColor = true;
            this.review.Click += new System.EventHandler(this.review_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Coral;
            this.label8.Location = new System.Drawing.Point(500, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 66;
            this.label8.Text = "رقم الفاتوره";
            this.label8.Click += new System.EventHandler(this.label8_Click_1);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.Location = new System.Drawing.Point(399, 494);
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(179, 31);
            this.printToolStripButton.TabIndex = 56;
            this.printToolStripButton.Text = "طباعة";
            this.printToolStripButton.UseVisualStyleBackColor = true;
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // order
            // 
            this.order.Enabled = false;
            this.order.Location = new System.Drawing.Point(383, 21);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(100, 28);
            this.order.TabIndex = 65;
            this.order.TextChanged += new System.EventHandler(this.order_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 50;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(376, 421);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Red;
            this.btnAdd.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnAdd.ForeColor = System.Drawing.Color.Snow;
            this.btnAdd.Location = new System.Drawing.Point(399, 60);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(179, 42);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "اضافه منتج للفاتوره";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnPO
            // 
            this.btnPO.BackColor = System.Drawing.Color.Red;
            this.btnPO.Font = new System.Drawing.Font("Tahoma", 15F);
            this.btnPO.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPO.Location = new System.Drawing.Point(399, 115);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(179, 38);
            this.btnPO.TabIndex = 3;
            this.btnPO.Text = "تاكيد";
            this.btnPO.UseVisualStyleBackColor = false;
            this.btnPO.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(399, 190);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(179, 37);
            this.btnGenerate.TabIndex = 55;
            this.btnGenerate.Text = "Generate Total";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(785, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 71;
            this.textBox1.Text = "0";
            // 
            // txtAvail
            // 
            this.txtAvail.Location = new System.Drawing.Point(758, 494);
            this.txtAvail.Name = "txtAvail";
            this.txtAvail.Size = new System.Drawing.Size(186, 20);
            this.txtAvail.TabIndex = 6;
            // 
            // txtCstName
            // 
            this.txtCstName.Location = new System.Drawing.Point(769, 61);
            this.txtCstName.Name = "txtCstName";
            this.txtCstName.Size = new System.Drawing.Size(233, 20);
            this.txtCstName.TabIndex = 58;
            this.txtCstName.TextChanged += new System.EventHandler(this.txtCstName_TextChanged);
            // 
            // btnAvailable
            // 
            this.btnAvailable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAvailable.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailable.ForeColor = System.Drawing.Color.Tomato;
            this.btnAvailable.Location = new System.Drawing.Point(758, 345);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(197, 38);
            this.btnAvailable.TabIndex = 59;
            this.btnAvailable.Text = "مراجعه المخزن ";
            this.btnAvailable.UseVisualStyleBackColor = false;
            this.btnAvailable.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(974, 495);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(152, 19);
            this.label13.TabIndex = 60;
            this.label13.Text = "الكميه الموجوده فى المخزن";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(758, 403);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(186, 20);
            this.txtAmount.TabIndex = 40;
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13F);
            this.label1.Location = new System.Drawing.Point(990, 545);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 61;
            this.label1.Text = "نسبه الخصم";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(990, 601);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 19);
            this.label7.TabIndex = 63;
            this.label7.Text = "السعر بعد الخصم";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(758, 602);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(186, 20);
            this.total.TabIndex = 64;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // printDocument1
            // 
            this.printDocument1.OriginAtMargins = true;
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(935, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 19);
            this.label9.TabIndex = 65;
            this.label9.Text = "الحساب القديم";
            // 
            // totalcus
            // 
            this.totalcus.Location = new System.Drawing.Point(785, 87);
            this.totalcus.Name = "totalcus";
            this.totalcus.Size = new System.Drawing.Size(123, 20);
            this.totalcus.TabIndex = 66;
            this.totalcus.TextChanged += new System.EventHandler(this.totalcus_TextChanged);
            // 
            // cbMtrlName
            // 
            this.cbMtrlName.Location = new System.Drawing.Point(758, 223);
            this.cbMtrlName.Name = "cbMtrlName";
            this.cbMtrlName.Size = new System.Drawing.Size(233, 20);
            this.cbMtrlName.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1010, 307);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "نوع الكميه";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // sale
            // 
            this.sale.Location = new System.Drawing.Point(758, 548);
            this.sale.Name = "sale";
            this.sale.Size = new System.Drawing.Size(186, 20);
            this.sale.TabIndex = 73;
            this.sale.Text = "0.0";
            // 
            // pri
            // 
            this.pri.HideSelection = false;
            this.pri.Location = new System.Drawing.Point(758, 444);
            this.pri.Name = "pri";
            this.pri.Size = new System.Drawing.Size(186, 20);
            this.pri.TabIndex = 75;
            this.pri.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label12.ForeColor = System.Drawing.Color.Coral;
            this.label12.Location = new System.Drawing.Point(935, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 19);
            this.label12.TabIndex = 76;
            this.label12.Text = "تاريخ اخر دفع";
            this.label12.Click += new System.EventHandler(this.label12_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(785, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 20);
            this.textBox2.TabIndex = 77;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label14.ForeColor = System.Drawing.Color.Coral;
            this.label14.Location = new System.Drawing.Point(949, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 19);
            this.label14.TabIndex = 78;
            this.label14.Text = "الواصل";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label10.ForeColor = System.Drawing.Color.Coral;
            this.label10.Location = new System.Drawing.Point(950, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 79;
            this.label10.Text = "الباقى";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(785, 187);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 20);
            this.textBox3.TabIndex = 80;
            this.textBox3.Text = "0";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::WindowsFormsApplication2.Properties.Resources.remove;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(399, 584);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(179, 33);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCnfrm
            // 
            this.btnCnfrm.Image = global::WindowsFormsApplication2.Properties.Resources.filesave;
            this.btnCnfrm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCnfrm.Location = new System.Drawing.Point(399, 276);
            this.btnCnfrm.Name = "btnCnfrm";
            this.btnCnfrm.Size = new System.Drawing.Size(179, 33);
            this.btnCnfrm.TabIndex = 53;
            this.btnCnfrm.Text = "Confirm";
            this.btnCnfrm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCnfrm.UseVisualStyleBackColor = true;
            this.btnCnfrm.Click += new System.EventHandler(this.btnCnfrm_Click);
            // 
            // btnAddM
            // 
            this.btnAddM.Image = global::WindowsFormsApplication2.Properties.Resources.add;
            this.btnAddM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddM.Location = new System.Drawing.Point(599, 127);
            this.btnAddM.Name = "btnAddM";
            this.btnAddM.Size = new System.Drawing.Size(108, 30);
            this.btnAddM.TabIndex = 34;
            this.btnAddM.Text = "New";
            this.btnAddM.UseVisualStyleBackColor = true;
            this.btnAddM.Click += new System.EventHandler(this.btnAddM_Click);
            // 
            // btnAddC
            // 
            this.btnAddC.Image = global::WindowsFormsApplication2.Properties.Resources.add;
            this.btnAddC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddC.Location = new System.Drawing.Point(599, 40);
            this.btnAddC.Name = "btnAddC";
            this.btnAddC.Size = new System.Drawing.Size(108, 32);
            this.btnAddC.TabIndex = 31;
            this.btnAddC.Text = "New";
            this.btnAddC.UseVisualStyleBackColor = true;
            this.btnAddC.Click += new System.EventHandler(this.btnAddC_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkGray;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Image = global::WindowsFormsApplication2.Properties.Resources.order_icon;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(6, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1352, 52);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sales Order";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(939, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 81;
            // 
            // SalesOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 698);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pri);
            this.Controls.Add(this.sale);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cbMtrlName);
            this.Controls.Add(this.totalcus);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAvail);
            this.Controls.Add(this.btnAvailable);
            this.Controls.Add(this.txtCstName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbUnit);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.MaximizeBox = false;
            this.Name = "SalesOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesOrder_FormClosing);
            this.Load += new System.EventHandler(this.SalesOrder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddM;
        private System.Windows.Forms.ComboBox cbUnit;
        private System.Windows.Forms.MaskedTextBox mtbQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCnfrm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtCstName;
        private System.Windows.Forms.TextBox txtAvail;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox order;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button printToolStripButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox totalcus;
        private System.Windows.Forms.TextBox cbMtrlName;
        private System.Windows.Forms.Button review;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox sale;
        private System.Windows.Forms.TextBox pri;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}