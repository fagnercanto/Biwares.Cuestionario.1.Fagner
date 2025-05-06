using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biwares.Cuestionario.Fagner
{
    /// <summary>
    /// Representa un turno con hora de inicio y fin.
    /// </summary>
    internal class Schedule
    {
        public required string EmployeeId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
