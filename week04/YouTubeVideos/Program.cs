public class Program
{
    public static void Main()
    {
        // Create Videos
        Video video1 = new Video("C# Tutorial for Beginners", "John Doe", 600);
        Video video2 = new Video("Introduction to OOP", "Jane Smith", 750);
        Video video3 = new Video("Understanding Encapsulation and Abstraction", "Mike Johnson", 900);
       

        // Add Comments to Video 1
        video1.AddComment(new Comment("Bob", "I finally understand classes now!"));
        video1.AddComment(new Comment("Julia", "Good examples for understanding classes!"));
       
        // Add Comments to Video 2
        video2.AddComment(new Comment("David", "OOP is so interesting!"));

        // Add Comments to Video 3
        video3.AddComment(new Comment("Grace", "This is exactly what I needed!"));

       
        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3};

        // Display all videos and their comments
        foreach (Video video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}

