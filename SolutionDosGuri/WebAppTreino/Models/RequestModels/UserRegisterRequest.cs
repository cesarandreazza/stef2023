﻿namespace WebAppTreino.Models.RequestModels;

public class UserRegisterRequest
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string PhoneNumber { get; set; } = string.Empty;
}
