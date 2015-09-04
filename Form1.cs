//Intro Project 1 
//Team Lirin
//CS 325 - Fall 2015
//Dr. Mayer
//Zachary Killebrew

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checks
{
    
    public partial class Form1 : Form
    {
        InputProcessor inputProcessor = new InputProcessor();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Receiving the date from the system
            DateTime thisDay = DateTime.Today;

            //Assigning the formated date to the correct textbox
            textBox10.Text = (thisDay.ToString("d"));

            //Creating the picture box to display the check
            PictureBox picture = new PictureBox
            {
                Name = "pictureBox",
                Size = new Size(2000, 2000),
                Location = new Point(0, 0)
                
            };

            //Setting the check as picture box background
            Controls.Add(picture);
            picture.ImageLocation = @"..\Image\check.png";
        }
        
        //Creating label 1 for "Name"
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        //Creating label 2 for "Memo"
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        //Auto-created code for textBox1, "Name" text box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        //Auto-created code for texBox2, "Memo" text box
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Auto-created code for textBox3, "$ (Num.)" text box
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)  {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.')) {e.Handled = true;}

            // allows only one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }
        //Auto-created code for textBox4, space for name on check
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        //Auto-created code for textBox7, written $ amount on check
        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        //Auto-created code for textBox8, numeric dollar amount on check
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        
        //Auto-created code for textBox9, check number
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        //Auto-created code for textBox10, date on check
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        //Auto-created code for "Number of Checks:" label
        private void label5_Click(object sender, EventArgs e)
        {

        }


        //Auto-created code for "$ (Num.)" label
        private void label3_Click(object sender, EventArgs e)
        {
            
        }
        
        //Code for update button
        private void button1_Click(object sender, EventArgs e)
        {
            inputProcessor.setName(textBox1.Text);
            inputProcessor.setMemo(textBox2.Text);
            inputProcessor.setCheckAmount(textBox3.Text);

            //Tally needs to be set to textBox12.Text
            // = textBox12.Text;
            textBox11.Text = inputProcessor.getCheckNumber();
            textBox9.Text = inputProcessor.getCheckNumber();

            //amountWord needs to be set to dollar amount in words
            //amountWord = ;
            textBox7.Text = inputProcessor.checkAmountToString(inputProcessor.getCheckAmount());

            //Setting text boxs to user input
            textBox4.Text = inputProcessor.getName();
            textBox6.Text = inputProcessor.getMemo();
            textBox8.Text = inputProcessor.getCheckAmount();
            textBox12.Text = inputProcessor.getTotalAmount();

            inputProcessor.newCheck();

            //Creating confirmation pop up window
            MessageBox.Show("Your check has been updated.");
        }
    }
}
