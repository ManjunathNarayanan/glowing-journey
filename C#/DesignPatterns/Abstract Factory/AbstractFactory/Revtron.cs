namespace AbstractFactoryWithInterface
{
    public class Revtron : ICarEngine
    {
        public string GetEngineInfo()
        {
            return "Revtron Engine for Petrol/Diesel Cars...";
        }
    }
}