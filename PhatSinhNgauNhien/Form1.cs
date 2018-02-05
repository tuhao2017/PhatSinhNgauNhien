using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhatSinhNgauNhien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*
         * phát sinh số ngẫu nhiên
         */
        
        private int PhatSinhSoNgauNhien()
        {
            int bienSoNgauNhien = 0; 

            Random rd = new Random();

            bienSoNgauNhien = rd.Next(100);

            return bienSoNgauNhien; 

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string laySoNgauNhien = null;

            int tam = 0;

            int[] mang = new int[6];

            for (int i = 0; i < 6; i++)
            {
                mang[i] = PhatSinhSoNgauNhien();
            }

            
            txtSoNgauNhien.Text = " " + laySoNgauNhien;
        }
    }
}
