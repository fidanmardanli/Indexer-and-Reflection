using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerAndReflectionTask
{
    public class Class2
    {
        private string[] arr;

        public List()
        {
            arr = new string[0];

        }

       
        public void Add(string name)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = name;
        }

        public void Clear(T data)
        {

        }

        public void Find(T data)
        {
            var result = data;
            foreach (var item in arr)
            {
                Console.WriteLine(item );
            }
        }

        public void GetAll()
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item );
            }
        }
            

    }
}
