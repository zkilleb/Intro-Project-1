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
        
        string name, memo, amountNum, amountWord;
        int checkNum = 3001; //Variable for check number
        int numOfChecks = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Receiving the date from the system
            DateTime thisDay = DateTime.Today;
            Console.WriteLine(thisDay.ToString());
            Console.WriteLine();

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
            name = textBox1.Text;
            memo = textBox2.Text;
            amountNum = textBox3.Text;
            
            //Tally needs to be set to textBox12.Text
            // = textBox12.Text;
            

            //amountWord needs to be set to dollar amount in words
            //amountWord = ;

            //Setting text boxs to user input
            textBox4.Text = name;
            textBox6.Text = memo;
            textBox7.Text = amountWord;
            textBox8.Text = amountNum;

            //Incrementing check number
            checkNum++;
            string checkText = checkNum.ToString();
            textBox9.Text = checkText;

            //Incrementing the number of checks
            numOfChecks++;
            string numText = numOfChecks.ToString();
            textBox11.Text = numText;

            //Creating confirmation pop up window
            MessageBox.Show("Your check has been updated.");


        }
    }
}
