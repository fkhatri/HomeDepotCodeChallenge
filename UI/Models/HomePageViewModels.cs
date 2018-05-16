using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UI.Models
{
    public class HomePageViewModels
    {
        [Display(Name = "Band A Color")]        
        public List<SelectListItem> BandAColor { get; set; }

        [Display(Name = "Band B Color")]
        public List<SelectListItem> BandBColor { get; set; }

        [Display(Name = "Multiplier")]
        public List<SelectListItem> BandCColor { get; set; }

        [Display(Name = "Tolerance")]        
        public List<SelectListItem> BandDColor { get; set; }

        [Required]
        public string SelectedBandA { get; set; }

        [Required]
        public string SelectedBandB { get; set; }

        [Required]
        public string SelectedBandC { get; set; }

        public string SelectedBandD { get; set; }

        public int Result { get; set; } 



    }
}