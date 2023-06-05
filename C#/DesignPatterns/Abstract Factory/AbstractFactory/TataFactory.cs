namespace AbstractFactoryWithInterface
{
    public class TataFactory : ICarFactory
    {
        public ICarEngine GetCarEngine()
        {
            return new Revtron();
        }

        public ICarLight GetCarLight()
        {
            return new HalogenLight();
        }
    }
}
