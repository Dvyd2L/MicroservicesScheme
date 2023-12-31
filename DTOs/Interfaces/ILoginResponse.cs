﻿using DTOs.UsersMS;

namespace DTOs.Interfaces;

public interface ILoginResponse
{
    string? AvatarUrl { get; init; }
    string Email { get; init; }
    string Id { get; init; }
    string Nombre { get; init; }
    string Token { get; init; }

    void Deconstruct(out string Id, out string Nombre, out string? AvatarUrl, out string Email, out string Token);
    bool Equals(LoginResponse? other);
    bool Equals(object? obj);
    int GetHashCode();
    string ToString();
}
