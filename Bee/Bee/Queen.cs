using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bee
{

    public class Queen : Bee
    {
        public Queen(Worker[] workers)
            : base(275)
        {
            this.workers = workers;
        }

        private Worker[] workers;
        private int shiftNumber = 0;


        public bool AssignWork(string job, int numberOfShifts)
        {
            for (int i = 0; i < workers.Length; i++)
                if (workers[i].DoThisJob(job, numberOfShifts))
                    return true;
            return false;
        }

        public string WorkTheNextShift()
        {
            double totalConsumption = 0;
            for (int i = 0; i < workers.Length; i++)
                totalConsumption += workers[i].GetHoneyConsumption();
            totalConsumption += GetHoneyConsumption();

            shiftNumber++;
            string report = "Relatório do turno #" + shiftNumber + "\r\n";
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].WorkOneShift())
                    report += "Operária #" + (i + 1) + " terminou o trabalho.\r\n";
                if (String.IsNullOrEmpty(workers[i].CurrentJob))
                    report += "Operária #" + (i + 1) + " está atoa.\r\n";
                else
                    if (workers[i].ShiftsLeft > 0)
                        report += "Operária #" + (i + 1) + " esta fazendo ‘" + workers[i].CurrentJob
                            + "’ por " + workers[i].ShiftsLeft + " mais turnos.\r\n";
                    else
                        report += "Operária #" + (i + 1) + " irá terminar em ‘"
                            + workers[i].CurrentJob + "’ após esse turno.\r\n";
            }
            report += "Quantidade de mel consumido: " + totalConsumption + " unidades";
            return report;
        }

        public override double GetHoneyConsumption()
        {
            double consumption = 0;
            double largestWorkerConsumption = 0;
            int workersDoingJobs = 0;
            for (int i = 0; i < workers.Length; i++)
            {
                if (workers[i].GetHoneyConsumption() > largestWorkerConsumption)
                    largestWorkerConsumption = workers[i].GetHoneyConsumption();
                if (workers[i].ShiftsLeft > 0)
                    workersDoingJobs++;
            }
            consumption += largestWorkerConsumption;
            consumption += (workersDoingJobs >= 3) ? 30 : 20;
            
            return consumption;
        }
    }
}
