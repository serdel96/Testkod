using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testkod
{
    class Trial
    {
        int Choice;
        bool madeChoice;
        int nrChoice;

        public Trial(int nrChoice, bool madeChoice = false)
        {
            this.madeChoice = madeChoice;
            this.nrChoice = nrChoice;
        }

        public void Chosen()
        {
            if (madeChoice == true)
            {
                Choice = nrChoice;
            }
        }


    }
}
