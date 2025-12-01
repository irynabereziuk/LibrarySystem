using LibrarySystem;
using System;

namespace LibrarySystem
{
    internal class SecureLibraryServiceDecorator: ILibraryService
    {
        private readonly ILibraryService _service;
        private readonly AuthorizationService _auth;
        private readonly UserRBAC _user;

        public SecureLibraryServiceDecorator(
            ILibraryService service,
            AuthorizationService authorizationService,
            UserRBAC user)
        {
            _service = service;
            _auth = authorizationService;
            _user = user;
        }

        private void EnsurePermission(string code)
        {
            if (!_auth.CheckPermission(_user, code))
                throw new UnauthorizedAccessException($"Доступ заборонено! Потрібний дозвіл: {code}");
        }

        public void LendBook(string title)
        {
            EnsurePermission("LEND_BOOK");
            _service.LendBook(title);
        }

        public void ReturnBook(string title)
        {
            EnsurePermission("RETURN_BOOK");
            _service.ReturnBook(title);
        }

        public void AddNewBook(string title, string author)
        {
            EnsurePermission("ADD_NEW_BOOK");
            _service.AddNewBook(title, author);
        }
    }
}
