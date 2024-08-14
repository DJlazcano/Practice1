namespace Practice1
{
    internal class BMICalculator
    {

        public static void bmiCalculator()
        {
            Console.WriteLine("Please enter your weight in kilograms: ");
            var weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your height in meters: ");
            var height = float.Parse(Console.ReadLine());

            float bmi = calculateBmi(weight, height);

            Console.WriteLine("Your BMI is: {0}, and your category is: {1}\n", bmi.ToString("#.##"),
                bmi < 18.5 ? "Underweight" :
                (bmi > 18.5 && bmi <= 24.9) ? "Normal Weight" :
                (bmi > 25 && bmi <= 29.9) ? "Overweight" : "Obesity");
        }

        private static float calculateBmi(float weight, float height)
        {
            var bmi = weight / (height * height);
            if (height > 2)
            {
                bmi *= 10000;
            }

            return bmi;
        }
    }
}