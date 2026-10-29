using System.Collections;
using System.Security.Claims;

namespace _29thOct
{
    public class Program
    {
        static void Main(string[] args)
        {

            Calculator<int>  c = new Calculator<int>();
            c.Add(10, 20);

           
        }
    }

    public class Calculator<A>
    {
        public A Add(A a, A b)
        {
            dynamic x = a;
            dynamic y = b;
            Console.WriteLine(x+y);
            return x + y;
        }
        public A Sub(A a, A b)
        {
            dynamic x = a;
            dynamic y = b;
            return x - y;
        }
        public A Mul(A a, A b)
        {
            dynamic x = a;
            dynamic y = b;
            return x * y;
        }
        public A Div(A a, A b)
        {
            dynamic x = a;
            dynamic y = b;
            return x / y;
        }
    }
}
