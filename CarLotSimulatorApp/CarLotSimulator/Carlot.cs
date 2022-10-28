using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    internal class Carlot
    { 
        public List<Car> Cars { get; set; }
        public Carlot()
        {
            Cars = new List<Car>();
        }
    }
}
