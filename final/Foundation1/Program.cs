using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Console.WriteLine("Youtube Videos\n");

        Video video1 = new Video();
        video1._author = "Monica Castellano";
        video1._title = "How to Make American Pancakes";
        video1._length = 180;

        Comment comment1 = new Comment("Sheri", "I use this recipe every time I want great pancakes, thank you!");
        Comment comment2 = new Comment("Roger", "Not a bad idea to use 3 eggs here.");
        Comment comment3 = new Comment("Susy", "I love American pancakes");
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        video1.DisplayVideoInfo();

        Video video2 = new Video();
        video2._author = "Irineu Jr";
        video2._title = "How to Learn English";
        video2._length = 380;

        Comment comment4 = new Comment("Bob", "My dream is to learn English!");
        Comment comment5 = new Comment("Mary", "I am going to apply these tips, I have to learn English for work!");
        Comment comment6 = new Comment("Sarah", "I wish I could learn English earlier on in my life.");
        Comment comment7 = new Comment("Steve", "I have free course for people who want to learn English, comment here.");

        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);
        video2.AddComment(comment7);

        video2.DisplayVideoInfo();   

        Video video3 = new Video();
        video3._author = "Elon Musk ";
        video3._title = "How I created SpaceX";
        video3._length = 560;

        Comment comment8 = new Comment("Mob45", "Elon is a genius man!");
        Comment comment9 = new Comment("Purple112", "Wow, this is what it takes to get something big like this done.");
        Comment comment10 = new Comment("Irina", "That`s crazy how close to bankruptcy he was");
        Comment comment11 = new Comment("Alice", "This is an insane story");

        video3.AddComment(comment8);
        video3.AddComment(comment9);
        video3.AddComment(comment10);
        video3.AddComment(comment11);


        video3.DisplayVideoInfo();   

        Video video4 = new Video();
        video4._author = "The Church of Jesus Christ";
        video4._title = "The Power of the Atonement";
        video4._length = 120;

        Comment comment12 = new Comment("Molly", "Christ is my redeemer, and the atonement is what helps me overcome my trials of faith!");
        Comment comment13 = new Comment("Russ", "I felt the spirit very strongly as I watched this video.");
        Comment comment14 = new Comment("Shannon", "The atonement is a concept most of us cannot understand, but this video made it super easy!");

        video4.AddComment(comment12);
        video4.AddComment(comment13);
        video4.AddComment(comment14);

        video4.DisplayVideoInfo();   


        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);


        


    }
}