namespace LabelStyleFontIssue
{
    public partial class StyledPage : ContentPage
    {
        public StyledPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }

}
