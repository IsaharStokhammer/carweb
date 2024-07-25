namespace carweb.Models
{
    public class Car
    {
        public string Model { get; set; }
        public string Year { get; set; }
        public Car(string model, string year)
        { 
            Model = model;
            Year = year;
        }
    }
}
