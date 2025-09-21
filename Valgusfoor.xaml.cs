using System.Runtime.CompilerServices;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;
using Microsoft.Maui.Dispatching;

namespace TARgv24;

public partial class Valgusfoor : ContentPage
{
    BoxView redLight, yellowLight, greenLight;
    Label infoLabel;
    Button startBtn, stopBtn, nightBtn, dayBtn, resetBtn;
    bool isOn = false;

    public Valgusfoor()
    {
        // background image
        var backgroundImage = new Image
        {
            Source = "trafficlight.png",
            //Aspect = Aspect.AspectFit
        };

        // Title
        infoLabel = new Label
        {
            Text = "Valgusfoor on välja lülitatud",
            FontSize = 24,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Colors.DarkGreen
        };

        // red
        redLight = CreateLight(Colors.Black);
        var tapRed = new TapGestureRecognizer();
        tapRed.Tapped += (s, e) => ShowMessage("Seisa", redLight, Colors.Red);
        redLight.GestureRecognizers.Add(tapRed);

        // yellow
        yellowLight = CreateLight(Colors.Black);
        var tapYellow = new TapGestureRecognizer();
        tapYellow.Tapped += (s, e) => ShowMessage("Valmista", yellowLight, Colors.Yellow);
        yellowLight.GestureRecognizers.Add(tapYellow);

        // green
        greenLight = CreateLight(Colors.Black);
        var tapGreen = new TapGestureRecognizer();
        tapGreen.Tapped += (s, e) => ShowMessage("Sõida", greenLight, Colors.Green);
        greenLight.GestureRecognizers.Add(tapGreen);

        // buttons
        startBtn = new Button { Text = "SISSE" };
        startBtn.Clicked += OnStartClicked;
        stopBtn = new Button { Text = "VÄLJA" };
        stopBtn.Clicked += OnStopClicked;
        nightBtn = new Button { Text = "ÖÖREŽIIM" };
        nightBtn.Clicked += OnNightModeClicked;
        dayBtn = new Button { Text = "PÄEVAREŽIIM" };
        dayBtn.Clicked += OnDayModeClicked;
        resetBtn = new Button { Text = "RESET" };
        resetBtn.Clicked += (s, e) =>
        {

            dayModeActive = false;
            nightModeActive = false;


            ResetLights();
            infoLabel.Text = "Valgusfoor on välja lülitatud!";
            isOn = false;
        };



        var buttonsLayout = new HorizontalStackLayout
        {
            Spacing = 10,
            HorizontalOptions = LayoutOptions.Start,
            Children = { startBtn, stopBtn , nightBtn, dayBtn, resetBtn }
        };

        var lightsLayout = new VerticalStackLayout
        {
            Spacing = 20,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            Children = { redLight, yellowLight, greenLight }
        };

        // GRID: background + inside content
        var grid = new Grid
        {
            RowDefinitions =
    {
        new RowDefinition { Height = new GridLength(62) }, // верхняя часть (заголовок + пустое место)
        new RowDefinition { Height = new GridLength(120) }, // красный
        new RowDefinition { Height = new GridLength(120) }, // жёлтый
        new RowDefinition { Height = new GridLength(120) }, // зелёный
        new RowDefinition { Height = GridLength.Auto }      // кнопки
    }
        };

        // фон
        grid.Children.Add(backgroundImage);
        Grid.SetRowSpan(backgroundImage, 5); // картинка на весь Grid
        backgroundImage.TranslationX = -2;

        // заголовок
        grid.Children.Add(infoLabel);
        Grid.SetRow(infoLabel, 0);
        infoLabel.HorizontalOptions = LayoutOptions.Center;
        infoLabel.VerticalOptions = LayoutOptions.Start;

        // красный
        grid.Children.Add(redLight);
        Grid.SetRow(redLight, 1);
        redLight.HorizontalOptions = LayoutOptions.Center;
        redLight.VerticalOptions = LayoutOptions.Center;

        // жёлтый
        grid.Children.Add(yellowLight);
        Grid.SetRow(yellowLight, 2);
        yellowLight.HorizontalOptions = LayoutOptions.Center;
        yellowLight.VerticalOptions = LayoutOptions.Center;

        // зелёный
        grid.Children.Add(greenLight);
        Grid.SetRow(greenLight, 3);
        greenLight.HorizontalOptions = LayoutOptions.Center;
        greenLight.VerticalOptions = LayoutOptions.Center;

        // кнопки
        grid.Children.Add(buttonsLayout);
        Grid.SetRow(buttonsLayout, 4);
        buttonsLayout.HorizontalOptions = LayoutOptions.Center;
        buttonsLayout.VerticalOptions = LayoutOptions.End;

        Content = grid;
    }


    private BoxView CreateLight(Color color)
    {
        return new BoxView
        {
            Color = color,
            WidthRequest = 100,
            HeightRequest = 100,
            CornerRadius = 50,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.Center,
            BackgroundColor = Colors.Transparent
        };
    }

    private void OnStartClicked(object? sender, EventArgs e)
    {
        isOn = true;
        infoLabel.Text = "Valgusfoor sisse lülitatud!";
        ResetLights();
    }

    private void OnStopClicked(object? sender, EventArgs e)
    {
        isOn = false;
        infoLabel.Text = "Valgusfoor välja lülitatud!";
        ResetLights();
    }

    private void ShowMessage(string text, BoxView light, Color color)
    {
        if (!isOn)
        {
            infoLabel.Text = "Kõigepealt lülita valgusfoor sisse!";
            return;
        }

        ResetLights();
        light.Color = color;
        infoLabel.Text = text;
    }

    private void ResetLights()
    {
        redLight.Color = Colors.Black;
        yellowLight.Color = Colors.Black;
        greenLight.Color = Colors.Black;
    }

    private bool nightModeActive = false;

    private async void OnNightModeClicked(object? sender, EventArgs e)
    {
        if (!isOn) // если светофор выключен
        {
            infoLabel.Text = "ÖÖREŽIIM AKTIVEERITUD!";
            nightModeActive = true;

            // все лампы выключаем
            redLight.Color = Colors.Black;
            redLight.BackgroundColor = Colors.Transparent;
            greenLight.Color = Colors.Black;
            greenLight.BackgroundColor = Colors.Transparent;

            // цикл мигания
            for (int i = 0; i < 5 && nightModeActive; i++)
            {
                yellowLight.Color = Colors.Yellow;
                yellowLight.BackgroundColor = Colors.Transparent;
                await Task.Delay(700);

                yellowLight.Color = Colors.Black;
                yellowLight.BackgroundColor = Colors.Transparent;
                await Task.Delay(700);
            }
        }
        else
        {
            // выключаем ночной режим
            infoLabel.Text = "ÖÖREŽIIM LÕPETATUD!";
            nightModeActive = false;
            yellowLight.BackgroundColor = Colors.Transparent;
        }

    }

    private bool dayModeActive = false;

    private async void OnDayModeClicked(object? sender, EventArgs e)
    {
        if (!isOn)
        {
            infoLabel.Text = "PÄEVAREŽIIM AKTIVEERITUD!";
            dayModeActive = true;

            ResetLights();

            while (dayModeActive)
            {
                redLight.Color = Colors.Red;
                await Task.Delay(2000);

                yellowLight.Color = Colors.Yellow;
                await Task.Delay(1500);

                redLight.Color = Colors.Black;
                yellowLight.Color = Colors.Black;
                greenLight.Color = Colors.Green;
                await Task.Delay(2000);

                //for (int i = 0; i < 3 && dayModeActive; i++)
                //{
                //    greenLight.Color = Colors.Black;
                //    await Task.Delay(1000);

                //    greenLight.Color = Colors.Green;
                //    await Task.Delay(1000);
                //}

                greenLight.Color = Colors.Black;
                await Task.Delay(1000);

                greenLight.Color = Colors.Green;
                await Task.Delay(1000);

                greenLight.Color = Colors.Black;
                await Task.Delay(1000);

                greenLight.Color = Colors.Green;
                await Task.Delay(500);

                greenLight.Color = Colors.Black;
                yellowLight.Color = Colors.Yellow;
                await Task.Delay(1500);

                yellowLight.Color = Colors.Black;
            }
        }
        else
        {
            // выключаем дневной режим
            infoLabel.Text = "PÄEVAREŽIIM LÕPETATUD!";
            dayModeActive = false;
            ResetLights();
        }
    }
}