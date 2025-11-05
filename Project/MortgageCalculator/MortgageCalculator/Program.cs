using System.Globalization;

Console.WriteLine("Mortage Calculator Bangladesh");

double loanAmount;
double interestRate;
int loanPeriod;

Console.Write("Enter loan amount: ");
loanAmount = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter annual interest rate (in %): ");
interestRate = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter loan period (in Years): ");
loanPeriod = Convert.ToInt32(Console.ReadLine());


double monthlyInterestRate = interestRate / 100 / 12;
int totalPayment = loanPeriod * 12;

double monthlyPayment = loanAmount * monthlyInterestRate * Math.Pow(1 + monthlyInterestRate, totalPayment) / (Math.Pow(1 + monthlyInterestRate, totalPayment) - 1);


double totalPaid = monthlyPayment * totalPayment;
double totalInterest = totalPaid - loanAmount;


CultureInfo bdCulture = new CultureInfo("bn-BD");

Console.WriteLine($"\nMonthly Payment: {monthlyPayment.ToString("C", bdCulture)}");
Console.WriteLine($"\nTotal Paid: {totalPaid.ToString("C", bdCulture)}");
Console.WriteLine($"\nTotal Interest: {totalInterest.ToString("C", bdCulture)}");
