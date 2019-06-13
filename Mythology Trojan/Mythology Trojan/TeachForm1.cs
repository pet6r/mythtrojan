using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using MeltingScreen;



namespace Mythology_Trojan
{
    public partial class TeachForm1 : Form
    {
        public TeachForm1()
        {
            InitializeComponent();

            //Thread.Sleep(15000);
            System.Diagnostics.Process.Start("cmd.exe", "/C tree");

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

        private void SpookyCMD() //suppose to spook the user lol
        {
            System.Diagnostics.Process.Start("cmd.exe", "/C tree");
            System.Diagnostics.Process.Start("cmd.exe", "/C tree");
            System.Diagnostics.Process.Start("cmd.exe", "/C tree");
        }

        private void Beep() //suppose to spook the user lol
        {
            Console.Beep(520, 215);
            Console.Beep(520, 265);
            Console.Beep(520, 265);
            Console.Beep(520, 215);
            Console.Beep(560, 215);
            Console.Beep(520, 215);

        }

        private void annoyingtxt()
        {
            string path = @"C:/Users/" + Environment.UserName + "/Desktop/hey.txt";
            //write txt file using textbox
            System.IO.File.WriteAllText(path, textErrorFile.Text);

            //opens txt file 90 times
            System.Diagnostics.Process.Start(path);
            Thread.Sleep(200);
            System.Diagnostics.Process.Start(path);
            Thread.Sleep(200);
            System.Diagnostics.Process.Start(path);
            Thread.Sleep(200);
            System.Diagnostics.Process.Start(path);
            Thread.Sleep(200);
            System.Diagnostics.Process.Start(path);
            Thread.Sleep(200);
            System.Diagnostics.Process.Start(path);
            Thread.Sleep(200);
        }

        private void Open1() //suppose to spook the user lol
        {
            System.Diagnostics.Process.Start("chrome", "https://en.wikipedia.org/wiki/Trojan_Horse");
        }
        private void Open2() //suppose to spook the user lol
        {
            System.Diagnostics.Process.Start("chrome", "https://www.google.com/search?q=trojan+horse&client=firefox-b-1-ab&source=lnms&tbm=isch&sa=X&ved=0ahUKEwiZmauVtfveAhWLg1QKHRLBDiIQ_AUIDigB&biw=2144&bih=1090#imgrc=dAJcr9DjK57S0M:");
        }
        private void Open3() //suppose to spook the user lol
        {
            System.Diagnostics.Process.Start("chrome", "http://www.fallingfalling.com/");
        }
        private void Open4() //suppose to spook the user lol
        {
            System.Diagnostics.Process.Start("chrome", "http://zoomquilt.org/");
        }
        private void Open5() //suppose to spook the user lol
        {
            System.Diagnostics.Process.Start("chrome", "https://cat-bounce.com/");
        }
        private void Open6() //suppose to spook the user lol
        {
            System.Diagnostics.Process.Start("chrome", "https://www.google.com/search?q=trojan+horse&client=firefox-b-1-ab&source=lnms&tbm=isch&sa=X&ved=0ahUKEwiZmauVtfveAhWLg1QKHRLBDiIQ_AUIDigB&biw=2144&bih=1090#imgrc=wHBZFDF2qsYD1M:");
           // System.Diagnostics.Process.Start("paint");
        }
        private void Open7() //suppose to spook the user lol
        {
            System.Diagnostics.Process.Start("chrome", "http://www.nullingthevoid.com/");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < Screen.AllScreens.Length; i++)
            {
                ShowScreenForm s = new ShowScreenForm();
                s.Start(i, 1);
            }
        }

        //next page
        private void button1_Click(object sender, EventArgs e)
        {
            Spazz();
            Beep();
            MessageBox.Show("Chaos starts now.. ", ":P", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
            Spazz();
            SpookyCMD();
            Spazz();
            Spazz();
            Open1();
            Spazz();
            Spazz();
            annoyingtxt();
            Open2();
            Thread.Sleep(2000);
            SpookyCMD();
            Open3();
            Thread.Sleep(2000);
            Spazz();
            Thread.Sleep(3000);
            Open4();
            Spazz();
            Spazz();
            SpookyCMD();
            Spazz();
            Spazz();
            Thread.Sleep(1000);
            Open5();
            Thread.Sleep(2000);
            Spazz();
            Open6();
            Thread.Sleep(2000);
            Open7();
            Spazz();
            Spazz();
            Spazz();
            Spazz();
            Thread.Sleep(1000);
            Open4();
            Spazz();
            Spazz();
            Spazz();
            Spazz();
            Spazz();
            Spazz();
            Spazz();
            Spazz();
            Spazz();
            Spazz();

            LastForm form3 = new LastForm();
            form3.Show();


        }
    }
}
