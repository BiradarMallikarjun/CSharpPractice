using Library.Factory;
using System;

namespace Library.EventsExample.RadioBroadcast
{
    public class RadioBroadCast
    {
        public event EventHandler<RadioEventArgs> NewsBroadCasted;

        protected virtual void OnNewsBroadCasted(Radio radio)
        {
            if (NewsBroadCasted != null)
                NewsBroadCasted(this, new RadioEventArgs() { Radio = radio });
        }

        public void NewsBroadCast()
        {
            var radio = FactoryClass.GetRadio();
            radio.Messase = "Covid19 emergency!!!";
            radio.Station = "international channel";

            //TODO:
            Console.WriteLine(" News BroadCasting ...");  
            //Event raising
            OnNewsBroadCasted(radio);
        }

    }

}
