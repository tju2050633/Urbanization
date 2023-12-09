public class Theater : Building
{
    public Theater()
    {
        init_limit = 5;
        unlock_culture = 0; // 无需解锁条件
        cost_gold = 100;
        cost_wood = 50;
        cost_stone = 50;
        yield_culture = 10;
    }
}