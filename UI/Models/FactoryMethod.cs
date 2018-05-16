using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Models
{
    internal class FactoryMethod
    {
        internal HomePageViewModels CreateHomeViewModel(IEnumerable<ColorBand> bandColors)
        {
            var bandColor = bandColors
                                .Where(x => x.IsBandColor)
                                .Select(x => CreateListItem(x.Name,x.SignificantNumber)).ToList();

            var multiplier=bandColors.Select(x => CreateListItem(x.Name,x.Multiplier.ToString())).ToList();
            var tolerance = bandColors.Select(x =>CreateListItem(x.Name,x.Code)).ToList();

            return new HomePageViewModels()
            {
                BandAColor = bandColor,
                BandBColor = bandColor,
                BandCColor = multiplier,
                BandDColor = tolerance
            };
        }

        private SelectListItem CreateListItem(string text, string value)
        {
            return new SelectListItem()
            {
                Text = text,
                Value = value.ToString()
            };
        }
    }
}