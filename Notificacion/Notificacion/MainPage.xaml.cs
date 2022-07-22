using Plugin.LocalNotification;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notificacion
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var notificacion = new NotificationRequest
            {
                BadgeNumber = 1,
                Description = "Prueba de notificacion",
                Title = "Prueba notificacion",
                ReturningData = "Dummy data",
                NotificationId = 1337,
                NotifyTime = DateTime.Now.AddSeconds(5) // Used for Scheduling local notification, if not specified notification will show immediately.
            };
            NotificationCenter.Current.Show(notificacion);
        }
    }
}
