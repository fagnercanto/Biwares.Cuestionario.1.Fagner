using Biwares.Cuestionario.Fagner;

internal class Program
{ 
    
    private static void Main(string[] args)
    {
        var turnos = new List<Schedule>
            {
                new() { EmployeeId = "A", StartDate = DateTime.Parse("2024-05-07 09:00"), EndDate = DateTime.Parse("2024-05-07 12:00") },
                new() { EmployeeId = "B", StartDate = DateTime.Parse("2024-05-07 11:00"), EndDate = DateTime.Parse("2024-05-07 14:00") },
                new() { EmployeeId = "C", StartDate = DateTime.Parse("2024-05-07 15:00"), EndDate = DateTime.Parse("2024-05-07 18:00") },
                new() { EmployeeId = "D", StartDate = DateTime.Parse("2024-05-07 11:30"), EndDate = DateTime.Parse("2024-05-07 13:00") }
            };

        var solapamientos = ScheduleChecker.ObtenerSolapamientos(turnos);

        Console.WriteLine("Resultados de solapamientos:");
        foreach (var solape in solapamientos)
        {
            Console.WriteLine($"- Solape entre {solape.EmployeeA} y {solape.EmployeeB}: {solape.OverlapStart} a {solape.OverlapEnd}");
        }
    }




}