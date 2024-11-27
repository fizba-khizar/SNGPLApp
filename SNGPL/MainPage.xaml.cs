namespace SNGPL
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
          /*  count += 10;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);*/
            await Launcher.OpenAsync("https://pho-gis-03.sngpl.com.pk/sngplgis/apps/dashboards/2e0e12a035684bb292944f9f65b14295");
        }

        /*  private async void OnCounterClicked(object sender, EventArgs e)
          {
              string url = "https://www.google.com"; // Change this to your test URL
              bool canOpen = await Launcher.CanOpenAsync(url);
              Console.WriteLine($"Can Open URL: {canOpen}");

              if (canOpen)
              {
                  await Launcher.OpenAsync("https://pho-gis-03.sngpl.com.pk/sngplgis/apps/dashboards/2e0e12a035684bb292944f9f65b14295");
                  //}
                  //else
                  //{
                  //    await Application.Current.MainPage.DisplayAlert("Error", $"Cannot open the URL: {url}", "OK");
                  //}
              }

          }*/
    }
}
