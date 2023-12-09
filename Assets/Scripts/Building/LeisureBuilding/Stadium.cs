public class Stadium : Building
{
    public Stadium()
    {
        init_limit = 2;
        unlock_culture = 100;
        unlock_productivity = 200;
        cost_gold = 1000;
        cost_wood = 400;
        cost_stone = 400;
        cost_copper = 100;
        cost_iron = 100;
        yield_culture = 20;
        yield_happiness = (0, 30);
    }
}