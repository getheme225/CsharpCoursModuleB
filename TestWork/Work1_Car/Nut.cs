using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace Work1_Car
{
    public class Nut : Detail
    {
        /// <summary>
        /// Вес Гайки по умольчанию 1
        /// </summary>
        public override double Weight => 1;

        /// <summary>
        /// Имя Гайки, по умольчанию nut
        /// </summary>
        public override string Name => "Гайка";


    }
}
