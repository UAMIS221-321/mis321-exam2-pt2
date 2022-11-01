namespace exam2_part3_fall22_test
{
    public interface IGetStats
    {
        List<QBStats> GetQBStats();
        List<RBStats> GetRBStats();
        List<WRStats> GetWRStats();
    }
}