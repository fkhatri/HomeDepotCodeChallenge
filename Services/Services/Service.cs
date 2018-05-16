using Services.Implementation;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services.Models;

namespace Services.Services
{
    /// <summary>
    /// Represents a Service (Mediator) class referencing Calculate object to calculate resistor and for other retrieval methods
    /// </summary>
    public class Service : IService
    {
        /// <summary>
        /// Backlog object
        /// </summary>
        private readonly IRepository _repository;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="repository"></param>
        public Service(IRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Calculate Resistors based on the inputs
        /// </summary>
        /// <param name="bandA"></param>
        /// <param name="bandB"></param>
        /// <param name="bandC"></param>
        /// <param name="bandD"></param>
        /// <returns></returns>
        public int CalculateResistor(string bandA, string bandB, string bandC, string bandD)
        {
            if(String.IsNullOrEmpty(bandA) || string.IsNullOrEmpty(bandB) || String.IsNullOrEmpty(bandC))
            {
                return -1;
            }
            var calculate = new OhmValueCalculator(_repository);

            return calculate.CalculateOhmValue(bandA, bandB, bandC, bandD);

        }

        public IEnumerable<ColorBand> GetAllBandColors()
        {
            return _repository.GetColorBand();
        }
    }
}
