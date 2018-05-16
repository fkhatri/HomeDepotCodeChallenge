using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    /// <summary>
    /// Represnts a entity model for the color band
    /// We can use static files or enum for the color band as well. 
    /// </summary>
    public class ColorBand
    {
        /// <summary>
        /// Represent an Id of the color
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Represents name of the color
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Reperesents the code for the Color
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Represents multiplier
        /// </summary>
        public decimal Multiplier { get; set; }

        /// <summary>
        /// Represents Tolerance, it allow null as well
        /// </summary>
        public decimal? Tolerance { get; set; }

        /// <summary>
        /// Reprsent field to represent the color is allowed for the bandor not 
        /// </summary>
        public bool IsBandColor { get; set; }

        public string SignificantNumber { get; set; }
    }
}
