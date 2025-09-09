using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TARgv24;

public partial class StartPage : ContentPage
{
	public List<ContentPage> lehed = new List<ContentPage>() { new TextPage(), new FigurePage(), new TimerPage(), new Valgusfoor()}; // describing all pages what we use in our project
	public List<string> tekstid = new List<string>() { "Tee lahti leht Teks'ga", "Tee lahti Figure leht", "Käivita timerid", "Valgusfoor" }; // describtion on action
	ScrollView sv;
	VerticalStackLayout vsl;


	public StartPage() //constuctor
	{

		//InitializeComponent();
		Title = "Avaleht";
		vsl = new VerticalStackLayout { BackgroundColor = Color.FromRgb(200, 200, 0) };
		for (int i = 0; i < tekstid.Count; i++)
		{
			Button nupp = new Button
			{
				Text = tekstid[i],
				FontSize = 20,
				BackgroundColor = Color.FromRgb(200, 200, 0),
				TextColor = Colors.Black,
				CornerRadius = 20,
				FontFamily = "LowRider BB 400",
				ZIndex = i,
			};
			vsl.Add(nupp);
            nupp.Clicked += Nupp_Nav;
		}
		sv = new ScrollView { Content = vsl };
		Content = sv;

	}

    private async void Nupp_Nav(object? sender, EventArgs e)
    {
		Button nupp = (Button)sender;
		await Navigation.PushAsync(lehed[nupp.ZIndex]);
    }
}