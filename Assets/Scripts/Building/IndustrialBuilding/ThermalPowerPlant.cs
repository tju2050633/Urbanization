public class ThermalPowerPlant : Building
{
    public ThermalPowerPlant()
    {
        init_limit = 5;
        unlock_productivity = 500;
        cost_gold = 5000;
        cost_wood = 2000;
        cost_stone = 2000;
        cost_copper = 500;
        cost_iron = 500;
        yield_productivity = 50;
        yield_electricity = (6, 10);
        yield_pollution = (3, 10);
    }

    public override void updateBonus()
    {
        if (yield_science >= 100)
        {
            yield_productivity += 20;
        }
    }
}