namespace cSharpHw1
{
    partial class Form
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
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.PhoneNumber = new System.Windows.Forms.TextBox();
            this.PaintPrice = new System.Windows.Forms.TextBox();
            this.WallLength = new System.Windows.Forms.TextBox();
            this.WallHeight = new System.Windows.Forms.TextBox();
            this.NumWalls = new System.Windows.Forms.TextBox();
            this.LabelCustomerName = new System.Windows.Forms.Label();
            this.LabelPhoneNumber = new System.Windows.Forms.Label();
            this.LabelPaintPrices = new System.Windows.Forms.Label();
            this.LabelWallLength = new System.Windows.Forms.Label();
            this.LabelWallHeight = new System.Windows.Forms.Label();
            this.LabelNumWalls = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Continue = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(127, 11);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(157, 20);
            this.CustomerName.TabIndex = 0;
            this.CustomerName.TextChanged += new System.EventHandler(this.CustomerName_TextChanged);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(263, 242);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 1;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Visible = false;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Location = new System.Drawing.Point(127, 52);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(157, 20);
            this.PhoneNumber.TabIndex = 2;
            this.PhoneNumber.TextChanged += new System.EventHandler(this.PhoneNumber_TextChanged);
            // 
            // PaintPrice
            // 
            this.PaintPrice.Location = new System.Drawing.Point(127, 89);
            this.PaintPrice.Name = "PaintPrice";
            this.PaintPrice.Size = new System.Drawing.Size(157, 20);
            this.PaintPrice.TabIndex = 3;
            this.PaintPrice.TextChanged += new System.EventHandler(this.PaintPrice_TextChanged);
            // 
            // WallLength
            // 
            this.WallLength.Location = new System.Drawing.Point(127, 169);
            this.WallLength.Name = "WallLength";
            this.WallLength.Size = new System.Drawing.Size(157, 20);
            this.WallLength.TabIndex = 5;
            this.WallLength.Visible = false;
            this.WallLength.TextChanged += new System.EventHandler(this.WallLength_TextChanged);
            // 
            // WallHeight
            // 
            this.WallHeight.Location = new System.Drawing.Point(127, 207);
            this.WallHeight.Name = "WallHeight";
            this.WallHeight.Size = new System.Drawing.Size(157, 20);
            this.WallHeight.TabIndex = 6;
            this.WallHeight.Visible = false;
            this.WallHeight.TextChanged += new System.EventHandler(this.WallHeight_TextChanged);
            // 
            // NumWalls
            // 
            this.NumWalls.Location = new System.Drawing.Point(127, 130);
            this.NumWalls.Name = "NumWalls";
            this.NumWalls.Size = new System.Drawing.Size(157, 20);
            this.NumWalls.TabIndex = 4;
            this.NumWalls.TextChanged += new System.EventHandler(this.NumWalls_TextChanged);
            // 
            // LabelCustomerName
            // 
            this.LabelCustomerName.AutoSize = true;
            this.LabelCustomerName.Location = new System.Drawing.Point(13, 18);
            this.LabelCustomerName.Name = "LabelCustomerName";
            this.LabelCustomerName.Size = new System.Drawing.Size(85, 13);
            this.LabelCustomerName.TabIndex = 7;
            this.LabelCustomerName.Text = "Customer Name:";
            this.LabelCustomerName.Click += new System.EventHandler(this.LabelCustomerName_Click);
            // 
            // LabelPhoneNumber
            // 
            this.LabelPhoneNumber.AutoSize = true;
            this.LabelPhoneNumber.Location = new System.Drawing.Point(12, 59);
            this.LabelPhoneNumber.Name = "LabelPhoneNumber";
            this.LabelPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.LabelPhoneNumber.TabIndex = 8;
            this.LabelPhoneNumber.Text = "Phone Number:";
            // 
            // LabelPaintPrices
            // 
            this.LabelPaintPrices.AutoSize = true;
            this.LabelPaintPrices.Location = new System.Drawing.Point(13, 96);
            this.LabelPaintPrices.Name = "LabelPaintPrices";
            this.LabelPaintPrices.Size = new System.Drawing.Size(73, 13);
            this.LabelPaintPrices.TabIndex = 9;
            this.LabelPaintPrices.Text = "Price of Paint:";
            // 
            // LabelWallLength
            // 
            this.LabelWallLength.AutoSize = true;
            this.LabelWallLength.Location = new System.Drawing.Point(13, 169);
            this.LabelWallLength.Name = "LabelWallLength";
            this.LabelWallLength.Size = new System.Drawing.Size(67, 13);
            this.LabelWallLength.TabIndex = 11;
            this.LabelWallLength.Text = "Wall Length:";
            this.LabelWallLength.Visible = false;
            this.LabelWallLength.Click += new System.EventHandler(this.LabelWallLength_Click);
            // 
            // LabelWallHeight
            // 
            this.LabelWallHeight.AutoSize = true;
            this.LabelWallHeight.Location = new System.Drawing.Point(13, 207);
            this.LabelWallHeight.Name = "LabelWallHeight";
            this.LabelWallHeight.Size = new System.Drawing.Size(65, 13);
            this.LabelWallHeight.TabIndex = 12;
            this.LabelWallHeight.Text = "Wall Height:";
            this.LabelWallHeight.Visible = false;
            // 
            // LabelNumWalls
            // 
            this.LabelNumWalls.AutoSize = true;
            this.LabelNumWalls.Location = new System.Drawing.Point(12, 130);
            this.LabelNumWalls.Name = "LabelNumWalls";
            this.LabelNumWalls.Size = new System.Drawing.Size(88, 13);
            this.LabelNumWalls.TabIndex = 10;
            this.LabelNumWalls.Text = "Number of Walls:";
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(172, 242);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(75, 23);
            this.Next.TabIndex = 13;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Visible = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // Continue
            // 
            this.Continue.Location = new System.Drawing.Point(224, 167);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(75, 23);
            this.Continue.TabIndex = 15;
            this.Continue.Text = "Continue";
            this.Continue.UseVisualStyleBackColor = true;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 324);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(434, 186);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "\r\n";
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 542);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Continue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.LabelNumWalls);
            this.Controls.Add(this.LabelWallHeight);
            this.Controls.Add(this.LabelWallLength);
            this.Controls.Add(this.LabelPaintPrices);
            this.Controls.Add(this.LabelPhoneNumber);
            this.Controls.Add(this.LabelCustomerName);
            this.Controls.Add(this.NumWalls);
            this.Controls.Add(this.WallHeight);
            this.Controls.Add(this.WallLength);
            this.Controls.Add(this.PaintPrice);
            this.Controls.Add(this.PhoneNumber);
            this.Controls.Add(this.CustomerName);
            this.Name = "Form";
            this.Text = "Paint Calculator";
            this.Load += new System.EventHandler(this.Form_Load);
            this.ResizeEnd += new System.EventHandler(this.Next_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.TextBox PhoneNumber;
        private System.Windows.Forms.TextBox PaintPrice;
        private System.Windows.Forms.TextBox WallLength;
        private System.Windows.Forms.TextBox WallHeight;
        private System.Windows.Forms.TextBox NumWalls;
        private System.Windows.Forms.Label LabelCustomerName;
        private System.Windows.Forms.Label LabelPhoneNumber;
        private System.Windows.Forms.Label LabelPaintPrices;
        private System.Windows.Forms.Label LabelWallLength;
        private System.Windows.Forms.Label LabelWallHeight;
        private System.Windows.Forms.Label LabelNumWalls;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Continue;
        private System.Windows.Forms.TextBox textBox1;
    }
}