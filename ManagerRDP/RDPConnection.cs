namespace ManagerRDP
{
    public class RDPConnection
    {
        public string URL { get; init; }
        public int Port { get; init; }
        public string User { get; init; }
        public string Password { get; init; }
        public bool UseVPN { get; init; }

        public RDPConnection(string uRL, int port, string user, string password, bool useVPN = false)
        {
            URL = uRL;
            Port = port;
            User = user;
            Password = password;
            UseVPN = useVPN;
        }

    }
}
