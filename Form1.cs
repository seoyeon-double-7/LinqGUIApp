using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinqGUIApp
{
    public partial class Form1 : Form
    {
        static private List<Product> products = new List<Product>()
        {
            new Product (){ Name="맥북", Price = 2000000},
            new Product (){ Name="메모장", Price = 5000},
            new Product (){ Name="샤프", Price = 3000},
            new Product (){ Name="노트", Price = 6000},
            new Product (){ Name="연필", Price = 1000},
            new Product (){ Name="안경", Price = 150000},
            new Product (){ Name="기타", Price = 60000},

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // 연동
        private void button1_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = products;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              where item.Price >= 1500
                                              orderby item.Price descending
                                              select item;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productBindingSource.DataSource = from item in products
                                              orderby item.Name ascending
                                              select item;
        }
    }
}
