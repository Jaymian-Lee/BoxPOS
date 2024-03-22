namespace Kassasysteem
{
    partial class RegisterFom
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.productListview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descriptionListview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountListview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.priceListview = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.productBtn = new System.Windows.Forms.Button();
            this.customerInput = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.descriptionBtn = new System.Windows.Forms.Button();
            this.descriptionInput = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.kortingInput = new System.Windows.Forms.TextBox();
            this.discountBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.amountInput = new System.Windows.Forms.TextBox();
            this.amountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productListview,
            this.descriptionListview,
            this.amountListview,
            this.priceListview});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(276, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(312, 276);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // productListview
            // 
            this.productListview.Text = "Product";
            // 
            // descriptionListview
            // 
            this.descriptionListview.Text = "Beschrijving";
            this.descriptionListview.Width = 75;
            // 
            // amountListview
            // 
            this.amountListview.Text = "Hoeveelheid";
            this.amountListview.Width = 75;
            // 
            // priceListview
            // 
            this.priceListview.Text = "Prijs";
            this.priceListview.Width = 40;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(496, 318);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Contant betaling";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(415, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pin betaling";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // customerBtn
            // 
            this.customerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerBtn.Location = new System.Drawing.Point(12, 152);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(75, 23);
            this.customerBtn.TabIndex = 3;
            this.customerBtn.Text = "Klant";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // productBtn
            // 
            this.productBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productBtn.Location = new System.Drawing.Point(11, 181);
            this.productBtn.Name = "productBtn";
            this.productBtn.Size = new System.Drawing.Size(75, 23);
            this.productBtn.TabIndex = 4;
            this.productBtn.Text = "Product";
            this.productBtn.UseVisualStyleBackColor = true;
            this.productBtn.Click += new System.EventHandler(this.productBtn_Click);
            // 
            // customerInput
            // 
            this.customerInput.Location = new System.Drawing.Point(92, 153);
            this.customerInput.Name = "customerInput";
            this.customerInput.Size = new System.Drawing.Size(162, 20);
            this.customerInput.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(92, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 6;
            // 
            // descriptionBtn
            // 
            this.descriptionBtn.Location = new System.Drawing.Point(11, 239);
            this.descriptionBtn.Name = "descriptionBtn";
            this.descriptionBtn.Size = new System.Drawing.Size(75, 23);
            this.descriptionBtn.TabIndex = 7;
            this.descriptionBtn.Text = "Beschrijving";
            this.descriptionBtn.UseVisualStyleBackColor = true;
            // 
            // descriptionInput
            // 
            this.descriptionInput.Location = new System.Drawing.Point(92, 240);
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.Size = new System.Drawing.Size(162, 20);
            this.descriptionInput.TabIndex = 8;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Location = new System.Drawing.Point(12, 331);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Toevoegen";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // kortingInput
            // 
            this.kortingInput.Location = new System.Drawing.Point(92, 268);
            this.kortingInput.Name = "kortingInput";
            this.kortingInput.Size = new System.Drawing.Size(162, 20);
            this.kortingInput.TabIndex = 10;
            // 
            // discountBtn
            // 
            this.discountBtn.Location = new System.Drawing.Point(11, 268);
            this.discountBtn.Name = "discountBtn";
            this.discountBtn.Size = new System.Drawing.Size(75, 23);
            this.discountBtn.TabIndex = 11;
            this.discountBtn.Text = "Korting";
            this.discountBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelBtn.Location = new System.Drawing.Point(11, 12);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Annuleren";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(92, 211);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(162, 20);
            this.amountInput.TabIndex = 14;
            // 
            // amountBtn
            // 
            this.amountBtn.Location = new System.Drawing.Point(12, 210);
            this.amountBtn.Name = "amountBtn";
            this.amountBtn.Size = new System.Drawing.Size(75, 23);
            this.amountBtn.TabIndex = 13;
            this.amountBtn.Text = "Hoeveelheid";
            this.amountBtn.UseVisualStyleBackColor = true;
            // 
            // RegisterFom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.amountBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.discountBtn);
            this.Controls.Add(this.kortingInput);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.descriptionInput);
            this.Controls.Add(this.descriptionBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.customerInput);
            this.Controls.Add(this.productBtn);
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegisterFom";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader productListview;
        private System.Windows.Forms.ColumnHeader descriptionListview;
        private System.Windows.Forms.ColumnHeader amountListview;
        private System.Windows.Forms.ColumnHeader priceListview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button productBtn;
        private System.Windows.Forms.TextBox customerInput;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button descriptionBtn;
        private System.Windows.Forms.TextBox descriptionInput;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox kortingInput;
        private System.Windows.Forms.Button discountBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.TextBox amountInput;
        private System.Windows.Forms.Button amountBtn;
    }
}