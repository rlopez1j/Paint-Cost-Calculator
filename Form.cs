using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintCalc
{
    public partial class Form : System.Windows.Forms.Form
    {
        int instances;
        int wallNumber = 1;
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e){}

        private void Submit_Click(object sender, EventArgs e)
        {
            Controls.Remove(Submit);
            Controls.Remove(Next);
            Controls.Remove(CustomerName);
            Controls.Remove(PhoneNumber);
            Controls.Remove(PaintPrice);
            Controls.Remove(NumWalls);
            Controls.Remove(WallLength);
            Controls.Remove(WallHeight);
            Controls.Remove(LabelCustomerName);
            Controls.Remove(LabelPhoneNumber);
            Controls.Remove(LabelPaintPrices);
            Controls.Remove(LabelNumWalls);
            Controls.Remove(LabelWallLength);
            Controls.Remove(LabelWallHeight);

            //Calculations.calc_all();

            Data.Visible = true;
            Data.Text = Display.displayInfo();
        }

       private void LabelCustomerName_Click(object sender, EventArgs e){}
       private void PaintPrice_TextChanged(object sender, EventArgs e){}
       private void WallHeight_TextChanged(object sender, EventArgs e){}
       private void PhoneNumber_TextChanged(object sender, EventArgs e){}
       private void NumWalls_TextChanged(object sender, EventArgs e){}
       private void WallLength_TextChanged(object sender, EventArgs e){}
       private void LabelWallLength_Click(object sender, EventArgs e){}
       private void CustomerName_TextChanged(object sender, EventArgs e){}
       private void Next_Click(object sender, EventArgs e)
        {
            //if nothing is inputed into the textboxes
            if (WallHeight.Text == "" || WallLength.Text == "")
            {
                if (WallHeight.Text == "")
                    MessageBox.Show("Please Enter A Wall Height.");
                if (WallLength.Text == "")
                    MessageBox.Show("Please Enter A Wall Length.");
            }
            else
            {
                wallNumber++;
                instances--;

                ReadInput.getWallHeight(WallHeight.Text);
                ReadInput.getWallLength(WallLength.Text);

                if (instances == 0)
                {
                    Next.Enabled = false;
                    WallHeight.ReadOnly = true;
                    WallLength.ReadOnly = true;
                    Submit.Visible = true;
                    Calculations.calc_all();
                }
                else
                {
                    WallHeight.Clear();
                    WallLength.Clear();

                    Calculations.calc_all();

                }
            }
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            //checks that values were inputed into the textbox
            if (CustomerName.Text == "" || PhoneNumber.Text == "" //need to find a more elegant solution to this, if possible
                || PaintPrice.Text == "" || NumWalls.Text == "")
            {
                if (CustomerName.Text == "")
                    MessageBox.Show("Please Enter Customer Name");
                if (PhoneNumber.Text == "")
                    MessageBox.Show("Please Enter Phone Number");
                if (PaintPrice.Text == "")
                    MessageBox.Show("Please Enter Price of Paint.");
                if (NumWalls.Text == "")
                    MessageBox.Show("Please Enter Number of Walls.");
            }
            else
            {
                Controls.Remove(Continue);

                Next.Visible = true;
                WallLength.Visible = true;
                WallHeight.Visible = true;
                LabelWallHeight.Visible = true;
                LabelWallLength.Visible = true;

                ReadInput.getCustomerName(CustomerName.Text);
                ReadInput.getPhoneNum(PhoneNumber.Text);
                ReadInput.getPaintPrice(PaintPrice.Text);
                ReadInput.getNumWalls(NumWalls.Text);

                CustomerName.ReadOnly = true;
                PhoneNumber.ReadOnly = true;
                PaintPrice.ReadOnly = true;
                NumWalls.ReadOnly = true;

                instances = Convert.ToInt32(NumWalls.Text);
                wallNumber = 1;
            }
        }

        private void Data_TextChanged(object sender, EventArgs e){}
    }
}
