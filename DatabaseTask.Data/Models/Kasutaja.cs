using System;
using System.Collections.Generic;

namespace DatabaseTask.Data.Models
{
    public partial class Kasutaja
    {
        public Guid Id { get; set; }
        public string Nimi { get; set; } = null!;
        public string Aadress { get; set; } = null!;
    }
}
