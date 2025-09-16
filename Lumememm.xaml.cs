using Microsoft.Maui.Layouts;

namespace TARgv24;

public partial class Lumememm : ContentPage
{
    Label lumememm_lbl;
    BoxView boxView_bucket;
    BoxView boxView_lumememme_pea;
    BoxView boxView_lumememme_keha;


    Picker picker;
    Slider slider;
    Stepper stepper;
    AbsoluteLayout allm;

    public Lumememm()
    {
        // ===== элементы снеговика =====
        lumememm_lbl = new Label
        {
            Text = "See on minu Lumememm",
            FontSize = 20,
            TextColor = Colors.LightCyan,
            HorizontalTextAlignment = TextAlignment.Center
        };

        boxView_bucket = new BoxView
        {
            Color = Colors.Black,
            WidthRequest = DeviceDisplay.MainDisplayInfo.Width / 4,
            HeightRequest = DeviceDisplay.MainDisplayInfo.Height / 12, // как «ведро»
            BackgroundColor = Colors.Transparent,
            CornerRadius = 0
        };

        boxView_lumememme_pea = new BoxView
        {
            Color = Colors.LightBlue,
            WidthRequest = DeviceDisplay.MainDisplayInfo.Width / 4,
            HeightRequest = DeviceDisplay.MainDisplayInfo.Width / 4,
            BackgroundColor = Colors.Transparent,
            CornerRadius = 9999 // кружок
        };

        boxView_lumememme_keha = new BoxView
        {

            Color = Colors.LightBlue,
            WidthRequest = DeviceDisplay.MainDisplayInfo.Width / 3.5,
            HeightRequest = DeviceDisplay.MainDisplayInfo.Width / 3.5,
            BackgroundColor = Colors.Transparent,
            CornerRadius = 9999
        };



        // ===== UI: picker/slider/stepper =====
        picker = new Picker
        {
            Title = "Tegevus",
            ItemsSource = new[] { "Peida", "Näita", "Muuda värvi", "Sulata", "Tantsi" }
        };

        slider = new Slider
        {
            Minimum = 0,
            Maximum = 10,
            Value = 5
        };
        // Прозрачность снеговика
        slider.ValueChanged += (_, e) =>
        {
            var alpha = e.NewValue;
            boxView_lumememme_pea.Opacity = alpha;
            boxView_bucket.Opacity = alpha;
            boxView_lumememme_keha.Opacity = alpha;
        };

        stepper = new Stepper
        {
            Minimum = 0.4,
            Maximum = 1,
            Increment = 0.1,
            Value = 0.6
        };
        // Масштаб снеговика
        stepper.ValueChanged += (_, e) =>
        {
            var scale = e.NewValue;
            boxView_lumememme_pea.Scale = scale;
            boxView_bucket.Scale = scale;
            boxView_lumememme_keha.Scale = scale;
        };

        // ===== AbsoluteLayout =====
        allm = new AbsoluteLayout();

        var views = new View[]
        {
            lumememm_lbl, boxView_bucket, boxView_lumememme_pea, boxView_lumememme_keha, picker, slider, stepper
        };

        foreach (var v in views)
            allm.Children.Add(v);

        for (int i = 0; i < views.Length; i++)
        {
            // центр по X, «лесенкой» по Y, ширина/высота как доля
            AbsoluteLayout.SetLayoutBounds(views[i], new Rect(0.5, i * 0.16, 0.9, 0.15));
            AbsoluteLayout.SetLayoutFlags(views[i], AbsoluteLayoutFlags.All);
        }

        Content = allm;
    }
}
