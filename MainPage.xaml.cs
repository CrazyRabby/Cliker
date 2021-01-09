using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shark_says_A
{   
    public partial class MainPage : ContentPage
    {   //переменные глобальные
        int clickTotal = 0;
        
        //тут идёт чисто инициализация компонентов
        public MainPage()
        {
           
            InitializeComponent();

            sharkBT.Source = ImageSource.FromResource("Shark_says_A.pick1.jpg");
           
        }
        //после нажатия на кнопку картинку
        void sharkBT_Pressed(object sender, EventArgs e)
            {
                clickTotal += 1;
                label1.Text = $"Gura {clickTotal} time say{(clickTotal == 1 ? "" : "s")} A";
                sharkBT.Source = ImageSource.FromResource("Shark_says_A.pick2.jpg");
           //проигрывание аудио
            if (clickTotal % 15 == 0)
            {
                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                player.Load("sound_shark.mp3");
                player.Play();
            }
            else 
            {
                var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
                player.Load("sound_a.mp3");
                player.Play();
            }

        }

        private void sharkBT_Released(object sender, EventArgs e)
        {
            sharkBT.Source = ImageSource.FromResource("Shark_says_A.pick1.jpg");
        }
       
      
    }

}
