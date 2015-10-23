using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharpHw1
{
    public partial class Form : System.Windows.Forms.Form
    {
        int instances;
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e){}

        private void Submit_Click(object sender, EventArgs e)
        {
            Submit.Visible = false;
            Next.Visible = false;

            textBox1.Visible = true;

            textBox1.Text = Display.displayInfo();
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
            instances--;
            if (instances == 0)
            {
                Next.Enabled = false;
                WallHeight.ReadOnly = true;
                WallLength.ReadOnly = true;
                Submit.Visible = true;
            }
            else
            {
                ReadInput.getWallHeight(WallHeight.Text);
                ReadInput.getWallLength(WallLength.Text);

                Calculations.calc_all();
                WallHeight.Clear();
                WallLength.Clear();
            } 
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            Continue.Visible = false;
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

             instances = Display.show_numWalls();
        }

        private void textBox1_TextChanged(object sender, EventArgs e){}
    }
}
