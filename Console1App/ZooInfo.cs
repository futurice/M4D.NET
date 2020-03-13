using System;

namespace Console1App
{
    class ZooInfo : Zoo
    {
        [Out]
        public override Guid Id => base.Id;

        [Out]
        public override string Name => base.Name;
    }
}