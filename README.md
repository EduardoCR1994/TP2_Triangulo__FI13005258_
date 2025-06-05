# Tarea Programada 2 - Programación Avanzada (SC-701)

**Nombre:** Eduardo Castro  
**Carné:** FI13005258  
**Proyecto:** Calculadora de Triángulos en ASP.NET MVC  
**Profesor:** Luis Andrés Rojas Matey  

---

## 🧩 Descripción

Esta aplicación web permite al usuario ingresar las longitudes de los tres lados de un triángulo y, a partir de estos valores, realiza lo siguiente:

- Verifica que los datos ingresados sean válidos.
- Calcula el perímetro, semiperímetro y área (usando la fórmula de Herón).
- Determina el tipo de triángulo (equilátero, isósceles o escaleno).
- Calcula los tres ángulos interiores mediante la **ley de cosenos**.
- Muestra todos los resultados en una interfaz clara, sobria (diseño en escala de grises y negro).

---

## 🧪 Pruebas sugeridas

### ✅ Triángulo equilátero
- a: 5, b: 5, c: 5  
- Resultado: Tipo = Equilátero, Ángulos ≈ 60º, Área ≈ 10.83 u²

### ✅ Triángulo isósceles
- a: 6, b: 6, c: 4  
- Resultado: Tipo = Isósceles, Ángulos variados, Área ≈ 11.31 u²

### ✅ Triángulo escaleno
- a: 7, b: 5, c: 4  
- Resultado: Tipo = Escaleno, Área ≈ 9.80 u²

### ❌ Errores controlados
- a: 0, b: 5, c: 4 → Error: "Lado a debe ser mayor que cero"
- a: 2, b: 2, c: 5 → Error: "La suma de los dos lados menores debe ser mayor que el mayor"

---

## 💻 Tecnologías utilizadas

- ASP.NET MVC 5 con .NET Framework 4.8.1
- C#
- Razor Views
- Bootstrap (estilos preconfigurados)
- Math API de .NET (`Math.Sqrt`, `Math.Acos`, `Math.Pow`, etc.)

---

## 📁 Estructura del proyecto

- `Controllers/TriangleController.cs`
- `Models/TriangleModel.cs`
- `Views/Triangle/Index.cshtml`
- `App_Start/RouteConfig.cs` (ruta inicial modificada)
- Excluidas las carpetas `/bin` y `/obj` del .zip como lo solicitó el enunciado

---

## 🔗 Recursos utilizados

- [Fórmula de Herón - Wikipedia](https://es.wikipedia.org/wiki/F%C3%B3rmula_de_Her%C3%B3n)
- [Documentación de Math en .NET](https://learn.microsoft.com/dotnet/api/system.math)


## 📦 Instrucciones de entrega

El archivo comprimido entregado fue:  
`TP2-FI13005258.zip`  
Contiene el proyecto completo con código fuente limpio, sin carpetas `bin/` ni `obj/`.

---

## ✅ Estado del proyecto

✅ Funcional  
✅ Validaciones  
✅ Cálculos correctos  
✅ Interfaz visual adaptada (gris con negro)  
