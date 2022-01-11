using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogikHra
{
    public partial class Form1 : Form
    {
        private Combination[] combinations;
        //konstruktor Form1
        public Form1()
        {
            InitializeComponent();
            SetDefaults();
        }
        //metoda na vytovoření pole - struturování 
        private void SetDefaults()
        {
            //pole bez deklarace obsahuje hodnoty null
            combinations = new Combination[9];
            for (int i = 0; i < combinations.Length; i++)
            {
                combinations[i] = new Combination();
            }
        }

        //založení nové hry 
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int size = 37;
            for (int i = 0; i<combinations.Length; i++)
            {
                combinations[i].Draw(e.Graphics, new PointF(10, 10 +i * 1.2F*size),size);
            }
        }
    }
}
