using Microsoft.Maui.Controls;
using Microsoft.Maui.Devices;

namespace TARgv24;

public partial class Valgusfoor : ContentPage
{
    BoxView redLight, yellowLight, greenLight;
    Label infoLabel;
    Button startBtn, stopBtn;
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
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Colors.White
        };

        // red
        redLight = CreateLight(Colors.Black);
        var tapRed = new TapGestureRecognizer();
        tapRed.Tapped += (s, e) => ShowMessage("STOP", redLight, Colors.Red);
        redLight.GestureRecognizers.Add(tapRed);

        // yellow
        yellowLight = CreateLight(Colors.Black);
        var tapYellow = new TapGestureRecognizer();
        tapYellow.Tapped += (s, e) => ShowMessage("OOTA", yellowLight, Colors.Yellow);
        yellowLight.GestureRecognizers.Add(tapYellow);

        // green
        greenLight = CreateLight(Colors.Black);
        var tapGreen = new TapGestureRecognizer();
        tapGreen.Tapped += (s, e) => ShowMessage("MINE", greenLight, Colors.Green);
        greenLight.GestureRecognizers.Add(tapGreen);

        // buttons
        startBtn = new Button { Text = "SISSE" };
        startBtn.Clicked += OnStartClicked;
        stopBtn = new Button { Text = "VÄLJA" };
        stopBtn.Clicked += OnStopClicked;

        var buttonsLayout = new HorizontalStackLayout
        {
            Spacing = 200,
            HorizontalOptions = LayoutOptions.Center,
            Children = { startBtn, stopBtn }
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
}