using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Threading.Tasks;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "ZpP1Ki8KAnIPEQ5ehgfKGKXBEUdxcRGOEiwMvnos",
            BasePath = "https://tempsens-bf95c.firebaseio.com/"
        };
        IFirebaseClient client;
        public MainPage()
        {
            this.InitializeComponent();

            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                    getData();
            }
        }

        private async void getData()
        {
            while (true)
            {

                FirebaseResponse response = await client.GetAsync("tempData/newest");
                Data result = response.ResultAs<Data>();
              
                if (result.Dt.ToString("H:m:s - ddd, MMM d, yyyy") != datetime.Text)
                {
                    temp.Text = result.Temp.ToString();
                    hum.Text = result.Hum.ToString();
                    datetime.Text = result.Dt.ToString("H:m:s - ddd, MMM d, yyyy");
                }
                Task.Delay(2000).Wait();
            }
        }
    }
}
