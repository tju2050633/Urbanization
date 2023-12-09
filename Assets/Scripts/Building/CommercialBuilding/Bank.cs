public class Bank : Building
{
    public Bank()
    {
        init_limit = 3;
        unlock_commercialization = 50;
        cost_gold = 500;
        cost_wood = 200;
        cost_stone = 200;
        yield_commercialization = 20;
        yield_gold_incre = 20;
    }
}