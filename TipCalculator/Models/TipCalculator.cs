using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage ="A value is required")]
        [Range(0, 999999999, ErrorMessage ="Invalid Amount. Must be > 0 or < 999999999")]
        public double? MealCost { get; set; }

        public double CalculateTip(double percentage)
        {
            if (MealCost.HasValue)
            {
                return MealCost.Value * percentage;
            }
            else return 0;
        }
        //STEP 1: 
        /*
        Using the FutureValueModel class from the FutureValue app as a guide, 
        you're going to configure a data model that requires a public double
        property called "MealCost".  It should have 
        1. default get and set accessors
        2. It should have a Required attribute with an appropriate message
        3. It should have a Range attribute for a value greater than zero and below some very large value
        */

        //STEP 2:
        /*
        Using the CalculateFutureValue() method from the FutureValueModel class as a guide, 
        create a method called CalculateTip.
        1. It should return a double and take a double as an argument.
        2. The argument should represent the percentage of the tip in 0 <= % <= 1 format.
        3. If MealCost.HasValue is true, return MealCost.Value * the percentage,
        otherwise return 0
        */

        //PROCEED TO HomeController.cs NEXT...
    }
}
