//Constructor bir class'ı newlediğimiz de çalışan bloktur.
//bir class ilk kez oluştuğu zaman 2 kere çalışır bir daha çalışmaz.
//constructor:Yapıcı Blok
class Program
{
    static void Main(string[] args)
    {
        Customer customer = new Customer();

        //parametresi olmayan constructor'a default constructor deniyor.

        //bu şekil bir newleme yapığımızda constructor çalışıyor.

        Customer customer1 = new Customer { Id = 1, FirstName = "Özcan", LastName = "öner", City = "Tokat" };

        Customer customer2 = new Customer(1, "Mts", "sahin", "tokat");

        Console.WriteLine(customer2.FirstName);
    }

            // bu şekilde yapmak istiyorsam parametreleri geçmemiz lazım.

    class Customer
    {
        public Customer(int id, string firstName, string lastName, string city)//bu şekilde yaparsak default constructor'u ezmiş oluyoruz.
        {
            Console.WriteLine("Yapıcı Blok çalıştı");

            Id = id;   
            FirstName = firstName;  
            LastName = lastName;    
            City = city;    
                         //method parametreleri camelCase yazılır.
        }

        public Customer() //parametresi olmayan constructor'a default constructor deniyor.
        {
            //default constructor.
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string City { get; set; }
    } }
