using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace middleware
{
    internal class middleware
    {

        public void main() {
            allFunc(8, 2);
            allFunc(5, 3);
            allFunc(124, 11);

        }

        public void allFunc(int a, int b )
        {
            wrap(a, b, add);
            wrap(a, b, multi);
            wrap(a, b, sub);
            wrap(a, b, div);
        }

        public void wrap(int a, int b,Action<int,int> function)
        {
            Console.WriteLine("[ {0} ]:",function.Method.Name.ToString());
            function(a,b);
        }

        public void add(int a, int b)
        {
            Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
        }

        public void multi(int a , int b)
        {
            Console.WriteLine("{0} * {1} = {2}", a,b,a*b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
        }

        public void div(int a, int b)
        {
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
        }
    }
}
