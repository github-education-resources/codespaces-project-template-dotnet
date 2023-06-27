[![Abre en GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://github.com/codespaces/new?hide_repo_select=true&ref=main&repo=education/codespaces-project-template-dotnet) 

# .NET (Blazor) Sitio de Portafolio con GitHub Codespaces

_Cree, personalice e implemente su propio sitio web de portafolio en minutos._ ✨

En este repositorio de plantillas tenemos el entorno de desarrollo y el conjunto base y listo para funcionar. Para que pueda iniciar inmediatamente Codespaces para personalizar sin configuración.

* **¿Para quién es esto?** __Cualquiera__ que desee crear un sitio de portafolio, aprender desarrollo web o probar Codespaces.
* **¿Cuánta experiencia necesitas?** __Cero__. Usted decide cuánto desea personalizar según su experiencia y el tiempo disponible.
* **Herramientas necesarias:** _Ninguna_. ¡No es necesario instalar nada! Todo lo que necesitas es un navegador web.
* **Requisitos previos:** _Ninguno_. Esta plantilla incluye su entorno de desarrollo y una aplicación web implementable para que pueda crear su propio sitio.

## Acerca de esta plantilla de portafolio

En este portafolio de plantillas "elige tu propia aventura", tenemos una aplicación web basada en [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor?WT.mc_id=dotnet-82024-juyoo) lista para que la personalice e implemente fácilmente usando solo su navegador web.

![Aplicación web de perfil de Blazor WebAssembly](./images/blazorwasm-portfolio-site.gif "Aplicación web de perfil de Blazor WebAssembly")

### Inicio rápido

1. Haga clic en el botón **Usar esta plantilla**
   
    [![Usar esta plantilla](/images/template-button.svg)](https://github.com/education/codespaces-project-template-dotnet/generate)
1. Seleccione el propietario del repositorio (por ejemplo, su cuenta de GitHub)
1. Ingrese un nombre único para su nuevo repositorio
1. Haga clic en el botón **Código**
1. Haga clic en **Crear Codespace en el botón principal**
1. [Personalice el sitio de su portafolio}(#-personalice-su-sitio-en-4-pasos)
1. [Implemente su sitio](#-implemente-su-aplicación-web)

<details>
    <summary><b>🎥 Para obtener más información sobre Codespaces, vea nuestra serie de tutoriales en video</b></summary>
   
[![Tutorial de Codespaces](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://aka.ms/CodespacesVideoTutorial "Tutorial de Codespaces")
</details>

<br />

## 🗃️ .NET (Blazor) Plantilla de Portafolio

Este repositorio es una plantilla de GitHub para crear una aplicación web frontend de portafolio personal de .NET utilizando el framework Blazor WebAssembly. El objetivo es brindarle una plantilla para que pueda utilizar de inmediato para crear su propio sitio web a través de Codespaces.

El repositorio contiene lo siguiente:

* `/.DevContainer`
   - `.DevContainer/DockerFile`: archivo de configuración utilizado por Codespaces para determinar el sistema operativo y otros detalles.
   - `.DevContainer/DevContainer.json`: archivo de configuración utilizado por Codespaces para configurar la configuración del código de Visual Studio, como la habilitación de extensiones adicionales.
   - `.devcontainer/post-create.sh`: archivo de configuración utilizado por Codespaces para instalar herramientas adicionales, como PowerShell.
* `/SRC`: Proyecto Blazor WebAssembly para construir su sitio de portafolio.
* `.EditorConfig`: Configuración para [EditorConfig](https://editorconfig.org/) que ayuda a mantener estilos de codificación consistentes en CodeSpaces.
* `Global.json`: Configuración para la aplicación Blazor WebAssembly para evitar el uso de la versión .NET pre-lanzada.
* `swa-cli.config.json`: Configuración para [Azure SWA CLI](https://azure.github.io/static-web-apps-cli/) para ejecutar la aplicación Blazor WebAssembly en Codespaces.
* `Myportfolio.sln`: el archivo de solución que contiene el proyecto de aplicación Blazor WebAssembly.

<br />

## 🚀 Empezando

Este proyecto de sitio de portafolio está lleno de datos de muestra para que pueda abrir Codespaces inmediatamente, verlo en ejecución e implementarlo en cualquier momento.

Su entorno de desarrollo está listo para que comience. Basado en nuestra [plantilla .NET CodesPaces](https://github.com/education/codespaces-teaching-template-dotnet), aquí está lo que ya está configurado y listo para que use:

* Simple [Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor?wt.mc_id=dotnet-82024-juyoo) Aplicación con componentes para cada sección del sitio de portafolio
* [SWA CLI](https://azure.github.io/static-web-apps-cli/) en su lugar para construir su sitio cuando se implementa
* Código linting y en formato usando [EditorConfig](https://editorconfig.org/) para la consistencia del código.

### Crea tu portafolio

1. Cree un repositorio a partir de esta plantilla. Use este [crear enlace de repositorio] (https://github.com/education/codespaces-teaching-template-dotnet/generate). Seleccione el propietario del repositorio, proporcione un nombre, una descripción si lo desea y si desea que el nuevo repositorio sea público o privado.
2. Navegue a la página principal del repositorio recién creado.
3. Debajo del nombre del repositorio, use el menú desplegable Código y, en la pestaña Espacios de códigos, seleccione "Crear espacio de códigos en principal".

     <img src="https://docs.github.com/assets/cb-138303/images/help/codespaces/new-codespace-button.png" alt="Crear codespace" style="width:270px;"/ >
    
4. Espere mientras GitHub inicializa Codespaces.

     <img src="./images/codespaces-initializing.png" alt="Codespaces initializing" style="width: 600px;"/>
    
5. Cuando termine, verá que sus Codespaces se cargan con una sección de terminal en la parte inferior. Aquí verá la ejecución de `dotnet restore && dotnet build`. Cuando termine, volverá al indicador de terminal donde puede ejecutar la aplicación web ejecutando: `swa start`.

    Cuando se inicie la aplicación web, verá un mensaje que le indicará que se inició correctamente en el puerto 4280, y puede abrir ese sitio dentro de su navegador:

    <img src="./images/app-running-in-codespaces.png" alt="La aplicación web se inició en el puerto 4280" style="width: 340px;"/>

<br />

## ✨ Personalice su sitio en 4-pasos

Este proyecto está construido para ser fácilmente personalizable. Cada sección del sitio es un componente separado y su información debe configurarse en un solo lugar. Esto no es solo para facilitar la actualización, sino para que pueda ver cómo se pasan los valores prop a los componentes de React.

Para cada paso, abra el proyecto en Codespaces, luego puede realizar y confirmar sus cambios dentro de sus Codespaces.

> Consulte [Uso del control de código fuente en sus espacios de código] (https://docs.github.com/codespaces/developing-in-codespaces/using-source-control-in-your-codespace) para obtener más instrucciones sobre el control de código fuente de Codespaces

### 1️⃣ Agrega tus datos y cuentas de redes sociales

Abra `/src/BlazorApp/wwwroot/sample-data/siteproperties.json`. Este es un objeto JSON que contiene los pares de valores clave necesarios para personalizar su nombre, título, correo electrónico y cuentas de redes sociales.

```jsonc
{
  "name": "Alexandrie Grenier",
  "title": "Web Designer & Content Creator",
  "email": "alex@example.com",
  "gitHub": "microsoft",
  "devDotTo": null,
  "instagram": "microsoft",
  "linkedIn": "satyanadella",
  "medium": "",
  "twitter": "microsoft",
  "youTube": "microsoft",
};
```
Actualice el nombre y el título que desea mostrar en la parte superior de su sitio.

_Valores opcionales_ son la dirección de correo electrónico y las cuentas sociales. Estos se utilizan en el componente `Pie de página`. Si algún elemento no está incluido en la lista o se establece en una cadena vacía (""), no mostrará el icono ni el enlace.

### 2️⃣ Actualizar imágenes

Este sitio de cartera incluye 3 imágenes: fondo de la sección superior, fondo "Acerca de mí" y sección de cartera (escritorio). Estas pueden ser cualquier imagen de tamaño **paisaje** que elijas de tu propia colección, o que tengas una licencia que te permita usar sin atribución.

Un par de sitios posibles para encontrar fotos son [Pixabay](https://pixabay.com/) y [Unsplash](https://unsplash.com). Fotos, ilustraciones, vectores, ¡tú eliges! Cuando encuentre sus imágenes, guarde cada una en `/src/BlazorApp/wwwroot/images` con un nombre de archivo breve y significativo.

Abra `/src/BlazorApp/wwwroot/sample-data/heroimages.json` y actualice las imágenes con sus preferidas, así como el texto alternativo para cada imagen:

```jsonc
[
  {
    // Home component
    // section at top of the page, main image you will see when site loads (woman standing by server wall in sample)
    "name": "home",
    "src": "images/server-wall.jpg",
    "alt": "woman holding laptop standing by server room with glass wall"
  },
  {
    // About me component
    // background behind the detailed "about me" section (abstract mosaic in sample)
    "name": "about",
    "src": "images/mosaic.svg",
    "alt": "purple and blue abstract background"
  },
  {
    // Portfolio component
    // image highted in left hand side of section (design desk photo in sample)
    "name": "portfolio",
    "src": "images/design-desk.jpeg",
    "alt": "desktop with books and laptop"
  }
]
```
### 3️⃣ Añade tu "acerca de mí"

La sección Acerca de ayuda a brindar a las personas un poco más de información sobre tus habilidades y pasiones. Abra `/src/BlazorApp/wwwroot/sample-data/aboutme.json` y actualice esas 3 propiedades:

* `descripción`: frase corta o dos que te describen a ti mismo, objetivo profesional y/o pasiones
* `skillsList`: una [matriz](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Array) de sus habilidades para enumerar en el sitio, puede ser tantas o tan pocas como desee
* `detailOrQuote`: bloque más largo para que agregues más detalles sobre ti, o incluso una cita que te guste


### 4️⃣ Agrega elementos en los que has trabajado y detalla el texto

Esta sección para actualizar es el portafolio, donde resalta los elementos en los que ha trabajado. Estos serían artículos, videos, diseños de logotipos, proyectos de GitHub, ¡cualquier cosa que lo destaque!

Abra `/src/BlazorApp/wwwroot/sample-data/projects.json` que es una matriz JSON. Cada elemento que desee resaltar necesita: título, descripción y URL.

El diseño de la muestra tiene 4, pero el número que incluya depende de usted.

```jsonc
[
  {
    "title": "10 Things To Know About Azure Static Web Apps 🎉",
    "description": "Collaboration to create a beginner friendly article to help explain Azure Static Web Apps and tooling to get started.",
    "url": "https://dev.to/azure/10-things-to-know-about-azure-static-web-apps-3n4i"
  },
  {
    "title": "Web Development for Beginners",
    "description": "Contributed sketch note imagery to accompany each lesson. These help provide visual representation of what is being taught.",
    "url": "https://github.com/microsoft/web-dev-for-beginners"
  },
  {
    "title": "My Resume Site",
    "description": "Created from Microsoft's resume workshop and deployed to GitHub pages. Includes my experience and design abilities.",
    "url": "https://github.com/microsoft/workshop-library/tree/main/full/build-resume-website"
  },
  {
    "title": "GitHub Codespaces and github.dev",
    "description": "Video interview to explain when to use GitHub.dev versus GitHub Codespaces, and how best to use each tool.",
    "url": "https://www.youtube.com/watch?v=c3hHhRME_XI"
  }
]
```

<br/>

## 🏃 Implementa tu aplicación web

Project incluye la configuración necesaria para implementar **gratis** en ambas [Azure Static Web Apps](https://azure.microsoft.com/products/app-service/static/?WT.mc_id=dotnet-82024- juyoo) y [Páginas de GitHub](https://pages.github.com/)</a>.

### Aplicaciones web estáticas de Azure

[Azure Static Web Apps](https://azure.microsoft.com/products/app-service/static/?WT.mc_id=dotnet-82024-juyoo) es la solución de alojamiento de Microsoft para sitios estáticos (o sitios que se representan en el navegador del usuario, no en un servidor) a través de Azure. Este servicio brinda oportunidades adicionales para expandir su sitio a través de Azure Functions, autenticación, versiones provisionales y más.

Necesitará cuentas de Azure y GitHub para implementar su aplicación web. Si aún no tiene una cuenta de Azure, puede crearla desde dentro durante el proceso de implementación o desde los siguientes enlaces:

* [Cree una cuenta de Azure para estudiantes (no se requiere tarjeta de crédito)](https://azure.microsoft.com/free/students/?WT.mc_id=dotnet-82024-juyoo)
* [Crear una nueva cuenta de Azure](https://azure.microsoft.com/free/?WT.mc_id=dotnet-82024-juyoo)

Con su proyecto abierto en Codespaces:

1. Haga clic en el icono de Azure en la barra lateral izquierda. Inicie sesión si aún no lo ha hecho y, si es nuevo en Azure, siga las indicaciones para crear su cuenta.
1. En el menú de Azure, haga clic en el signo "➕" y luego seleccione "Crear aplicación web estática".

    <img src="./images/deploy-to-azure.png" alt="Crear aplicación web estática" style="width: 300px;" />

1. Si no ha iniciado sesión en GitHub, se le pedirá que inicie sesión. Si tiene algún cambio de archivo pendiente, se le pedirá que confirme esos cambios.
1. Configure la información de su aplicación cuando se le solicite:
     1. **Nombre de la aplicación web estática**: ingrese el nombre de la aplicación web estática. Predeterminado a su nombre de repositorio de GitHub.
     1. **Región**: elige la más cercana a tu región
     1. **Estructura del proyecto**: seleccione "Blazor"
     1. **Ubicación del código de la aplicación**: ingrese `/src/BlazorApp`
     1. **Ubicación de salida**: ingrese `wwwroot`
1. Cuando termine, verá una notificación en la parte inferior de su pantalla y se agregará un nuevo flujo de trabajo de GitHub Action a su proyecto. Si hace clic en "Abrir acción en GitHub", verá la acción que se creó para usted y que se está ejecutando actualmente.

> 🤩 **Bonificación**: [Configure un dominio personalizado para su aplicación web estática de Azure](https://learn.microsoft.com/shows/azure-tips-and-tricks-static-web-apps/how-to -configurar-un-nombre-de-dominio-personalizado-en-azure-static-web-apps-10-of-16--azure-tips-and-tricks-static-w/?WT.mc_id=dotnet-82024 -juyoo)

### Páginas de GitHub

[Páginas de GitHub](https://pages.github.com/) le permite alojar sitios web directamente desde su repositorio de GitHub. Este proyecto ya está configurado para que pueda implementar su cartera en las páginas de GitHub con pasos mínimos.

En tu repositorio de GitHub:

1. Vaya a la pestaña "Configuración" y navegue hasta el menú "Páginas".
1. En la sección _Crear e implementar_, seleccione el origen de **Acciones de GitHub**.

     <img src="./images/deploy-to-ghpages-01.png" alt="Elegir acciones de GitHub para implementar en páginas de GitHub" style="width: 600px;" />

1. Asegure la visibilidad de sus Páginas de GitHub para **Público**.
1. Ejecute un flujo de trabajo de GitHub Action insertando código o invocándolo manualmente.

     <img src="./images/deploy-to-ghpages-02.png" alt="Invocar acciones de GitHub" style="width: 600px;" />

1. Visite sus páginas de GitHub.

     <img src="./images/deploy-to-ghpages-03.png" alt="Visita páginas de GitHub" style="width: 600px;" />

> 🤩 **Bonificación**: [Configure un dominio personalizado para su sitio de páginas de GitHub](https://docs.github.com/pages/configuring-a-custom-domain-for-your-github-pages-site/ administrar-un-dominio-personalizado-para-su-sitio-github-pages)

<br />

## 🏆 Desafíos

A continuación se presentan 4 formas adicionales en las que puede continuar personalizando su sitio de cartera y aprender algunos Codespaces, CSS, HTML y JavaScript en el camino.

   1. [Personaliza tus Codespaces](#1-personaliza-tus-codespaces)
   1. [Actualización para desplazamiento suave a una sección](#2-actualización-para-desplazamiento-suave-a-una-sección)
   1. [Animar la foto del escritorio](#3-animar-la-foto-del-escritorio)
   1. [Agregar una nueva sección](#4-agregar-una-nueva-sección)

### 1. Personaliza tus Codespaces

Su entorno viene con extensiones preinstaladas. Puede cambiar con qué extensiones comienza su entorno Codespaces, así es como:

1. Abra el archivo _.devcontainer/devcontainer.json_ y localice el siguiente elemento JSON **extensiones**

   ```jsonc
   "extensions": [
     "ms-dotnettools.csharp",
     "ms-vscode.PowerShell",
     "ms-vscode.vscode-node-azure-pack",
     "VisualStudioExptTeam.vscodeintellicode"
   ]
   ```

   1. Agreguemos la extensión `indent-rainbow`. Para hacer esto, ve a la lista de **extensiones** y agrega:

   
   ```jsonc
   "oderwat.indent-rainbow"
   ```

   Lo que hiciste anteriormente fue agregar el identificador único de una extensión de [indent-rainbow](https://marketplace.visualstudio.com/items?itemName=oderwat.indent-rainbow&WT.mc_id=dotnet-82024-juyoo). Esto le permitirá a Codespaces saber que esta extensión debe estar preinstalada al inicio.

Para encontrar el identificador único de una extensión:

* Vaya a la página web de la extensión, así [https://marketplace.visualstudio.com/items?itemName=oderwat.indent-rainbow](https://marketplace.visualstudio.com/items?itemName=oderwat.indent- arco iris&WT.mc_id=dotnet-82024-juyoo)
* Ubique el campo _Identificador único_ en la sección **Más información** en su lado derecho.
   
> 💡 Más información aquí, <https://docs.github.com/codespaces/customizing-your-codespace/personalizing-github-codespaces-for-your-account>

### 2. Actualizar para desplazarse suavemente a una sección

En el encabezado de su sitio tiene enlaces a cada sección a continuación. Haga clic en uno de estos enlaces y observe cómo se desplaza la página hasta esa sección. No es realmente un pergamino, ¿verdad?

Hagamos de esto una mejor experiencia para el usuario ralentizándolo para que el usuario tenga una idea de lo que está sucediendo y hacia dónde está navegando en la página.

1. Abra `/src/BlazorApp/wwwroot/css/app.css`, que es la hoja de estilo para su aplicación de cartera. Necesitamos agregar un estilo para `html`. Si observa, verá que ahora los estilos `html` y `body` se están configurando juntos, así que agreguemos el siguiente fragmento de css para configurar el desplazamiento del elemento `html`:

    ```css
    html {
      scroll-behavior: smooth;
    }
    ```
Su sitio ya debería estar ejecutándose en sus Codespaces, y el cambio se volverá a cargar en la página automáticamente. Haga clic en un enlace en el encabezado superior para ver el desplazamiento suave en acción.

### 3. Animar foto de escritorio

Las animaciones son una forma en que puede agregar fácilmente algo de movimiento a los elementos de su página para aumentar la interactividad del usuario y resaltar los elementos que desea asegurarse de que noten. Vamos a animar la foto del escritorio en la sección de portafolio.

1. Abra la hoja de estilo de su sitio, `/src/BlazorApp/wwwroot/css/app.css` dentro de sus Codespaces. Agregue la secuencia de animación agregando una definición `@keyframes` para deslizar desde la izquierda:

```css
    @keyframes slideInLeft {
      0% {
        transform: translateX(-100%);
      }
      100% {
        transform: translateX(0);
      }
    }
    ```

    1. Ahora que hemos definido nuestra secuencia de animación `slideInLeft` podemos decirle a nuestra foto de escritorio que se anime con esa secuencia. Abra `/src/BlazorApp/Components/Portfolio.razor` y localice la etiqueta `img`. Verá que utiliza CSS en línea para configurar su estilo. Dentro de su definición de estilo, agregue lo siguiente:

        ```css
        animation: 1s ease-out 0s 1 slideInLeft;
        ```

    La etiqueta de tu imagen debería ser algo como:

    ```html
    <img src="@(hero.Src)" style="height: 90%; width: 100%; object-fit: cover; animation: 1s ease-out 0s 1 slideInLeft;" alt="@(hero.Alt)" />
    ```

    Su sitio ya debería estar ejecutándose en sus Codespaces, y el cambio se volverá a cargar en la página automáticamente. Desplácese hacia arriba y hacia abajo en la página y observe cómo se desliza la foto de su escritorio en la página.

> 🤩 **Bonificación**: Flecha de desplazamiento hacia abajo animada

### 4. Agregar una nueva sección

Comenzamos con algunas secciones básicas para su sitio de cartera, pero tiene libertad creativa para personalizarlo y agregar nuevas secciones relevantes para lo que desea en su sitio.

Por ejemplo, agreguemos una sección de educación a su sitio de cartera.

1. Cree un nuevo componente para la sección dentro de la carpeta `Componentes`. Agrega un nuevo archivo llamado `Education.razor`.

1. En `Education.razor` agregue la función del componente, la exportación y la información que le gustaría incluir:

    ```razor
    <section class="light" id="portfolio">
        <h2>Education</h2>
    </section>
    ```

1. En `Index.razor` agregue el componente `Educación` donde le gustaría que se muestre dentro de la página insertando:


    ```razor
    <Education />
    ```

En sus Codespaces, su aplicación de cartera debería estar ejecutándose y recargará su sitio con los cambios.


<br />

## 📚 Recursos

* [Resumen de documentos de GitHub Codespaces] (https://docs.github.com/codespaces/overview)
* [Guías de espacios de código de GitHub] (https://docs.github.com/codespaces/guides)
* [Usar contenedores de desarrollo localmente con VS Code y Docker](https://github.com/microsoft/vscode-remote-try-dotnet#vs-code-dev-containers)
* [Empezar con Blazor](https://learn.microsoft.com/training/paths/build-web-apps-with-blazor/?WT.mc_id=dotnet-82024-juyoo)
* [Desarrollo web para principiantes](https://github.com/microsoft/Web-Dev-For-Beginners)

> #### Aplicación de navegador Codespaces
>
> Si está utilizando Edge o Chrome, verá una opción para instalar la aplicación Codespaces cuando inicie su Codespaces. La aplicación Codespaces le permite iniciar sus Codespaces dentro de la aplicación para que pueda trabajar fuera del navegador. Busque el icono de la aplicación e instale la ventana emergente para probarla.
>
> <img src="./images/codespaces-app.png" alt="Aplicación de navegador Codespaces" style="width: 400px;"/>

<br />

## 🔎 ¿Encontró un problema o tiene una idea para mejorar?

Ayúdanos a mejorar este repositorio de plantillas [informándonos y abriendo un problema](/../../issues/new).