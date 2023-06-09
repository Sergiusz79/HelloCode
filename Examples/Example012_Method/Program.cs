﻿// Вид 1 
//Первая группа методов — не принимает никаких аргументов и ничего не возвращают

//void Method1() //Метод
//{
//    Console.WriteLine("Автор........"); //Тело метода
//}
//Method1(); //Вызов метода


// Вид 2
//Вторая группа методов — принимает какие-то аргументы, но ничего не возвращают

void Method2(string msg) //Метод
{
    Console.WriteLine(msg); //Оператор, в скобках указан принятый аргумент
}
//Method2("Текст сообщения"); //Вызов метода. Metod2 является идентификатором, 
                              //а в скобках указан текст, выводимый в консоли
//Method2(msg:"Текст сообщения"); //С именованным аргументом когда аргументу msg 
                                  //присвоили значение "Текст сообщения"
                                  // когда у нас явно может быть указано какому аргументу, 
                                  //какое значение мы хотим указать.
void Method21(string msg, int count) //Метод
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++; //Увеличение счётчика на 1 называют инкрементом, а уменьшение на 1 очень часто называют декрементом
    } 
}
//Method21("Текст сообщения", 4);//Вызов метода, после запятой указано количество вызовов (должно повториться 4 раза)
Method21(msg:"Текст сообщения", count: 4); //явное присвоение значения переменным при вызове метода, 
                                          //при этом в скобках не обязательно перечислять их по порядку
                                          //Например Method21(count: 4, msg:"Текст сообщения");

//Вид3
//Третья группа методов — может что-то возвращать, но не принимает никаких аргументов. 
//Например, может служить для генерации случайных данных.
//Если метод что-то возвращает, мы в обязательном порядке должны указать тип данных, 
//значение которого ожидаем (int, double, string).

int Metod3() //не принимает никакие аргументы
{
        return DataTime.Now.Year; //обязательное использование оператора return,
} 
int year = Metod3(); //вызываем метод, в левой части используем идентификатор (в данном случае int) 
                     //переменной (year) 
                     //и через оператор присваивания (=) кладём нужное значение
Console.WriteLine(year);




//Вид4
//Самая важная Четвёртая группа методов — которые что-то принимают (аргументы, данные) 
//и что-то возвращают для дальнейшей работы.
// Мы будем string компоновать друг за другом count раз.

//string Metod4(int count, char c) //Возвращать будем строку string, 
                                   //Передавать будем int count и условный тип char, новый тип данных для вас
string Metod4(int count, string c)  //Возвращать будем строку string,
                                       //Передавать будем int count и string c                             
{
int i = 0;
string result = String.Empty; //Изначально можно и нужно в string result положить какое-то значение
                              //в данном случае пустую строку (можно написать так string result = ""; 
                              //но правильнее будет так string result = String.Empty;)

    while (i<count)
    {
        result = result + c;
        i++;
    }
    return result; //После того, как данный метод отработает, используем классический и известный оператор
                   //return, в котором указываем результат или переменную значение, 
                   //которой ожидаем получить из метода.
}
string res = Metod4(10, "asdf"); //Чтобы вызвать этот метод мы должны будем, создать нужную нам переменную,
                                 //дальше по порядочку указать, например, значение 10 и текст, 
                                 //который мы будем склеивать 10 раз, пусть это будет условный asdf текст
Console.WriteLine(res); //После этого можем показать на экране результат, который этот метод будет возвращать


