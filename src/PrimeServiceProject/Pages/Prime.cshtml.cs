using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PrimeServiceProject.Pages
{
    public class PrimeModel : PageModel
    {
        [BindProperty]
        public String Message { get; set; }

        [BindProperty]
        public PrimeService primeService { get; set; }

        public IActionResult OnGet()
        {
            Message = "Waiting for number...";
            if (primeService == null)
            {
                primeService = new PrimeService();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if(ModelState.IsValid)
            {
                if(primeService.IsPrime(primeService.number))
                    Message = "Prime";
                else
                    Message = "Not Prime";
            }

            return Page();
        }
    }

    public class PrimeService
    {
        [Required]
        [Display(Name = "Enter Number:")]
        public int number { get; set; }
        public String result { get; set; }

        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            //if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}