// See https://aka.ms/new-console-template for more information
using System;

class program
{
    static void Main()
    {
        try
        {
            SayaTubeUser User = new SayaTubeUser("Faris");
            User.addVideo(new SayaTubeVideo("TUroial"));
            User.addVideo(new SayaTubeVideo("Coba"));
            User.addVideo(new SayaTubeVideo("test"));
           User.PrintAllVideoPlayCount();
        }
        catch (Exception ex)
        {

        }
    }
}