class Program
{
    static bool Vis(int a)
    {
        if (a%4 != 0) return false;
        return true;
    }
    static int[] GetNumbers(string m)
    {
        int[] a = new int[3];
        int i = 0;
        string[] dmy = m.Split('/');
        foreach (string s in dmy)
        {
            a[i] = int.Parse(s);
            i++;
        }
        return a;
    }
    static int Days(int n)
    {
        System.Console.WriteLine("введите вашу дату и год рождения в формате MM/DD/YYYY");
        string day = IsNullOrNORead();
        int[] a = GetNumbers(day);
        string  Text = DateTime.Now.ToString();
        int[] b = GetNumbers(Text);
        int d = a[2];
        int pogr = 0;

        if (Vis(a[2]))
        {
            while (d < b[2])
            {
                if (!Vis(d))
                {
                    pogr++;
                }
                d++;
            }
        }
        else
        {
            if (a[0] > 2) pogr++;
            else
            {
                if (a[1] == 29)
                {
                    pogr++;
                }
            }
        }
        if (!Vis(b[2]))
        {
            if (b[0] > 2) pogr++;
            else
            {
                if (b[1] == 29)
                {
                    pogr++;
                }
            }
        }


        return pogr;
    }
    static string IsNullOrNORead()
    {
        string? n;
        try
        {
            n = System.Console.ReadLine();
            if (n == null)
            {
                throw new Exception("не введено значение");
            }
            else
            {
                return n;
            }
        }
        catch (Exception e) {
            Console.WriteLine($"Ошибка: {e.Message}");
            return IsNullOrNORead();
        }
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("Введите ваше имя");
        string name;
        name = IsNullOrNORead();
        System.Console.WriteLine("Введите ваш возраст");
        int age;
        age = Int32.Parse(IsNullOrNORead());
        System.Console.WriteLine("“Привет, " + name + "! Через 5 лет тебе будет " + (age+5) +" лет.”");

        System.Console.WriteLine("Хочешь узнать сколько будет твой возраств в днях?");
        string answer = IsNullOrNORead();
        if (answer == "да") {
            System.Console.WriteLine("твой возраст в днях равняется: " + Days(age) );
        }
    }
}