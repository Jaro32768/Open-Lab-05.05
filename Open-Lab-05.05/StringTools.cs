using System;

namespace Open_Lab_05._05
{
    public class StringTools
    {
        public string AlternatingCaps(string original)
        {
            int k = 0;
            string low = original.ToLower();
            string ret = "";
            for (int i = 0; i < low.Length; i++)
            {
                if (low[i] == ' ')
                {
                    ret = ret + low[i];
                }
                else if (k % 2 == 0)
                {
                    ret = ret + low[i].ToString().ToUpper();
                    k = k + 1;
                }
                else if (k % 2 == 1)
                {
                    ret = ret + low[i].ToString().ToLower();
                    k = k + 1;
                }
            }
            return ret;
        }
    }
}
