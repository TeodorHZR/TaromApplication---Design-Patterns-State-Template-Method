using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public class Key
    {
        public int From { get; set; } //stare
        public int Choice { get; set; } //alege de continuare

        public override int GetHashCode()
        {
            return From.GetHashCode() ^ Choice.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Key other = (Key)obj;
            return From == other.From && Choice == other.Choice;
        }
    }
}
