using Stride.Engine;

namespace KinetBonesTest
{
    class KinetBonesTestApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
