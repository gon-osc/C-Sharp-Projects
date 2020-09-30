using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drill248___ASSIGNMENT
{
    public class Employee<T>
    {
        List<T> things;
        public Employee()
        {
            things = new List<T>();
        }
        public void AddToList(T item)
        {
            things.Add(item);
        }
        public void DisplayList()
        {
            foreach (var item in things)
            {
                Console.WriteLine("{0}", item);
            }
        }
    }
}
