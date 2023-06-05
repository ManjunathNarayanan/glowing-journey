namespace AbstractFactoryWithInterface
{
    public class Client
    {
        private ICarFactory _carFactory = null;

        public void CreateCarWithLight(string carName)
        {
            if(carName.ToLower() == "maruti")
            {
                _carFactory = new MarutiFactory();
            }
            else if(carName.ToLower() == "tata")
            {
                _carFactory = new TataFactory();                
            }

            if(_carFactory != null)
                Console.WriteLine($"{carName} uses {_carFactory.GetCarEngine().GetEngineInfo()} with {_carFactory.GetCarLight().GetLightInfo()} as headlight!");
        }
    }
}