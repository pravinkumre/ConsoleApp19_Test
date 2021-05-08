using System;

namespace ConsoleApp19_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "AA,BB,CC\n1,das,ssf\n5,erwe,rwerw\n6,NULL,dsfs";
            string input = "AA,BB,CC\nANNUL,das,ssf\n5,null,rwerw\n6,NULL,dsfs\n7,duyu,dsfs\n8,ANULL,NULLABLE\n9,12,13";
            string[] outerArr = input.Split('\n');
            string output = "";

            foreach (var oArr in outerArr)
            {
                string[] innerArr = oArr.Split(',');
                bool noNull = false;
                string tempOut = null;

                for (int i = 0; i < innerArr.Length; i++)
                {
                    if (innerArr[i] == "NULL")
                    {
                        noNull = false;
                        break;
                    }
                    else
                    {
                        noNull = true;
                        if (i == 0)
                            tempOut = tempOut + innerArr[i];
                        else
                            tempOut = tempOut + "," + innerArr[i];
                    }
                }

                if (noNull)
                    output = output + tempOut + "\n";
            }

           output = output.Substring(0, output.Length - 1);

            Console.WriteLine("output : " + output);
        }
    }
}
