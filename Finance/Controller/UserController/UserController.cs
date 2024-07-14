using Finance.Controller;
using Finance.Data.Repositories;
using Finance.Helpers;
using Finance.Helpers.Validations;
using Finance_Project.Model.Entities;
using System.Windows.Forms;

public interface IUserController
{

}

public class UserController : ControllerBase, IUserController
{
    private readonly UserRepository _repository;

    public UserController()
    {
        _repository = new UserRepository();
    }

    public Result Register(string name, string email, string password)
    {
        if (!Validations.EmailIsValid(email))
            return Unsuccessful("Email no formato inválido!");

        var user = new User
        {
            Name = name,
            Email = email,
            Password = password.PasswordHasher()
        };

        _repository.Register(user);

        if (!_repository.Save())
            return Unsuccessful("Falha ao salvar o usuário!");

        return Successful("Usuário cadastrado com sucesso!");
    }

    public bool Login(string password)
    {
        var user = _repository.GetUser();

        if(user == null)
            return false;

        return password.VerifyPassword(user.Password);
    }
}
