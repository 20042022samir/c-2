
#region task-1
do
{
    try
    {
        Console.WriteLine("zehmet olmasa topladiginiz bali daxil edin");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade >= 91 && grade <= 100)
        {
            Console.WriteLine("qiymet--A");
        }
        else if (grade >= 81 && grade <= 90)
        {
            Console.WriteLine("qiymet--B");
        }
        else if (grade >= 71 && grade <= 80)
        {
            Console.WriteLine("qiymet--C");
        }
        else if (grade >= 61 && grade <= 70)
        {
            Console.WriteLine("qiymet--D");
        }
        else if (grade >= 51 && grade <= 61)
        {
            Console.WriteLine("qiymet--E");
        }
        else if (grade > 100 || grade < 0)
        {
            Console.WriteLine("0-100 arasinda olur");
        }
        else
        {
            Console.WriteLine("kesilmisen");
        }
    }
    catch (Exception)
    {
        Console.WriteLine("duzgun eded daxil et");
    }
}
while (true);
#endregion


#region- task2
int[] numbers = { 1, -5, -8, -9, 34, 99, 21 };

int CounterNegative = 0;
int CounterPositive = 0;

for (int i = 0; i < numbers.Length; i++)
{
	if (numbers[i] > 0)
	{
		CounterPositive++;
	}
	else if (numbers[i] < 0)
	{
		CounterNegative++;
	}
}
Console.WriteLine(CounterPositive);
Console.WriteLine(CounterNegative);
#endregion


#region task-3
Console.WriteLine("zehmet olmasa nece eded daxil etmek istediyinizi qeyd edin");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[num];

for (int i = 0; i < num; i++)
{
    Console.WriteLine("zehmet olmasa" + (i + 1) + "-ci ededi daxil edin");
    int x = Convert.ToInt32(Console.ReadLine());
    array[i] = x;
}


int biggest = 0;
for (int i = 0; i < num; i++)
{
    if (array[i] > biggest)
    {
        biggest = array[i];
    }
}

Console.WriteLine(biggest);
#endregion




