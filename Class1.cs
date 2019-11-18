using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace criclass
{
    class Class1
    {
        private double valor;
        public string recebe
        {
            set
            {
                valor = Convert.ToDouble(value);
            }
        }

        public string envia
        {
            get
            {
                return(valor + 2).ToString();
            }
        }
    }
}
