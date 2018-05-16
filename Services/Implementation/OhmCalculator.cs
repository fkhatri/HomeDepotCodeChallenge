using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Services.Helpers;

namespace Services.Implementation
{
    /// <summary>
    /// Represents an implementation for the interface IOhmValueCalculator
    /// </summary>
    public class OhmValueCalculator : IOhmValueCalculator
    {
        private const decimal DEFAULT_TOLERANCE = 20.0M;

        /// <summary>
        /// The injected object, 
        /// </summary>
        private readonly IRepository _repository;

        public OhmValueCalculator(IRepository repository)
        {
            _repository = repository;
        }
        /// <summary>
        /// Calculates the Ohm value of a resistor based on the band colors.
        /// We assume the tolerance value to be positive in number. 
        /// </summary>
        /// <param name="bandAColor">The color of the first figure of component value band.</param>
        /// <param name="bandBColor">The color of the second significant figure band.</param>
        /// <param name="bandCColor">The color of the decimal multiplier band.</param>
        /// <param name="bandDColor">The color of the tolerance value band.</param>

        /// <returns></returns>
        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            var tolerance = 0.0M;

            var bandColors = (bandAColor + bandBColor).ParseInt();

            if (bandColors < 0) return -1;
             
            if (String.IsNullOrEmpty(bandDColor))
            {
                tolerance = DEFAULT_TOLERANCE;
            }
            else {
                var colorTolerance = _repository.GetColorBand().FirstOrDefault(x => x.Code == bandDColor).Tolerance;
                tolerance = (colorTolerance !=null) ? colorTolerance.Value : 0;
            }

            var multiplier = decimal.Parse(bandCColor);
            var bandMultiplier = (int)(bandColors * multiplier);
            var result = (int)(bandMultiplier - (tolerance > 0 ? (bandMultiplier * (tolerance / 100)) : 0));
            return result;
        }
    }
}
