using SQLITE_DEMO.Models;
using SQLITE_DEMO.Repositories;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SQLITE_DEMO
{
    public partial class App : Application
    {
        private static BaseRepository<Customer> _customerRepository;

        public static BaseRepository<Customer> CustomerRepository
        {
            get
            {
                if (_customerRepository == null)
                {
                    _customerRepository = new BaseRepository<Customer>();
                }
                return _customerRepository;
            }
        }

        private static BaseRepository<Order> _orderRepository;

        public static BaseRepository<Order> OrderRepository
        {
            get
            {
                if (_orderRepository == null)
                {
                    _orderRepository = new BaseRepository<Order>();
                }
                return _orderRepository;
            }
        }

        private static BaseRepository<Passport> _passportRepository;

        public static BaseRepository<Passport> PassportRepository
        {
            get
            {
                if (_passportRepository == null)
                {
                    _passportRepository = new BaseRepository<Passport>();
                }
                return _passportRepository;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
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
