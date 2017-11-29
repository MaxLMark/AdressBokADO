using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBok.Model
{
    class KontaktTyp
    {
        public string TypNamn;
        public int TypID;
        
        public  override string ToString()
        {
            return TypNamn;
        }

    }
}
