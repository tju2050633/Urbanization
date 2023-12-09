public class Hangar : Building
{
    public Hangar()
    {
        init_limit = 2;
        unlock_military = 100;
        unlock_productivity = 300;
        cost_gold = 1000;
        cost_wood = 400;
        cost_stone = 400;
        cost_copper = 100;
        cost_iron = 100;
        yield_military = 20;
    }
}