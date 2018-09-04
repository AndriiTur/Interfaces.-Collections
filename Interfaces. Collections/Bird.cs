using System;

namespace Interfaces.Collections
{
    class Bird : IFlyable
    {
        string name;
        string canFly;

        public void Fly()
        {
            throw new NotImplementedException();
        }
    }
}
