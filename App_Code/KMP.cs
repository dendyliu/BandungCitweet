using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

   public  class KMP
    {
        private char[] Pattern;
        private int[] Prefix;

        public KMP(char[] P)
        {
            Pattern = new char[P.Length];
            Array.Copy(P, Pattern, P.Length);
            Prefix = BuildTable(P);
        }
        public KMP(String P)
        {
            Pattern = P.ToCharArray();
           
            Prefix = BuildTable(Pattern);
        }

        private int[] BuildTable(char[] P)
        {
            int[] result = new int[P.Length];
            if (P.Length!=1)
            {
                
                int pos = 2;
                int cnd = 0;
                result[0] = -1;
                result[1] = 0;
                while (pos < P.Length)
                {
                    if (P[pos - 1] == P[cnd])
                    {
                        ++cnd; result[pos] = cnd; ++pos;
                    }
                    else if (cnd > 0)
                        cnd = result[cnd];
                    else
                    {
                        result[pos] = 0; ++pos;
                    }
                }
            }
            else
            {
            result[0] = 0;
            }
            return result;
        }

        public int Search(String S)
        {

            int m = 0;
            int i = 0;
            while (m + i < S.Length)
            {
                if (Pattern[i] == S[m + i])
                {
                    if (i == Pattern.Length - 1)
                        return m;
                    ++i;
                }
                else
                {
                    m = m + i - Prefix[i];
                    if (Prefix[i] > -1)
                        i = Prefix[i];
                    else
                        i = 0;
                }
            }
            return -1;  // not found
        }
    }

