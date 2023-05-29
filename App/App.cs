using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test2_sql_f
{
    public partial class App : Application
    {
        static UserOperation db;

        // Create the database connection as a singleton.
        public static UserOperation UserSQLite
        {
            get
            {
                if (db == null)
                {
                    db = new UserOperation(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NumberCodeOpreration.db3"));
                }
                return db;
            }
        }
        Users user;
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new HomePage(user));

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
