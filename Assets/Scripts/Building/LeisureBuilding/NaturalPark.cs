public class NaturalPark : Building
{
    public NaturalPark()
    {
        init_limit = 1;
        unlock_culture = 200;
        unlock_science = 300;
        unlock_productivity = 300;
        cost_gold = 5000;
        cost_wood = 2000;
        cost_stone = 2000;
        cost_copper = 500;
        cost_iron = 500;
        yield_culture = 20;
        yield_happiness = (2, 100);
        yield_pollution = (6, -50);
        lower_building_limit_incre.Add("Zoo", 3);
        lower_building_limit_incre.Add("AmusementPark", 1);
    }
}