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

<img width="601" height="487" alt="Captura de pantalla 2026-05-12 132736" src="https://github.com/user-attachments/assets/2868895f-3baa-4003-a73b-1f44f885103d" />

<img width="574" height="445" alt="Captura de pantalla 2026-05-12 133019" src="https://github.com/user-attachments/assets/55288161-abdf-43cd-ada8-72741ddf022a" />

