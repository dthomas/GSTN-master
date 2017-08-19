﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Risersoft.API.GSTN.GSTR1
{


    public class B2CLAInv : B2CLInv
    {
        [Required]
        [Display(Name = "Original invoice number")]
        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z0-9]+$")]
        public string onum { get; set; }

        [Required]
        [Display(Name = "Original invoice date")]
        [RegularExpression("^((0[1-9]|[12][0-9]|3[01])[-](0[1-9]|1[012])[-]((19|20)\\d\\d))*$")]
        public string odt { get; set; }

    }

    public class B2clAOutward
    {

        [Required]
        [Display(Name = "Receipient State Code")]
        [MaxLength(2)]
        public string state_cd { get; set; }

        [Required]
        [Display(Name = "Invoice Details")]
        public List<B2CLAInv> inv { get; set; }
    }



}