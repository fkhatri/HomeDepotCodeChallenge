using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bandA"></param>
        /// <param name="bandB"></param>
        /// <param name="bandC"></param>
        /// <param name="bandD"></param>
        /// <returns></returns>
        int CalculateResistor(string bandA, string bandB, string bandC, string bandD);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<ColorBand> GetAllBandColors();
    }
}
