using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace sub
{
    class subsequence
    {
        public static List<string> getsub(string str)
        {
            if(str.Length==0)
            {
                List<string>ans=new List<string>();
                ans.Add(" ");
                return ans;
            }

            char ch=str[0];
            string rec=str.Substring(1);

            List<string>sres=getsub(rec);
            List<string>res=new List<string>(sres);

            foreach(string st in sres)
            {
                res.Add(ch+st);
            }
            return res;
        }
        static void Main(string[]args)
        {
            string str=Console.ReadLine();
            List<string> rt=getsub(str);
            foreach( string s in rt)
            {
                Console.WriteLine(s);
            }
        }
    }
}