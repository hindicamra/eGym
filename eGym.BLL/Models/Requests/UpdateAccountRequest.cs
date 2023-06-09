﻿using eGym.BLL.Models.Enums;

namespace eGym.BLL.Models.Requests;

public class UpdateAccountRequest
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Username { get; set; }
    public string? Password { get; set; }
    public DateTime? BirthDate { get; set; }
}

