﻿using ExemploBancoDeDados02.REPOSITORY;
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
    public partial class EstatisticasHerois : Form
    {
        public EstatisticasHerois()
        {
            InitializeComponent();
        }

        private void EstatisticasHerois_Load(object sender, EventArgs e)
        {
            double totalContas = new HeroiRepositorio().ObterTotalDasContas();
            lblTotalContasBancarias.Text = Convert.ToString(totalContas);

        }

        private void lblTotalContasBancarias_Click(object sender, EventArgs e)
        {

        }
    }
}
