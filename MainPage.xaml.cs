namespace mju23_opc_MAUI_hi_lo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGuessClicked(object sender, EventArgs e)
        {
            string numStr = Guess.Text;
            MessageText.Text = "Gissade "+numStr;
            SemanticScreenReader.Announce(MessageText.Text);
            Guess.Text = "";
            SemanticScreenReader.Announce(Guess.Text);
        }
    }
}