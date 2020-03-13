using System;

namespace Console1App
{
    class AnimalInfo : Animal
    {
        [Out]
        public override Guid Id => base.Id;

        [Out]
        public override string Name => base.Name;

        [Out]
        public new ZooInfo Zoo { get; }

        [Out]
        public int FriendsCount => AnimalsCount.Value - 1;

        public Zoo.AnimalsCount AnimalsCount { get; }
    }
}