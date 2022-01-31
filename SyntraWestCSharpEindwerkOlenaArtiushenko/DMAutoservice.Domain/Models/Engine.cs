
using System;
using System.Collections.Generic;
using System.Text;

namespace DMAutoservice.Domain.Models
{
 
    public class Engine 
    {
        public int Id { get; set; }

        public string EngineType { get; set; }
        public int PowerStandard { get; set; }
        public int PowerAfterTuning { get; set; }
        public int PowerDifference => PowerAfterTuning - PowerStandard;
        public int TorqueStandard { get; set; }
        public int TorqueAfterTuning { get; set; }
        public int TorqueDifference => TorqueAfterTuning - TorqueStandard;
        public string Fuel { get; set; }

        public int GenerationId { get; set; }

        //prop nav
        public Generation GenerationType { get; set; }
        //TODO public TuningSpecification SpecificationTuning { get; set; }

        public override string ToString()
        {
            return GenerationType.ToString() + $"\nType of Engine:\t{EngineType}";
        }
    }
}
