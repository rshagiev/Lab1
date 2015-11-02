using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Task : Form
    {
        private string Surname;
        private string NameSt;
        private string Lastname;
        private string Kalss;
        private string Zad;
        private bool But1;
        private bool But2;

        public Task()
        {
            InitializeComponent();
        }

        public Task(string text1, string text2, string text3, string text4, string text5, bool bat1,bool bat2)
        {
            this.Surname = text3;
            this.NameSt = text2;
            this.Lastname = text1;
            this.Kalss = text4;
            this.Zad = text5;
            this.But1 = bat1;
            this.But2 = bat2;

            InitializeComponent();

            //text1 = name
            //text2 = Lastname
            //v = name
            // text3 =?
            // text4 =?

            label1.Text = "Ученик: " + Lastname + " "+ NameSt + "\n" + "Класс " + text4 +  "\n" + "Zadanie " + Zad + "\n" + "Grade: Not good enough!";
            
            int n = Convert.ToInt32(Zad);
            
            for (int i = 1; i < n+1; i++)
            {
                if (But1 == true)
                {

                    Random rnd = new Random();
                    int first = rnd.Next(1, 3);
                    int second = rnd.Next(1, 3);
                    int third = rnd.Next(2, 6);
                    
                    CheckBox t = new CheckBox();
                    CheckBox z = new CheckBox();
                    t.Text = " Yes" ;
                    z.Text = " No";
                    int x, y;
                    x = 20;
                    y = i * 30;
                    t.Location = new Point(x, y);
                    this.Controls.Add(t);

                    z.Location = new Point(x+120, y);
                    this.Controls.Add(z);

                    MessageBox.Show("Hi, is " + first + " + " + second + " = " + third + "?", "Task " + i);
                }
                else if (But2 == true)
                {
                    Random rnd = new Random();
                    int first = rnd.Next(1, 50);
                    int second = rnd.Next(50, 200);
                    System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"\\Mac\Home\Downloads\man.wav");
                    sp.Play();
                    TextBox t = new TextBox();
                    t.Text = "Answer " + i;
                    int x, y;
                    x = 20;
                    y = i * 30;
                    t.Location = new Point(x, y);
                    this.Controls.Add(t);
                    MessageBox.Show("You'r a man. Hard task it is " + first + " * " + second + " = " + "? ", "Task " + i);
                }
            }
            


        }

        private void Task_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
