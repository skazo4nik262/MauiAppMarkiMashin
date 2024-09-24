namespace MauiAppMarkiMashin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        List<Group> Groups = DataBase.getInstance().Zapolnenie();

        
    }

}
