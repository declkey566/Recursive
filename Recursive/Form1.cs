using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Recursive
{
    public partial class Form1 : Form
    {
        Stopwatch watch1 = new Stopwatch();
        Stopwatch watch2 = new Stopwatch();
        Stopwatch watch3 = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }
        
        static int Fibonacci(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            if (n == 0) return 0; //It will return the first number of the series
            if (n == 1) return 1; // it will return  the second number of the series
            for (int i = 2; i <= n; i++)  // main processing starts from here
            {
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }
            return result;
        }
        

        static int FibonacciR(int n)
        {
            int firstnumber = 0, secondnumber = 1, result = 0;
            if (n == 0) return 0; //it will return the first number of the series
            if (n == 1) return 1; // it will return the second number of the series
            return FibonacciR(n - 1) + FibonacciR(n - 2);
        }

        static int sumOfDigitsFrom1ToN(int n)
        {

            // initialize result 
            int result = 0;

            // One by one compute sum of digits 
            // in every number from 1 to n 
            for (int x = 1; x <= n; x++)
                result += sumOfDigits(x);

            return result;
        }
        static int sumOfDigits(int x)
        {
            int sum = 0;

            while (x != 0)
            {
                sum += x % 10;
                x = x / 10;
            }

            return sum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            watch1.Start();
            int length = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < length; i++)
            {
                label1.Text = ("The Interative search of " + (length) + " is: " + Fibonacci(i) + "\n" + "Completed in: " + watch1.ElapsedMilliseconds + " ms");
            }
            watch1.Stop();
            watch1.Reset();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            watch2.Start();
            int length = Convert.ToInt32(textBox1.Text);
            for (int i = 0; i < length; i++)
            {
                label1.Text = ("The Recursive search of " + (length) + " is: " + FibonacciR(i) + "\n" + "Completed in: " + watch2.ElapsedMilliseconds + " ms");
            }
            watch2.Stop();
            watch2.Reset();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            watch3.Start();
            int n = Convert.ToInt32(textBox1.Text);
            label3.Text = ("The sum of digits from 1 to " + n + " is " + sumOfDigitsFrom1ToN(n) + " Completed in: " + watch2.ElapsedMilliseconds + " ms");
            watch3.Stop();
            watch3.Reset();
        }
    }
    
}
