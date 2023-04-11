//Добавили метод

int Max(int arg1, int arg2, int arg3) //Подпрограмма (функция, метод)
{
    int resalt = arg1;                 
if (arg2 > resalt) resalt = arg2;      
if (arg3 > resalt) resalt = arg3;      
return resalt;                         
}

int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 23;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

//После добавления метода, 
//необходимость в строках (22-32) отпадает
// int max = a1;
// if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

// int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);

//Строки 33-36 можно записать в одну как строку 39

int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); //Передача функции внутри аргумента

// Console.WriteLine(max1);
// Console.WriteLine(max2);
// Console.WriteLine(max3);
Console.WriteLine(max);
