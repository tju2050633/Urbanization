public class MilitaryBase : Building
{
    public MilitaryBase()
    {
        init_limit = 1;
        unlock_military = 300;
        unlock_productivity = 300;
        unlock_electricity = 100;
        cost_gold = 2000;
        cost_wood = 800;
        cost_stone = 800;
        cost_copper = 200;
        cost_iron = 200;
        yield_military = 50;
        lower_building_limit_incre.Add("Barrack", 3);
        lower_building_limit_incre.Add("Hangar", 2);
    }
}