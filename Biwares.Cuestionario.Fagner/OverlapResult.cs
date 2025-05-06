using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biwares.Cuestionario.Fagner
{
    /// <summary>
    /// Representa el resultado de un solapamiento entre dos turnos.
    /// Incluye los IDs de los empleados y el intervalo de tiempo del solapamiento.
    /// </summary>
    internal class OverlapResult
    {
        /// <summary>
        /// ID del primer empleado involucrado en el solapamiento.
        /// </summary>
        public required string EmployeeA { get; set; }
        /// <summary>
        /// ID del segundo empleado involucrado en el solapamiento.
        /// </summary>
        public required string EmployeeB { get; set; }
        /// <summary>
        /// Fecha y hora de inicio del solapamiento.
        /// </summary>
        public DateTime OverlapStart { get; set; }
        /// <summary>
        /// Fecha y hora de fin del solapamiento.
        /// </summary>
        public DateTime OverlapEnd { get; set; }

    }
}
