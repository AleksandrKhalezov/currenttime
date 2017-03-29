using System;
using System.Collections.Generic;
using System.IO;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEV_10
{
    class Inputter
    {
        private string line = string.Empty;
        private List<string> list = new List<string>();
        private List<string> valuelist = new List<string>();
        private List<object> cashList1 = new List<object>();
        private List<object> cashList2 = new List<object>();

        public string GetParameters()
        {
            string parameters = string.Empty;
            parameters = Console.ReadLine();
            return parameters;
        }
        public List<string> GetData(string fileName)
        {
            List<string> list = new List<string>();
            try
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    String line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return list;
        }

        public List<string> SetValue(List<object> paramList)
        {
            List<object> cashList1 = new List<object>();
            List<object> cashList2 = new List<object>();
            List<string> valueList = new List<string>();

            for (int i = 0; i < paramList.Count - 1; i++)
            {
                if (paramList[i] instanceof string) 
            {
                Console.WriteLine("Input " + paramList[i] + ": ");
                               if (paramList[i + 1] instanceof string) {
                    valueList.Add(getParam());
                                    }
                            }
                        else {
               cashArrayList1 = (List<Object>)paramList[i];
                Console.WriteLine();
                                for (int j = 0; j < cashArrayList1.Length(); j++)
                {
                    Console.WriteLine("Input " + (j + 1) + " element of array: ");
                    cashArrayList2 = (List<Object>)cashArrayList1[j];
                                        for (int k = 0; k < cashArrayList2.Length(); k++)
                    {
                        Console.WriteLine("Input " + cashArrayList2[k] + ": ");
                        valueList.Add(GetParam());
                                            }
                                  }
                       }
                    }
       if (paramList[paramList.Length() - 1] instanceof string) 
            {
            Console.WriteLine("Input " + paramList[paramList.Length() - 1) + ": "];
             valueList.Add(GetParam());
         }
         return valueList;
        }
    }
}
