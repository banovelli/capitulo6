using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Coletar néctar", "Produção de mel" });
            workers[1] = new Worker(new string[] { "Cuidar dos ovos", "Ensinar as abelhas bebês" });
            workers[2] = new Worker(new string[] { "Manutenção da colméia", "Patrulha" });
            workers[3] = new Worker(new string[] { "Coletar néctar", "Produção de mel",
                         "Cuidar dos ovos", "Ensinar as abelhas bebês", "Manutenção da colméia", "Patrulha" });
            queen = new Queen(workers);
        }

        Queen queen;

        private void nextShift_Click(object sender, EventArgs e)
        {
            relatorio.Text = queen.WorkTheNextShift();
        }

        private void assignJob_Click(object sender, EventArgs e)
        {
            if (queen.AssignWork(workerBeeJobs.Text, (int)shifts.Value) == false)
                MessageBox.Show("Não existem operárias disponíveis.'"
                    + workerBeeJobs.Text + "'", "A Rainha diz...");
            else
                MessageBox.Show("O trabalhob '" + workerBeeJobs.Text + "' será realizado em "
                    + shifts.Value + " turno.", "A Rainha diz...");
        }
    }
}
