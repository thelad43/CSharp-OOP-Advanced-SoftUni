using System;

namespace _06._Traffic_Lights
{
    public class TrafficLight
    {
        private const int NumberOfSignals = 3;

        private Signal signal;

        public TrafficLight(string signal)
        {
            this.signal = (Signal)Enum.Parse(typeof(Signal), signal);
        }

        public void UpdateSignal()
        {
            this.signal =
                (Signal)Enum.Parse(typeof(Signal), (((int)(this.signal) + 1) % NumberOfSignals).ToString());
        }
    }
}