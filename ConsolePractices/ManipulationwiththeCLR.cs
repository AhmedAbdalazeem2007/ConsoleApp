
namespace ConsolePractices
{
    public class ManipulationwiththeCLR
    {
        public ManipulationwiththeCLR()
        {

        }
        public void mainpulation()
        {
            Console.WriteLine(GC.GetTotalMemory(false));
            GC.Collect();
        }
    }
}
