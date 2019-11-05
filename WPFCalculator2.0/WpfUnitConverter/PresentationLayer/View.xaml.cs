using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfUnitConverter.PresentationLayer
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        public static ViewModel viewModels;
        public View(ViewModel viewModel)
        {
            InitializeComponent();

            viewModels = viewModel;
            this.DataContext = viewModels;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if (viewModels.ClearOnPush == true)
                {
                    SolutionBox.Text = "";
                    viewModels.ClearOnPush = false;
                }
                SolutionBox.Text += "1";
                if (viewModels.IsOnOperandOne == true)
                {
                    viewModels.OperandOneString += "1";
                }
                else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                {
                    viewModels.OperandTwoString += "1";
                }
            }
        }
         

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if (viewModels.ClearOnPush == true)
                {
                    SolutionBox.Text = "";
                    viewModels.ClearOnPush = false;
                }
                SolutionBox.Text += "2";
                if (viewModels.IsOnOperandOne == true)
                {
                    viewModels.OperandOneString += "2";
                }
                else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                {
                    viewModels.OperandTwoString += "2";
                }
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if (viewModels.ClearOnPush == true)
                {
                    SolutionBox.Text = "";
                    viewModels.ClearOnPush = false;
                }
                SolutionBox.Text += "3";
                if (viewModels.IsOnOperandOne == true)
                {
                    viewModels.OperandOneString += "3";
                }
                else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                {
                    viewModels.OperandTwoString += "3";
                }
            }
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if (viewModels.ClearOnPush == true)
                {
                    SolutionBox.Text = "";
                    viewModels.ClearOnPush = false;
                }
                SolutionBox.Text += "4";
                if (viewModels.IsOnOperandOne == true)
                {
                    viewModels.OperandOneString += "4";
                }
                else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                {
                    viewModels.OperandTwoString += "4";
                }
            }
        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if (viewModels.ClearOnPush == true)
                {
                    SolutionBox.Text = "";
                    viewModels.ClearOnPush = false;
                }
                SolutionBox.Text += "5";
                if (viewModels.IsOnOperandOne == true)
                {
                    viewModels.OperandOneString += "5";
                }
                else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                {
                    viewModels.OperandTwoString += "5";
                }
            }
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if (viewModels.ClearOnPush == true)
                {
                    SolutionBox.Text = "";
                    viewModels.ClearOnPush = false;
                }
                SolutionBox.Text += "6";
                if (viewModels.IsOnOperandOne == true)
                {
                    viewModels.OperandOneString += "6";
                }
                else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                {
                    viewModels.OperandTwoString += "6";
                }
            }
        }

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if (viewModels.ClearOnPush == true)
                {
                    SolutionBox.Text = "";
                    viewModels.ClearOnPush = false;
                }
                SolutionBox.Text += "7";
                if (viewModels.IsOnOperandOne == true)
                {
                    viewModels.OperandOneString += "7";
                }
                else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                {
                    viewModels.OperandTwoString += "7";
                }
            }
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if (viewModels.ClearOnPush == true)
                {
                    SolutionBox.Text = "";
                    viewModels.ClearOnPush = false;
                }
                SolutionBox.Text += "8";
                if (viewModels.IsOnOperandOne == true)
                {
                    viewModels.OperandOneString += "8";
                }
                else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                {
                    viewModels.OperandTwoString += "8";
                }
            }
        }

        private void Btn9_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if (viewModels.ClearOnPush == true)
                {
                    SolutionBox.Text = "";
                    viewModels.ClearOnPush = false;
                }
                SolutionBox.Text += "9";
                if (viewModels.IsOnOperandOne == true)
                {
                    viewModels.OperandOneString += "9";
                }
                else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                {
                    viewModels.OperandTwoString += "9";
                }
            }
        }

        private void BtnDEC_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if ((viewModels.IsOnOperandOne && viewModels.OperandOneString != "" && viewModels.OperandOneString != null) || (viewModels.IsOnOperandOne == false && viewModels.OperandTwoString != "" && viewModels.OperandTwoString != null))
                {
                    if (viewModels.ClearOnPush == true)
                    {
                        SolutionBox.Text = "";
                        viewModels.ClearOnPush = false;
                    }
                    if (viewModels.IsOnOperandOne == true)
                    {
                        if (!viewModels.OperandOneString.Contains("."))
                        {
                            viewModels.OperandOneString += ".";
                            SolutionBox.Text += ".";
                        }
                    }
                    else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                    {
                        if (!viewModels.OperandTwoString.Contains("."))
                        {
                            viewModels.OperandTwoString += ".";
                            SolutionBox.Text += ".";
                        }
                    }
                }
            }
        }

        private void Btn0_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsUnary == false)
            {
                if (viewModels.ClearOnPush == true)
                {
                    SolutionBox.Text = "";
                    viewModels.ClearOnPush = false;
                }
                SolutionBox.Text += "0";
                if (viewModels.IsOnOperandOne == true)
                {
                    viewModels.OperandOneString += "0";
                }
                else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false)
                {
                    viewModels.OperandTwoString += "0";
                }
            }
        }

        private void BtnCE_Click(object sender, RoutedEventArgs e)
        {
            SolutionBox.Text += "";

            viewModels.IsOnOperandOne = true;
            viewModels.IsUnary = false;
            viewModels.OperandOne = 0;
            viewModels.OperandTwo = 0;
            viewModels.OperandOneString = "";
            viewModels.OperandTwoString = "";
            SolutionBox.Text = "";

        }

        private void BtnPlus_Click(object sender, RoutedEventArgs e)
        {

            if (viewModels.IsOnOperandOne == true && viewModels.OperandOneString != "")
            {
                viewModels.OperandOne = double.Parse(viewModels.OperandOneString);
                viewModels.IsOnOperandOne = false;  
                viewModels.redoEquationString(ViewModel.expressions.Addition, false);
            }
            else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false && viewModels.ExpressionSet == true)
            {
                viewModels.redoEquationString(ViewModel.expressions.Addition, false);
            }
        }

        private void BtnSqr_Click(object sender, RoutedEventArgs e)
        {

            if (viewModels.IsOnOperandOne == true && viewModels.OperandOneString != "")
            {
                viewModels.OperandOne = double.Parse(viewModels.OperandOneString);
                viewModels.IsOnOperandOne = false;
                viewModels.redoEquationString(ViewModel.expressions.Square, true);
            }
            else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false && viewModels.ExpressionSet == true)
            {
                viewModels.redoEquationString(ViewModel.expressions.Square, false);
            }
        }

        private void BtnSin_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsOnOperandOne == true && viewModels.OperandOneString != "")
            {
                viewModels.OperandOne = double.Parse(viewModels.OperandOneString);
                viewModels.IsOnOperandOne = false;
                viewModels.redoEquationString(ViewModel.expressions.Sin, true);
            }
            else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false && viewModels.ExpressionSet == true)
            {
                viewModels.redoEquationString(ViewModel.expressions.Sin, false);
            }
        }

        private void BtnSub_Click(object sender, RoutedEventArgs e)
        {


            if (viewModels.IsOnOperandOne == true && viewModels.OperandOneString != "")
            {
                viewModels.OperandOne = double.Parse(viewModels.OperandOneString);
                viewModels.IsOnOperandOne = false;
                viewModels.redoEquationString(ViewModel.expressions.Subtraction, false);
            }
            else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false && viewModels.ExpressionSet == true)
            {
                viewModels.redoEquationString(ViewModel.expressions.Subtraction, false);
            }
        }

        private void BtnCos_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsOnOperandOne == true && viewModels.OperandOneString != "")
            {
                viewModels.OperandOne = double.Parse(viewModels.OperandOneString);
                viewModels.IsOnOperandOne = false;
                viewModels.redoEquationString(ViewModel.expressions.Cos, true);
            }
            else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false && viewModels.ExpressionSet == true)
            {
                viewModels.redoEquationString(ViewModel.expressions.Cos, false);
            }
        }

        private void BtnMul_Click(object sender, RoutedEventArgs e)
        {


            if (viewModels.IsOnOperandOne == true && viewModels.OperandOneString != "")
            {
                viewModels.OperandOne = double.Parse(viewModels.OperandOneString);
                viewModels.IsOnOperandOne = false;
                viewModels.redoEquationString(ViewModel.expressions.Multiplication, false);
            }
            else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false && viewModels.ExpressionSet == true)
            {
                viewModels.redoEquationString(ViewModel.expressions.Multiplication, false);
            }
        }

        private void BtnTan_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsOnOperandOne == true && viewModels.OperandOneString != "")
            {
                viewModels.OperandOne = double.Parse(viewModels.OperandOneString);
                viewModels.IsOnOperandOne = false;
                viewModels.redoEquationString(ViewModel.expressions.Tan, true);
            }
            else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false && viewModels.ExpressionSet == true)
            {
                viewModels.redoEquationString(ViewModel.expressions.Tan, false);
            }
        }

        private void BtnDiv_Click(object sender, RoutedEventArgs e)
        {


            if (viewModels.IsOnOperandOne == true && viewModels.OperandOneString != "")
            {
                viewModels.OperandOne = double.Parse(viewModels.OperandOneString);
                viewModels.IsOnOperandOne = false;
                viewModels.redoEquationString(ViewModel.expressions.Division, false);
            }
            else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false && viewModels.ExpressionSet == true)
            {
                viewModels.redoEquationString(ViewModel.expressions.Division, false);
            }
        }


        private void BtnPercent_Click(object sender, RoutedEventArgs e)
        { 
            if (viewModels.IsOnOperandOne == false && viewModels.OperandTwoString != "" && viewModels.OperandTwoString != null)
            {
                viewModels.EquationString = viewModels.OperandOneString + viewModels.convertExpression(viewModels.CurrentExpression) + viewModels.OperandTwoString + "%";
            }
        }

        private void BtnSqrRt_Click(object sender, RoutedEventArgs e)
        {
            if (viewModels.IsOnOperandOne == true && viewModels.OperandOneString != "")
            {
                viewModels.OperandOne = double.Parse(viewModels.OperandOneString);
                viewModels.IsOnOperandOne = false;
                viewModels.redoEquationString(ViewModel.expressions.Sqrt, true);
            }
            else if (viewModels.IsOnOperandOne == false && viewModels.IsUnary == false && viewModels.ExpressionSet == true)
            {
                viewModels.redoEquationString(ViewModel.expressions.Sqrt, false);
            }
        }

        private void BtnEqual_Click(object sender, RoutedEventArgs e)
        {
            SolutionBox.Text = "";
            if (viewModels.IsUnary == false && viewModels.OperandTwoString != "" && viewModels.OperandTwoString != null)
            {
                viewModels.OperandTwo = double.Parse(viewModels.OperandTwoString);
            }

            if (viewModels.EquationString.Contains("%"))
            { 
                double newOpTwo = 0;
                newOpTwo = viewModels.OperandTwo / 100;
                viewModels.OperandTwo = newOpTwo;
                viewModels.OperandTwoString = newOpTwo.ToString();
            }
            SolutionBox.Text = viewModels.Solve().ToString();

            SolutionBox.Text += "";

            viewModels.IsOnOperandOne = true;
            viewModels.IsUnary = false;
            viewModels.OperandOne = 0;
            viewModels.OperandTwo = 0;
            viewModels.OperandOneString = "";
            viewModels.OperandTwoString = "";
            viewModels.ExpressionSet = false;
            viewModels.CurrentExpression = ViewModel.expressions.none;
            viewModels.ClearOnPush = true;

        }
    }
}
