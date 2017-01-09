using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proxy
{
    abstract class Subject
    {
       public abstract Packet Request(User user);
       public abstract Packet Response(Packet request, User user);
    }
}
