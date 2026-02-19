namespace MyFormApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        string name = nameEntry.Text?.Trim() ?? "";
        string email = emailEntry.Text?.Trim() ?? "";

        // Validate
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email))
        {
            await DisplayAlert("แจ้งเตือน", "กรุณากรอกข้อมูลให้ครบ", "OK");
            return;
        }

        resultLabel.Text = $"✅ ชื่อ: {name} | อีเมล: {email}";
    }
}