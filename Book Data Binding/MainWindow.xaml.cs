using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Book_Data_Binding
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public class BookViewModel
        {
            public BookModel CurrentBook { get; set; }
        }

        public BookViewModel ViewModel { get; set; }

        public MainWindow()
        {
            this.InitializeComponent();

            ViewModel = new BookViewModel()
            {
                CurrentBook = new BookModel
                {
                    ID = "1",
                    Name = "The Hobbit",
                    Cover = "Assets/hobbit.jpg",
                    Author = "J.R.R. Tolkien",
                    Year = 1937,
                    ISBN = "978-0-395-08254-1"
                }
            };
        }
    }
}
