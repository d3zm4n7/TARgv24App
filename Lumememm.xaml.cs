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
        lumememm_lbl = new Label
        {
            Text = "See on minu Lumememm",
            FontSize = 24,
            FontFamily = "LowRider BB 400",
            TextColor = Colors.DarkBlue,
            HorizontalTextAlignment = TextAlignment.Center
        };

        // Ведро
        boxView_bucket = new BoxView
        {
            Color = Colors.Black,
            WidthRequest = 80,
            HeightRequest = 60,
            BackgroundColor = Colors.Transparent
        };

        // Голова
        boxView_lumememme_pea = new BoxView
        {
            Color = Colors.White,
            WidthRequest = 100,
            HeightRequest = 100,
            CornerRadius = 50,
            BackgroundColor = Colors.Transparent
        };

        // Глаза
        var eye_left = new BoxView
        {
            Color = Colors.Black,
            WidthRequest = 10,
            HeightRequest = 10,
            CornerRadius = 5,
            BackgroundColor = Colors.Transparent
        };
        var eye_right = new BoxView
        {
            Color = Colors.Black,
            WidthRequest = 10,
            HeightRequest = 10,
            CornerRadius = 5,
            BackgroundColor = Colors.Transparent
        };

        // Нос (морковка)
        var nose = new BoxView
        {
            Color = Colors.Orange,
            WidthRequest = 15,
            HeightRequest = 10,
            CornerRadius = 3,
            BackgroundColor = Colors.Transparent
        };

        // Рот
        var mouth1 = new BoxView { Color = Colors.Black, WidthRequest = 10, HeightRequest = 10, CornerRadius = 5, BackgroundColor = Colors.Transparent };
        var mouth2 = new BoxView { Color = Colors.Black, WidthRequest = 10, HeightRequest = 10, CornerRadius = 5, BackgroundColor = Colors.Transparent };
        var mouth3 = new BoxView { Color = Colors.Black, WidthRequest = 10, HeightRequest = 10, CornerRadius = 5, BackgroundColor = Colors.Transparent };
        var mouth4 = new BoxView { Color = Colors.Black, WidthRequest = 10, HeightRequest = 10, CornerRadius = 5, BackgroundColor = Colors.Transparent };
        var mouth5 = new BoxView { Color = Colors.Black, WidthRequest = 10, HeightRequest = 10, CornerRadius = 5, BackgroundColor = Colors.Transparent };
        var mouth6 = new BoxView { Color = Colors.Black, WidthRequest = 10, HeightRequest = 10, CornerRadius = 5, BackgroundColor = Colors.Transparent };

        // Туловище
        var boxView_lumememme_kesk = new BoxView
        {
            Color = Colors.White,
            WidthRequest = 140,
            HeightRequest = 140,
            CornerRadius = 70,
            BackgroundColor = Colors.Transparent
        };

        // Пуговицы
        var button1 = new BoxView { Color = Colors.Black, WidthRequest = 12, HeightRequest = 12, CornerRadius = 6, BackgroundColor = Colors.Transparent };
        var button2 = new BoxView { Color = Colors.Black, WidthRequest = 12, HeightRequest = 12, CornerRadius = 6, BackgroundColor = Colors.Transparent };
        var button3 = new BoxView { Color = Colors.Black, WidthRequest = 12, HeightRequest = 12, CornerRadius = 6, BackgroundColor = Colors.Transparent };

        // Руки
        var hand_left = new BoxView
        {
            Color = Colors.SaddleBrown,
            WidthRequest = 40,
            HeightRequest = 6,
            CornerRadius = 3,
            BackgroundColor = Colors.Transparent
        };
        var hand_left_elbow = new BoxView
        {
            Color = Colors.SaddleBrown,
            WidthRequest = 6,
            HeightRequest = 60,
            CornerRadius = 3,
            BackgroundColor = Colors.Transparent
        };
        var hand_right = new BoxView
        {
            Color = Colors.SaddleBrown,
            WidthRequest = 40,
            HeightRequest = 6,
            CornerRadius = 3,
            BackgroundColor = Colors.Transparent
        };
        var hand_right_elbow = new BoxView
        {
            Color = Colors.SaddleBrown,
            WidthRequest = 6,
            HeightRequest = 60,
            CornerRadius = 3,
            BackgroundColor = Colors.Transparent
        };

        // Нижняя часть
        boxView_lumememme_keha = new BoxView
        {
            Color = Colors.White,
            WidthRequest = 180,
            HeightRequest = 180,
            CornerRadius = 90,
            BackgroundColor = Colors.Transparent
        };

        // ===== AbsoluteLayout =====
        allm = new AbsoluteLayout();

        // Добавляем элементы
        allm.Children.Add(lumememm_lbl);
        allm.Children.Add(boxView_bucket);
        allm.Children.Add(boxView_lumememme_pea);
        allm.Children.Add(eye_left);
        allm.Children.Add(eye_right);
        allm.Children.Add(nose);
        allm.Children.Add(mouth1);
        allm.Children.Add(mouth2);
        allm.Children.Add(mouth3);
        allm.Children.Add(mouth4);
        allm.Children.Add(mouth5);
        allm.Children.Add(mouth6);
        allm.Children.Add(boxView_lumememme_kesk);
        allm.Children.Add(button1);
        allm.Children.Add(button2);
        allm.Children.Add(button3);
        allm.Children.Add(hand_left);
        allm.Children.Add(hand_left_elbow);
        allm.Children.Add(hand_right);
        allm.Children.Add(hand_right_elbow);
        allm.Children.Add(boxView_lumememme_keha);

        // Позиции
        AbsoluteLayout.SetLayoutBounds(lumememm_lbl, new Rect(0.5, 0.05, 0.9, 0.1));
        AbsoluteLayout.SetLayoutFlags(lumememm_lbl, AbsoluteLayoutFlags.All);

        AbsoluteLayout.SetLayoutBounds(boxView_bucket, new Rect(0.5, 0.16, 80, 40));
        AbsoluteLayout.SetLayoutFlags(boxView_bucket, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(boxView_lumememme_pea, new Rect(0.5, 0.22, 100, 100));
        AbsoluteLayout.SetLayoutFlags(boxView_lumememme_pea, AbsoluteLayoutFlags.PositionProportional);

        // Лицо
        AbsoluteLayout.SetLayoutBounds(eye_left, new Rect(0.46, 0.22, 10, 10));
        AbsoluteLayout.SetLayoutFlags(eye_left, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(eye_right, new Rect(0.54, 0.22, 10, 10));
        AbsoluteLayout.SetLayoutFlags(eye_right, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(nose, new Rect(0.5, 0.25, 15, 10));
        AbsoluteLayout.SetLayoutFlags(nose, AbsoluteLayoutFlags.PositionProportional);
        
        //Mouth buttons
        AbsoluteLayout.SetLayoutBounds(mouth1, new Rect(0.43, 0.28, 10, 10));
        AbsoluteLayout.SetLayoutFlags(mouth1, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(mouth2, new Rect(0.45, 0.29, 10, 10));
        AbsoluteLayout.SetLayoutFlags(mouth2, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(mouth3, new Rect(0.48, 0.3, 10, 10));
        AbsoluteLayout.SetLayoutFlags(mouth3, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(mouth4, new Rect(0.52, 0.3, 10, 10));
        AbsoluteLayout.SetLayoutFlags(mouth4, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(mouth5, new Rect(0.55, 0.29, 10, 10));
        AbsoluteLayout.SetLayoutFlags(mouth5, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(mouth6, new Rect(0.57, 0.28, 10, 10));
        AbsoluteLayout.SetLayoutFlags(mouth6, AbsoluteLayoutFlags.PositionProportional);

        // Туловище
        AbsoluteLayout.SetLayoutBounds(boxView_lumememme_kesk, new Rect(0.5, 0.38, 140, 140));
        AbsoluteLayout.SetLayoutFlags(boxView_lumememme_kesk, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(button1, new Rect(0.5, 0.34, 12, 12));
        AbsoluteLayout.SetLayoutFlags(button1, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(button2, new Rect(0.5, 0.38, 12, 12));
        AbsoluteLayout.SetLayoutFlags(button2, AbsoluteLayoutFlags.PositionProportional);

        AbsoluteLayout.SetLayoutBounds(button3, new Rect(0.5, 0.42, 12, 12));
        AbsoluteLayout.SetLayoutFlags(button3, AbsoluteLayoutFlags.PositionProportional);

        // Левая рука
        AbsoluteLayout.SetLayoutBounds(hand_left, new Rect(0.25, 0.38, 60, 6));
        AbsoluteLayout.SetLayoutFlags(hand_left, AbsoluteLayoutFlags.PositionProportional);
        // Левый локоть
        AbsoluteLayout.SetLayoutBounds(hand_left_elbow, new Rect(0.24, 0.42, 6, 40));
        AbsoluteLayout.SetLayoutFlags(hand_left_elbow, AbsoluteLayoutFlags.PositionProportional);


        // Правая рука
        AbsoluteLayout.SetLayoutBounds(hand_right, new Rect(0.75, 0.38, 60, 6));
        AbsoluteLayout.SetLayoutFlags(hand_right, AbsoluteLayoutFlags.PositionProportional);
        // Правый локоть
        AbsoluteLayout.SetLayoutBounds(hand_right_elbow, new Rect(0.76, 0.42, 6, 40));
        AbsoluteLayout.SetLayoutFlags(hand_right_elbow, AbsoluteLayoutFlags.PositionProportional);

        // Нижний шар
        AbsoluteLayout.SetLayoutBounds(boxView_lumememme_keha, new Rect(0.5, 0.62, 180, 180));
        AbsoluteLayout.SetLayoutFlags(boxView_lumememme_keha, AbsoluteLayoutFlags.PositionProportional);

        Content = allm;
    }
}
