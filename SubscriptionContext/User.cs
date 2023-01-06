using Bruno.SharedContext;

namespace Bruno.SubscriptionContext
{
    public class User : Base
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = null!; // nao tenho o valor no momento mas ele nao será nulo no futuro
    }
}