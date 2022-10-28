using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CloseButton.Click += (s, e) => Close();

            CEBtn.Click += ClearButton_Click;
            CBtn.Click += ClearButton_Click;
            ClearLastBtn.Click += ClearButton_Click;
            DivBtn.Click += SimpleButton_Click;
            SevenBtn.Click += SimpleButton_Click;
            EightBtn.Click += SimpleButton_Click;
            NineBtn.Click += SimpleButton_Click;
            MultBtn.Click += SimpleButton_Click;
            FourBtn.Click += SimpleButton_Click;
            FiveBtn.Click += SimpleButton_Click;
            SixBtn.Click += SimpleButton_Click;
            SubBtn.Click += SimpleButton_Click;
            OneBtn.Click += SimpleButton_Click;
            TwoBtn.Click += SimpleButton_Click;
            ThreeBtn.Click += SimpleButton_Click;
            AddBtn.Click += SimpleButton_Click;
            DotBtn.Click += SimpleButton_Click;
            ZeroBtn.Click += SimpleButton_Click;
            EqualsBtn.Click += EqualsButton_Click;
        }
        private void SimpleButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Output.Text += button.Content.ToString();
        }
        private void EqualsButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                String oper;
                int indexOper = 0;
                if (Output.Text.Contains("+")) indexOper = Output.Text.IndexOf("+");
                else if (Output.Text.Contains("-")) indexOper = Output.Text.IndexOf("-");
                else if (Output.Text.Contains("/")) indexOper = Output.Text.IndexOf("/");
                else if (Output.Text.Contains("*")) indexOper = Output.Text.IndexOf("*");
                oper = Output.Text.Substring(indexOper, 1);
                double oper1 = Convert.ToDouble(Output.Text.Substring(0, indexOper));
                double oper2 = Convert.ToDouble(Output.Text.Substring(indexOper + 1, Output.Text.Length - indexOper - 1));
                if (oper == "+")  Result.Text += Convert.ToString(oper1 + oper2);
                else if (oper == "-") Result.Text += Convert.ToString(oper1 - oper2);
                else if (oper == "/") Result.Text += Convert.ToString(oper1 / oper2);
                else if (oper == "*") Result.Text += Convert.ToString(oper1 * oper2);
            }
            catch (Exception ex) { this.Output.Text = ex.Message; }
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Output.Text = " ";
            Result.Text = " ";
        }
    }
}