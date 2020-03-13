using System;
using System.ComponentModel.DataAnnotations;
using static Console1App.PropValueKind;

namespace Console1App
{

    [Authorize("EmployerName", typeof(Zoo.Props.Name))]
    class AnimalFeedOperation : Animal
    {
        [In]
        public override Guid Id { get; set; }

        [In]
        [Range(0, 100)]
        public double GrassAmountKg { get; set; }

        [In]
        [Range(0.1, 2)]
        [SmallerThan(Original, nameof(WeightKg))]
        public double WaterAmountKg { get; set; }

        [In]
        public override string Feeder { get; set; }

        public override double WeightKg => base.WeightKg + GrassAmountKg * 0.42 + WaterAmountKg;
    }
}