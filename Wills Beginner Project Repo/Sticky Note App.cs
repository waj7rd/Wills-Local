﻿using System;
using System.Collections.Genmeric;

namespace StickyNotes
{
    class Program

    {
        static List<string> notes = new List<String>();

        static void Main(string[] args)

        {

            bool running = true
        while (running)
            {
                Console.WriteLine("Sticky Notes App");
                Console.WriteLine("1. Create Note")
                Console.WriteLine("2. View Notes")
                Console.WriteLine("3. Exit")
                Console.WriteLine("Select an option...")

                    switch (Console.readline())
                {
                    case "1":
                        CreateNote();
                        break;
                    case "2":
                        ViewNotes();
                        break;
                    case "3":
                        running = false;
                        break;
                    default:
                        console.WriteLine("Invalid option, please try again.");
                        break;
                }

            }
        }
        static void CreateNote()
        {
            Console.Write("Enter your note: ");
            string note = Console.Readline();
            notes.Add(note);
            Console.WriteLine("Note added!");
        }

        static void ViewNotes()
        {
            Console.Writeline("Your notes:")
                foreach (var note in notes)
            {
                Console.Writeline($" - {note}");
            }
        }
    } 
}