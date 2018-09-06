using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    // when a delegate is called as an event the first parameter is the sender ("this" inside code) and an EventArg
    // parameter that encapsulates the needed information
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
}
