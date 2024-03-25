using System;

public class SayaTubeUser
{
	private int id;
	private List<SayaTubeVideo> uploadedVideos;
	public string Username;
	public SayaTubeUser(string username)
	{
		this.Username = username;
		uploadedVideos = new List<SayaTubeVideo>();
        this.id = generatedId();
    }
	private int generatedId()
	{
        Random idRandom = new Random();
        return idRandom.Next(17064, 99999);
    }
	public void addVideo(SayaTubeVideo video)
	{
		uploadedVideos.Add(video);
	}

	public int GetTotalVideoPlayCount()
	{
		int total = 0;
		for (int i = 0; i < uploadedVideos.Count; i++)
		{
			total = total + uploadedVideos[i].getPlayCount();
		}
		return total;
	}

	public void PrintAllVideoPlayCount()
	{
		Console.WriteLine("User :" + Username);
		for(int i = 0;i < uploadedVideos.Count;i++)
		{
			Console.WriteLine("Video " + uploadedVideos[i].getTitle() + "Count = " + uploadedVideos[i].getPlayCount());
		}
	}
}
