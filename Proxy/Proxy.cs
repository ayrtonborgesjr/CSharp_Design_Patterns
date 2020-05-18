namespace Proxy
{
    public class Proxy : Subject
    {
        private RealSubject RealSubject;

        public override void Request()
        {
            if (this.RealSubject == null)
            {
                this.RealSubject = new RealSubject();
            }
            this.RealSubject.Request();
        }
    }
}
