using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Proje
{
  public  class Urun
    {
        public Urun_Tanimi tanim { get; set; }

        public Urun()
        {
            tanim = new Urun_Tanimi();
        }
    }
}
