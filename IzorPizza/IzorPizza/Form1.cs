using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IzorPizza
{
    public partial class Form1 : Form
    {
        cPizza pizza1;

        String total2;

        public Form1()
        {
            InitializeComponent();

        }

        //########################################################################### //selector for size        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pizza1 = new cSmallPizza();
            label2.Text = pizza1.getDesc();

            double total = pizza1.cost();
            total2 = System.Convert.ToString(total);

            label3.Text = "$" + total2;

         
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pizza1 = new cMedPizza();
            label2.Text = pizza1.getDesc();

            double total = pizza1.cost();
            total2 = System.Convert.ToString(total);

            label3.Text = "$" + total2;

            Refresh();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pizza1 = new cLargePizza();
            label2.Text = pizza1.getDesc();

            double total = pizza1.cost();
            total2 = System.Convert.ToString(total);

            label3.Text = "$" + total2;

            Refresh();
        }

        //########################################################################### //selector for Crust

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                pizza1 = new cDeepDish(pizza1);
                label2.Text = pizza1.getDesc();

                double total = pizza1.cost();
                total2 = System.Convert.ToString(total);

                label3.Text = "$" + total2;

                
            }

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                pizza1 = new cFlatBread(pizza1);
                label2.Text = pizza1.getDesc();

                double total = pizza1.cost();
                total2 = System.Convert.ToString(total);

                label3.Text = "$" + total2;

                //label2.Refresh();
            }

          
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton6.Checked == true)
            {
                pizza1 = new cNormal(pizza1);
                label2.Text = pizza1.getDesc();

                double total = pizza1.cost();
                total2 = System.Convert.ToString(total);

                label3.Text = "$" + total2;

                //label2.Refresh();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        //########################################################################### //selector for Toppings


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
       

            if (checkBox1.Checked == true)
            {
                pizza1 = new cGPepper(pizza1);
                label2.Text = pizza1.getDesc();

                double total = pizza1.cost();
                total2 = System.Convert.ToString(total);

                label3.Text = "$" + total2;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                pizza1 = new cHam(pizza1);
                label2.Text = pizza1.getDesc();

                double total = pizza1.cost();
                total2 = System.Convert.ToString(total);

                label3.Text = "$" + total2;
            }

        }

   

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                pizza1 = new cOnions(pizza1);
                label2.Text = pizza1.getDesc();

                double total = pizza1.cost();
                total2 = System.Convert.ToString(total);

                label3.Text = "$" + total2;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                pizza1 = new cMballs(pizza1);
                label2.Text = pizza1.getDesc();

                double total = pizza1.cost();
                total2 = System.Convert.ToString(total);

                label3.Text = "$" + total2;
            }

        }


        //########################################################################### //Other GUI actions

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thanks.Text = "Order Submitted - Thanks";

            label2.Text = pizza1.getDesc();

            double total = pizza1.cost();
            total2 = System.Convert.ToString(total);

            label3.Text = "$" + total2;

            System.IO.File.WriteAllText(@"C:\Users\derek.izor\Desktop\IzorPizza\IzorPizza\OrderReceipt.txt", label2.Text + label3.Text);
             

        }

        //########################################################################### //Gui Junk

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      

      


        
    }
}
