namespace Snake2._0.Meal
{
    public interface IMealBehavior
    {
        Meal SetMealOnArena(FieldType[][] playGround);
        void AddMealToArena(int mealCounter);
        Meal MealContainer();
    }
}