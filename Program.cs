internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("nhap diem toan: ");
        double mathScore;
        double.TryParse(Console.ReadLine(), out mathScore);

        Console.Write("nhap diem ly: ");
        double physicsScore;
        double.TryParse(Console.ReadLine(), out physicsScore);

        Console.Write("nhap diem hoa: ");
        double chemistryScore;
        double.TryParse(Console.ReadLine(), out chemistryScore);

        double averageScore = (mathScore + physicsScore + chemistryScore) / 3;

        Console.WriteLine($"diem trung binh: {averageScore}");
    }
}