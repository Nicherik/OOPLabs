using SecondTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.Decorators
{
    class AddPointDecorator:DateTimeDecorator
    {
        public AddPointDecorator(IDateTime dateTime) : base(dateTime) { }

        public override void AddSymbols()
        {
            Console.WriteLine("....");
            base.AddSymbols();
            Console.WriteLine("....");
        }
    }
}
