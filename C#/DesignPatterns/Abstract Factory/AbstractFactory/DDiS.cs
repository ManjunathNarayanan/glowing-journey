namespace AbstractFactoryWithInterface
{
    internal class DDiS : ICarEngine
    {
        public string GetEngineInfo()
        {
           return "DDiS Engine for Diesel Cars...";
        }
    }
}
