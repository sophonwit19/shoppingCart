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
            label1.Location = new Point(460, 168);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 7;
            label1.Text = "total";
            label1.Click += label1_Click;
            // 
            // tbtotal
            // 
            tbtotal.Location = new Point(521, 161);
            tbtotal.Name = "tbtotal";
            tbtotal.Size = new Size(137, 27);
            tbtotal.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
