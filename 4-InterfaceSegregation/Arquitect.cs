namespace InterfaceSegregation
{
    public class Arquitect : IActivities
    {
        public Arquitect()
        {
        }

        public void Plan() 
        {
            throw new ArgumentException();
        }

        public void Comunicate() 
        {
            throw new ArgumentException();
        }

        public void Develop() 
        {
            Console.WriteLine("I'm developing the functionalities required");
        }

        public void Design()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}