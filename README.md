# Boletín de Calificaciones
## Actividad individual – Programación Básica (Windows Forms, C#)

## 1. Datos del estudiante
- **Nombre:** Rotciv Ozuna
- **Matrícula:** 2025-2501
- **Fecha:** 26/11/2026

## 2. Descripción del programa
Aplicación de escritorio en Windows Forms (C#) que calcula el promedio de cada asignatura de un estudiante, determina su situación académica y muestra un resumen con el promedio general. Todo el código está en Form1.cs.

## 3. Datos de entrada
- Nombre del estudiante.
- Tanda: Matutina o Vespertina.
- Asignatura (Matemática, Lengua Española, Ciencias Naturales, Inglés o Informática).
- Calificaciones de los 4 períodos (P1 a P4), cada una de 0 a 100.
- Si cumple la asistencia mínima (80 %).

## 4. Proceso
1. **Promedio** = suma de las 4 calificaciones ÷ 4.
2. **Situación de la asignatura:**
   - 70 o más: Aprobada.
   - De 60 a 69.99: En recuperación.
   - Menos de 60: Reprobada.
   - Sin asistencia mínima: Reprobada por asistencia, sin importar el promedio.
3. **Promedio general** = promedio de los promedios registrados.
4. **Situación general:**
   - Al menos una reprobada: "Tiene asignaturas reprobadas".
   - Alguna en recuperación y ninguna reprobada: "Tiene asignaturas en recuperación".
   - Todas aprobadas: "Aprobó todas las asignaturas".

**Validaciones:** nombre no vacío, tanda y asignatura seleccionadas, calificaciones numéricas de 0 a 100, y no se muestra el resumen sin asignaturas registradas.

## 5. Salida
- Cada asignatura registrada aparece en la lista con su promedio y situación, por ejemplo: Matemática · 85.50 · Aprobada.
- El resumen muestra el promedio general (2 decimales), las cantidades de aprobadas, en recuperación y reprobadas, y la situación general.

**Ejemplo:** Matemática 85.50 (Aprobada), Inglés 64.00 (En recuperación) e Informática 55.25 (Reprobada) dan un promedio general de **68.25** y la situación *Tiene asignaturas reprobadas*.

## 6. Captura de pantalla
![Programa en ejecución](Capturas/CAP_1_Normal)
