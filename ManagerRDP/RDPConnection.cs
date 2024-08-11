namespace ManagerRDP
{
    internal class RDPConnection
    {
        public string URL { get; set; }
        public int Port { get; set; }

        public string User { get; set; }
        public string Password { get; set; }

        public bool UseVPN { get; set; }
    }
}
