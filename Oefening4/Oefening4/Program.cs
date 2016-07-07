using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4

{
    interface IStateMachine
    {
        void Update();
    }

    public class Wait : IStateMachine
    {
        public void SaySomething()
        {
            Console.WriteLine("Miao..");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
