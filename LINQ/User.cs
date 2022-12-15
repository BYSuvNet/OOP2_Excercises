class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get => FirstName + " " + LastName; }
    public DateTime DateOfBirth { get; set; }
    public string Country { get; set; }
    public int DataStored { get; set; }
    public string Email { get; set; }

    public static List<User> GetRandomListOfUsers(int amount = 100)
    {
        List<User> users = new();

        for (int i = 0; i < amount; i++)
        {
            users.Add(new User()
            {
                FirstName = Faker.Name.First(),
                LastName = Faker.Name.Last(),
                DateOfBirth = Faker.Identification.DateOfBirth(),
                Country = Faker.Address.Country(),
                DataStored = Faker.RandomNumber.Next(1000, 9999999),
                Email = Faker.Internet.Email()
            });
        }

        return users;
    }
}