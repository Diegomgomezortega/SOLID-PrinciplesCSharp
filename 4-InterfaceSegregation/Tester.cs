namespace InterfaceSegregation
{
    public class Tester : ITestActivities
    {
        public Tester()
        {
        }

        public void Test() 
        {
            throw new ArgumentException();
        }
    }
}