namespace FlyWeightPatternLesson
{
    public class CeramicTile : ITile
    {
        public static int ObjectCounter = 0;

        string _color;

        //public int X { get; set; }
        //public int Y { get; set; }
        //public int Width { get; set; }
        //public int Height { get; set; }

        public CeramicTile()
        {
            _color = "Red";

            //X = x;
            //Y = y;
            //Width = width;
            //Height = height;

            ++ObjectCounter;
        }

        public void Placement(int x, int y, int width, int height)
        {

        }
    }
}
