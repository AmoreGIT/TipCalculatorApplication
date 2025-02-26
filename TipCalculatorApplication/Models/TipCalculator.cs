namespace TipCalculatorApplication.Models
{
    public class TipCalculator
    {
        public decimal MealCost { get; set; }

        public decimal CalculateTip(decimal percentage)
        {
            return MealCost * percentage;
        }
    }
}
