public class Museum : Building
{
    public Museum()
    {
        init_limit = 1;
        unlock_culture = 300;
        unlock_productivity = 100;
        cost_gold = 2000;
        cost_wood = 800;
        cost_stone = 800;
        cost_copper = 200;
        cost_iron = 200;
        yield_culture = 30;
        yield_happiness = (1, 50);
        lower_building_limit_incre.Add("Theater", 3);
    }
}