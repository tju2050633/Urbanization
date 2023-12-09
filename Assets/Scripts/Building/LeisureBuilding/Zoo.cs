public class Zoo : Building
{
    public Zoo()
    {
        init_limit = 3;
        unlock_culture = 50;
        unlock_science = 50;
        cost_gold = 500;
        cost_wood = 200;
        cost_stone = 200;
        yield_culture = 20;
        yield_happiness = (0, 10);
    }
}