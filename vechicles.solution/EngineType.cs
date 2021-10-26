using System.Threading.Tasks;
using System.Timers;

namespace vechicles.solution
{
    public class EngineType
    {

        public bool IsRunning { get; set; }
        private float FuelLevel { get; set; }
        public int RPM { get; set; }
        public int Throttle { get; set; }

        private Timer EngineWorker { get; set; }

        public EngineType()
        {
            EngineWorker = new Timer();
            EngineWorker.Elapsed += EngineWorker_Elapsed;
        }

        void EngineWorker_Elapsed(object sender, ElapsedEventArgs e)
        {
            FuelLevel -= (float)(RPM * 0.04);
        }

        public void TurnOn()
        {
            IsRunning = true;
            SetThrottle(10);
            EngineWorker.Enabled = true;
        }

        /// <summary>
        /// Position 0 - 100
        /// </summary>
        /// <param name="Position"></param>
        public int SetThrottle(int Position)
        {
            int throttleposition = Position;
            RPM = Throttle * 1000;
            EngineWorker.Interval = RPM;

            return throttleposition;
        }

        private async Task Working()
        {
            await Task.Run(() => {

            });
        }


    }
}