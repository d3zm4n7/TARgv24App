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
        // Фон
        var backgroundImage = new Image
        {
            Source = "trafficlight.png", // картинка из Resources/Images
            Aspect = Aspect.AspectFit
        };

        // Заголовок
        infoLabel = new Label
        {
            Text = "Valgusfoor on välja lülitatud",
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Colors.White
        };

        // Красный
        redLight = CreateLight(Colors.Black);
        var tapRed = new TapGestureRecognizer();
        tapRed.Tapped += (s, e) => ShowMessage("STOP", redLight, Colors.Red);
        redLight.GestureRecognizers.Add(tapRed);

        // Жёлтый
        yellowLight = CreateLight(Colors.Black);
        var tapYellow = new TapGestureRecognizer();
        tapYellow.Tapped += (s, e) => ShowMessage("OOTA", yellowLight, Colors.Yellow);
        yellowLight.GestureRecognizers.Add(tapYellow);

        // Зелёный
        greenLight = CreateLight(Colors.Black);
        var tapGreen = new TapGestureRecognizer();
        tapGreen.Tapped += (s, e) => ShowMessage("MINE", greenLight, Colors.Green);
        greenLight.GestureRecognizers.Add(tapGreen);

        // Кнопки
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

        // GRID: фон + содержимое
        var grid = new Grid();
        grid.Children.Add(backgroundImage); // на задний план
        grid.Children.Add(new VerticalStackLayout
        {
            Spacing = 20,
            Children =
            {
                infoLabel,
                lightsLayout,
                buttonsLayout
            }
        });

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
            HorizontalOptions = LayoutOptions.Center
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
        redLight.Color = Colors.DarkGray;
        yellowLight.Color = Colors.DarkGray;
        greenLight.Color = Colors.DarkGray;
    }
}
