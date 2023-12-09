public class Barrack : Building
{
    public Barrack()
    {
        init_limit = 3;
        unlock_military = 50;
        cost_gold = 500;
        cost_wood = 200;
        cost_stone = 200;
        yield_military = 10;
    }
}