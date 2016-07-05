using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace __Birthday_Party
{

    public class BirthdayParty : Party
    {
        public int CakeSize;

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            : base(numberOfPeople, fancyDecorations)
        {
            CalculateCakeSize();
            this.CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        private string cakeWriting = "";
        public string CakeWriting
        {
            get { return this.cakeWriting; }
            set
            {
                int maxLength = (CakeSize == 8) ? (maxLength = 16) : (maxLength = 40);
                if (value.Length > maxLength)
                {
                    MessageBox.Show("Too many letters for a " + CakeSize);
                    if (maxLength > this.cakeWriting.Length)
                        maxLength = this.cakeWriting.Length;
                    this.cakeWriting = cakeWriting.Substring(0, maxLength);
                }
                else
                    this.cakeWriting = value;

            }
        }


        public override decimal CalculateCost()
        {
            decimal CakeCost = (CakeSize == 8) ? (40M + CakeWriting.Length * .25M) : (75M + CakeWriting.Length * .25M);
            return base.CalculateCost() + CakeCost;
        }

        public override int NumberOfPeople
        {
            get { return base.NumberOfPeople; }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                this.CakeWriting = cakeWriting;
            }
        }
    }
}
