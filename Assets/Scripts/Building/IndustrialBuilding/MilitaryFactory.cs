public class MilitaryFactory : Building
{
    public MilitaryFactory()
    {
        init_limit = 3;
        unlock_productivity = 300;
        cost_gold = 2000;
        cost_wood = 800;
        cost_stone = 800;
        cost_copper = 200;
        cost_iron = 200;
        yield_productivity = 30;
        yield_military = 10;
    }
}
