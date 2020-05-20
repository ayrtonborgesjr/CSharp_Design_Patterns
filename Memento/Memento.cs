namespace Memento
{
    public class Memento
    {
        private string State_;

        public Memento(string state)
        {
            this.State_ = state;
        }

        public string State
        {
            get { return this.State_; }
        }
    }
}
