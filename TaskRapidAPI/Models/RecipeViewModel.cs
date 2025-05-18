namespace TaskRapidAPI.Models
{
    public class RecipeViewModel
    {
            public string id { get; set; }
            public string name { get; set; }
            public string[] tags { get; set; }
            public string description { get; set; }
            public int prepareTime { get; set; }
            public int cookTime { get; set; }
            public Ingredient[] ingredients { get; set; }
            public string[] steps { get; set; }
            public int servings { get; set; }
            public Servingsize1[] servingSizes { get; set; }
            public Nutrients nutrients { get; set; }
            public string image { get; set; }
        public class Nutrients
        {
            public float caloriesKCal { get; set; }
            public float totalCarbs { get; set; }
            public float diabetesCarbsADA { get; set; }
            public float netCarbs { get; set; }
            public float diabetesCarbs { get; set; }
            public float fiber { get; set; }
            public float sugar { get; set; }
            public float sugarAlcohols { get; set; }
            public float protein { get; set; }
            public float fat { get; set; }
            public float monousatFat { get; set; }
            public float polyunsatFat { get; set; }
            public float saturatedFat { get; set; }
            public float cholesterol { get; set; }
            public float vitaminA { get; set; }
            public float vitaminC { get; set; }
            public float vitaminD { get; set; }
            public float vitaminE { get; set; }
            public float vitaminK { get; set; }
            public float vitaminB1 { get; set; }
            public float vitaminB2 { get; set; }
            public float vitaminB3 { get; set; }
            public float vitaminB6 { get; set; }
            public float vitaminB12 { get; set; }
            public float potassium { get; set; }
            public float magnesium { get; set; }
            public float calcium { get; set; }
            public float iron { get; set; }
            public float zinc { get; set; }
            public float copper { get; set; }
            public float phosphorus { get; set; }
            public float sodium { get; set; }
            public float selenium { get; set; }
            public float folate { get; set; }
            public float choline { get; set; }
        }

        public class Ingredient
        {
            public string name { get; set; }
            public Servingsize servingSize { get; set; }
        }

        public class Servingsize
        {
            public string units { get; set; }
            public string desc { get; set; }
            public float qty { get; set; }
            public float grams { get; set; }
            public float scale { get; set; }
        }

        public class Servingsize1
        {
            public float scale { get; set; }
            public float qty { get; set; }
            public float grams { get; set; }
            public string units { get; set; }
        }

    }
}
