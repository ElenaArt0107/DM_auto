using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.models
{
    public class Rekening
    {
        public int Id { get; set; }
        public string OpNaamVan { get; set; }
        public string RekeningType { get; set; }
        public decimal Balans { get; set; }
    }
}
