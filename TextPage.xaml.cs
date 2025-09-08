namespace TARgv24;

public partial class TextPage : ContentPage
{
	Label lblTekst;
	Editor editorTekst;
	HorizontalStackLayout hsl;


	public TextPage()
	{
		//InitializeComponent();
		lblTekst = new Label
		{
			Text = "Tekst: ",
			FontSize = 20,
			TextColor = Colors.Black,
			FontFamily = "LowRider BB 400",
		};
		editorTekst = new Editor
		{
			FontSize = 20,
			BackgroundColor = Color.FromRgb(200, 200, 0),
			FontFamily = "LowRider BB 400",
			AutoSize = EditorAutoSizeOption.TextChanges,
			Placeholder = "Siia tuleb tekst",
			PlaceholderColor = Colors.White,
			FontAttributes = FontAttributes.Bold,
		};
		editorTekst.TextChanged += EditorTekst_TextChanged;

		hsl = new HorizontalStackLayout
		{
			BackgroundColor = Color.FromRgb(200, 200, 0),
			Children = {lblTekst, editorTekst},
			HorizontalOptions = LayoutOptions.Center,
		};
		Content = hsl;
	}
	private void EditorTekst_TextChanged(object? sender, TextChangedEventArgs e)
	{
		lblTekst.Text = editorTekst.Text;
	}
}