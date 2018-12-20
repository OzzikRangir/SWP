using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using Swp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Swp.Identity
{
    public class UserStore : IUserStore<Uzytkownik>, IUserPasswordStore<Uzytkownik>
    {
        private readonly SwpContext db;

        public UserStore(SwpContext db)
        {
            this.db = db;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                db?.Dispose();
            }
        }

        public Task<string> GetUserIdAsync(Uzytkownik user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Iduzytkownika.ToString());
        }

        public Task<string> GetUserNameAsync(Uzytkownik user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Login);
        }

        public Task SetUserNameAsync(Uzytkownik user, string userName, CancellationToken cancellationToken)
        {
            throw new NotImplementedException(nameof(SetUserNameAsync));
        }

        public Task<string> GetNormalizedUserNameAsync(Uzytkownik user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException(nameof(GetNormalizedUserNameAsync));
        }

        public Task SetNormalizedUserNameAsync(Uzytkownik user, string normalizedName, CancellationToken cancellationToken)
        {
            return Task.FromResult((object)null);
        }

        public async Task<IdentityResult> CreateAsync(Uzytkownik user, CancellationToken cancellationToken)
        {
            db.Add(user);

            await db.SaveChangesAsync(cancellationToken);

            return await Task.FromResult(IdentityResult.Success);
        }

        public Task<IdentityResult> UpdateAsync(Uzytkownik user, CancellationToken cancellationToken)
        {
            throw new NotImplementedException(nameof(UpdateAsync));
        }

        public async Task<IdentityResult> DeleteAsync(Uzytkownik user, CancellationToken cancellationToken)
        {
            db.Remove(user);

            int i = await db.SaveChangesAsync(cancellationToken);

            return await Task.FromResult(i == 1 ? IdentityResult.Success : IdentityResult.Failed());
        }

        public async Task<Uzytkownik> FindByIdAsync(string userId, CancellationToken cancellationToken)
        {
            if (int.TryParse(userId, out int id))
            {
                return await db.Uzytkownik.FindAsync(id);
            }
            else
            {
                return await Task.FromResult((Uzytkownik)null);
            }
        }

        public async Task<Uzytkownik> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
        {
            return await db.Uzytkownik
                           .AsAsyncEnumerable()
                           .SingleOrDefault(p => p.Login.Equals(normalizedUserName, StringComparison.OrdinalIgnoreCase), cancellationToken);
        }

        public Task SetPasswordHashAsync(Uzytkownik user, string passwordHash, CancellationToken cancellationToken)
        {
            user.Haslo = passwordHash;

            return Task.FromResult((object)null);
        }

        public Task<string> GetPasswordHashAsync(Uzytkownik user, CancellationToken cancellationToken)
        {
            return Task.FromResult(user.Haslo);
        }

        public Task<bool> HasPasswordAsync(Uzytkownik user, CancellationToken cancellationToken)
        {
            return Task.FromResult(!string.IsNullOrWhiteSpace(user.Haslo));
        }
    }
}
