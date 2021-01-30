namespace WindowsFormsApplication2
{
    partial class Admin_Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Home));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.مرتجعمنفاتورهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInfoToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهمنتجلفاتورهقديمهToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInfoToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newEntryToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.دفعToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewInfoToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.extraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.المخزنToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.موردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اضافهموردجديدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.معلوماتعنالموردToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printPreviewToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.معلوماتعنالمدفوعاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip.BackgroundImage")));
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu,
            this.vATToolStripMenuItem,
            this.extraToolStripMenuItem,
            this.المخزنToolStripMenuItem,
            this.موردToolStripMenuItem,
            this.logOffToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.menuStrip.Size = new System.Drawing.Size(1370, 37);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem,
            this.viewInfoToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(95, 29);
            this.fileMenu.Text = "مشتريات";
            this.fileMenu.Click += new System.EventHandler(this.fileMenu_Click);
            // 
            // newEntryToolStripMenuItem
            // 
            this.newEntryToolStripMenuItem.Name = "newEntryToolStripMenuItem";
            this.newEntryToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.newEntryToolStripMenuItem.Text = "جديد";
            this.newEntryToolStripMenuItem.Click += new System.EventHandler(this.newEntryToolStripMenuItem_Click);
            // 
            // viewInfoToolStripMenuItem
            // 
            this.viewInfoToolStripMenuItem.Name = "viewInfoToolStripMenuItem";
            this.viewInfoToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.viewInfoToolStripMenuItem.Text = "عرض المعلومات";
            this.viewInfoToolStripMenuItem.Click += new System.EventHandler(this.viewInfoToolStripMenuItem_Click);
            // 
            // editMenu
            // 
            this.editMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem1,
            this.viewInfoToolStripMenuItem1,
            this.مرتجعمنفاتورهToolStripMenuItem});
            this.editMenu.Name = "editMenu";
            this.editMenu.Size = new System.Drawing.Size(80, 29);
            this.editMenu.Text = "المرتجع";
            this.editMenu.Click += new System.EventHandler(this.editMenu_Click);
            // 
            // newEntryToolStripMenuItem1
            // 
            this.newEntryToolStripMenuItem1.Name = "newEntryToolStripMenuItem1";
            this.newEntryToolStripMenuItem1.Size = new System.Drawing.Size(213, 30);
            this.newEntryToolStripMenuItem1.Text = "جديد";
            this.newEntryToolStripMenuItem1.Click += new System.EventHandler(this.newEntryToolStripMenuItem1_Click);
            // 
            // viewInfoToolStripMenuItem1
            // 
            this.viewInfoToolStripMenuItem1.Name = "viewInfoToolStripMenuItem1";
            this.viewInfoToolStripMenuItem1.Size = new System.Drawing.Size(213, 30);
            this.viewInfoToolStripMenuItem1.Text = "عرض المعلومات";
            this.viewInfoToolStripMenuItem1.Click += new System.EventHandler(this.viewInfoToolStripMenuItem1_Click);
            // 
            // مرتجعمنفاتورهToolStripMenuItem
            // 
            this.مرتجعمنفاتورهToolStripMenuItem.Name = "مرتجعمنفاتورهToolStripMenuItem";
            this.مرتجعمنفاتورهToolStripMenuItem.Size = new System.Drawing.Size(213, 30);
            this.مرتجعمنفاتورهToolStripMenuItem.Text = "مرتجع من فاتوره";
            this.مرتجعمنفاتورهToolStripMenuItem.Click += new System.EventHandler(this.مرتجعمنفاتورهToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEntryToolStripMenuItem2,
            this.viewInfoToolStripMenuItem2,
            this.اضافهمنتجلفاتورهقديمهToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(52, 29);
            this.toolsMenu.Text = "بيع ";
            // 
            // newEntryToolStripMenuItem2
            // 
            this.newEntryToolStripMenuItem2.Name = "newEntryToolStripMenuItem2";
            this.newEntryToolStripMenuItem2.Size = new System.Drawing.Size(313, 30);
            this.newEntryToolStripMenuItem2.Text = "فاتوره جديده";
            this.newEntryToolStripMenuItem2.Click += new System.EventHandler(this.newEntryToolStripMenuItem2_Click);
            // 
            // viewInfoToolStripMenuItem2
            // 
            this.viewInfoToolStripMenuItem2.Name = "viewInfoToolStripMenuItem2";
            this.viewInfoToolStripMenuItem2.Size = new System.Drawing.Size(313, 30);
            this.viewInfoToolStripMenuItem2.Text = "معلومات عن الفواتير القديمه ";
            this.viewInfoToolStripMenuItem2.Click += new System.EventHandler(this.viewInfoToolStripMenuItem2_Click);
            // 
            // اضافهمنتجلفاتورهقديمهToolStripMenuItem
            // 
            this.اضافهمنتجلفاتورهقديمهToolStripMenuItem.Name = "اضافهمنتجلفاتورهقديمهToolStripMenuItem";
            this.اضافهمنتجلفاتورهقديمهToolStripMenuItem.Size = new System.Drawing.Size(313, 30);
            this.اضافهمنتجلفاتورهقديمهToolStripMenuItem.Text = "اضافه منتج لفاتوره قديمه";
            this.اضافهمنتجلفاتورهقديمهToolStripMenuItem.Click += new System.EventHandler(this.اضافهمنتجلفاتورهقديمهToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDetailsToolStripMenuItem,
            this.viewInfoToolStripMenuItem3});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(58, 29);
            this.windowsMenu.Text = "منتج";
            this.windowsMenu.Click += new System.EventHandler(this.windowsMenu_Click);
            // 
            // addDetailsToolStripMenuItem
            // 
            this.addDetailsToolStripMenuItem.Name = "addDetailsToolStripMenuItem";
            this.addDetailsToolStripMenuItem.Size = new System.Drawing.Size(334, 30);
            this.addDetailsToolStripMenuItem.Text = "اضافه منتج جديد";
            this.addDetailsToolStripMenuItem.Click += new System.EventHandler(this.addDetailsToolStripMenuItem_Click);
            // 
            // viewInfoToolStripMenuItem3
            // 
            this.viewInfoToolStripMenuItem3.Name = "viewInfoToolStripMenuItem3";
            this.viewInfoToolStripMenuItem3.Size = new System.Drawing.Size(334, 30);
            this.viewInfoToolStripMenuItem3.Text = "معلومات عن المنتجات الموجوده";
            this.viewInfoToolStripMenuItem3.Click += new System.EventHandler(this.viewInfoToolStripMenuItem3_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.دفعToolStripMenuItem,
            this.newEntryToolStripMenuItem3,
            this.viewDetailsToolStripMenuItem,
            this.معلوماتعنالمدفوعاتToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(65, 29);
            this.helpMenu.Text = "عميل";
            this.helpMenu.Click += new System.EventHandler(this.helpMenu_Click);
            // 
            // newEntryToolStripMenuItem3
            // 
            this.newEntryToolStripMenuItem3.Name = "newEntryToolStripMenuItem3";
            this.newEntryToolStripMenuItem3.Size = new System.Drawing.Size(328, 30);
            this.newEntryToolStripMenuItem3.Text = "عميل جديد";
            this.newEntryToolStripMenuItem3.Click += new System.EventHandler(this.newEntryToolStripMenuItem3_Click);
            // 
            // دفعToolStripMenuItem
            // 
            this.دفعToolStripMenuItem.Name = "دفعToolStripMenuItem";
            this.دفعToolStripMenuItem.Size = new System.Drawing.Size(328, 30);
            this.دفعToolStripMenuItem.Text = "دفع";
            this.دفعToolStripMenuItem.Click += new System.EventHandler(this.دفعToolStripMenuItem_Click);
            // 
            // viewDetailsToolStripMenuItem
            // 
            this.viewDetailsToolStripMenuItem.Name = "viewDetailsToolStripMenuItem";
            this.viewDetailsToolStripMenuItem.Size = new System.Drawing.Size(328, 30);
            this.viewDetailsToolStripMenuItem.Text = "معلومات عن العملاء الموجودين";
            this.viewDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewDetailsToolStripMenuItem_Click);
            // 
            // vATToolStripMenuItem
            // 
            this.vATToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewInfoToolStripMenuItem4});
            this.vATToolStripMenuItem.Name = "vATToolStripMenuItem";
            this.vATToolStripMenuItem.Size = new System.Drawing.Size(113, 29);
            this.vATToolStripMenuItem.Text = "وحده قياس";
            // 
            // viewInfoToolStripMenuItem4
            // 
            this.viewInfoToolStripMenuItem4.Name = "viewInfoToolStripMenuItem4";
            this.viewInfoToolStripMenuItem4.Size = new System.Drawing.Size(213, 30);
            this.viewInfoToolStripMenuItem4.Text = "عرض المعلومات";
            this.viewInfoToolStripMenuItem4.Click += new System.EventHandler(this.viewInfoToolStripMenuItem4_Click);
            // 
            // extraToolStripMenuItem
            // 
            this.extraToolStripMenuItem.Name = "extraToolStripMenuItem";
            this.extraToolStripMenuItem.Size = new System.Drawing.Size(119, 29);
            this.extraToolStripMenuItem.Text = "اضافه وحده";
            this.extraToolStripMenuItem.Click += new System.EventHandler(this.extraToolStripMenuItem_Click);
            // 
            // المخزنToolStripMenuItem
            // 
            this.المخزنToolStripMenuItem.Name = "المخزنToolStripMenuItem";
            this.المخزنToolStripMenuItem.Size = new System.Drawing.Size(78, 29);
            this.المخزنToolStripMenuItem.Text = "المخزن";
            this.المخزنToolStripMenuItem.Click += new System.EventHandler(this.المخزنToolStripMenuItem_Click);
            // 
            // موردToolStripMenuItem
            // 
            this.موردToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اضافهموردجديدToolStripMenuItem,
            this.معلوماتعنالموردToolStripMenuItem});
            this.موردToolStripMenuItem.Name = "موردToolStripMenuItem";
            this.موردToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.موردToolStripMenuItem.Text = "مورد";
            this.موردToolStripMenuItem.Click += new System.EventHandler(this.موردToolStripMenuItem_Click);
            // 
            // اضافهموردجديدToolStripMenuItem
            // 
            this.اضافهموردجديدToolStripMenuItem.Name = "اضافهموردجديدToolStripMenuItem";
            this.اضافهموردجديدToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.اضافهموردجديدToolStripMenuItem.Text = "اضافه مورد جديد";
            this.اضافهموردجديدToolStripMenuItem.Click += new System.EventHandler(this.اضافهموردجديدToolStripMenuItem_Click);
            // 
            // معلوماتعنالموردToolStripMenuItem
            // 
            this.معلوماتعنالموردToolStripMenuItem.Name = "معلوماتعنالموردToolStripMenuItem";
            this.معلوماتعنالموردToolStripMenuItem.Size = new System.Drawing.Size(237, 30);
            this.معلوماتعنالموردToolStripMenuItem.Text = "معلومات عن المورد";
            this.معلوماتعنالموردToolStripMenuItem.Click += new System.EventHandler(this.معلوماتعنالموردToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.ForeColor = System.Drawing.Color.Crimson;
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(132, 29);
            this.logOffToolStripMenuItem.Text = "تسجيل الخروج";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.toolStripSeparator1,
            this.printToolStripButton,
            this.printPreviewToolStripButton,
            this.toolStripSeparator2,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 37);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip.Size = new System.Drawing.Size(1370, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "Print";
            this.printToolStripButton.Click += new System.EventHandler(this.printToolStripButton_Click);
            // 
            // printPreviewToolStripButton
            // 
            this.printPreviewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printPreviewToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripButton.Image")));
            this.printPreviewToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.printPreviewToolStripButton.Name = "printPreviewToolStripButton";
            this.printPreviewToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printPreviewToolStripButton.Text = "Print Preview";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "Help";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 727);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(2, 0, 30, 0);
            this.statusStrip.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(202, 17);
            this.toolStripStatusLabel.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // معلوماتعنالمدفوعاتToolStripMenuItem
            // 
            this.معلوماتعنالمدفوعاتToolStripMenuItem.Name = "معلوماتعنالمدفوعاتToolStripMenuItem";
            this.معلوماتعنالمدفوعاتToolStripMenuItem.Size = new System.Drawing.Size(328, 30);
            this.معلوماتعنالمدفوعاتToolStripMenuItem.Text = "معلومات عن المدفوعات";
            this.معلوماتعنالمدفوعاتToolStripMenuItem.Click += new System.EventHandler(this.معلوماتعنالمدفوعاتToolStripMenuItem_Click);
            // 
            // Admin_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Admin_Home";
            this.Text = "Admin-Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Admin_Home_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editMenu;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripButton printPreviewToolStripButton;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem addDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem newEntryToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem viewDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewInfoToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem extraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem المخزنToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem موردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهموردجديدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem معلوماتعنالموردToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem مرتجعمنفاتورهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اضافهمنتجلفاتورهقديمهToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem دفعToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem معلوماتعنالمدفوعاتToolStripMenuItem;
    }
}



