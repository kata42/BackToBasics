
namespace FeatureLib
{   
    public class Car
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

        internal virtual string GetColor()
        {
            return color;
        }

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
