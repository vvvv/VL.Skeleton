using Stride.Engine;

namespace NuitrackSkeletonTest
{
    class NuitrackSkeletonTestApp
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
