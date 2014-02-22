using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grasshopper
{
    public interface IResource
    {
        int Quantity
        {
            get;
        }

        ResourceType Type
        {
            get;
        }
    }
}
