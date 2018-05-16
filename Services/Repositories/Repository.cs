using Services.Interfaces;
using System;
using System.Collections.Generic;
using Services.Models;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    /// <summary>
    /// Class represents a repository layer to extract the information from the database or datamodel
    /// </summary>
    public class Repository : IRepository
    {      
        /// <summary>
        /// Get the color band details 
        /// Values are hardcoded to extract the information
        /// </summary>
        /// <returns></returns>
        public List<ColorBand> GetColorBand()
        {
            return new List<ColorBand>()
            {
                new ColorBand() { Id=1, SignificantNumber="", Name="Pink", Code="PK", Multiplier=0.001M, Tolerance=null, IsBandColor=false},
                new ColorBand() { Id=2,SignificantNumber="", Name="Silver", Code="SR", Multiplier=0.01M, Tolerance=10.00M, IsBandColor=false},
                new ColorBand() { Id=3,SignificantNumber="", Name="Gold", Code="GD", Multiplier=0.1M, Tolerance=5.00M, IsBandColor=false},
                new ColorBand() { Id=4,SignificantNumber="0", Name="Black", Code="BK", Multiplier=1.00M, Tolerance=null, IsBandColor=true},
                new ColorBand() { Id=5,SignificantNumber="1", Name="Brown", Code="BN", Multiplier=10.00M, Tolerance=1.00M, IsBandColor=true},
                new ColorBand() { Id=6,SignificantNumber="2", Name="Red", Code="RD", Multiplier=100.00M, Tolerance=2.00M, IsBandColor=true},
                new ColorBand() { Id=7,SignificantNumber="3", Name="Orange", Code="OG", Multiplier=1000.00M, Tolerance=null, IsBandColor=true},
                new ColorBand() { Id=8, SignificantNumber="4",Name="Yellow", Code="YE", Multiplier=10000.00M, Tolerance=5.00M, IsBandColor=true},
                new ColorBand() { Id=9, SignificantNumber="5",Name="Green", Code="GN", Multiplier=100000.00M, Tolerance=0.5M, IsBandColor=true},
                new ColorBand() { Id=10,SignificantNumber="6", Name="Blue", Code="BU", Multiplier=1000000.00M, Tolerance=0.25M, IsBandColor=true},
                new ColorBand() { Id=11,SignificantNumber="7", Name="Violet", Code="VT", Multiplier=10000000.00M, Tolerance=.1M, IsBandColor=true},
                new ColorBand() { Id=12,SignificantNumber="8", Name="Gray", Code="GY", Multiplier=100000000.00M, Tolerance=10.00M, IsBandColor=true},
                new ColorBand() { Id=13,SignificantNumber="9", Name="White", Code="WH", Multiplier=1000000000.00M, Tolerance=null, IsBandColor=true}
            };
        }
    }
}
