using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ajaplaan
{
    public partial class MainPage : ContentPage
    {
        Label l;
        TimePicker timePicker;
        Image img;


        public MainPage()
        {
            Grid grd = new Grid
            {
                RowDefinitions =
{
new RowDefinition{Height=new GridLength(1,GridUnitType.Star)},
new RowDefinition{Height=new GridLength(1,GridUnitType.Star)}

},
                ColumnDefinitions =
{
new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)},
new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
}

            };
            l = new Label { Text = "", TextColor = Color.Gold, BackgroundColor = Color.Red, FontSize = 50 };
            grd.Children.Add(l, 0, 0);
            Grid.SetColumnSpan(l, 3);

            timePicker = new TimePicker() { Time = new TimeSpan(18, 1, 1) };
            grd.Children.Add(timePicker, 2, 1);
            timePicker.PropertyChanged += TimePicker_PropertyChanged1;
            img = new Image { };
            grd.Children.Add(img, 0, 1);
            Grid.SetColumnSpan(l, 2);
            Grid.SetColumnSpan(img, 2);
            Content = grd;


        }

        private void TimePicker_PropertyChanged1(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == TimePicker.TimeProperty.PropertyName)
            {
                var time = timePicker.Time.Hours;
                
                 if (time == 7)
                {
                    l.Text = "Просыпаюсь";
                    img.Source = FileImageSource.FromFile("a.jpg");
                }
                else if (time == 8)
                {
                    l.Text = "Учеба";
                    img.Source = FileImageSource.FromFile("b.jpg");
                }
                else if (time == 9)
                {
                    l.Text = "Иду домой";
                    img.Source = FileImageSource.FromFile("c.jpg");
                }
                else if (time == 10)
                {
                    l.Text = "Обедаю";
                    img.Source = FileImageSource.FromFile("d.jpg");
                }
                else if (time == 11)
                {
                    l.Text = "Иду гулять";
                    img.Source = FileImageSource.FromFile("e.jpg");
                }
                else if (time == 12)
                {
                    l.Text = "Ужинаю";
                    img.Source = FileImageSource.FromFile("f.jpg");
                }
                else if (time == 13)
                {
                    l.Text = "Смотрю телевизор";
                    img.Source = FileImageSource.FromFile("g.jpg");
                }
                else if (time == 14)
                {
                    l.Text = "Играю в ПК";
                    img.Source = FileImageSource.FromFile("h.jpg");
                }
                else if (time == 15)
                {
                    l.Text = "Готовлюсь ко сну";
                    img.Source = FileImageSource.FromFile("k.jpg");
                }
                else if (time == 16)
                {
                    l.Text = "Все еще готовлюсь";
                    img.Source = FileImageSource.FromFile("k.jpg");
                }
                else if (time == 17)
                {
                    l.Text = "Расстилаю кровать";
                    img.Source = FileImageSource.FromFile("l.jpg");
                }
                else if (time == 18)
                {
                    l.Text = "Смотрю фильм";
                    img.Source = FileImageSource.FromFile("g.jpg");
                }
                else if (time == 19)
                {
                    l.Text = "Смотрю фильм";
                    img.Source = FileImageSource.FromFile("g.jpg");
                }
                else if (time == 20)
                {
                    l.Text = "Смотрю фильм";
                    img.Source = FileImageSource.FromFile("g.jpg");
                }
                else if (time == 21)
                {
                    l.Text = "Играю с котом";
                    img.Source = FileImageSource.FromFile("m.jpg");
                }
                else if (time == 22)
                {
                    l.Text = "Питаюсь";
                    img.Source = FileImageSource.FromFile("f.jpg");
                }
                else if (time == 23)
                {
                    l.Text = "ложусь спать";
                    img.Source = FileImageSource.FromFile("m.jpg");
                }
            }
        }


    }
}
