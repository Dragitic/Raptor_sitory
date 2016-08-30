namespace Snake2._0
{
    public interface IArenaRules
    {
        FieldType[][] SetBoundaries(FieldType[][] playGround);
        MealPosition SetMealOnArena(FieldType[][] playGround);
        void AddMealToArena();
    }
}