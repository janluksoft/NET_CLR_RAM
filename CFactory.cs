using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sProjFood4
{
    internal class CFactory
    {
        private int Id;
        private string SName;
        private int IFounded;

        public CFactory(int id, string sName, int iFounded)
        {
            Id = id;
            SName = sName;
            IFounded = iFounded;
        }

        public CFactory()
        {
            Id = 0;
            SName = "NoName";
            IFounded = 1992;
        }
    }
}
