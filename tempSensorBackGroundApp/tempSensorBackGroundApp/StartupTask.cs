using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using Windows.ApplicationModel.Background;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Sensors.Dht;
using Windows.Devices.Gpio;
using System.Threading.Tasks;
using System.Diagnostics;


// The Background Application template is documented at http://go.microsoft.com/fwlink/?LinkID=533884&clcid=0x409

namespace tempSensorBackGroundApp
{
    public sealed class StartupTask : IBackgroundTask
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ZpP1Ki8KAnIPEQ5ehgfKGKXBEUdxcRGOEiwMvnos",
            BasePath = "https://tempsens-bf95c.firebaseio.com/"
        };
        IFirebaseClient client;

        private const int DHTPIN = 4;
        private IDht dht = null;
        private GpioPin dhtPin = null;
        private int ID;

        public void Run(IBackgroundTaskInstance taskInstance)
        {
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                dhtPin = GpioController.GetDefault().OpenPin(DHTPIN, GpioSharingMode.Exclusive);
                dht = new Dht11(dhtPin, GpioPinDriveMode.Input);

                while (true)
                {
                    readSensor(ID);
                    ID++;
                    Task.Delay(10000).Wait();
                }
            }
        }

        private async void readSensor(int ID)
        {
            double Temp = 0;
            double Hum = 0;
            DateTime Dt;
            DhtReading reading = await dht.GetReadingAsync().AsTask();
            if (reading.IsValid)
            {
                Temp = reading.Temperature;
                Hum = reading.Humidity;
                Dt = DateTime.Now;
                var data = new Data
                {
                    Temp = Temp,
                    Hum = Hum,
                    Dt = Dt
                };
                SetResponse response = await client.SetAsync("tempData/collection/"+ID, data);
                Data result = response.ResultAs<Data>();
                Debug.WriteLine("Data inserted " + result.Dt);
                SetResponse responseSet = await client.SetAsync("tempData/newest", data);
                Data resultSet = response.ResultAs<Data>();
                
            }
        }
    }
}
