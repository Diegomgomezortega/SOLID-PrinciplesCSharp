namespace InterfaceSegregation
{
    public interface IActivities: IDevActivities,IDesignActivities,IWorkTeamActivities,ITestActivities
    {
        //Remuevo todas los metodos de la interface, e implemento
        //Desde cada una de las que fui creando

        // void Plan();
        // void Comunicate();
        // void Design();
        // void Develop();
        // void Test();
    }
}