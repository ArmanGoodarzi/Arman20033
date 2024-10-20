using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Book book = new Book("Biography of Prof. Hesabi", "Irej Hesabi", "978_964_422_097_5", 1395);
            Member member = new Member("Arman Goodarzi", 09906678520, 22813821402);
            MessageBox.Show($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN},Year:{book.Year}");
            MessageBox.Show($"Name : {member.Name},PhoneNumber : {member.PhoneNumber},MemberID: {member.MemberID}");
        }
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }

            public string ISBN { get; set; }

            public int Year { get; set; }

            public Book(string T, string A, string I, int Y)
            {
                Title = T;
                Author = A;
                ISBN = I;
                Year = Y;
            }


            public void PrintInfo()
            {
                Console.WriteLine($"Title: {Title} ,Author: {Author},ISBN: {ISBN}, Year: {Year}");
            }
        }

        public class Member
        {
            public string Name { get; set; }
            public long PhoneNumber { get; set; }

            public long MemberID { get; set; }

            public Member(string N, long P, long M)
            {
                Name = N;
                PhoneNumber = P;
                MemberID = M;
            }
            public void PrintInfo()
            {
                Console.WriteLine($"Name: {Name} ,PhoneNumber: {PhoneNumber},MemberID: {MemberID}");
            }
        }
    }
}
