namespace WindowsFormsApplication2
{
    partial class back
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.iMSDataSet1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.mtbQuantity = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.order = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iMSDataSet1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "رقم الفاتوره";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "كود المنتج";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F);
            this.button1.Location = new System.Drawing.Point(76, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "استرجاع";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "العدد";
            // 
            // mtbQuantity
            // 
            this.mtbQuantity.Location = new System.Drawing.Point(76, 162);
            this.mtbQuantity.Mask = "00000";
            this.mtbQuantity.Name = "mtbQuantity";
            this.mtbQuantity.Size = new System.Drawing.Size(121, 20);
            this.mtbQuantity.TabIndex = 37;
            this.mtbQuantity.Text = "1";
            this.mtbQuantity.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(76, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 38;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(76, 40);
            this.order.Name = "order";
            this.order.Size = new System.Drawing.Size(121, 20);
            this.order.TabIndex = 39;
            this.order.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // back
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 323);
            this.Controls.Add(this.order);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mtbQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "back";
            this.Text = "مرتجع من فاتوره";
            this.Load += new System.EventHandler(this.back_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iMSDataSet1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource iMSDataSet1BindingSource2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbQuantity;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox order;

    }
}