using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyStudyLabs.ObjectLibrary;

namespace DataRepository
{
    public interface ILabRepo
    {
        void Create(Lab lab);
    }
}
