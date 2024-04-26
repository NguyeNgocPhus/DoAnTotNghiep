using DoAn.Shared.Abstractions.Messages;
using DoAn.Shared.Services.V1.Identity.Responses;

namespace DoAn.Shared.Services.V1.Identity.Commands;

public class CreateUserCommand : ICommand<UserResponse>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string UserName { get; set; }
    public string PhoneNumber { get; set; }
    public List<string> Roles { get; set; } = new();
}