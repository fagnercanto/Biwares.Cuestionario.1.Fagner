using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biwares.Cuestionario.Fagner
{
    internal class ScheduleChecker
    {
        /// <summary>
        /// Calcula los solapamientos entre una lista de turnos.
        /// </summary>
        /// <param name="turnos">Lista de turnos a evaluar.</param>
        /// <returns>Lista de resultados de solapamientos encontrados.</returns>
        public static List<OverlapResult> ObtenerSolapamientos(List<Schedule> turnos)
        {
            var solapamientos = new List<OverlapResult>();

            for (int i = 0; i < turnos.Count; i++)
            {
                for (int j = i + 1; j < turnos.Count; j++)
                {
                    var turnoA = turnos[i];
                    var turnoB = turnos[j];

                    if (turnoA.StartDate < turnoB.EndDate && turnoB.StartDate < turnoA.EndDate)
                    {
                        var inicioSolape = turnoA.StartDate > turnoB.StartDate ? turnoA.StartDate : turnoB.StartDate;
                        var finSolape = turnoA.EndDate < turnoB.EndDate ? turnoA.EndDate : turnoB.EndDate;

                        solapamientos.Add(new OverlapResult
                        {
                            EmployeeA = turnoA.EmployeeId,
                            EmployeeB = turnoB.EmployeeId,
                            OverlapStart = inicioSolape,
                            OverlapEnd = finSolape
                        });
                    }
                }
            }

            return solapamientos;
        }
    }
}
