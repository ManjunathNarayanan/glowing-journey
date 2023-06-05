namespace AbstractFactoryWithInterface
{
    public interface ICarFactory
    {
        ICarEngine GetCarEngine();
        ICarLight GetCarLight();
    }
}
