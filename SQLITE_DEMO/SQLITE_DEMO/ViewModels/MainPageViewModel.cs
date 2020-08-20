using Bogus;
using PropertyChanged;
using SQLITE_DEMO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace SQLITE_DEMO.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel
    {
        public List<Customer> Customers { get; set; }
        public ICommand AddCommand { get; set; }
        public Customer NewCustomer { get; set; }
        public ICommand DeleteCommand { get; set; }

        public MainPageViewModel()
        {
            var orders = App.OrderRepository.GetItems();
            Refresh();
            GenerateNewCustomer();

            AddCommand = new Command(() =>
            {
                App.CustomerRepository.SaveItemWithChildren(NewCustomer);
                Console.WriteLine(App.CustomerRepository.StatusMessage);
                GenerateNewCustomer();
                Refresh();
            });

            DeleteCommand = new Command((customer) =>
            {
                App.CustomerRepository.DeleteItem((Customer)customer);
                Refresh();
            });
        }

        private void GenerateNewCustomer()
        {
            NewCustomer = new Faker<Customer>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.Address, f => f.Person.Address.Street)
                .Generate();

            NewCustomer.Passports = new List<Passport>
            {
                new Passport
                {
                    ExpirationDate = DateTime.Now.AddDays(30)
                },
                new Passport
                {
                    ExpirationDate = DateTime.Now.AddDays(15)
                },
            };

            /*new Passport
            {
                ExpirationDate = DateTime.Now.AddDays(30)
            };*/
        }

        private void Refresh()
        {
            Customers = App.CustomerRepository.GetItemsWithChildren();
            //Customers = App.CustomerRepository.GetItems();
            //Customers = App.CustomerRepository.Get(x=> x.Name.StartsWith("a"));
            var passport = App.PassportRepository.GetItems();
        }
    }
}
