using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public class BirthdayParty
    {
        public const int costOfFoodPerPerson = 15;
        private int numberOfPeople;
        public int NumberOfPeople {
            get{return numberOfPeople;} 
            set{ 
                numberOfPeople = value;
                calculateCostOfDecorations(fancyDecorations);
                CalculateCakeSize();
                this.cakeWriting = cakeWriting;
            } 
        }
        private string cakeWriting = "";
        public string CakeWriting {
            get{ return cakeWriting;} 
            set{
                int maxLength = (cakeSize == 8) ? 16 : 40;
                if (value.Length > maxLength)
                {
                    MessageBox.Show("Muitas letras para um bolo de tamanho " + cakeSize, "Atenção");
                    if (maxLength > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                    this.cakeWriting = value;
            } 
        }
        public decimal CosOfDecorations = 0;
        private bool fancyDecorations;
        public int cakeSize;

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            CalculateCakeSize();
            this.cakeWriting = cakeWriting;
            calculateCostOfDecorations(fancyDecorations);
        }

        private void CalculateCakeSize()
        {
            if(NumberOfPeople <= 4){
                cakeSize = 8;
            }
            else{
                cakeSize = 16;
            }
        }

        private void calculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
                CosOfDecorations = NumberOfPeople * 15.00M + 50M;
            else
                CosOfDecorations = NumberOfPeople * 7.50M + 30M;
        }

        public decimal calculateCost()
        {
            decimal totalCost = CosOfDecorations +
                (costOfFoodPerPerson * NumberOfPeople);
            decimal cakeCost = (cakeSize == 8) ? (40M + CakeWriting.Length * .25M) : (75M + CakeWriting.Length * .25M);
            return totalCost + cakeCost;
        }

    }
}
