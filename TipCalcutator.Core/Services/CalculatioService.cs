using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalcutator.Core.Services
{
    public class CalculatioService : ICalculationService
    {
        public decimal TipAmount(decimal subTotal, double generosity)
        {
            return subTotal * (decimal)(generosity / 100);
        }
    }
}
