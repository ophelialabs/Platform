using System.Security.Claims;

namespace cmd_cntr.Services
{
    public class AuthService
    {
        private ClaimsPrincipal? _currentUser;
        public event Action? OnAuthStateChanged;

        public ClaimsPrincipal CurrentUser
        {
            get => _currentUser ?? new ClaimsPrincipal(new ClaimsIdentity());
            set
            {
                _currentUser = value;
                OnAuthStateChanged?.Invoke();
            }
        }

        public bool IsAuthenticated => _currentUser?.Identity?.IsAuthenticated ?? false;

        public string? GetUserName() => _currentUser?.FindFirst(ClaimTypes.Name)?.Value;

        public string? GetRole() => _currentUser?.FindFirst(ClaimTypes.Role)?.Value;

        public bool HasRole(string role) => _currentUser?.IsInRole(role) ?? false;

        public void Login(string userName, string role)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, userName),
                new Claim(ClaimTypes.Role, role),
                new Claim("oid", Guid.NewGuid().ToString()), // Object ID like Azure AD
                new Claim("tid", Guid.NewGuid().ToString()), // Tenant ID
            };

            var identity = new ClaimsIdentity(claims, "mock");
            CurrentUser = new ClaimsPrincipal(identity);
        }

        public void Logout()
        {
            CurrentUser = new ClaimsPrincipal(new ClaimsIdentity());
        }
    }
}
