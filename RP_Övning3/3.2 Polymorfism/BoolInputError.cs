using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP_Övning3
{
    internal class BoolInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a bool input in a text only field. This fired an error!";
        }
    }
}
