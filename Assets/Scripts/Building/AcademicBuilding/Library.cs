public class Library : Building
{
    public Library()
    {
        init_limit = 3;
        unlock_science = 150;
        unlock_culture = 150;
        cost_gold = 800;
        cost_wood = 300;
        cost_stone = 300;
        yield_science = 15;
        yield_culture = 10;
        lower_building_limit_incre.Add("PrimarySchool", 1);
        lower_building_limit_incre.Add("MiddleSchool", 1);
    }
}