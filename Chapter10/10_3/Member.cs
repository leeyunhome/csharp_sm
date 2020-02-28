using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3
{
    class Member
    {
        private string Name;
        private string Phone;

        public string NAME
        {
            get { return Name; }
            set { Name = value; }
        }

        public string PHONE
        {
            get { return Phone; }
            set { Phone = value; }
        }
    }
}
