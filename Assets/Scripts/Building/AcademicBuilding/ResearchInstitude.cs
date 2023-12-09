public class ResearchInstitute : Building
{
    public ResearchInstitute()
    {
        init_limit = 1;
        unlock_science = 500;
        unlock_productivity = 300;
        unlock_electricity = 500;
        cost_gold = 3000;
        cost_wood = 1000;
        cost_stone = 1000;
        cost_copper = 500;
        cost_iron = 500;
        yield_science = 100;
        lower_building_limit_incre.Add("University", 1);
    }

    public override void updateBonus()
    {
        if (cell.electricity >= 1000)
        {
            yield_science += 100;
        }
    }
}