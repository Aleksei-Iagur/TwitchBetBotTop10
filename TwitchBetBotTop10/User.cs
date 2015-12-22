namespace TwitchBetBotTop10
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Coins { get; set; }
        public UserRoles UserLevel { get; set; }
    }
}
