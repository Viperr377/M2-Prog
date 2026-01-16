using System;
using System.Collections.Generic;

namespace _01_Class;

class Program
{
    Dictionary<string, Room> rooms = new Dictionary<string, Room>();
    static void Main(string[] args)
    {
        newprogram().run();
    }
    void run()
    {
        Room start = new Room(0, 0, new string[]
        {
            "#########",
            "#       #",
            "#   X   #",
            "#       #",
            "#########"
        });

        rooms.Add(start.GetRoomLocationKey(), start);

        Room next = new Room(1, 0, new string[]
        {
            "#########",
            "#       #",
            "#   O   #",
            "#       #",
            "#########"
        });
        rooms.Add(next.GetRoomLocationKey(), next);

        ShowRoom(0, 0);
        ShowRoom(1, 0);
    }
        private void ShowRoom(int x, int y)
        { 
            bool hasRoom = rooms.ContainsKey($"{x},{y}");
            Room room = rooms[$"{x},{y}"];

            Console.WriteLine($"You are in room {x},{y}:");
            foreach (string r in room.level)
        {
            Console.WriteLine(r);
        }
           
    }
}

