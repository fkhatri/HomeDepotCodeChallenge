using System;
using System.Collections.Generic;
using Services.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    /// <summary>
    /// Represents the interface for the repository to get the data information
    /// </summary>
    public interface IRepository
    {
        /// <summary>
        /// Get the list of color band 
        /// </summary>
        /// <returns></returns>
        List<ColorBand> GetColorBand();
    }
}
