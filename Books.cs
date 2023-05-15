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
            Console.WriteLine("enter 1 to add a book .\nenter 2 to del a book .\nenter 3 to update a book . \nenter 4 to show list .\nenter 11 to see this  help .\nand 0 to exit .\n"); 
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
                if (action == "5") // sort books price and outputs
                {
                    List<Books> sortedList = books.OrderByDescending(x => x.price).ToList();
                    for (int i = 0; i < sortedList.Count; i++)
                    {
                        Console.WriteLine(i + ", " + sortedList[i].bname + ", " + sortedList[i].author + ", " + sortedList[i].price);
                    }

                }
                if (action == "6") // search with book name and outputs
                    {
                        Console.WriteLine("Enter book name to search:");
                        string searchName = Console.ReadLine();

                        List<Books> matchedBooks = books.Where(x => x.bname == searchName).ToList();
                        if (matchedBooks.Count > 0)
                        {
                            Console.WriteLine("id, bookname, author, price ");
                            for (int i = 0; i < matchedBooks.Count; i++)
                            {
                                Console.WriteLine(i + ", " + matchedBooks[i].bname + ", " + matchedBooks[i].author + ", " + matchedBooks[i].price);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No result.");
                        }
                    }
                if (action == "7") // show book with the highest price
                    {
                        if (books.Count > 0)
                        {
                            Books maxPriceBook = books.OrderByDescending(x => x.price).FirstOrDefault();
                            Console.WriteLine("Book with largest price: ");
                            Console.WriteLine("bookname: ",maxPriceBook.bname);
                            Console.WriteLine("author: ",maxPriceBook.author);
                            Console.WriteLine("price: ",maxPriceBook.price);
                        }
                        else
                        {
                            Console.WriteLine("No result.");
                        }
                    }
                if (action == "8") // show book with with the lowest price
                {
                    if (books.Count > 0)
                    {
                        Books minPriceBook = books.OrderBy(x => x.price).FirstOrDefault();
                        Console.WriteLine("Book with lowest price: ");
                        Console.WriteLine("bookname: " + minPriceBook.bname);
                        Console.WriteLine("author: " + minPriceBook.author);
                        Console.WriteLine("price: " + minPriceBook.price);
                    }
                    else
                    {
                        Console.WriteLine("No result.");
                    }
                }
                if(action == "11") // show help
                {
                    // Console.WriteLine("enter 1 to add a book .\nenter 1 to add a book .\nenter 2 to add a book .\nenter 3 to update a book . \
                    // \nenter 4 to show list .\nenter 5 to see this  help .\nand 0 to exit ."); 

                    // or
                    Console.Clear();
                    Console.WriteLine("enter 1 to add a book .");
                    Console.WriteLine("enter 2 to del a book .");
                    Console.WriteLine("enter 3 to update a book .");
                    Console.WriteLine("enter 4 to show list .");
                    Console.WriteLine("enter 11 to see this  help .");
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