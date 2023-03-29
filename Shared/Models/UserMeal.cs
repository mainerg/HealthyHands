﻿namespace HealthyHands.Shared.Models
{
    public class UserMeal
    {
        public string UserMealId { get; set; }
        public string MealName { get; set; }
        public DateTime MealDate { get; set; }
        public int? Calories { get; set; }
        public int? Protein { get; set; }
        public int? Carbs { get; set; }
        public int? Fat { get; set; }
        public int? Sugar { get; set; }
        public string ApplicationUserId { get; set; } = string.Empty;
    }
}
