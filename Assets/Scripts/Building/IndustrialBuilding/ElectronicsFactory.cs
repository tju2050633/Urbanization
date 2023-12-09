public class ElectronicsFactory : Building
{
    public ElectronicsFactory()
    {
        init_limit = 2;
        unlock_productivity = 100;
        cost_gold = 1000;
        cost_wood = 400;
        cost_stone = 400;
        cost_copper = 100;
        cost_iron = 100;
        yield_productivity = 20;
    }

    public override void updateBonus()
    {
        if (yield_science >= 50)
        {
            yield_productivity += 10;
        }
    }
}