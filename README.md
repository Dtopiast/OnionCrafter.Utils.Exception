# OnionCrafter.Utils.Exception

![Versión de la librería](https://img.shields.io/badge/Versi%C3%B3n-1.0.3-brightgreen) [![NuGet](https://img.shields.io/nuget/v/OnionCrafter.Utils.Exception.svg)](https://www.nuget.org/packages/OnionCrafter.Utils.Exception/)

![](https://raw.githubusercontent.com/Dtopiast/OnionCrafter.Utils.Exception/main/Images/Logo.png)

**Estado de la Librería: Pre-Alfa - No Listo para Producción**

Esta librería se encuentra actualmente en un estado pre-alfa, lo que significa que está en una fase muy temprana de desarrollo y no está destinada para su uso en entornos de producción. Estamos trabajando arduamente para mejorar y estabilizar la librería, pero aún pueden existir errores y limitaciones significativas.

Si estás interesado en utilizar esta librería, te recomendamos encarecidamente que la pruebes en un entorno de desarrollo o pruebas para evaluar su idoneidad para tu proyecto. No se garantiza la estabilidad ni la compatibilidad con versiones futuras en este estado inicial.

Por favor, mantente atento a futuras actualizaciones y anuncios sobre el progreso de la librería. Tu retroalimentación y contribuciones son bienvenidas a medida que avanzamos hacia una versión más estable y lista para producción.

## Descripción

"OnionCrafter.Utils.Exception" es una biblioteca diseñada para facilitar el manejo de excepciones en aplicaciones desarrolladas en .NET 7. Esta librería proporciona una serie de extensiones y utilidades que simplifican la gestión de excepciones en proyectos .NET, ayudando a los desarrolladores a controlar y propagar errores de manera efectiva.

## Características

- Extensiones para lanzar excepciones condicionalmente.
- Capacidad para personalizar las excepciones lanzadas con argumentos adicionales.
- Ayuda en la creación de excepciones personalizadas.
- Simplifica el manejo de excepciones en aplicaciones .NET 7.
- Contribuye a un código más limpio y estructurado.

## Requisitos

- .NET 7 (puedes encontrar información sobre cómo instalarlo [aquí](https://dotnet.microsoft.com/download/dotnet/7.0)).

## Instalación

Puedes agregar "OnionCrafter.Utils.Exception" a tu proyecto utilizando NuGet. Para hacerlo, abre la consola de NuGet y ejecuta el siguiente comando:

```bash
nuget install OnionCrafter.Utils.Exception
```

## Uso

A continuación, se muestra un ejemplo simple de cómo utilizar las extensiones proporcionadas por la librería:

```csharp
using OnionCrafter.Utils.Exception;

// ...

int age = 15;

age.ThrowIf<ArgumentException>(age < 0, "La edad no puede ser un número negativo.");
```

Este código lanzará una excepción `ArgumentException` si la edad es menor que 0, con el mensaje personalizado proporcionado.

## Contribuir

Si deseas contribuir a esta librería, ¡te damos la bienvenida! Puedes hacerlo de las siguientes maneras:

1. **Informa problemas:** Si encuentras algún problema o error, por favor, abre un [issue](https://github.com/tuusuario/OnionCrafter.Utils.Exception/issues).

2. **Envía Pull Requests:** Si deseas agregar nuevas características o corregir errores existentes, no dudes en enviar un [pull request](https://github.com/tuusuario/OnionCrafter.Utils.Exception/pulls).

## Licencia

Este proyecto está bajo la Licencia Mozilla Public License 2 (MPL 2). Consulta el archivo [LICENSE](LICENSE.txt) para obtener más detalles.

---

¡Esperamos que "OnionCrafter.Utils.Exception" te sea útil en tu proyecto! Si tienes alguna pregunta o sugerencia, no dudes en ponerte en contacto con nosotros. ¡Gracias por utilizar nuestra librería!
