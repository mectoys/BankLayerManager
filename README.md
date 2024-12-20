# BankLayerManager

BankLayerManager es una aplicación de escritorio desarrollada en C# con arquitectura en capas (DAL, BLL y UI) que permite realizar operaciones CRUD sobre una base de datos MySQL para la gestión de bancos. Este proyecto sigue buenas prácticas de diseño de software, implementando el patrón Repository y principios de separación de responsabilidades.

![Captura de pantalla 2024-12-15 130105](https://github.com/user-attachments/assets/429e4378-b70b-4774-bc93-8a07a3d7c7f0)

Versión UI:1.0
## Funcionalidades
- **Gestión de Bancos:**
  - Crear, editar, eliminar y listar bancos.
- **Arquitectura en capas:**
  - **DAL (Data Access Layer):** Contiene la lógica de acceso a datos.
  - **BLL (Business Logic Layer):** Implementa la lógica de negocio.
  - **UI (User Interface):** Interfaz gráfica de usuario con Windows Forms.
- **Integración con MySQL:** Utiliza ADO.NET para interactuar con la base de datos.

## Tecnologías utilizadas
- **Lenguaje:** C#
- **Base de datos:** MySQL
- **IDE:** Visual Studio 2022
- **Framework:** .NET Framework 4.8
- **Patrón de diseño:** Repository Pattern

## Estructura del proyecto
- **BankLayerManager.DAL:** Manejo de acceso a datos, consultas SQL y conexión a la base de datos.
- **BankLayerManager.BLL:** Contiene las reglas de negocio.
- **BankLayerManager.UI:** Interfaz de usuario para interactuar con la aplicación.

## Requisitos
1. Visual Studio 2019 o superior.
2. MySQL Server instalado y configurado.
3. Crear la tabla `Bancos` en la base de datos con el siguiente script:
   ```sql
   CREATE TABLE Bancos (
       idbco INT AUTO_INCREMENT PRIMARY KEY,
       descripcion VARCHAR(255) NOT NULL
   );
Contribuciones
¡Contribuciones son bienvenidas! Si deseas mejorar este proyecto, crea un fork y envía un pull request.

Autor
Creado por Jose Ponciano.
