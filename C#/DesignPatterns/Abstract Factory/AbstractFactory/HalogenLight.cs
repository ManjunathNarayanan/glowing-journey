namespace AbstractFactoryWithInterface
{
    public class HalogenLight : ICarLight
    {
        public string GetLightInfo()
        {
            return "Halogen Light";
        }
    }
}
