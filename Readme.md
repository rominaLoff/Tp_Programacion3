# TP Integrador - Programación 3

Web API desarrollada en ASP.NET Core y C# que permite consultar productos
almacenados en una base de datos SQL Server. Implementa inyección de
dependencias, separación en capas (Controller, Service, Repository) y
acceso a datos con ADO.NET.

## Tecnologías utilizadas

- ASP.NET Core Web API (.NET 8)
- C#
- SQL Server
- ADO.NET (Microsoft.Data.SqlClient)
- Swagger (para probar los endpoints)

## Arquitectura

La aplicación está organizada en capas:

Controller → Service → Repository → ADO.NET → SQL Server

- **Controllers**: reciben las peticiones HTTP y devuelven las respuestas.
- **Services**: contienen la lógica de la aplicación.
- **Data (Repository)**: se encargan del acceso a datos con ADO.NET.
- **Models**: representan las entidades (Producto).

## Requisitos previos

- .NET 8 SDK instalado.
- Acceso a una base de datos SQL Server con la base `Programacion3`
  y la tabla `Productos`.
- Visual Studio 2022 (o similar).

## Configuración

1. Clonar el repositorio.
2. En el archivo `appsettings.json`, configurar la cadena de conexión
   `ConnectionStrings:Programacion3` con los datos del servidor SQL Server.
3. Si la base no existe, ejecutar el script `script.sql` para crear la
   base de datos, la tabla y los datos de prueba.

## Cómo ejecutar

1. Abrir la solución en Visual Studio.
2. Presionar F5 (o ejecutar `dotnet run`).
3. Se abrirá Swagger en el navegador.

## Endpoints

| Método | Ruta                   | Descripción                        |
|--------|------------------------|------------------------------------|
| GET    | /api/productos         | Devuelve todos los productos       |
| GET    | /api/productos/{id}    | Devuelve un producto por su Id     |

### Respuestas posibles

- **200 OK**: la consulta se realizó correctamente.
- **404 Not Found**: el producto solicitado no existe.
- **500 Internal Server Error**: error al acceder a la base de datos.

## Autor

Romina Argañaraz - TP Integrador Programación 3