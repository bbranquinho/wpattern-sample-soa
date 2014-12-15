using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Arquitetura.Business.BusinessObjects;
using Arquitetura.Data.Repository;
using Arquitetura.Data.RepositoryInterfaces;

namespace Arquitetura.Presentation.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ICategoryRepository CategoryRepository { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeCustom();
        }

        private void ButtonListCategories_Click(object sender, RoutedEventArgs e)
        {
            foreach(var cat in CategoryRepository.GetAll())
            {
                TextBoxListcategories.Text += String.Format("Category: ID {0} and Name {1}\n", cat.CategoryID, cat.CategoryName);
            }
        }

        private void InitializeCustom()
        {
            CategoryRepository = new CategoryRepository();
        }
    }
}
