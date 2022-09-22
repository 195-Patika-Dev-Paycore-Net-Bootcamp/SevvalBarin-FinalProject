using FinalProject.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FinalProject.Repository
{
    public interface IAccountRepository
    {
        Task<Account> GetAccount(int id);
        Task<IEnumerable<Account>> GetAllCountries();
        Task AddAccount(Account account);
        Task<Account> UpdateAccount(Account account);
        Task<Account> DeleteAccount(int id);
    }
}
