using System;
using System.Threading;
using System.Windows.Forms;

namespace Assignment8
{
    public partial class Form1 : Form
    {
        int[] intArray = new int[20];
        double[] doubleArray = new double[20];

        bool searchDoubleArray = false;

        public Form1()
        {
            InitializeComponent();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        private void GenericSearch<T>(T[] inputArray, T searchInput) where T : IComparable<T>
        {
            int i = 0;
            foreach (var element in inputArray)
            {
                if (element.CompareTo(searchInput) == 0)
                {
                    lblResult.Text = "Found value in index -> " + i.ToString();
                    break;
                }
                else
                {
                    lblResult.Text = "Value not found";
                }

                ++i;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblName.Text = "Cameron Helkuik";
            lblResult.Text = "Search Results";
        }

        private void btnIntegers_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Search Results";
            txtSearch.Focus();
            Array.Clear(intArray, 0, intArray.Length);
            txtList.Text = "Index       Value\n";

            for (int i = 0; i < 20; i++)
            {
                intArray[i] = RandomNumber(0, 1000);
                
                txtList.AppendText($"{i,-8}       {intArray[i],-8}\n");
                Thread.Sleep(20);
            }

            searchDoubleArray = false;
        }

        private void btnDoubles_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Search Results";
            txtSearch.Focus();
            Array.Clear(doubleArray, 0, doubleArray.Length);
            txtList.Text = "Index       Value\n";

            for (int i = 0; i < 20; i++)
            {
                doubleArray[i] = RandomNumber(0, 1000)/25.0;

                txtList.AppendText($"{i,-8}       {doubleArray[i],-8}\n");
                Thread.Sleep(20);
            }

            searchDoubleArray = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.SelectionStart = 0;
            txtSearch.SelectionLength = txtSearch.Text.Length;


            if (searchDoubleArray == true)
            {
                double doubleSearch = double.Parse(txtSearch.Text);

                GenericSearch(doubleArray, doubleSearch);
            }
            else
            {
                int intSearch = int.Parse(txtSearch.Text);

                GenericSearch(intArray, intSearch);
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtList.Clear();
            lblResult.Text = "Search Results";
            txtSearch.Clear();
            txtSearch.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
