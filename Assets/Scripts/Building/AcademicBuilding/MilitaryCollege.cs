public class MilitaryCollege : Building
{
    public MilitaryCollege()
    {
        init_limit = 1;
        unlock_science = 300;
        unlock_military = 300;
        unlock_productivity = 100;
        unlock_electricity = 200;
        cost_gold = 2000;
        cost_wood = 800;
        cost_stone = 800;
        cost_copper = 500;
        cost_iron = 500;
        yield_science = 20;
        yield_military = 10;
        lower_building_limit_incre.Add("MiddleSchool", 2);
    }

    public override void updateBonus()
    {
        if (cell.electricity >= 500)
        {
            yield_science += 10;
            yield_military += 5;
        }
    }
}