using Finance_Project.Model.Entities;
using static Finance.Controller.Services.UserControllers;

public class UserController
{
    private readonly UserRepository _repository;

    public UserController()
    {
        _repository = new UserRepository();
    }

    public void Register(string name, string email, string password)
    {
        var user = new User
        {
            Name = name,
            Email = email,
            Password = password
        };

        _repository.SaveUser(user);
        MessageBox.Show("Usuario registrado com sucesso!");
    }

    public bool Login(string password)
    {
        var user = _repository.GetUserByPassword(password);
        return user != null;
    }
}
