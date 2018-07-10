using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExemploBancoDeDados02
{
    public partial class ListaHerois : Form
    {
        public ListaHerois()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CadastroHeroi().ShowDialog();
        }
        private void AtualizarLista()
        {

        }
    
    
    }


}
