using LOGINREPOSITORY.ViewModel;

namespace LOGINREPOSITORY.Repository
{
    public interface IStudent
    {
        bool SignIn(SignInModel model);
        void SignUp(SignUpModel model);
    }
}
