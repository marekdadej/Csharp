using System;
using System.Collections.Generic;

namespace Calculator.Models
{
    public class CalculatorModel
    {
        public float a { get; set; }
        public float b { get; set; }
        public float c { get; set; }
        public string oper { get; set; } = string.Empty;
        public float wynik { get; set; }
        public float? x1 { get; set; }
        public float? x2 { get; set; }
        public string ErrorMessage { get; set; }
        public List<string> History { get; private set; } = new List<string>();
        public bool ShowCField => oper == "delta";

        public void Dzialanie()
        {
            try
            {
                if (!ValidateInput())
                {
                    return;
                }

                switch (oper)
                {
                    case "+":
                        wynik = a + b;
                        break;
                    case "-":
                        wynik = a - b;
                        break;
                    case "*":
                        wynik = a * b;
                        break;
                    case "/":
                        wynik = b != 0 ? a / b : float.NaN;
                        break;
                    case "sin":
                        wynik = (float)Math.Sin(DegToRad(a));
                        break;
                    case "cos":
                        wynik = (float)Math.Cos(DegToRad(a));
                        break;
                    case "tg":
                        wynik = (float)Math.Tan(DegToRad(a));
                        break;
                    case "ctg":
                        wynik = 1 / (float)Math.Tan(DegToRad(a));
                        break;
                    case "potega":
                        wynik = (float)Math.Pow(a, b);
                        break;
                    case "pierwiastek":
                        wynik = (float)Math.Sqrt(a);
                        break;
                    case "log":
                        wynik = (float)Math.Log(a, b);
                        break;
                    case "%":
                        wynik = a * (b / 100);
                        break;
                    case "delta":
                        wynik = Delta();
                        break;
                    case "rozwiaz":
                        RozwiazRownanieKwadratowe();
                        break;
                    default:
                        throw new ArgumentException("Nieprawidłowy operator");
                }

                AddToHistory($"{oper}: {wynik}");
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }

        private bool ValidateInput()
        {
            if (oper == "pierwiastek" && a < 0)
            {
                ErrorMessage = "Nie można obliczyć pierwiastka z liczby ujemnej.";
                return false;
            }
            return true;
        }

        private void AddToHistory(string record)
        {
            History.Insert(0, record);
            if (History.Count > 10)
            {
                History.RemoveAt(History.Count - 1);
            }
        }

        private float Delta()
        {
            return b * b - 4 * a * c;
        }

        private void RozwiazRownanieKwadratowe()
        {
            float delta = Delta();
            if (delta > 0)
            {
                x1 = (-b + (float)Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - (float)Math.Sqrt(delta)) / (2 * a);
            }
            else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
            }
            else
            {
                x1 = x2 = null;
            }
        }

        private static double DegToRad(double degrees)
        {
            return (Math.PI / 180) * degrees;
        }
    }
}

