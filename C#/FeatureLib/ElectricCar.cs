
namespace FeatureLib
{
    public class ElectricCar: Car
    {
        public string Fly()
        {
            return "Car isi flying";
        }

        public override void Undefined()
        {
            throw new System.NotImplementedException();
        }

        public override void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}
