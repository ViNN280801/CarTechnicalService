using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarTechnicalService.Objects;

namespace CarTechnicalService.Functions
{
    public class BreakOutsCreatingModule
    {
        List<BreakOut> breakOuts = new List<BreakOut>();
        public List<BreakOut> ViewAllBreakOuts()
        {
            return breakOuts;
        }
    }
}