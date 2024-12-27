namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chbCoffee = new CheckBox();
            chbgreentea = new CheckBox();
            tbCoffeePrice = new MaskedTextBox();
            tbGreenteaPrice = new MaskedTextBox();
            tbCoffeeQuantity = new MaskedTextBox();
            tbGreenteaQuantity = new MaskedTextBox();
            button1 = new Button();
            label1 = new Label();
            tbtotal = new MaskedTextBox();
            label2 = new Label();
            tbCash = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tbChange = new MaskedTextBox();
            tb1000 = new MaskedTextBox();
            tb500 = new MaskedTextBox();
            tb100 = new MaskedTextBox();
            tb50 = new MaskedTextBox();
            tb20 = new MaskedTextBox();
            tb10 = new MaskedTextBox();
            tb5 = new MaskedTextBox();
            tb1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // chbCoffee
            // 
            chbCoffee.AutoSize = true;
            chbCoffee.Location = new Point(31, 34);
            chbCoffee.Name = "chbCoffee";
            chbCoffee.Size = new Size(73, 24);
            chbCoffee.TabIndex = 0;
            chbCoffee.Text = "coffee";
            chbCoffee.UseVisualStyleBackColor = true;
            chbCoffee.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // chbgreentea
            // 
            chbgreentea.AutoSize = true;
            chbgreentea.Location = new Point(31, 85);
            chbgreentea.Name = "chbgreentea";
            chbgreentea.Size = new Size(94, 24);
            chbgreentea.TabIndex = 1;
            chbgreentea.Text = "green tea";
            chbgreentea.UseVisualStyleBackColor = true;
            chbgreentea.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // tbCoffeePrice
            // 
            tbCoffeePrice.Location = new Point(172, 34);
            tbCoffeePrice.Name = "tbCoffeePrice";
            tbCoffeePrice.Size = new Size(125, 27);
            tbCoffeePrice.TabIndex = 2;
            // 
            // tbGreenteaPrice
            // 
            tbGreenteaPrice.Location = new Point(172, 85);
            tbGreenteaPrice.Name = "tbGreenteaPrice";
            tbGreenteaPrice.Size = new Size(125, 27);
            tbGreenteaPrice.TabIndex = 3;
            // 
            // tbCoffeeQuantity
            // 
            tbCoffeeQuantity.Location = new Point(340, 34);
            tbCoffeeQuantity.Name = "tbCoffeeQuantity";
            tbCoffeeQuantity.Size = new Size(125, 27);
            tbCoffeeQuantity.TabIndex = 4;
            tbCoffeeQuantity.MaskInputRejected += tbCoffeeQuantity_MaskInputRejected;
            // 
            // tbGreenteaQuantity
            // 
            tbGreenteaQuantity.Location = new Point(340, 85);
            tbGreenteaQuantity.Name = "tbGreenteaQuantity";
            tbGreenteaQuantity.Size = new Size(125, 27);
            tbGreenteaQuantity.TabIndex = 5;
            tbGreenteaQuantity.MaskInputRejected += tbGreentaeQuantity_MaskInputRejected;
            // 
            // button1
            // 
            button1.Location = new Point(521, 34);
            button1.Name = "button1";
            button1.Size = new Size(137, 86);
            button1.TabIndex = 6;
            button1.Text = "Check out";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 133);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 7;
            label1.Text = "total";
            label1.Click += label1_Click;
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(521, 130);
            tbtotal.Name = "tbtotal";
            tbtotal.Size = new Size(137, 27);
            tbtotal.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 173);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 9;
            label2.Text = "Cash";
            // 
            // tbCash
            // 
            tbCash.Location = new Point(521, 170);
            tbCash.Name = "tbCash";
            tbCash.Size = new Size(135, 27);
            tbCash.TabIndex = 10;
            tbCash.MaskInputRejected += tbCash_MaskInputRejected;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(467, 247);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 11;
            label3.Text = "1000";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(700, 173);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 12;
            label4.Text = "10";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(708, 211);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 13;
            label5.Text = "5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(475, 282);
            label6.Name = "label6";
            label6.Size = new Size(33, 20);
            label6.TabIndex = 14;
            label6.Text = "500";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(475, 321);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 15;
            label7.Text = "100";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(483, 363);
            label8.Name = "label8";
            label8.Size = new Size(25, 20);
            label8.TabIndex = 16;
            label8.Text = "50";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(700, 133);
            label9.Name = "label9";
            label9.Size = new Size(25, 20);
            label9.TabIndex = 17;
            label9.Text = "20";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(708, 247);
            label10.Name = "label10";
            label10.Size = new Size(17, 20);
            label10.TabIndex = 18;
            label10.Text = "1";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(456, 215);
            label11.Name = "label11";
            label11.Size = new Size(59, 20);
            label11.TabIndex = 19;
            label11.Text = "Change";
            label11.Click += label11_Click;
            // 
            // tbChange
            // 
            tbChange.Location = new Point(521, 208);
            tbChange.Name = "tbChange";
            tbChange.Size = new Size(137, 27);
            tbChange.TabIndex = 20;
            // 
            // tb1000
            // 
            tb1000.Location = new Point(521, 244);
            tb1000.Name = "tb1000";
            tb1000.Size = new Size(137, 27);
            tb1000.TabIndex = 21;
            // 
            // tb500
            // 
            tb500.Location = new Point(521, 279);
            tb500.Name = "tb500";
            tb500.Size = new Size(137, 27);
            tb500.TabIndex = 22;
            // 
            // tb100
            // 
            tb100.Location = new Point(521, 321);
            tb100.Name = "tb100";
            tb100.Size = new Size(137, 27);
            tb100.TabIndex = 23;
            // 
            // tb50
            // 
            tb50.Location = new Point(521, 363);
            tb50.Name = "tb50";
            tb50.Size = new Size(137, 27);
            tb50.TabIndex = 24;
            // 
            // tb20
            // 
            tb20.Location = new Point(742, 130);
            tb20.Name = "tb20";
            tb20.Size = new Size(137, 27);
            tb20.TabIndex = 25;
            // 
            // tb10
            // 
            tb10.Location = new Point(742, 166);
            tb10.Name = "tb10";
            tb10.Size = new Size(137, 27);
            tb10.TabIndex = 26;
            // 
            // tb5
            // 
            tb5.Location = new Point(742, 208);
            tb5.Name = "tb5";
            tb5.Size = new Size(137, 27);
            tb5.TabIndex = 27;
            // 
            // tb1
            // 
            tb1.Location = new Point(742, 247);
            tb1.Name = "tb1";
            tb1.Size = new Size(137, 27);
            tb1.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 488);
            Controls.Add(tb1);
            Controls.Add(tb5);
            Controls.Add(tb10);
            Controls.Add(tb20);
            Controls.Add(tb50);
            Controls.Add(tb100);
            Controls.Add(tb500);
            Controls.Add(tb1000);
            Controls.Add(tbChange);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbCash);
            Controls.Add(label2);
            Controls.Add(tbtotal);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(tbGreenteaQuantity);
            Controls.Add(tbCoffeeQuantity);
            Controls.Add(tbGreenteaPrice);
            Controls.Add(tbCoffeePrice);
            Controls.Add(chbgreentea);
            Controls.Add(chbCoffee);
            Name = "Form1";
            Text = "coffee";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbhCoffee;
        private CheckBox checkBox2;
        private MaskedTextBox tbCoffeePrice;
        private MaskedTextBox tbGreenteaPrice;
        private MaskedTextBox tbCoffeeQuantity;
        private MaskedTextBox tbGreenteaQuantity;
        private Button button1;
        private Label label1;
        private MaskedTextBox tbtotal;
        private CheckBox chbCoffee;
        private CheckBox chbgreentea;
        private Label label2;
        private MaskedTextBox tbCash;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private MaskedTextBox tbChange;
        private MaskedTextBox tb1000;
        private MaskedTextBox tb500;
        private MaskedTextBox tb100;
        private MaskedTextBox tb50;
        private MaskedTextBox tb20;
        private MaskedTextBox tb10;
        private MaskedTextBox tb5;
        private MaskedTextBox tb1;
    }
}
