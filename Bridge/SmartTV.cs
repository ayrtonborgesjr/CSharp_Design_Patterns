namespace Bridge
{
    public class SmartTV
    {
        public IChannel SelectedChannel { get; set; }

        public void DisplayTunedChannel()
        {
            if (SelectedChannel != null)
            {
                System.Console.WriteLine(SelectedChannel.Channel()); 
            }
            else
            {
                System.Console.WriteLine("Please, tune in channel!");
            }
        }

        public void PlayTV()
        {
            if (SelectedChannel != null)
            {
                System.Console.WriteLine(SelectedChannel.Status());
            }
            else
            {
                System.Console.WriteLine("Please, tune in channel to watch something!");
            }
        }
    }
}
