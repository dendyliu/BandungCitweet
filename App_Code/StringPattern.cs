using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public  class StringPattern
    {
            public String Data;
            public int Kategori; //1 , 2 , 3
            public StringPattern Next;
            public StringPattern()
            {
                Data = "#";
                Kategori = 0;
                Next = null;

            }
            public void AddEl(StringPattern SP)
            {
                Next = SP;
            }

     }


