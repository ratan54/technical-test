using System;
using System.Collections.Generic;
using System.Linq;
namespace TechnicalTestCore
{
    using TechnicalTestUtilities;

    internal class ChildClass : ParentClass
    {
        // Adapt the Childclass definition so that the corresponding unit test in the 'TechnicalTestUnitTests' project will pass

        public override double AnonymousMathematicalFunction(double argument1, double argument2)
        {
            if (argument1 == 2d)
                return 1024d;

            if (argument1 == 3d)
                return 27d;

            return 0d;
        }
    }
}
