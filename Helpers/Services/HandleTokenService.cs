﻿namespace ToDoList.Helpers.Services
{
    public class HandleTokenService : IHandleTokenService
    {
        public async Task<string> IsTokenExist()
        {
            string? accessToken = await SecureStorage.Default.GetAsync("access_token");

            return accessToken is null ? throw new Exception("No existe un token") : accessToken;
        }

        public async Task<(bool success, string? value)> HandleTokenAsync(TypeActionToken typeAction, string? token = null)
        {
            switch (typeAction)
            {
                case TypeActionToken.Save:

                    if (string.IsNullOrWhiteSpace(token)) throw new Exception("Se debe proporcionar un token");

                    await SecureStorage.Default.SetAsync("access_token", token);

                    return (true, null);

                case TypeActionToken.Get:

                    return (true, await IsTokenExist());

                case TypeActionToken.Delete:
                    bool success = SecureStorage.Default.Remove("access_token");
                    return (success, success ? null : "No se pudo eliminar el token.");

                default:
                    throw new ArgumentOutOfRangeException(nameof(typeAction), "Acción no válida para el token.");
            }
        }
    }
}
