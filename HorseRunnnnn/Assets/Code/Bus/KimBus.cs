namespace Code.Bus
{
    public class KimBus<T> where T : IEvent
    {
        public delegate void Event(T evt);
        public static event Event OnEvent;
        public static void Raise(T evt) => OnEvent?.Invoke(evt);
    }
}
