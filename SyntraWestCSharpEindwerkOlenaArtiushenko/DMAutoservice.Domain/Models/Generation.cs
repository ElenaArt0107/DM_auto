using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DMAutoservice.Domain.Models
{
    public class Generation
    {
        public int Id { get; set; }
        public string GenerationName { get; set; }
        public int ModelId { get; set; }
        
        
        //nav prop
        public Model ModelType { get; set; }
        public List<Engine> EngineTypes = new List<Engine>(); // changed after migration => how to update db ?

        public override string ToString()
        {
            return ModelType.ToString() + $"\nGeneration:\t{GenerationName}";
        }

    }
}
