using OnlineCourse.Api.Models;

using (CustomerDbContext db=new CustomerDbContext())
{
    Customer customer1 = new Customer
    {
        FirstName = "Ali",
        PhoneNumber = "+998901404040",
        Email = "Example@mail.ru",
        BuyCourse = "Dotnet"
    };
    Customer customer2 = new Customer
    {
        FirstName = "Vali",
        PhoneNumber = "+998901404041",
        Email = "Example2@mail.ru",
        BuyCourse = "PHP"
    };
    db.Add(customer1);
    db.Add(customer2);
    db.SaveChanges();
    Console.WriteLine("Malumotlar Saqlandi");

    var customers=db.Customers.ToList();
    Console.WriteLine("Ro'yxati: ");

    foreach(var customer in customers)
    {
        Console.WriteLine($"{customer.ID}.{customer.FirstName} " +
            $" PhoneNumber: {customer.PhoneNumber} Bought course: {customer.BuyCourse}");
    }







}