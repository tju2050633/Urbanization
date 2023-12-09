public class FinancialCenter : Building
{
    public FinancialCenter()
    {
        init_limit = 1;
        unlock_commercialization = 500;
        unlock_productivity = 300;
        unlock_electricity = 300;
        cost_gold = 5000;
        cost_wood = 2000;
        cost_stone = 2000;
        cost_copper = 500;
        cost_iron = 500;
        yield_commercialization = 100;
        yield_gold_incre = 200;
        lower_building_limit_incre.Add("Company", 5);
    }
}