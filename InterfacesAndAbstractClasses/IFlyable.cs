using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndAbstractClasses;

public interface IFlyable
{
    public void FlyTo(Coordinate newPoint);
    public int GetFlyTime(Coordinate newPoint);
}
