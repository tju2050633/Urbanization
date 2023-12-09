public class Factory : Building
{
    public Factory()
    {
        init_limit = 3;
        unlock_productivity = 50;
        cost_gold = 500;
        cost_wood = 200;
        cost_stone = 200;
        yield_productivity = 10;
        yield_pollution = (3, 10);
    }
}