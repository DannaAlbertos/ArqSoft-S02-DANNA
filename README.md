# Ahorcado 
Un juego sencillo escrito en C#

Identificación de violaciones SOLID

| Situación | Principio violado |
|---|---|
| La clase Juego controla turnos, dibuja el tablero, muestra mensajes y elige la palabra | SRP - Single Responsability Principle
| Las palabras están hardcodeadas dentro del constructor | DIP - Dependency Inversion Principle
| Para agregar un segundo juego habría que modificar Juego directamente | OCP - Open/Closed Principle