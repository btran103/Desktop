using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace TwoControls
{
    class TwoControls : Window
    {
        private TextBox txtName;

        [STAThread]
        static void Main(string[] args)
        {
            Application app = new Application();
            app.Run(new TwoControls());
        }

        public TwoControls()
        {
            Title = "Two Controls Demo";
            Width = 288;

            const int MARGINSIZE = 10;

            StackPanel panel = new StackPanel();
            Content = panel;
            panel.Background = Brushes.Beige;
            panel.Margin = new Thickness(MARGINSIZE);

            txtName = new TextBox();
            txtName.FontSize = 16;
            txtName.HorizontalAlignment = HorizontalAlignment.Center;
            txtName.Width = Width / 2;
            txtName.Margin = new Thickness(MARGINSIZE);
            panel.Children.Add(txtName);

            Button btnGreet = new Button();
            btnGreet.Content = "Say Hello";
            btnGreet.FontSize = 16;
            btnGreet.HorizontalAlignment = HorizontalAlignment.Center;
            btnGreet.Margin = new Thickness(MARGINSIZE);
            btnGreet.Click += ButtonOnClick;
            panel.Children.Add(btnGreet);

            SizeToContent = SizeToContent.Height;
        }

        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            MessageBox.Show("Hello, " + txtName.Text, "Greeting");
        }
    }
}
