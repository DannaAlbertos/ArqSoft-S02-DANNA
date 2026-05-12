# Ahorcado 
Un juego sencillo escrito en C#

Este juego fue desarrollado utilizando lenguaje C# y está basado en los principios SOLID para mantener una buena práctica inicial de Arquitectura en nuestro sistema.
Hice uso de la IA para poder arreglar el código con un error que tuvo.

Identificación de violaciones SOLID

| Situación | Principio violado |
|---|---|
| La clase Juego controla turnos, dibuja el tablero, muestra mensajes y elige la palabra | SRP - Single Responsability Principle
| Las palabras están hardcodeadas dentro del constructor | DIP - Dependency Inversion Principle
| Para agregar un segundo juego habría que modificar Juego directamente | OCP - Open/Closed Principle