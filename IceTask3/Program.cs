namespace IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle("Rectange", 5,7);
            rec.VirtualDisplay();
            rec.CalculateArea();

            Console.WriteLine(); 

            Circle cir = new Circle("Circle", 6);
            cir.VirtualDisplay();
            cir.CalculateArea();

            Console.ReadKey();  
        }
    }
}
