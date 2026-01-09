namespace Canvas
{
    public class Canvas
    {
        public char[,] grid;
        public int w, h;
        string[,] fgColors;
        string[,] bgColors;
        string currentFgColor = "\x1b[38;2;255;255;255m";
        string currentBgColor = "\x1b[48;2;0;0;0m";
        public Canvas(int width, int height)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            grid = new char[width, height];
            fgColors = new string[width, height];
            bgColors = new string[width, height];
            w = width;
            h = height;
            Clear();
            Console.CursorVisible = false;
        }
        public void Draw()
        {
            var sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    sw.Write(fgColors[j, i]);
                    sw.Write(bgColors[j, i]);
                    sw.Write(grid[j, i]);
                }
                sw.WriteLine();
            }

            Console.Out.Flush();
        }
        public void Clear()
        {
            Console.CursorLeft = 0;
            Console.CursorTop = 0;  
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    fgColors[j, i] = "\x1b[38;2;255;255;255m";
                    bgColors[j, i] = "\x1b[48;2;0;0;0m";
                    grid[j, i] = ' ';
                }
            }

        }
        public void SetPixel(int x, int y, char c)
        {
            fgColors[x,y] = currentFgColor;
            bgColors[x,y] = currentBgColor;
            grid[x, y] = c;
        }
        public void SetForegroundColor(byte r, byte g, byte b)
        {
            currentFgColor = $"\x1b[38;2;{r};{g};{b}m";
        }
        public void setBackgroundColor(byte r, byte g, byte b)
        {
            currentBgColor = $"\x1b[48;2;{r};{g};{b}m";
        }


    }
}
