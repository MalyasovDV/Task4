/*git branch -M main
git remote add origin https://github.com/MalyasovDV/Task4.git
git push -u origin main*/

int Compare(int a, int b, int c)
{
    if (a > b)
        if (a > c)
            return a;
        else
            return c;
    else
        if (b > c)
            return b;
        else 
            return c;
}

int a = 2,b = 3, c = 7;
Console.WriteLine(a + ", " + b + ", "+ c +':' + " max = " + Compare(a, b, c));

a = 44; b = 5; c = 78;
Console.WriteLine(a + ", " + b + ", "+ c +':' + " max = " + Compare(a, b, c));

a = 22; b = 3; c = 9;
Console.WriteLine(a + ", " + b + ", "+ c +':' + " max = " + Compare(a, b, c));