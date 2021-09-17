using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web.Models
{
    public class CatViewModel
    {
        [Required(ErrorMessage ="Name cannot be blank")]
        [StringLength(maximumLength: 50,ErrorMessage ="name of the cat should be between 2 to 50 characters", MinimumLength =2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Gender cannot be blank")]
        public int GenderId { get; set; }
        public Data.Entities.Gender Gender { get; set; }
        [Required(ErrorMessage = "Birthday cannot be blank")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? Dob { get; set; }
        public decimal? legLength { get; set; }
        public decimal? ribLength { get; set; }
        [Required(ErrorMessage = "Please select cat type")]
        public int CatType { get; set; }
        [Required(ErrorMessage = "Please select fur type")]
        public int FurType { get; set; }

    }
}