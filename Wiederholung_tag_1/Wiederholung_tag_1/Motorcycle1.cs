using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wiederholung_tag_1
{
    internal class Motorcycle1 : Vehicle
    {
        public Motorcycle1(int typeId, string make, string model, string typeName, int ccm, string color)
        {
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            CCM = ccm;
        }

    }
}
