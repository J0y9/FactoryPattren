using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattren.Factory
{
    public interface ICreator
    {
        IShape CreateShape();
    }
}