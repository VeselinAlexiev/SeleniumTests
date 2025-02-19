using Bogus;
using Infrastructure.Models;

public class UserFactory
{
    public static User CreateFakeUser()
    {
        var faker = new Faker<User>()
        .RuleFor(u => u.Username, f => f.Internet.UserName())
        .RuleFor(u => u.Password, f => f.Internet.Password())
        .RuleFor(u => u.Email, f => f.Internet.Email())
        .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber());

        return faker.Generate();
        

    }
}
