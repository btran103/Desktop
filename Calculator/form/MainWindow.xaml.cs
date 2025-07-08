using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtOp1.Text);
                int num2 = Convert.ToInt32(txtOp2.Text);
                int answer = num1 + num2;
                txtAns.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Please enter integers only.\n\n" + ex.Message,
                                "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtOp1.Text);
                int num2 = Convert.ToInt32(txtOp2.Text);
                int answer = num1 - num2;
                txtAns.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Please enter integers only.\n\n" + ex.Message,
                                "Input Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void chkCenter_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)chkCenter.IsChecked)
            {
                txtOp1.TextAlignment = TextAlignment.Center;
                txtOp2.TextAlignment = TextAlignment.Center;
                txtAns.TextAlignment = TextAlignment.Center;
            }
            else
            {
                txtOp1.TextAlignment = TextAlignment.Left;
                txtOp2.TextAlignment = TextAlignment.Left;
                txtAns.TextAlignment = TextAlignment.Left;
            }
        }
    }
}
