using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamaTahtasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button[,] Mybutton = new Button[8, 8];//array tanımlandı
            int left = 0;
            int top = 0;
            for (int i = 0; i <= Mybutton.GetUpperBound(0); i ++)
            {
                for (int j = 0; j <=Mybutton.GetUpperBound(1); j ++)
                {
                    Mybutton[i, j] = new Button();
                    Mybutton[i, j].Width = 50;
                    Mybutton[i, j].Height = 50;
                    Mybutton[i,j].Left= left;
                    Mybutton[i,j].Top= top;
                    left +=50;
                    if ((i + j)%2 == 0)
                    {
                        Mybutton[i, j].BackColor = Color.White;
                    }
                    else
                    {
                        Mybutton[i, j].BackColor = Color.Black;
                    }                  
                    this.Controls.Add(Mybutton[i, j]);
                }

                left= 0;
                top +=50;
            }



        }
    }
}
