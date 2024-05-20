namespace Notes;

public partial class NotePage : ContentPage
{
	public NotePage()
	{
		InitializeComponent();
	}

    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");


}