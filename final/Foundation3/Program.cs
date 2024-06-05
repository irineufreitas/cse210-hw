using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Events in the community!\n");

        Address address1 = new Address("101 Creek Dr", "Alams", "Utah");
        Address address2 = new Address("1200 Boss Moves St", "Alams", "Utah");
        Address address3 = new Address("233 John Kennedy Dr", "Alams", "Utah");

        Lectures lectures = new Lectures("The Power to Become","Come learn how to achieve goals and become the best version of yourself!","June 24, 2024","7:30PM",address1, "Judith Marrow",3450);

        Reception reception = new Reception("Barnes & Nobles Reception Ceremony","Come enjoy free drinks and pizza for the coming of Barnes & Nobles in town","June 15th, 2024", "3:30PM", address2);

        Outdoor outdoor = new Outdoor("Pic Nic with Live Music", "Live Music with amazing views at the park", "June 23rd, 2024","10AM",address3, "84Fº - Sunny");


        Console.WriteLine(lectures.DisplayLecture());
        Console.WriteLine("");

        Console.WriteLine(reception.DisplayReception());
        Console.WriteLine("");

        Console.WriteLine(outdoor.DisplayOutdoor());

        



    }

}