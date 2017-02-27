using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BoyerMoore
/// </summary>
public class BoyerMoore
{
    private int R;     // the radix
    private int[] right;     // the bad-character skip array
    private String pat;      // or as a string


    public BoyerMoore(String pat)
    {
        this.R = 256;
        this.pat = pat;

        // position of rightmost occurrence of c in the pattern
        right = new int[R];
        for (int c = 0; c < R; c++)
            right[c] = -1;
        for (int j = 0; j < pat.Length; j++)
            right[pat[j]] = j;
    }
    
  

    public int Search(String txt)
     {
         int M = pat.Length;
         int N = txt.Length;
         int skip;
         for (int i = 0; i <= N - M; i += skip)
         {
             skip = 0;
             for (int j = M - 1; j >= 0; j--)
             {
                 if (pat[j] != txt[i + j])
                 {
                    if (txt[i + j] < 256)
                    {
                        if ((j - right[txt[i + j]]) >= 1)
                            skip = j - right[txt[i + j]];
                        else
                            skip = 1;
                        break;
                    }
                    else
                        skip = 1;
                 }
             }
             if (skip == 0) return i;    // found
         }
         return -1;                       // not found
     }
     
     /*
    public int Search(String txt)
    {
        int m = pat.Length;
        int n = txt.Length;

        int s = 0; // s is shift of the pattern with respect to text
        while (s <= (n - m))
        {
            int j = m - 1;

            while (j >= 0 && pat[j] == txt[s + j])
                j--;

            if (j < 0)
            {
                return s;

                s += (s + m < n) ? m - right[txt[s + m]] : 1;

            }

            else
            {
                if (txt[s + j] < 256)
                    s += Math.Max(1, j - right[txt[s + j]]);
            }
        }
        return -1;
    }

    public int[] BuildBadCharTable(char[] needle)
    {
        int[] badShift = new int[256];
        for (int i = 0; i < 256; i++)
        {
            badShift[i] = needle.Length;
        }
        int last = needle.Length - 1;
        for (int i = 0; i < last; i++)
        {
            badShift[(int)needle[i]] = last - i;
        }
        return badShift;
    }
    */

   

}