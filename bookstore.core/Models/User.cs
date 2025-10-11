namespace bookstore.core.Models;

public class User
{

    public User(int id, string name, string email, string psw, string contactNumber)
    {
        this.Id = id;
        this.Name = name;
        this.Email = email;
        this.ContactNumber = contactNumber;
        this.Psw = psw;
    }

    public User(int id, string name)
    {
        this.Id = id;
        this.Name = name;
        this.Email = string.Empty;
        this.ContactNumber = string.Empty;
        this.Psw = string.Empty;
    }

    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Email { get; private set; }
    public string Psw { get; private set; }
    public string ContactNumber { get; private set; }
}