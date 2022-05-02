using LOGINREPOSITORY.Models;
using LOGINREPOSITORY.ViewModel;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LOGINREPOSITORY.Repository
{
    public class AccountService : IStudent
    {
        private ApplicationDbContext DbContext;
        public AccountService()
        {
            DbContext = new ApplicationDbContext();

        }
        public bool SignIn(SignInModel model)
        {
            var result = DbContext.students.SingleOrDefault(e => e.Email == model.Email && e.Password == model.Password);
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SignUp(SignUpModel model)
        {
            var user = new Student()
            {
                Fname = model.Fname,
                Lname = model.Lname,
                Email = model.Email,
                Password = model.ConfirmPassword,
                Gender = model.Gender,
            };
            DbContext.students.Add(user);
            DbContext.SaveChanges();

        }
    }
}
