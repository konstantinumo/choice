string[] s = new string[5] {"skufekuae", "hhk", "p98w3yr8", "91", "j"};
string[] p = new string[5] {"", "", "", "", ""};

Console.WriteLine("исходный массив строк:");

for(int i=0; i<5; i++)
Console.WriteLine("s[" + i + "]: " + s[i]);

Console.WriteLine("новый массив строк, длиной не более 3х символов:");

int j = 0;

for(int i=0; i<5; i++)
{
    if(s[i].Length<4)
    {
        p[j]=s[i];
        Console.WriteLine("p[" + j + "]: " + p[j]);
        j++;
    }
}

