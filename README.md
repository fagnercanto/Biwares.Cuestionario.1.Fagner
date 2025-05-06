
# 🛠️ Biwares.Cuestionario.1.Fagner

## 📋 Descripción

Este proyecto es una solución para la **Pregunta 1** del cuestionario técnico enviado por la empresa. La aplicación está escrita en **C#** y se trata de una **aplicación de consola** que identifica solapamientos (intersecciones) entre turnos.

## 🔍 Problema

> Asumiendo que un turno se define con esta clase:
 ```csharp
public class Schedule
{
    public string EmployeeId { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
}
```
> Crea un programa o función que reciba una lista de turnos y devuelva una lista de solapes de dichos turnos (Dos turnos A y B solapan durante un periodo de tiempo si éstos comparten alguna porción del tiempo).

## 🚀 Cómo ejecutar

1️⃣ Abra la solución en **Visual Studio 2022** (o compatible).

2️⃣ Compile la solución (`Ctrl + Shift + B`).

3️⃣ Ejecute el proyecto de consola. Por defecto, se incluyen ejemplos de turnos predefinidos que muestran cómo funciona la identificación de solapamientos.

## 🗂️ Estructura del proyecto

-   `Schedule.cs`: Representa un turno con un ID de empleado y un rango de tiempo (inicio y fin).
    
-   `ScheduleChecker.cs`: Contiene la lógica principal para identificar los solapamientos entre los turnos.
    
-   `OverlapResult.cs`: Define el resultado devuelto para cada par de turnos que tienen un solapamiento.
    
-   `Program.cs`: Punto de entrada del programa, donde se cargan los datos de ejemplo y se ejecuta la verificación.
    

## ✅ Resultado esperado

Al ejecutar el programa, se mostrará en consola una lista de todos los solapamientos encontrados, detallando qué empleados tienen turnos solapados y el intervalo exacto del solapamiento.

## 💬 Comentarios

Este proyecto está documentado en el propio código usando `/// <summary>` para facilitar la comprensión rápida del propósito de cada clase y método.
