public class StockExchange : Building
{
    public StockExchange()
    {
        init_limit = 1;
        unlock_commercialization = 300;
        unlock_electricity = 100;
        cost_gold = 2000;
        cost_wood = 800;
        cost_stone = 800;
        cost_copper = 200;
        cost_iron = 200;
        yield_commercialization = 60;
        yield_gold_incre = 100;
        lower_building_limit_incre.Add("Bank", 2);
    }
}