int value1 = 8;
int value2 = 9;

Console.WriteLine($"Before swap value1: {value1}, value2 :{value2}");

value1 = value1 + value2;
value2 = value1 - value2;
value1 = value1 - value2;

Console.WriteLine($"After swap :  value1 = {value1}, value2 = {value2}");