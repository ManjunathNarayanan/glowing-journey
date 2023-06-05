namespace AbstractFactoryWithInterface
{
    public class MarutiFactory : ICarFactory
    {
        public ICarEngine GetCarEngine()
        {
            return new DDiS();
        }

        public ICarLight GetCarLight()
        {
            return new LEDLight();
        }
    }
}
