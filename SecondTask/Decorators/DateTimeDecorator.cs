using SecondTask.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.Decorators
{
    class DateTimeDecorator:IDateTime
    {
        IDateTime _IDateTime;
        public DateTimeDecorator(IDateTime dateTime)
        {
            _IDateTime = dateTime;
        }
        public virtual void AddSymbols()
        {
            _IDateTime.Display();
        }
    }
}
