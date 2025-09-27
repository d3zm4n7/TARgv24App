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
    Switch isNightSwitch;

    public Lumememm()
    {
        // background image
        var backgroundImage = new Image
        {
            Source = "winter_day.png",
            //Aspect = Aspect.AspectFit
        };

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
        allm.Children.Add(backgroundImage);
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
        AbsoluteLayout.SetLayoutBounds(backgroundImage, new Rect(0, 0, 1, 1));
        AbsoluteLayout.SetLayoutFlags(backgroundImage, AbsoluteLayoutFlags.All);

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
        AbsoluteLayout.SetLayoutBounds(hand_left_elbow, new Rect(0.24, 0.415, 6, 40));
        AbsoluteLayout.SetLayoutFlags(hand_left_elbow, AbsoluteLayoutFlags.PositionProportional);


        // Правая рука
        AbsoluteLayout.SetLayoutBounds(hand_right, new Rect(0.75, 0.38, 60, 6));
        AbsoluteLayout.SetLayoutFlags(hand_right, AbsoluteLayoutFlags.PositionProportional);
        // Правый локоть
        AbsoluteLayout.SetLayoutBounds(hand_right_elbow, new Rect(0.76, 0.415, 6, 40));
        AbsoluteLayout.SetLayoutFlags(hand_right_elbow, AbsoluteLayoutFlags.PositionProportional);

        // Нижний шар
        AbsoluteLayout.SetLayoutBounds(boxView_lumememme_keha, new Rect(0.5, 0.62, 180, 180));
        AbsoluteLayout.SetLayoutFlags(boxView_lumememme_keha, AbsoluteLayoutFlags.PositionProportional);

        var action_lbl = new Label
        {
            Text = "Vali tegevus",
            FontSize = 18,
            TextColor = Colors.Yellow,
            HorizontalTextAlignment = TextAlignment.Center
        };

        picker = new Picker
        {
            Title = "Tegevus",
            ItemsSource = new[] { "Peida", "Näita", "Muuda värvi", "Sulata", "Tantsi" }
        };

        var action_btn = new Button
        {
            Text = "Käivita tegevus"
        };
        action_btn.Clicked += async (s, e) =>
        {
            string selected = picker.SelectedItem?.ToString();
            action_lbl.Text = $"Tegevus: {selected}";

            if (selected == "Peida")
            {
                boxView_bucket.IsVisible = false;
                boxView_lumememme_pea.IsVisible = false;
                boxView_lumememme_keha.IsVisible = false;
                boxView_lumememme_kesk.IsVisible = false;
                eye_left.IsVisible = false;
                eye_right.IsVisible = false;
                nose.IsVisible = false;
                mouth1.IsVisible = false;
                mouth2.IsVisible = false;
                mouth3.IsVisible = false;
                mouth4.IsVisible = false;
                mouth5.IsVisible = false;
                mouth6.IsVisible = false;
                boxView_lumememme_kesk.IsVisible = false;
                button1.IsVisible = false;
                button2.IsVisible = false;
                button3.IsVisible = false;
                hand_left.IsVisible = false;
                hand_left_elbow.IsVisible = false;
                hand_right.IsVisible = false;
                hand_right_elbow.IsVisible = false;
                
            }

            if (selected == "Näita")
            {
                boxView_bucket.IsVisible = true;
                boxView_lumememme_pea.IsVisible = true;
                boxView_lumememme_keha.IsVisible = true;
                boxView_lumememme_kesk.IsVisible = true;
                eye_left.IsVisible = true;
                eye_right.IsVisible = true;
                nose.IsVisible = true;
                mouth1.IsVisible = true;
                mouth2.IsVisible = true;
                mouth3.IsVisible = true;
                mouth4.IsVisible = true;
                mouth5.IsVisible = true;
                mouth6.IsVisible = true;
                boxView_lumememme_kesk.IsVisible = true;
                button1.IsVisible = true;
                button2.IsVisible = true;
                button3.IsVisible = true;
                hand_left.IsVisible = true;
                hand_left_elbow.IsVisible = true;
                hand_right.IsVisible = true;
                hand_right_elbow.IsVisible = true;
            }

            if (selected == "Muuda värvi")
            {
                Random rnd = new Random();
                var newColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                boxView_lumememme_pea.Color = newColor;
                boxView_lumememme_keha.Color = newColor;
                boxView_lumememme_kesk.Color = newColor;
            }

            if (selected == "Sulata")
            {
                await boxView_lumememme_pea.FadeTo(0, (uint)(2000 * stepper.Value));
                await boxView_lumememme_kesk.FadeTo(0, (uint)(2000 * stepper.Value));
                await boxView_lumememme_keha.FadeTo(0, (uint)(2000 * stepper.Value));
                await boxView_bucket.FadeTo(0, (uint)(2000 * stepper.Value));
            }

            if (selected == "Tantsi")
            {
                // Группа головы
                await boxView_lumememme_pea.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await boxView_bucket.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await eye_left.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await eye_right.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await nose.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await mouth1.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await mouth2.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await mouth3.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await mouth4.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await mouth5.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await mouth6.TranslateTo(-50, 0, (uint)(400 * stepper.Value));

                // Туловище
                await boxView_lumememme_kesk.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await button1.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await button2.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await button3.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await hand_left.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await hand_left_elbow.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await hand_right.TranslateTo(-50, 0, (uint)(400 * stepper.Value));
                await hand_right_elbow.TranslateTo(-50, 0, (uint)(400 * stepper.Value));

                // Нижний шар
                await boxView_lumememme_keha.TranslateTo(-50, 0, (uint)(400 * stepper.Value));

                // теперь обратно вправо
                await boxView_lumememme_pea.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await boxView_bucket.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await eye_left.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await eye_right.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await nose.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await mouth1.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await mouth2.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await mouth3.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await mouth4.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await mouth5.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await mouth6.TranslateTo(50, 0, (uint)(400 * stepper.Value));

                await boxView_lumememme_kesk.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await button1.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await button2.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await button3.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await hand_left.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await hand_left_elbow.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await hand_right.TranslateTo(50, 0, (uint)(400 * stepper.Value));
                await hand_right_elbow.TranslateTo(50, 0, (uint)(400 * stepper.Value));

                await boxView_lumememme_keha.TranslateTo(50, 0, (uint)(400 * stepper.Value));

                // возвращаем всё на место
                await boxView_lumememme_pea.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await boxView_bucket.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await eye_left.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await eye_right.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await nose.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await mouth1.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await mouth2.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await mouth3.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await mouth4.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await mouth5.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await mouth6.TranslateTo(0, 0, (uint)(400 * stepper.Value));

                await boxView_lumememme_kesk.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await button1.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await button2.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await button3.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await hand_left.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await hand_left_elbow.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await hand_right.TranslateTo(0, 0, (uint)(400 * stepper.Value));
                await hand_right_elbow.TranslateTo(0, 0, (uint)(400 * stepper.Value));

                await boxView_lumememme_keha.TranslateTo(0, 0, (uint)(400 * stepper.Value));
            }

        };

        var slider_lbl = new Label
        {
            Text = "Opacity: 1",
            FontSize = 16,
            TextColor = Colors.Green,
            HorizontalTextAlignment = TextAlignment.Center
        };

        slider = new Slider { Minimum = 0, Maximum = 1, Value = 1 };

        slider.ValueChanged += (s, e) =>
        {
            double alpha = e.NewValue;
            boxView_lumememme_pea.Opacity = alpha;
            boxView_bucket.Opacity = alpha;
            boxView_lumememme_keha.Opacity = alpha;
            boxView_lumememme_kesk.Opacity = alpha;

            eye_left.Opacity = alpha;
            eye_right.Opacity = alpha;
            nose.Opacity = alpha;
            mouth1.Opacity = alpha;
            mouth2.Opacity = alpha;
            mouth3.Opacity = alpha;
            mouth4.Opacity = alpha;
            mouth5.Opacity = alpha;
            mouth6.Opacity = alpha;
            boxView_lumememme_kesk.Opacity = alpha;
            button1.Opacity = alpha;
            button2.Opacity = alpha;
            button3.Opacity = alpha;
            hand_left.Opacity = alpha;
            hand_left_elbow.Opacity = alpha;
            hand_right.Opacity = alpha;
            hand_right_elbow.Opacity = alpha;

            slider_lbl.Text = $"Opacity: {e.NewValue:F1}";
        };

        var stepper_lbl = new Label
        {
            Text = "Speed: 1",
            FontSize = 16,
            TextColor = Colors.Green,
            HorizontalTextAlignment = TextAlignment.Center
        };

        stepper = new Stepper { Minimum = 0.2, Maximum = 2, Increment = 0.2, Value = 1 };

        stepper.ValueChanged += (s, e) =>
        {
            stepper_lbl.Text = $"Speed: {e.NewValue:F1}";
        };

        var switch_lbl = new Label
        {
            Text = "Night Mode: 1",
            FontSize = 16,
            TextColor = Colors.Green,
            HorizontalTextAlignment = TextAlignment.Center
        };

        isNightSwitch = new Switch
        {
            IsToggled = false
        };

        isNightSwitch.Toggled += (s, e) =>
        {
            bool isNight = e.Value;
            switch_lbl.Text = isNight ? "Night Mode: ON" : "Night Mode: OFF";
            backgroundImage.Source = isNight ? "winter_night.jpg" : "winter_day.jpg";

            if (isNight)
            {
                lumememm_lbl.TextColor = Colors.White;
                action_lbl.TextColor = Colors.White;
                slider_lbl.TextColor = Colors.White;
                stepper_lbl.TextColor = Colors.White;
                switch_lbl.TextColor = Colors.White;
            }
            else
            {
                lumememm_lbl.TextColor = Colors.DarkBlue;
                action_lbl.TextColor = Colors.Yellow;
                slider_lbl.TextColor = Colors.Green;
                stepper_lbl.TextColor = Colors.Green;
                switch_lbl.TextColor = Colors.Green;
            }
        };

        allm.Children.Add(action_lbl);
        allm.Children.Add(picker);
        allm.Children.Add(action_btn);
        allm.Children.Add(slider_lbl);
        allm.Children.Add(slider);
        allm.Children.Add(stepper_lbl);
        allm.Children.Add(stepper);
        allm.Children.Add(switch_lbl);
        allm.Children.Add(isNightSwitch);

        // Label для picker
        AbsoluteLayout.SetLayoutBounds(action_lbl, new Rect(0.5, 0.75, 0.9, 0.05));
        AbsoluteLayout.SetLayoutFlags(action_lbl, AbsoluteLayoutFlags.All);

        // Picker
        AbsoluteLayout.SetLayoutBounds(picker, new Rect(0.5, 0.78, 0.6, 0.06));
        AbsoluteLayout.SetLayoutFlags(picker, AbsoluteLayoutFlags.All);

        // Action button
        AbsoluteLayout.SetLayoutBounds(action_btn, new Rect(0.5, 0.82, 0.6, 0.06));
        AbsoluteLayout.SetLayoutFlags(action_btn, AbsoluteLayoutFlags.All);

        // Label для slider
        AbsoluteLayout.SetLayoutBounds(slider_lbl, new Rect(0.2, 0.89, 0.3, 0.05));
        AbsoluteLayout.SetLayoutFlags(slider_lbl, AbsoluteLayoutFlags.All);

        // Slider
        AbsoluteLayout.SetLayoutBounds(slider, new Rect(0.7, 0.89, 0.5, 0.05));
        AbsoluteLayout.SetLayoutFlags(slider, AbsoluteLayoutFlags.All);

        // Label для stepper
        AbsoluteLayout.SetLayoutBounds(stepper_lbl, new Rect(0.2, 0.95, 0.3, 0.05));
        AbsoluteLayout.SetLayoutFlags(stepper_lbl, AbsoluteLayoutFlags.All);

        // Stepper
        AbsoluteLayout.SetLayoutBounds(stepper, new Rect(0.7, 0.95, 0.3, 0.05));
        AbsoluteLayout.SetLayoutFlags(stepper, AbsoluteLayoutFlags.All);
        // Label для Switch
        AbsoluteLayout.SetLayoutBounds(switch_lbl, new Rect(0.2, 1.01, 0.3, 0.05));
        AbsoluteLayout.SetLayoutFlags(switch_lbl, AbsoluteLayoutFlags.All);

        // Switch
        AbsoluteLayout.SetLayoutBounds(isNightSwitch, new Rect(0.7, 1.01, 0.3, 0.05));
        AbsoluteLayout.SetLayoutFlags(isNightSwitch, AbsoluteLayoutFlags.All);



        Content = allm;
    }
}
