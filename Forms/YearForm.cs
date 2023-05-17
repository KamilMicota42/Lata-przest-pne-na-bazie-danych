using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Net4.Forms
{
    public class YearForm
    {
        [Display(Name = "Rok urodzenia: ")]
        [Required, Range(1899, 2022, ErrorMessage = "Wartość powinna być w zakresie {1} i {2}.")]
        public int Year { get; set; }

        [Display(Name = "Imię: ")]
        public string? Name { get; set; }
    }
}
