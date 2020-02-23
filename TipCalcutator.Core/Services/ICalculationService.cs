using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalcutator.Core.Services
{
    public interface ICalculationService
    {
        decimal TipAmount(decimal subTotal, double generosity);
    }
}
