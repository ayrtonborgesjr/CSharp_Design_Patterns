namespace Bridge
{
    public class Documentary : IChannel
    {
        public string Channel()
        {
            return ("Tuned to the Documentary Channel");
        }

        public string Status()
        {
            return ("You're watching - The Theory of Everything");
        }
    }
}
