using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul08
{

    class MyArr
    {
        int[] arr;
        public int Length;

        public MyArr(int Size)
        {
            arr = new int[Size];
            Length = Size;
        }

        // Создаем простейший индексатор
        public int this[int index]
        {
            set
            {
                arr[index] = value;
            }

            get
            {
                return arr[index];
            }
        }
    }

    class Program
    {
        static void Main()
        {

            Library library = new Library();

            Console.WriteLine(library[0].Name);

            library[0] = new Book("Былое и думы");

            Console.WriteLine(library[0].Name);

            Console.ReadLine();

            //Matrix matrix = new Matrix();
            //Console.WriteLine(matrix[0, 0]);
            //matrix[0, 0] = 111;
            //Console.WriteLine(matrix[0, 0]);
        }
    }
    
    class Book
    {
        public Book(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }

    class Library
    {
        Book[] books;

        public Library()
        {
            books = new Book[] { new Book("Отцы и дети"), new Book("Война и мир"), new Book("Евгений Онегин") };
        }

        public int Length
        {
            get { return books.Length; }
        }

        public Book this[int index]
        {
            get
            {
                return books[index];
            }
            set
            {
                books[index] = value;
            }
        }

    }


    class Matrix
    {
        private int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
            set
            {
                numbers[i, j] = value;
            }
        }
    }
}
