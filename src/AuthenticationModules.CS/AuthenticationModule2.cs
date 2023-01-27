using System.Threading;
using System.Threading.Tasks;
using Storex;

namespace AuthenticationModules
{
    [AuthenticationModuleExport("faf8d1ba-dd95-48d8-8f2e-146c3ad81681", "簡易認証 (氏名選択)", Description = "CSVファイル (ID と 氏名) を使用します")]
    public class AuthenticationModule2 : IAuthenticationModule
    {
        public bool IsConfiguable => true;

        public Task ConfigureAsync(CancellationToken cancellationToken)
        {
            AuthenticationModuleHelper.PickUsersFileAndSaveToSetting();

            return Task.CompletedTask;
        }

        public Task<IUser> AuthenticateAsync(CancellationToken cancellationToken)
        {
            IUser user = AuthenticationForm2.Authenticate();

            return Task.FromResult(user);
        }

        public void Dispose()
        {
        }
    }
}