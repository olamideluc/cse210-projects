using System;

class Program
{
    static void Main(string[] args)
    {
        var video1 = new Video("Dance on the floor", "James Ronald", 300);
        var video2 = new Video("Beautiful Girl", "Jane Karen", 420);
        var video3 = new Video("Wake up wake up", "Sata Ann", 380);

        video1.AddComment(new Comment("Seth", "Great music!"));
        video1.AddComment(new Comment("Kate", "Sounds good."));
        video1.AddComment(new Comment("Ruth", "Lovely Track"));

        video2.AddComment(new Comment("Daniel", "Great one!"));
        video2.AddComment(new Comment("Martha", " Sounds interesting."));
        video2.AddComment(new Comment("Pacome", "Great music."));

        video3.AddComment(new Comment("Johnson", "Amazing track."));
        video3.AddComment(new Comment("Henry", "I love this, it's great."));
        video3.AddComment(new Comment(" Suzane", " This is fantastic!"));

        var videos = new List<Video> { video1, video2, video3 };
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }

    }
}

        
