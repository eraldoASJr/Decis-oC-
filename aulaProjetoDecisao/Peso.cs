using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulaProjetoDecisao
{
    public partial class Peso : Form
    {
        public Peso()
        {
            InitializeComponent();
        }

        private void Peso_Load(object sender, EventArgs e)
        {
        }

        private void BtnPesoJoaoMaria_Click(object sender, EventArgs e)
        {
            float pesoJoao, pesoMaria;

            pesoJoao = 110.00f;
            pesoMaria = 120.00f;

            if (pesoJoao > pesoMaria)
                MessageBox.Show(" Peso Joao > que Peso Maria");
            else if (pesoMaria > pesoJoao)
                MessageBox.Show("Peso da Maria é maior que o peso do João");
            else
                MessageBox.Show(" Os dois possuem o mesmo peso ");

        }
    }
}
