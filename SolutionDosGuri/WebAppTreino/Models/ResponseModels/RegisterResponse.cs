﻿namespace WebAppTreino.Models.ResponseModels;

public class RegisterResponse
{
    public Guid? Id { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
}
