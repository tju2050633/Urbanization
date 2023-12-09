public class AmusementPark : Building
{
    public AmusementPark()
    {
        init_limit = 1;
        unlock_culture = 500;
        unlock_productivity = 300;
        unlock_electricity = 100;
        cost_gold = 5000;
        cost_wood = 2000;
        cost_stone = 2000;
        cost_copper = 500;
        cost_iron = 500;
        yield_culture = 50;
        yield_happiness = (1, 100);
    }
}