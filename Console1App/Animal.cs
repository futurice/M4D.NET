using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Console1App
{
    public class Animal : Entity
    {
        [Required]
        public Zoo Zoo { get; set; }

        [Required]
        public virtual string Name { get; set; }

        [Range(0.1, 100000)]
        [DisplayName("Weight (kg)")]
        public virtual double WeightKg { get; set; }

        [Description("Name of the last known person the animal was feed by")]
        public virtual string Feeder { get; set; }


        public class FullName : ComputedProperty<Animal, FullName, string>
        {
            static FullName() => Expr = e => e.Name;

            public override async Task<string> Adjust(string originalValue) =>
                originalValue.PadLeft(12);
        }
    }
}