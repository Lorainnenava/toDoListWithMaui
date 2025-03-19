namespace ToDoList.DTOs.User
{
    public class UserCreateRequest
    {
        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(6, MinimumLength = 4)]
        public string Password { get; set; } = string.Empty;
    }
}
