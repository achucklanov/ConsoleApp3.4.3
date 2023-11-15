namespace ConsoleApp3._4._3
{
    enum Semaphore : int
    {
        Red = 100,
        Yellow = 200,
        Green = 300
    }
    enum DaysOfWeek : byte
    {
        Monday = 1,
        Tuesday = 2,
        Wednesday = 3,
        Thursday = 4,
        Friday = 5,
        Saturday = 6,
        Sunday = 7
    }

    class Program
    {
        public static void Main(string[] args) 
        {
            DayOfWeek MyFavoriteDay;
            MyFavoriteDay = DayOfWeek.Sunday;
            Console.WriteLine("Мой любимый день {0} !", MyFavoriteDay);
        }
    }
}