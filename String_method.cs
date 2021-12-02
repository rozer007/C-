using System;
using System.Text;
namespace Letters
{
    class String_method
    {
        static void Main(String[]args)
        {
            // String str="Hello Pepcoder";
            // Console.WriteLine(str.Length);
            // Console.WriteLine(String.IsNullOrEmpty(str));
            // Console.WriteLine(String.IsNullOrWhiteSpace(str));
            // Console.WriteLine(str.IndexOf("P"));
            // Console.WriteLine(str.Substring(0,4));

            // String str1="Goodbye Pepcoder";
            // Console.WriteLine(str.Equals(str1));
            // Console.WriteLine(str1.StartsWith("Hello"));
            // Console.WriteLine(str1.EndsWith("Pepcoder"));;
            // Console.WriteLine(str.Remove(0,4));
            // str1=str1.Replace("Goodbye","Bye");
            // Console.WriteLine(str1);

            // string str2=" hello bye ";
            // Console.WriteLine(str2.Trim());

            // // String array
            // String[]names=new String[5]{"Scarlet","lucy","Tom","william","helison"};
            // String str3=String.Join(" * ",names);
            // Console.WriteLine(str3);

            // String str4=String.Format("{0:c},{1:00.000},{2:#.00},{3:0,0}",1.57,10.897,.75,9000);
            // Console.WriteLine(str4);

            // String builder
            StringBuilder sb = new StringBuilder();


            sb.Append("Hello Pepcoder ");
            sb.AppendFormat("The {0} are {1}","pepcoder","great");
            Console.WriteLine(sb.ToString());
            sb.Replace("Hello","Goodbye");
            Console.WriteLine(sb.ToString());
            sb.Remove(5,7);
            Console.WriteLine(sb.ToString());

      
        }
    }
}