using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
     abstract class Rules
    {
       public Rules NextRules {get; set;}
       public abstract void Rule(Packet packet);
    } 
}
