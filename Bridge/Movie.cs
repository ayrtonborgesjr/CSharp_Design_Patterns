namespace Bridge
{
    public class Movie : IChannel
    {
        public string Channel()
        {
            return ("Tuned in Channel Movies");
        }

        public string Status()
        {
            return ("You're watching - The Averages");
        }
    }
}
