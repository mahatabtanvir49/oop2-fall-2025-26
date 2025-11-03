Console.Write("Write the celsious value : ");
int celsius = Convert.ToInt32(Console.ReadLine());
double fahrenheit = (celsius * 9.0 / 5.0) + 32;
Console.WriteLine($"Celsious to Fahrenheit value is: {fahrenheit}");