public class NuclearPowerPlant : Building
{
    public NuclearPowerPlant()
    {
        init_limit = 1;
        unlock_productivity = 500;
        cost_gold = 5000;
        cost_wood = 2000;
        cost_stone = 2000;
        cost_copper = 500;
        cost_iron = 500;
        yield_productivity = 100;
        yield_electricity = (6, 200);
    }

    public override void updateBonus()
    {
        if (yield_science >= 300)
        {
            yield_productivity += 100;
        }
    }
}