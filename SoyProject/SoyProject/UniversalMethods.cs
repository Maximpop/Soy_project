using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoyProject
{
    class UniversalMethods
    {
        Gagnagrunnur DB = new Gagnagrunnur();

        public UniversalMethods()
        {
            DB.ConnectionToDatabase();
        }
    }
}
