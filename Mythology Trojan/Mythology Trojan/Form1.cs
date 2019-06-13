using MeltingScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;


namespace Mythology_Trojan
{ 

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            //ReleaseCapture();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("chrome", "https://en.wikipedia.org/wiki/Trojan_Horse");
            //Thread.Sleep(2500);

        }

        private void CheckKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Application.Exit();
            e.Handled = false;
        }

        private void InitializeFont()
        {
            //System.Drawing.Font systemfont = new System.Drawing.Font("Arial", 12f, FontStyle.Regular);
           // text = new D3D.Font(device, systemfont);
        }

        private static async void Spazz()
        {
            // Set our random seeds to create somewhat random numbers
            Random rndx2 = new Random(99);
            Random rndy2 = new Random(5);
            // Set variables for infinite loop + location of cursor
            int i = 1;
            int W;
            int H;
            // Start loop
            while (i == 1)
            {
                //get cursor
                Cursor a = new Cursor(Cursor.Current.Handle);
                //find y position of cursor
                W = Cursor.Position.Y;
                //create random number with changing points
                int Up = rndx2.Next(W - 1, W);
                //move to position
                Cursor.Position = new Point(Cursor.Position.X, Up);
                //repeat using different movements 
                W = Cursor.Position.Y;
                int Down = rndy2.Next(W, W + 3);
                Cursor.Position = new Point(Cursor.Position.X, Down);
                H = Cursor.Position.X;
                int Right = rndx2.Next(H - 1, H);
                Cursor.Position = new Point(Right, Cursor.Position.Y);
                H = Cursor.Position.X;
                int Left = rndy2.Next(H, H + 3);
                Cursor.Position = new Point(Left, Cursor.Position.Y);
                //runs forever
                await Task.Delay(1);
            }
        }

        private void button1_Click(object sender, EventArgs e) //fake exit button
        {
            DialogResult exitbtn = MessageBox.Show("Are you sure you want to exit?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (exitbtn == DialogResult.Yes)
            {
                //cursor spaz on button
                Spazz();
                Explanation();

                string path = @"C:/Users/" + Environment.UserName + "/Documents/hey.txt";
                //write txt file using textbox
                //System.IO.File.WriteAllText(path, textErrorFile.Text);

                //opens txt file 90 times
                //System.Diagnostics.Process.Start(path);
                Thread.Sleep(400);

                //System.Diagnostics.Process.Start("chrome", "https://en.wikipedia.org/wiki/Trojan_Horse");

            }
            else if (exitbtn == DialogResult.No)

            {
                //edgy cmd pop up
                System.Diagnostics.Process.Start("cmd.exe", "/C tree");
                Thread.Sleep(400);

            }
        }

        private void Explanation() //this function opens a txt file with an explantion of my "project"
        {
            string path = @"C:/Users/" + Environment.UserName + "/Desktop/DISCLAIMER.txt";
            //write txt file using textbox
            System.IO.File.WriteAllText(path, textIntro.Text);

            System.Diagnostics.Process.Start(path); //open file with coresponding to 
            Thread.Sleep(400);
        }

        private void SpookyCMD() //suppose to spook the user lol
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C tree");
            Thread.Sleep(10);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                ShowScreenForm s = new ShowScreenForm();
                s.Start(i, 1);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //No Button
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry but this option isn't working at the moment. :((( ", " ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //yes Button
        private void button1_Click_2(object sender, EventArgs e)
        {

            TeachForm1 form2 = new TeachForm1();
            form2.Show();
       
            //cursor spaz on button
            //Spazz();
            Explanation();

            string path = @"C:/Users/" + Environment.UserName + "/Documents/hey.txt";
            //write txt file using textbox
            //System.IO.File.WriteAllText(path, textErrorFile.Text);

            //opens txt file 90 times
            //System.Diagnostics.Process.Start(path);
            //Thread.Sleep(400);

            //System.Diagnostics.Process.Start("chrome", "https://en.wikipedia.org/wiki/Trojan_Horse");
        }
    }
}
