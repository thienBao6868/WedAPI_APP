namespace WedAPI_APP.Models
{
    public class MerchandiseVM
    {
        public string? MerchandiseName { get; set; }
        public double Prices { get; set; }
    }
    public class Merchandise : MerchandiseVM
    { 
        public int MerchandiseCode { get; set; }
    }
}
