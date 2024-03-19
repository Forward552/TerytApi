namespace TerytWsApi.Client
{
    public static class TerytConfig
    {
        public static void SetTerytConfig(string login, string haslo, string url)
        {
            LoginTeryt = login;
            HasloTeryt = haslo;
            UslugaTeryt = url;
        }
        public static string LoginTeryt { get; private set; } = "TestPubliczny";
        public static string HasloTeryt { get; private set; } = "1234abcd\r\n";
        public static string UslugaTeryt { get; private set; } = "https://uslugaterytws1test.stat.gov.pl/terytws1.svc";

    }
}
