using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStudyLabs.ObjectLibrary
{

    public class Lab
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _type;

        public int Type
        {
            get { return _type;  }
            set { _type = value; }
        }
    }
}
