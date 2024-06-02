class Program
{
    static void Main()
    {
        // Create an address
         Address a = new Address
        {
            _street = "193",
            _city = "Port Moresby",
            _state = "NCD",
            _zipCode = "111"
        };

        // Create event instances
        LectureEvent e1 = new LectureEvent("Programming with Classes", "Inheritance", DateTime.Now, TimeSpan.FromHours(2), eventAddress, "Dr. Smith", 100);
        ReceptionEvent e2 = new ReceptionEvent("Programming with clasess", "Connect with recruiters", DateTime.Now.AddDays(7), TimeSpan.FromHours(3), eventAddress, "rsvp@example.com");
        OutdoorEvent e3 = new OutdoorEvent("Visit to the park ", "Enjoy watching the birds", DateTime.Now.AddDays(14), TimeSpan.FromHours(4), eventAddress, "Sunny with a chance of clouds");

        // Generate marketing messages
        Console.WriteLine("Standard Details:");
        Console.WriteLine(e1.GetStandardDetails());
        Console.WriteLine(e2.GetStandardDetails());
        Console.WriteLine(e3.GetStandardDetails());

        // Call other methods as needed

        // Note: You can add more events and customize their attributes as desired.
    }
}
