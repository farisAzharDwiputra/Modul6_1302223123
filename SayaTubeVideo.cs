using System;
using System.Diagnostics;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
	private int id;
	private string title;
	private int playCount;

	public SayaTubeVideo(string title)
	{
		Debug.Assert(title != null && title.Length <= 200,"Judul video harus memiliki panjang max 100 karakter dan tidak boleh null");

		this.id = generatedId();
		this.title = title;
		this.playCount = 0;
	}

	private int generatedId()
	{
		Random idRandom = new Random();
		return idRandom.Next(17064,99999);
	}

	public string getTitle()
	{
		return title;
	}

	public void IncreasePlayCount(int count)
	{
		this.playCount = count;
	}

	public void PrintVideoDetails()
	{
		Console.WriteLine($"Video ID:{id}");
        Console.WriteLine($"title :{title}");
        Console.WriteLine($"Play Count:{id}");
    }

	public int getPlayCount()
	{
		return playCount;
	}
}
