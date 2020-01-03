using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace TrainChecklist.DomainModels
{
    public class Company
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id {get; private set;}

        [Display(Name = "Company Name")]
        public string CompanyName {get; private set;}

        [Display(Name = "Numer NIP")]
        [Remote(action: "CzyPodanyNipIsnieje", controller: "Company", ErrorMessage = "Podany NIP już istnieje")]
        [Required(ErrorMessage = "Wprowadz numer NIP")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Numer NIP składa się z 10 cyfr")]
        [RegularExpression(pattern: @"^[0-9\-\(\) ]*[0-9\-\(\)]*$", ErrorMessage = "Wprowadziłeś błędny znak, wprowadz cyfrę")]
        public string Nip {get; private set;}

        [StringLength(64)]
        [Required(ErrorMessage = "Nazwa ulicy jest wymagana")]
        public string Street {get; private set;}

        [StringLength(6, MinimumLength = 6, ErrorMessage = "Kod pocztowy składa się z 6 znaków")]
        [Display(Name = "Kod pocztowy")]
        [RegularExpression(pattern: @"^\d{2}-\d{3}$", ErrorMessage = "Kod pocztowy ma postać 11-111")]
        public string ZipCode {get; private set;}

        private Company(){}
    }
}