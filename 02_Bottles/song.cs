namespace _02_Bottles
{
    internal class song
    {
        public static string CountBottles(int v)
        {
            string song0 = "No more bottles of beer on the wall.";
            string song1 = "1 bottle of beer on the wall."
                + " 1 bottle of beer."
                + " Take one down and pass it around.";
            string song2 = "2 bottles of beer on the wall."
                + " 2 bottles of beer."
                + " Take one down and pass it around."
                + " 1 bottle of beer on the wall.";
            string songBody = "";
            if(v == 0)
            {
                return song0;
            }
            if(v == 1)
            {
                return (song1 + " " + song0);
            }
            else
            { 
                for(int i = v; i > 2; i--)
                {
                    songBody = songBody + i + " bottles of beer on the wall."
                    + " " + i + " bottles of beer."
                    + " Take one down and pass it around."
                    + " " + (i - 1) + " bottles of beer on the wall. ";
                }
                return songBody + song2 + " " + song1 + " " + song0;
            }
        }
    }
}