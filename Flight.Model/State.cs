using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.Model
{
    public abstract class State
    {
        public int Id { get; set; }
        public static int Choice { get; set; }

        public abstract void Display();
        public abstract void Read();
        public abstract bool IsFinal();
        public abstract string Message();
        public abstract bool IsCorrect();
        public abstract void Process();

        //metoda Template (schelet de algoritm)
        //panou curent stim sa il executam!!!
        public void Execute()
        {
            var ok = false;

            do
            {
                Display();
                Read();
                ok = IsCorrect();
                if (!ok)
                {
                    Message();
                }
            }
            while (!ok);

            Process();
        }
    }
}
