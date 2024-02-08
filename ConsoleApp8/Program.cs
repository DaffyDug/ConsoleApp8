





//Создать класс библиотеки и добавить в него поле с коллекцией книг.
//В классе библиотеке реализовать методы по работе с коллекцией книг такие как:
//1 – Получение ВСЕХ книг по Автору.
//2 – Получение ВСЕХ книг по переплёту.
//3 – Добавление новой книги.
//4 – Удаление книги.
using System;
namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
//Описать класс книги, у которой должны быть следующие поля:
//1 – Кол - во страниц в книге.
//2 – Год выхода
//3 – Автор 
//4 – Название 
//5 – Тип переплёта

//Поля «Автор» и «Тип переплёта» должны быть enum, в enum «Тип переплёта» необходимо поместить следующие значения (Мягкий, Твёрдый).
//В enum «Автор» нужно поместить 5 авторов по Вашему выбору.



class Books
{
    private int _pages;
    private int _released;
    private AUTHOR _author;
    private string _title;
    private BINDING_TYPE _binding_type;


    public Books(int pages, int released, AUTHOR author, string title, BINDING_TYPE binding_type)
    {
        _pages = pages;
        _released = released;
        _author = author;
        _title = title;
        _binding_type = binding_type;
    }
    //Для ВСЕХ полей в классе книги реализовать публичный метод ИЛИ свойство GET (На ваш выбор).
    //Метод или свойство SET должны остаться закрытыми.
    public int GetPages(int pages) 
    {
        return _pages;
    }
    public int GetReleased(int released)
    {
        return _released;
    }
    public AUTHOR GetAuthor() 
    {
        return _author;
    }
    //public int GetTitle() 
    //{
    //    return _title;
    //}
    public BINDING_TYPE GetBindingType() 
    {
        return _binding_type;
    }

    private void SetPages(int pages) 
    {      
        
    }
}
public enum AUTHOR
{
    //Братья Гримм, Уильям Шекспир, Лев Толстой, Чарльз Диккенс, Виктор Гюго. главное не запутайтесь :)
    The_Brothers_Grimm, William_Shakespeare, Leo_Tolstoy, Charles_Dickens, Victor_Hugo
}
public enum BINDING_TYPE
{
    Soft, Solid
}