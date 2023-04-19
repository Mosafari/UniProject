using System;
using System.Collections.Generic;

namespace test1
{
    class Books
    {
        public string author { get; set; }
        public string bname { get; set; } // book's name
        public float price { get; set; }
        // public Books(string iauthor,int iprice)
        // {
        //     author = iauthor;
        //     price = iprice;
        // }
    }
    public class main
    {
        static void Main()
        {
            List<Books> books = new List<Books>();
            
            Console.WriteLine("Help :");
            Console.WriteLine("enter 1 to add a book .\nenter 2 to del a book .\nenter 3 to update a book . \nenter 4 to show list .\nenter 5 to see this  help .\nand 0 to exit .\n"); 
            while(true)
            {
                Console.WriteLine("choose your action :");
                string action = Console.ReadLine();
                if(action == "1") // add book
                {
                    Console.WriteLine("enter book name:");
                    string ibname = Console.ReadLine();
                    Console.WriteLine("enter author's name:");
                    string iauthor = Console.ReadLine();
                    Console.WriteLine("enter price:");
                    float iprice =  float.Parse(Console.ReadLine());
                    books.Add(new Books() { author = iauthor, bname = ibname, price = iprice });
                }
                if(action == "2") // del book by id 
                {
                    Console.WriteLine("enter book id: ");
                    int index = int.Parse(Console.ReadLine());
                    books[index] = null;
                    books.RemoveAt(index);

                }
                if(action == "3") // update book by id
                {
                    Console.WriteLine("enter book id: ");
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine("update book name:");
                    books[index].bname = Console.ReadLine();
                    Console.WriteLine("update author's name:");
                    books[index].author = Console.ReadLine();
                    Console.WriteLine("update price:");
                    books[index].price = float.Parse(Console.ReadLine());
                }
                if(action == "4") // show list
                {
                    Console.WriteLine("id, bookname, author, price ");
                    for (int i=0; i<books.Count; i++) 
                        {
                            Console.WriteLine(i + ", "+books[i].bname+ ", "+books[i].author+ ", "+books[i].price);
                        }
                        Console.WriteLine("\n");

                }
                if(action == "5") // show help
                {
                    // Console.WriteLine("enter 1 to add a book .\nenter 1 to add a book .\nenter 2 to add a book .\nenter 3 to update a book . \
                    // \nenter 4 to show list .\nenter 5 to see this  help .\nand 0 to exit ."); 

                    // or
                    Console.Clear();
                    Console.WriteLine("enter 1 to add a book .");
                    Console.WriteLine("enter 2 to del a book .");
                    Console.WriteLine("enter 3 to update a book .");
                    Console.WriteLine("enter 4 to show list .");
                    Console.WriteLine("enter 5 to see this  help .");
                    Console.WriteLine("and 0 to exit .\n");
                }
                if(action == "0") // exit
                {
                    Console.WriteLine("Goodbye ...");
                    break;
                }

            }

        }
    }
    }