using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        private Car c;
        public Form1()
        {
            InitializeComponent();
            c = new Car("BMW",300);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = c.GetInfo();
            label2.Text = c.Speed.ToString();
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }
    }
    class Car
    {
        public string brand { get; set; }
        private int speed;

        public int Speed
        {
            get { return speed; }
            set
            {
                if (value >= 0 && value <= 290)
                {
                    speed = value;
                }
                else
                {
                     setSpeed();
                }
                
            }
        }
        public void setSpeed()
        {

            Console.WriteLine("Speed must be between 0 and 290.");
           
            
        }
        public Car(string b,int s)
        {
            brand = b ;
            speed = s ;
        }
        public string GetInfo()
        {
            return $"Brand: {brand}, Speed: {speed} km/h";
        }
    }
}
