using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
  public  class Language : BaseEntity
    {
        public string Name { get; set; }
        public string ShortCode { get; set; }
        public bool IsRTL { get; set; }
        public bool IsDefault { get; set; }
    }
}
