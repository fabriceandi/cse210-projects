using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "English Listening Practice";
        video1._author = "Christopher";
        video1._length = 60;
        Comment comment1 = new Comment();
        comment1._name = "Guy Carter";
        comment1._commentText = "Excellent video";
        Comment comment2 = new Comment();
        comment2._name = "Jim Fox";
        comment2._commentText = "Great job";
        Comment comment3 = new Comment();
        comment3._name = "Ray Bill";
        comment3._commentText ="I love it";
        video1.AddComment(comment1);
        video1.AddComment(comment2);
        video1.AddComment(comment3);

        Video video2 = new Video();
        video2._title = "Programming Language";
        video2._author = "Johnson";
        video2._length = 75;
        Comment comment4 = new Comment();
        comment4._name = "Kim Moore";
        comment4._commentText = "Good presentation";
        Comment comment5 = new Comment();
        comment5._name = "Maxime";
        comment5._commentText = "Wonderful";
        Comment comment6 = new Comment();
        comment6._name = "Milly";
        comment6._commentText = "Inspiring video";
        video2.AddComment(comment4);
        video2.AddComment(comment5);
        video2.AddComment(comment6);

        Video video3 = new Video();
        video3._title = "Strategies for better health";
        video3._author = "Damon Simons";
        video3._length = 40;
        Comment comment7 = new Comment();
        comment7._name = "Bobby";
        comment7._commentText = "Great video";
        Comment comment8 = new Comment();
        comment8._name = "Angel";
        comment8._commentText = "Marvelous";
        Comment comment9 = new Comment();
        comment9._name = "Tia";
        comment9._commentText = "I like this video";
        video3.AddComment(comment7);
        video3.AddComment(comment8);
        video3.AddComment(comment9);

        Video video4 = new Video();
        video4._title = "Morning Exercice Routine";
        video4._author = "Samuel";
        video4._length = 30;
        Comment comment10 = new Comment();
        comment10._name = "Manson";
        comment10._commentText = "Sure";
        Comment comment11 = new Comment();
        comment11._name = "Karl";
        comment11._commentText = "Absolutely true";
        Comment comment12 = new Comment();
        comment12._name = "Betty River";
        comment12._commentText = "Next video, please!I love it";
        Comment comment13 = new Comment();
        comment13._name = "Kenny Guichard";
        comment13._commentText = "Thank you";
        video4.AddComment(comment10);
        video4.AddComment(comment11);
        video4.AddComment(comment12);
        video4.AddComment(comment13);

        _videos.Add(video1);
        _videos.Add(video2);
        _videos.Add(video3);
        _videos.Add(video4);

        foreach(Video v in _videos)
        {
            int number = v.NumberOfComments();
            Console.WriteLine();
            Console.WriteLine($"{v._title} - {v._author}, {v._length} seconds");
            Console.WriteLine($"{number} Comments:");
            v.DisplayInfo();
            Console.WriteLine();
        }

    }
}