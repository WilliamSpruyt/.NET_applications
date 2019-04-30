using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloSpruyts
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random rnd = new Random();
        
        string gloatString = "shit it hasn't worked";
        string gloatStringPlus = "balls it hasn't worked";
        int go=0;
        string name = "oopsName";
        string verb = "oopsverb";
        string cpuverb = "oopscpuv";
        string cpuname = "oopscpuname";
        const int WIN = 0;
        const int DRAW = 1;
        const int LOSE = 2;
        Boolean yourTurn = true;
       
        





        public MainPage()
             


        {
            this.InitializeComponent();

        }

        private void textBlock1_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }
        private void textBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {



        }



        void Image_Loaded(object sender, RoutedEventArgs e)
        {
            Image img = sender as Image;
            if (img != null)
            {
                BitmapImage bitmapImage = new BitmapImage();
                img.Width = bitmapImage.DecodePixelWidth = 280;
                bitmapImage.UriSource = new Uri("ms-appx:///Assets/profileBernie.JPG");
                img.Source = bitmapImage;
            }
        }



        private async void button_Click(object sender, RoutedEventArgs e)
        {
            verb = "oopsverb";

            if (yourTurn)
            {
                
                haveGo(Class1.ALL_THINGS[0 + go], Class1.ALL_THINGS[1 + go], Class1.ALL_THINGS[2 + go], 1,rock);
                textBlock.Text = gloatString;
                MediaElement mediaElement = new MediaElement();
                var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream =
                    await synth.SynthesizeTextToStreamAsync(gloatStringPlus);
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }
            

        }

        private async void paper_Click(object sender, RoutedEventArgs e)
        {
            verb = "oopsverb";
            if (yourTurn)
            {
                 
                haveGo(Class1.ALL_THINGS[0 + go], Class1.ALL_THINGS[1 + go], Class1.ALL_THINGS[2 + go], 2,paper);
                textBlock.Text = gloatString;
                MediaElement mediaElement = new MediaElement();
                var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream =
                    await synth.SynthesizeTextToStreamAsync(gloatStringPlus);
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }


        }

        private async void scissors_Click(object sender, RoutedEventArgs e)
        {
            verb = "oopsverb";
            if (yourTurn)
            {
                scissors.Background = new SolidColorBrush(Colors.Red);
                haveGo(Class1.ALL_THINGS[0 + go], Class1.ALL_THINGS[1 + go], Class1.ALL_THINGS[2 + go], 3,scissors);
                textBlock.Text = gloatString;
                MediaElement mediaElement = new MediaElement();
                var synth = new Windows.Media.SpeechSynthesis.SpeechSynthesizer();
                Windows.Media.SpeechSynthesis.SpeechSynthesisStream stream =
                    await synth.SynthesizeTextToStreamAsync(gloatStringPlus);
                mediaElement.SetSource(stream, stream.ContentType);
                mediaElement.Play();
            }


        }

       



        private void haveGo(Thingy rock, Thingy paper, Thingy scissors, int turn,Button button)

        {
            string gloater = "balls balls balls";
            image.Stretch = Stretch.Fill;
            BitmapImage bitmapImage = new BitmapImage();
            image.Width = bitmapImage.DecodePixelWidth = 280;
            bitmapImage.UriSource = new Uri("ms-appx:///Assets/ic_launcher.png");
            image.Source = bitmapImage;

            int cpu = rnd.Next(1, 4);

            switch (cpu)
            {
                case 1:
                    cpuname = rock.getName();
                    cpuverb = rock.getVerb();
                    break;
                case 2:
                    cpuname = paper.getName();
                    cpuverb = paper.getVerb();
                    break;
                case 3:
                    cpuname = scissors.getName();
                    cpuverb = scissors.getVerb();
                    break;
            }


            int result = -1;


            if (turn == 1)
            {
                name = rock.getName();
                verb = rock.getVerb();


                if (cpu == 1)
                {
                    result = DRAW;
                }

                if (cpu == 2)
                    { 
                        result = LOSE;
                        setPic(rock);

                    }

                if (cpu == 3)
                {
                    //gloatString = ;
                    setPic(scissors);
                        result = WIN;

                    }

                    gloater = rock.getGloatwin(result);
                }
             if (turn == 2)

                {
                    name = paper.getName();
                    verb = paper.getVerb();

                    if (cpu == 1)
                    {
                         
                    result = WIN;
                    setPic(scissors);

                    }

                    if (cpu == 2) { result = DRAW; }

                if (cpu == 3)
                {
                    result = LOSE;
                    setPic(paper);
                } 
                    gloater = paper.getGloatwin(result);
                }


            if (turn == 3)
                {
                    name = scissors.getName();
                    verb = scissors.getVerb();

                    if (cpu == 1) { result = LOSE;setPic(scissors); }
                    if (cpu == 2)
                    {
                       
                        result = WIN;
                        setPic(paper);
                    }

                    if (cpu == 3){ result = DRAW; }
                    gloater = scissors.getGloatwin(result);

            }


                if (result == DRAW)
                {
                    //tester.Text = turn + " " + cpu + " " + "DRAW" + name + verb + cpu + cpuname + cpuverb;
                    gloatString = ("You chose " + name + ".\nWe chose " + cpuname + ".\nA draw.\n" +
                            name + " likes " + cpuname + ".");
             //   gloater += ("You chose " + name + " We chose " + cpuname + " draw " +
              //              name + " likes " + cpuname + " ");



                }
                if (result == WIN)
                {

                   // tester.Text = turn + " " + cpu + " " + "WIN" + name + verb + cpu + cpuname + cpuverb;
                    gloatString = "You chose " + name + ".\nWe chose " + cpuname + ".\nYou win!\n"
                                + name + " " + verb + " " + cpuname + ".";
               // gloater += "You chose " + name + " We chose " + cpuname + " You win!"
               //                 + name + " " + verb + " " + cpuname + " ";
               

                }
                if (result == LOSE)
                {


                   // tester.Text = turn + " " + cpu + " " + "LOSE" + name + verb + cpu + cpuname + cpuverb;
                    gloatString = ("You chose " + name + ".\nWe chose " +
                            cpuname + ".\nYou lose.\n"
                            + cpuname + " " +
                           cpuverb + " " + name + ".");
             //   gloater += ("You chose " + name + " We chose " +
               //             cpuname + " You lose "
                   //         + cpuname + " " +
                 //          cpuverb + " " + name + " ");

                }
                gloatStringPlus =gloater;

            if (result == WIN)
            {   go += 3;
                button.Background = new SolidColorBrush(Colors.Green);
            }

            if (result == LOSE) { go = 0; button.Background = new SolidColorBrush(Colors.Red); }

            if (result == DRAW) {  button.Background = new SolidColorBrush(Colors.Orange); }
            yourTurn = false;


        }
        



        


        

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            setButtons(Class1.ALL_THINGS[0 + go], Class1.ALL_THINGS[1 + go], Class1.ALL_THINGS[2 + go]);
            yourTurn = true;
        }

        private void setButtons(Thingy rockthingy, Thingy paperthingy, Thingy scissorsthingy) {
            rock.Background = new SolidColorBrush(Colors.Gray);
            paper.Background = new SolidColorBrush(Colors.Gray);
            scissors.Background = new SolidColorBrush(Colors.Gray);
            image.Stretch = Stretch.Fill;
            BitmapImage paperImg = new BitmapImage();
            image.Width = paperImg.DecodePixelWidth = 280;
            paperImg.UriSource = new Uri("ms-appx:///Assets/ic_launcher.png");
            image.Source = paperImg;
            rock.Content = rockthingy.getName();
            paper.Content = paperthingy.getName();
            scissors.Content = scissorsthingy.getName();
            textBlock.Text = "Come on then.";
            textBlock1.Text = go/3+"";
        }
        private void setPic(Thingy thing)
        {
            image.Stretch = Stretch.Fill;
            BitmapImage scissorsImg = new BitmapImage();
            image.Width = scissorsImg.DecodePixelWidth = 280;
            scissorsImg.UriSource = new Uri(thing.getBeatsPic());
            image.Source = scissorsImg;

        }

        private void textBlock_SelectionChanged_1(object sender, RoutedEventArgs e)
        {

        }
    }
}


    

