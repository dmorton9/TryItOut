namespace TryItOut.Domain
{
    public interface IRegisteredUser
    {
        string Firstname { get; set; }
        int Identifier { get; set; }
        string Lastname { get; set; }
        string Password { get; set; }
        string Username { get; set; }
    }
}