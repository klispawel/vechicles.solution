using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vechicles.solution
{
    interface IVechicle
    {
         string Id { get; set; }
         
        public string Name { get; set; }
        public EngineType Engine { get; set; }
        public ColorType Color { get; set; }

    }
}
