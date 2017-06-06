using Xamarin.Forms;

namespace SigaMATA270
{
    public partial class App : Application
    {
        static Util.Database database;

        public static Util.Database Database 
        {
            get 
            {
                if(Database == null) 
                {
                    database = new Util.Database(DependencyService.Get<Contracts.IFileHelper>().GetLocalFilePath("siga.db3"));        
                }
            }
        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.LoginView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
