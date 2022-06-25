using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pbl.DTO
{
    public class CBBSchedule
    {
        public int? Value { get; set; } = -1;
        public string Text { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
    
}
