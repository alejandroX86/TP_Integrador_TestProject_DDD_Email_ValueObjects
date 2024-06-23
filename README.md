Proyecto Hotel: Pruebas Unitarias del Value Object Email en la Capa de Dominio

Este repositorio contiene un proyecto de software desarrollado como parte del Trabajo Práctico de Laboratorio de Software, centrado en la implementación y pruebas unitarias del Value Object Email en la capa de dominio de un sistema de reservas de hotel.

Descripción del Proyecto
El proyecto utiliza una arquitectura basada en Domain-Driven Design (DDD) y se enfoca en la creación de un Value Object que represente un correo electrónico válido. Las pruebas unitarias aseguran que la lógica de validación de correos electrónicos funcione correctamente y maneje diferentes escenarios de entrada del usuario.

Componentes Principales
Program.cs
El archivo Program.cs contiene el método Main que inicializa y ejecuta un ejemplo de uso del Value Object Email, mostrando cómo manejar correos electrónicos válidos e inválidos.

Email.cs
Email.cs define la clase Email, que representa un correo electrónico y contiene la lógica de validación para asegurar que el correo electrónico sea válido según un patrón predefinido.

Métodos Principales
Email(string valor): Constructor que recibe un string y valida si es un correo electrónico válido.
debeContenerEmailValido(string valor): Método privado que utiliza una expresión regular para validar el formato del correo electrónico.
Valor(): Método que devuelve el valor del correo electrónico si es válido.
Pruebas Unitarias
Las pruebas unitarias están implementadas utilizando XUnit para verificar el correcto funcionamiento del Value Object Email.

EmailTests.cs
EmailTests.cs contiene las pruebas unitarias para verificar el comportamiento del Value Object Email.

Email_Valido_NoLanzaExcepcion: Verifica que un correo electrónico válido no lance ninguna excepción.
Email_Invalido_LanzaExcepcion: Asegura que un correo electrónico inválido lance una excepción con el mensaje "El email no es válido".
Ejecución de las Pruebas
Para ejecutar las pruebas unitarias:

Clona este repositorio en tu máquina local.
Abre el proyecto en tu entorno de desarrollo preferido (Visual Studio, VS Code, etc.).
Asegúrate de tener las dependencias necesarias instaladas, como XUnit.
Ejecuta las pruebas desde tu IDE o utilizando el comando dotnet test en la terminal dentro del directorio del proyecto.
Importancia de las Pruebas Unitarias
Las pruebas unitarias son esenciales para garantizar la calidad del software, ya que:

Detectan errores en etapas tempranas del desarrollo.
Evitan regresiones al asegurar que nuevas implementaciones no afecten funcionalidades existentes.
Documentan el comportamiento esperado de las funciones y componentes del sistema.
Facilitan el mantenimiento y la refactorización del código al proporcionar una validación continua de su funcionamiento.
