using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29thOct
{

    //public class Man : IMan
    //{
    //    public string Business { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //}

    public interface IMan
    {
        string Business {  get; set; }
        string greetings {  get; set; }

    }


    //public class Women : IWomen
    //{
    //    public string Manage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    //}

    public interface IWomen
    {
        string Manage {  get; set; }
        string greetings { get; set; }
    }
    public class Child : IMan, IWomen {
        public string Business {  get; set; }
        public string Manage { get; set; }
        string IMan.greetings { get ; set ; }
        string IWomen.greetings { get; set; }
    }
    public class MultipleIn
    {
        public static void Main(string[] args)
        {
            Child child = new Child();
            child.Business = "business";
            child.Manage = "managing";
            ((IMan)child).greetings = "hello form Man";
            ((IWomen)child).greetings = "hello from Woman";

            Console.WriteLine("bussiness:"+ child.Business);
            Console.WriteLine(child.Manage);
            Console.WriteLine(((IMan)child).greetings);
            Console.WriteLine(((IWomen)child).greetings);
            
        }
    }
}
