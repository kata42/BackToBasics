
namespace FeatureLib
{   
    public abstract class Car: IVehicle
    {
        public static int count = 0;

        public string color;
        public string model;
        public int year;

        public Car()
        {
            color = "blue";
            count++;
        }

        public Car(string initColor)
        {
            color = initColor;
            count++;
        }

        public Car(string initColor,string initModel,int initYear)
        {
            color = initColor;
            model = initModel;
            year = initYear;
            count++;
        }

        public string GetColor()
        {
            return color;
        }

        public virtual void Move()
        {
            throw new System.NotImplementedException();
        }

        public abstract void Undefined();

        //internal string GetColor(string area)
        //{
        //    switch (area)
        //    {
        //        case "interior":
        //            return "Black";
        //        case "Wheels":
        //            return "white";
        //        case "Roof":
        //            return "blue";
        //        default:
        //            return "No Color";
        //    }
        //}
    }
}
