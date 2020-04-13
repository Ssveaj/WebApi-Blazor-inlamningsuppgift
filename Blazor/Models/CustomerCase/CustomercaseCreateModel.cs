using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor.Models.CustomerCase
{
    public class CustomercaseCreateModel
    {
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Status { get; set; }
    }
}
/* 

steg 1. 
[Required(ErrorMessage = "Error - CustomerName is required")]
steg 2.
Lägg till - Pages/Customercase
<DataAnnotationsValidator />
<ValidationSummary />
steg 3.
Lägg till - Pages/Customercase
&nbsp;<ValidationMessage For="@(() => customercase.CustomerName)" />
*/
