using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne.CommonCrossCutting.Dtos
{
    public class CrudOperationResult<Tdto>
    {
        public CrudOperationResultStatus Status { get; set; }
        public Tdto? Result { get; set; }
    }
}
