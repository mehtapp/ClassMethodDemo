
using ClassMethodDemo;

Console.WriteLine("Hello, World!");
List<Customer> customers;
customers = new List<Customer>()
            {
                    new Customer
                    {
                        Id = 1,
                        CustomerName = "Sinem",
                        CustomerSurname = "Soysuz",
                        CustomerPhone = "0000 000 00 00"
                    },
                    new Customer
                    {
                        Id = 2,
                        CustomerName = "Mehmet",
                        CustomerSurname = "Can",
                       CustomerPhone = "0000 000 00 00"

                    },
                    new Customer
                    {
                        Id = 3,
                        CustomerName = "Ahmet",
                        CustomerSurname = "Keresteci",
                        CustomerPhone = "0000 000 00 00"
                    },
                    new Customer
                    {
                        Id = 4,
                        CustomerName = "Sıla",
                        CustomerSurname = "Samanyolu",
                        CustomerPhone = "0000 000 00 00"
                    },
                    new Customer
                    {
                        Id = 5,
                        CustomerName = "İrem",
                        CustomerSurname = "Gül",
                        CustomerPhone = "0000 000 00 00"
                    }
            };

CustomerManager customerManager = new CustomerManager();

Console.WriteLine("Müşteri listesine erişmektesiniz.");
foreach (var customer in customerManager.GetAllCustomer(customers))
{
    Console.WriteLine(customer.Id);
    Console.WriteLine(customer.CustomerName);
    Console.WriteLine(customer.CustomerSurname);
    Console.WriteLine(customer.CustomerPhone);
    Console.WriteLine();
}
Customer addedCustomer = new Customer { Id = 100, CustomerName = "Mahmut", CustomerSurname = "Kuş", CustomerPhone = "0000 000 00 00 " };
Customer deletedCustomer = customers[2];

customerManager.AddCustomer(customers, addedCustomer);


Console.WriteLine("Yeni müşteri eklendikten sonraki liste");
Console.WriteLine();
foreach (var customer in customerManager.GetAllCustomer(customers))
{
    Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname);
}



customerManager.DeleteCustomer(customers, deletedCustomer);
Console.WriteLine("Ahmet Keresteci adlı müşteri silindikten sonraki liste");
Console.WriteLine();
foreach (var customer in customerManager.GetAllCustomer(customers))
{
    Console.WriteLine(customer.CustomerName + " " + customer.CustomerSurname);
}



