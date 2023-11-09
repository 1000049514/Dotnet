namespace AbstractFactory{

    public interface ICar{
        string name {get;}
    }

    public class SedanCar : ICar
    {
        public string name =>  "Sedan";
    }

    public class SportsCar : ICar
    {
        public string name => "Sports Car";
    }

    public interface IAutomobileFactory{
        ICar CreateSedanCar();
        ICar CreateSportCar();
    }

    public class AutomobileFactory : IAutomobileFactory
    {
          public ICar CreateSedanCar()
        {
            return new SedanCar();
        }

        public ICar CreateSportCar()
        {
            return new SportsCar();
        }
    }
}