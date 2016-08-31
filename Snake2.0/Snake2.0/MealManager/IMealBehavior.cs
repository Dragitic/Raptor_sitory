namespace Snake2._0.Meal
{
    public interface IMealBehavior
    {
        Meal SetMealOnArena(FieldType[][] playGround);
        FieldType[][] AddMealToArena(int mealCounter);
        Meal MealContainer();
        void CheckIfOnlyOneMealIsOnPlayground(Meal mealContainer);
    }
}