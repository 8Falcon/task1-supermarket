namespace supermarket
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtproduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numquant = new System.Windows.Forms.NumericUpDown();
            this.maskprice = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.combcitiy = new System.Windows.Forms.ComboBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdiscval = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtafter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdilv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numquant)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "اسم العميل";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(115, 9);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(243, 20);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "اسم المنتج";
            // 
            // txtproduct
            // 
            this.txtproduct.Location = new System.Drawing.Point(115, 78);
            this.txtproduct.Name = "txtproduct";
            this.txtproduct.Size = new System.Drawing.Size(150, 20);
            this.txtproduct.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "الكمية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(525, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "السعر";
            // 
            // numquant
            // 
            this.numquant.Location = new System.Drawing.Point(609, 13);
            this.numquant.Name = "numquant";
            this.numquant.Size = new System.Drawing.Size(60, 20);
            this.numquant.TabIndex = 7;
            // 
            // maskprice
            // 
            this.maskprice.Location = new System.Drawing.Point(609, 82);
            this.maskprice.Mask = "0000";
            this.maskprice.Name = "maskprice";
            this.maskprice.Size = new System.Drawing.Size(100, 20);
            this.maskprice.TabIndex = 8;
            this.maskprice.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "المدينة";
            // 
            // combcitiy
            // 
            this.combcitiy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combcitiy.FormattingEnabled = true;
            this.combcitiy.Items.AddRange(new object[] {
            "القاهرة",
            "الجيزه",
            "الاسكندريه",
            "المنصوره",
            "اسيوط",
            "بور سعيد",
            "سوهاج"});
            this.combcitiy.Location = new System.Drawing.Point(115, 148);
            this.combcitiy.Name = "combcitiy";
            this.combcitiy.Size = new System.Drawing.Size(121, 21);
            this.combcitiy.TabIndex = 10;
            // 
            // btncalc
            // 
            this.btncalc.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalc.Location = new System.Drawing.Point(672, 148);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(114, 38);
            this.btncalc.TabIndex = 11;
            this.btncalc.Text = "احسب السعر";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(11, 213);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(69, 24);
            this.lb.TabIndex = 0;
            this.lb.Text = "المجموع";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(127, 218);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "نسبة الخصم";
            // 
            // txtdiscval
            // 
            this.txtdiscval.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiscval.Location = new System.Drawing.Point(529, 217);
            this.txtdiscval.Name = "txtdiscval";
            this.txtdiscval.Size = new System.Drawing.Size(100, 20);
            this.txtdiscval.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "المجموع بعد الخصم";
            // 
            // txtafter
            // 
            this.txtafter.Location = new System.Drawing.Point(211, 273);
            this.txtafter.Name = "txtafter";
            this.txtafter.Size = new System.Drawing.Size(100, 20);
            this.txtafter.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 24);
            this.label8.TabIndex = 17;
            this.label8.Text = "اجرة التوصيل";
            // 
            // txtdilv
            // 
            this.txtdilv.Location = new System.Drawing.Point(529, 277);
            this.txtdilv.Name = "txtdilv";
            this.txtdilv.Size = new System.Drawing.Size(100, 20);
            this.txtdilv.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(251, 359);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 31);
            this.label9.TabIndex = 19;
            this.label9.Text = "المجموع الكلي";
            // 
            // txtnet
            // 
            this.txtnet.Location = new System.Drawing.Point(475, 359);
            this.txtnet.Name = "txtnet";
            this.txtnet.Size = new System.Drawing.Size(100, 20);
            this.txtnet.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 453);
            this.Controls.Add(this.txtnet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtdilv);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtafter);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdiscval);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.combcitiy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskprice);
            this.Controls.Add(this.numquant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtproduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numquant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtproduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numquant;
        private System.Windows.Forms.MaskedTextBox maskprice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combcitiy;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdiscval;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtafter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdilv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnet;
    }
}

