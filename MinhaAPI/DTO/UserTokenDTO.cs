using MinhaAPI.Entity;

namespace MinhaAPI.DTO
{
    public class UserTokenDTO
    {
        public string Token { get; set; }
        public UserEntity User { get; set; }
    }
}
