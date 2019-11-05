using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfUnitConverter.PresentationLayer
{
   public class ViewModel : ObservableObject
    {
        private double operandOne;

        public double OperandOne
        {
            get { return operandOne; }
            set { operandOne = value; }
        }

        private bool expressionSet;

        public bool ExpressionSet
        {
            get { return expressionSet; }
            set { expressionSet = value; }
        }


        private double operandTwo;

        public double OperandTwo
        {
            get { return operandTwo; }
            set { operandTwo = value; }
        }

        private string operandOneString;

        public string OperandOneString
        {
            get { return operandOneString; }
            set { operandOneString = value; }
        }

        private string operandTwoString;

        public string OperandTwoString
        {
            get { return operandTwoString; }
            set { operandTwoString = value; }
        }

        private bool isOnOperandOne = true;

        public bool IsOnOperandOne
        {
            get { return isOnOperandOne; }
            set { isOnOperandOne = value; }
        }

        private bool clearOnPush;

        public bool ClearOnPush
        {
            get { return clearOnPush; }
            set { clearOnPush = value; }
        }


        private bool isUnaryOperator;

        public bool IsUnary
        {
            get { return isUnaryOperator; }
            set { isUnaryOperator = value; }
        }

        private double solution;

        public double Solution
        {
            get { return solution; }
            set { solution = value; }
        }


        public enum expressions{
            Addition, Subtraction, Multiplication, Division, Sin, Cos, Tan, Square, Sqrt, Percent, none
        }

        private expressions expression;

        public expressions CurrentExpression
        {
            get { return expression; }
            set { expression = value; }
        }

        public string convertExpression(ViewModel.expressions expressionsent)
        {
            string expressionString = "";
            switch (expressionsent)
            {
                case expressions.Addition:
                    expressionString = "+";
                    break;
                case expressions.Subtraction:
                    expressionString = "-";

                    break;
                case expressions.Multiplication:
                    expressionString = "*";

                    break;
                case expressions.Division:
                    expressionString = "/";

                    break;
                case expressions.Sin:
                    expressionString = "Sin()";

                    break;
                case expressions.Cos:
                    expressionString = "Cos()";

                    break;
                case expressions.Tan:
                    expressionString = "Tan()";

                    break;
                case expressions.Square:
                    expressionString = "^2";

                    break;
                case expressions.Sqrt:
                    expressionString = "√";

                    break;
                case expressions.Percent:
                    expressionString = "%";

                    break;
                case expressions.none: 

                    break;
                default:
                    break;
            }
            return expressionString;
        }
        public void redoEquationString(ViewModel.expressions expressionSent, bool _Unary)
        {
            IsUnary = _Unary;
            ExpressionSet = true;
            switch (_Unary)
            {
                case true:
                        if (OperandOneString != "" && OperandOneString != null && ExpressionSet == true)
                        { 
                            CurrentExpression = expressionSent;
                        if (CurrentExpression == ViewModel.expressions.Sqrt)
                        {
                            EquationString = convertExpression(CurrentExpression) + OperandOneString;
                        }
                        else if (CurrentExpression == ViewModel.expressions.Sin)
                        {
                            EquationString = "Sin("+OperandOneString+")";
                        }
                        else if (CurrentExpression == ViewModel.expressions.Cos)
                        {
                            EquationString = "Cos(" + OperandOneString + ")";
                        }
                        else if (CurrentExpression == ViewModel.expressions.Tan)
                        {
                            EquationString = "Tan(" + OperandOneString + ")";
                        }
                        else
                        {
                            EquationString = OperandOneString + convertExpression(CurrentExpression);
                        }
                        
                        }  
                    break;
                case false:
                    if (operandTwoString == "" || operandTwoString == null) {
                        if (OperandOneString != "" && OperandOneString != null && ExpressionSet == true)
                        {
                            CurrentExpression = expressionSent;
                            EquationString = OperandOneString + convertExpression(CurrentExpression); 

                        }
                    }
                    if (OperandOneString != "" && OperandOneString != null && ExpressionSet == true && operandTwoString != "" && operandTwoString != null)
                    {
                        CurrentExpression = expressionSent;
                        EquationString = OperandOneString + convertExpression(CurrentExpression) + operandTwoString; 
                    }
                    break;
                default:
                    break;
            }
        }


        private string equationString = "";

        public string EquationString
        {
            get { return equationString; }
            set { equationString = value; OnPropertyChanged(nameof(EquationString)); }
        }


        public double Solve()
        {
            double solution = 0;
            if (IsUnary == false)
            {
                if (OperandOneString != "" && operandTwoString != "")
                {
                    switch (CurrentExpression) {
                        case ViewModel.expressions.Addition:
                            solution = OperandOne + OperandTwo;
                            break;
                        case ViewModel.expressions.Subtraction:
                            solution = OperandOne - OperandTwo;
                            break;
                        case ViewModel.expressions.Division:
                            solution = OperandOne / OperandTwo;
                            break;
                        case ViewModel.expressions.Multiplication:
                            solution = OperandOne * OperandTwo;
                            break; 
                    }

                }
            }
            if (IsUnary == true)
            {
                if (OperandOneString != "" || OperandOneString != null)
                {
                    switch (CurrentExpression)
                    {
                        case ViewModel.expressions.Sin:
                            solution = Math.Sin(OperandOne);
                            break;
                        case ViewModel.expressions.Sqrt:
                            solution = Math.Sqrt(OperandOne);
                            break;
                        case ViewModel.expressions.Square:
                            solution = Math.Pow(OperandOne, 2);
                            break;
                        case ViewModel.expressions.Tan:
                            solution = Math.Tan(OperandOne);
                            break;
                        case ViewModel.expressions.Cos:
                            solution = Math.Cos(OperandOne);
                            break;

                    }

                }
            }
            return solution;
        }


    }
}
