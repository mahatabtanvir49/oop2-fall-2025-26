Console.Write("Student No 1: ");
int score1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Student No 2: ");
int score2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Student No 3: ");
int score3 = Convert.ToInt32(Console.ReadLine());

double Average = (score1 + score2 + score3) / 3.0;

Console.WriteLine($"Total Student Average score is : {Average}");