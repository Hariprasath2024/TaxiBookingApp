namespace TaxiBookingApp1.Models
{

    public class Booking
    {
        public int BookingID { get; set; }
        public string CustomerName { get; set; }
        public string DriverName { get; set; }
        public string PickupLocation { get; set; }
        public string DropoffLocation { get; set; }
        public DateTime BookingTime { get; set; }
        public string Status { get; set; }
    }
}
