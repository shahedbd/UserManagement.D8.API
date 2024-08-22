public static class SeedData
{
    public static List<User> GetUsers()
    {
        var users = new List<User>();

        for (int i = 1; i <= 10; i++)
        {
            users.Add(new User
            {
                Id = i,
                Name = $"User {i}",
                DOB = new DateTime(1990, 1, i),
                CreatedDate = DateTime.Now.AddDays(-i)
            });
        }

        return users;
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime DOB { get; set; }
    public DateTime CreatedDate { get; set; }
}