namespace Library.EventsExample.RadioBroadcast
{
    internal class FMRadio
    {
        public void OnNewsBroadCasted(object source, RadioEventArgs e)
        {
            System.Console.WriteLine($"News is {e.Radio.Messase} from station {e.Radio.Station}");
        }
    }
}