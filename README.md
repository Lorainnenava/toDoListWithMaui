# 📌 Proyecto en .NET MAUI con MVVM

Este repositorio proporciona una estructura completa y bien organizada para desarrollar aplicaciones en .NET MAUI utilizando el patrón MVVM. Incluye ejemplos base y buenas prácticas para acelerar el desarrollo de aplicaciones multiplataforma.

## 📑 Tabla de Contenidos
1. [Descripción](#-proyecto-en-net-maui-con-mvvm)  
2. [Estructura del Proyecto](#-estructura-del-proyecto)  
3. [Instalación](#-instalación)  
4. [Cómo ejecutar el proyecto](#-cómo-ejecutar-el-proyecto)  
5. [Uso](#-uso)  
6. [Arquitectura](#-arquitectura)  
7. [Tecnologías](#-tecnologías-utilizadas)  
8. [Contribuciones](#-contribuciones)
9. [Próximas implementaciones](#-próximas-implementaciones) 
10. [Licencia](#-licencia)  
11. [Autor](#%EF%B8%8F-autor)

## 📂 Estructura del Proyecto

```
📦 TuProyectoMaui
│── 📂 Controls         # Componentes reutilizables (Custom Controls)
│── 📂 DTOs             # Objetos de solicitud y respuesta (Data Transfer Objects)
│── 📂 Helper           # Servicios reutilizables como interfaces, services, enums
│── 📂 Interfaces       # Interfaces para ViewModels y servicios utilizados en la aplicación.
│── 📂 ViewModels       # Lógica de presentación (ViewModels de las Pages y Controls)
│── 📂 Views            # Páginas de la aplicación (XAML + Code-Behind)
│── 📂 Models           # Clases de modelos (si es necesario)
│── 📂 Resources        # Recursos como estilos, imágenes, fuentes
│── 📂 Services         # Servicios para acceder a datos o APIs
│── 📂 Platforms        # Código específico de cada plataforma (Android, iOS, Windows)
│── 📂 Properties       # Configuración de la aplicación (como `AssemblyInfo.cs`)
│── 📜 App.xaml         # Archivo de estilos y recursos globales
│── 📜 App.xaml.cs      # Clase principal que inicializa la app
│── 📜 AppShell.xaml    # Definición del Shell de navegación
│── 📜 AppShell.xaml.cs # Código-behind del Shell
│── 📜 GlobalUsings.cs  # Usings globales para evitar redundancia
│── 📜 MauiProgram.cs   # Configuración de la app (IoC, servicios, etc.)
│── 📜 .gitignore       # Archivo para ignorar archivos innecesarios en Git
│── 📜 README.md        # Documentación del proyecto

```

## 🛠 Instalación

1. Clona el repositorio:
   ```bash
   git clone https://github.com/Lorainnenava/toDoListWithMaui.git
   cd toDoListWithMaui
    ```

2. Instala las dependencias:
    ```bash
    dotnet restore
    ```
## 🚀 Cómo ejecutar el proyecto
📱 En un Emulador (Android/iOS)
1. Abre Visual Studio 2022.

2. Carga la solución (.sln).

3. En la barra superior, selecciona un dispositivo Android Emulator o iOS Simulator.

4. Haz clic en el botón ▶ Ejecutar.

💻 En Windows (WinUI 3)
Si estás en Windows y deseas ejecutarlo como una aplicación de escritorio, elige la opción Windows Machine y haz clic en Ejecutar.

🔧 Desde la Terminal
También puedes ejecutar el proyecto manualmente con:

```bash
dotnet build
dotnet maui run
```

## 📝 Uso  

Cuando inicies el proyecto, deberías ver la pantalla de **Login**, donde tendrás las siguientes opciones:  
- **Iniciar sesión** con una cuenta existente.  
- **Registrarte** si no tienes una cuenta.  
- **Olvidé mi contraseña**, para recuperar el acceso si lo necesitas.  

### 📌 Navegación  
🔹 Una vez que inicies sesión, accederás al **Dashboard**, donde encontrarás un **menú con diferentes opciones**.  
🔹 Las páginas aún no tienen implementación completa, pero cuentan con una **base estructurada** para servir como guía.  
🔹 Desde el navBar puedes cambiar entre los temas **claro y oscuro**.  
🔹 También puedes **cerrar sesión** en cualquier momento desde la vista de configuración.  

Este proyecto te servirá como base para construir tu propia aplicación. 🚀

## 🏛 Arquitectura

Este proyecto sigue el patrón **MVVM (Model-View-ViewModel)** para separar la lógica de UI y la lógica de negocio.  

🔹 **📝 Modelo (Model)**  
- Contiene las **clases de datos** que representan los objetos del dominio.  
- Define la estructura de los datos que utiliza la aplicación.  

🔹 **🎨 Vista (View)**  
- Es la interfaz gráfica con la que interactúa el usuario.  
- **No debe contener lógica de negocio**, solo debe mostrar la información que recibe del ViewModel.  

🔹 **🔄 Modelo de Vista (ViewModel)**  
- Conecta la **Vista** con el **Modelo**, gestionando la lógica de presentación.  
- Maneja **data binding**, **eventos** e interacción con los datos sin modificar la UI directamente.  

Este enfoque permite que la UI sea más flexible y desacoplada de la lógica de negocio, lo que facilita pruebas unitarias y mejora la mantenibilidad del código. 🚀  

## 🛠 Tecnologías Utilizadas

- **.NET MAUI** 🏗️ - Framework para desarrollar la aplicación multiplataforma.  
- **C#** 💻 - Lenguaje de programación principal del proyecto.  
- **MVVM** 🔄 - Patrón de arquitectura para separar la lógica de negocio de la UI.  
- **HTTP (HttpClient)** 🔗 - Para la comunicación con la API.  
- **XAML** 📜 - Lenguaje de marcado para diseñar la interfaz de usuario.  
- **Dependency Injection (DI)** 🏗️ - Para gestionar dependencias de manera eficiente.  

## 🤝 Contribuciones
¡Toda ayuda es bienvenida! Si deseas contribuir a este proyecto, sigue estos pasos:

1. Haz un fork del repositorio y clónalo en tu máquina local.

2. Crea una nueva rama con el nombre de tu mejora o corrección:
```bash
git checkout -b nombre-de-tu-rama
```

3. Realiza los cambios y confírmalos con un mensaje claro:
```bash
git commit -m "Descripción breve de los cambios"
```
4. Sube los cambios a tu fork:
```bash
git push origin nombre-de-tu-rama
```
5. Abre un pull request (PR) en este repositorio y describe los cambios que realizaste.

⚠️ **Nota:** Antes de hacer un PR, asegúrate de que tu código sigue las buenas prácticas y que todo funciona correctamente. 🚀

## 🧪 Próximas Implementaciones
📌 Pruebas Unitarias y de Integración
Actualmente, el proyecto no cuenta con pruebas automatizadas, pero próximamente se integrarán pruebas unitarias y de integración utilizando xUnit y MSTest, junto con Moq para simulaciones.

✅ Se implementarán tests para:

Servicios (validaciones, consumo de APIs, etc.).

ViewModels (pruebas de lógica de presentación).

Navegación y flujo de la aplicación.

⚙️ Se documentará cómo ejecutar y agregar nuevos tests en el proyecto. ¡Mantente atento a las actualizaciones! 🚀

## 📜 Licencia

Este proyecto está bajo la licencia MIT. Consulta el archivo `LICENSE` para más detalles.

## ✍️ Autor

👤 **Lorainne Navarro Carrillo**
 
🔗 [GitHub](https://github.com/Lorainnenava) | [LinkedIn](https://www.linkedin.com/in/lorainne-navarro-carrillo-full-stack-developer/)
