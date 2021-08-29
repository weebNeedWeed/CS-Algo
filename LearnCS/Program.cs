using System;
using System.Threading.Tasks;
using System.Linq;

namespace LearnCS
{
    class Program
    {
        static void Main(string[] args)
        {
          LinkedList lk = new LinkedList(); 
          lk.AddToList(new int[] {4 , 7, 1, 2, 7,21, 2314, 2534});
          lk.Print();
        }
    }
}
