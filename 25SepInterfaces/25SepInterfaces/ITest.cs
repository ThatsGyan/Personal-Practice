using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25SepInterfaces
{
    //<Modifire> interface <Name interface>
    //{
    //  -Abstract Member Decleration here;
    //}
    // default scope is public
    //by default every member of interface is abstract .
    //interface can inherit from another interface
    interface ITest
    {
        void Add(int a, int b);   
    }
    interface ITest2:ITest
    {
        void sub(int a, int b);
    }


    class ImplementationClass :ITest
    {
         public void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }
    }
    //createing object og an interface//



}
