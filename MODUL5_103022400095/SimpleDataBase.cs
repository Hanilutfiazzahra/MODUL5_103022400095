using System;
using System.Collections.Generic;
using System.Text;

namespace MODUL5_103022400095
{
    public class SimpleDataBase<T>
    {
        List<T> storedData;
        List<DateTime> inputDates = new List<DateTime>();

        public SimpleDataBase()
        {
            storedData = new List<T>();
        }

        public void AddData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void printData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + 
                    ", yang disimpan pada waktu : " + inputDates[i]);
            }
        }
    }
}
