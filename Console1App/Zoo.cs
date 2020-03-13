using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Console1App
{
    public class Zoo : Entity
    {
        public IList<Animal> Animals { get; set; }

        public virtual string Name { get; set; }


        public class AnimalsCount : ComputedProperty<Zoo, AnimalsCount, int>
        {
            static AnimalsCount() => Expr = e => e.Animals.Count();
        }

        public static class Props
        {
            public class Name : ComputedProperty<Zoo, Name, string>
            {
                static Name() => Expr = e => e.Name;
            }
        }
    }
}
