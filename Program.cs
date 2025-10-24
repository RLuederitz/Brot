namespace Brot
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Baker maBaker = new Baker();
      maBaker.BakeBread();
      maBaker.BakeBread();
      maBaker.BakeBread();
      maBaker.BakeBread();
    }
  }
}
