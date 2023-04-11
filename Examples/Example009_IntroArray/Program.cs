//Добавили метод

int Max(int arg1, int arg2, int arg3) //Подпрограмма (функция, метод)
{
    int resalt = arg1;                 
if (arg2 > resalt) resalt = arg2;      
if (arg3 > resalt) resalt = arg3;      
return resalt;                         
}

int [] array = {1, 23, 5, 14, 8, 6, 65, 29}; //создание массива
// array [0] = 12; элементу массива с индексом "0" присвоить значение 12
// Console.WriteLine(array[0]); вывести элемент с индексом "0"
int max = Max(
    Max(array[0], array[1], array[2]), 
    Max(array[3], array[4], array[5]), 
    Max(array[6], array[7], array[8])
             ); //Передача функции внутри аргумента

// Console.WriteLine(max1);
// Console.WriteLine(max2);
// Console.WriteLine(max3);
Console.WriteLine(max);
