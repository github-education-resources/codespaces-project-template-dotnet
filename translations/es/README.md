[![Abre en GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://github.com/codespaces/new?hide_repo_select=true&ref=main&repo=education/codespaces-project-template-dotnet) 

# .NET (Blazor) Sitio de Portafolio con GitHub Codespaces

_Cree, personalice e implemente su propio sitio web de portafolio en minutos._ ✨

En este repositorio de plantillas tenemos el entorno de desarrollo y el conjunto base y listo para funcionar. Para que pueda iniciar inmediatamente Codespaces para personalizar sin configuración.

* **¿Para quién es esto?** __Cualquiera__ que desee crear un sitio de portafolio, aprender desarrollo web o probar Codespaces.
* **¿Cuánta experiencia necesitas?** __Cero__. Usted decide cuánto desea personalizar según su experiencia y el tiempo disponible.
* **Herramientas necesarias:** _Ninguna_. ¡No es necesario instalar nada! Todo lo que necesitas es un navegador web.
* **Requisitos previos:** _Ninguno_. Esta plantilla incluye su entorno de desarrollo y una aplicación web implementable para que pueda crear su propio sitio.

## Acerca de esta plantilla de portafolio

En esta plantilla podrás "elegir tu propia aventura": tenemos una aplicación web basada en [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor?WT.mc_id=dotnet-82024-juyoo) lista para que puedas personalizarla e implementarla fácilmente utilizando solo tu navegador web.

![Aplicación web de perfil de Blazor WebAssembly](../../images/blazorwasm-portfolio-site.gif "Aplicación web de perfil de Blazor WebAssembly")

### Inicio rápido

1. Haga clic en el botón **Usar esta plantilla**
   
    [![Usar esta plantilla](/images/template-button.svg)](https://github.com/education/codespaces-project-template-dotnet/generate)
1. Seleccione el propietario del repositorio (por ejemplo, su cuenta de GitHub)
1. Ingrese un nombre único para su nuevo repositorio
1. Haga clic en el botón **Código**
1. Haga clic en **Crear Codespace en el botón principal**
1. [Personaliza tu portafolio](#-personalice-tu-portafolio)
1. [Sube tu Portafolio a la nube](#-sube-tu-portafolio-a-la-nube)

<details>
    <summary><b>🎥 Para obtener más información sobre Codespaces, ve nuestros tutoriales.</b></summary>
   
[![Tutorial de Codespaces](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://aka.ms/CodespacesVideoTutorial "Tutorial de Codespaces")
</details>

<br />

## 🗃️ .NET (Blazor) Plantilla de Portafolio

Este repositorio es una plantilla de GitHub para crear una aplicación web frontend de portafolio personal de .NET utilizando el framework Blazor WebAssembly. El objetivo es darte una plantilla que puedas utilizarla inmediatamente para crear tu propia página web a través de Codespaces.

El repositorio contiene lo siguiente:

* `/.devcontainer`
   - `.devcontainer/Dockerfile`: archivo de configuración utilizado por Codespaces para determinar el sistema operativo y otros detalles.
   - `.devcontainer/devcontainer.json`: archivo de configuración utilizado por Codespaces para configurar la configuración del código de Visual Studio, como la habilitación de extensiones adicionales.
   - `.devcontainer/post-create.sh`: archivo de configuración utilizado por Codespaces para instalar herramientas adicionales, como PowerShell.
* `/src`: Proyecto Blazor WebAssembly para construir tu portafolio web.
* `.editorconfig`: Configuración para [EditorConfig](https://editorconfig.org/) que ayuda a mantener estilos de codificación consistentes en Codespaces.
* `global.json`: Configuración para la aplicación Blazor WebAssembly para evitar el uso de la versión .NET pre-lanzada.
* `swa-cli.config.json`: Configuración para [Azure SWA CLI](https://azure.github.io/static-web-apps-cli/) para ejecutar la aplicación Blazor WebAssembly en Codespaces.
* `MyPortfolio.sln`: el archivo de solución que contiene el proyecto de aplicación Blazor WebAssembly.

<br />

## 🚀 Comenzando

Este portafolio web está lleno de datos de ejemplo para que puedas abrirlo inmediatamente en Codespaces, verlo en ejecución y subirlo a la nube en cualquier momento.

Tu entorno de desarrollo está listo para que pueda comenzar. Basado en nuestra [plantilla de .NET CodesPaces](https://github.com/education/codespaces-teaching-template-dotnet), esto es lo que ya está configurado y listo para su uso:

* Simple [Blazor WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor?wt.mc_id=dotnet-82024-juyoo) Aplicación con componentes para cada sección del Portafolio web
* [SWA CLI](https://azure.github.io/static-web-apps-cli/) en su lugar para construir su sitio cuando se implementa
* Código linting y en formato usando [EditorConfig](https://editorconfig.org/) para la consistencia del código.

### Crea tu portafolio

1. Crea un repositorio a partir de esta plantilla. Usa este [link para crear el repositorio](https://github.com/education/codespaces-teaching-template-dotnet/generate). Selecciona el propietario del repositorio, proporciona un nombre, una descripción si lo deseas y selecciona si tu nuevo repositorio será público o privado.
2. Ve a la página principal del repositorio recién creado.
3. Debajo del nombre del repositorio, usa el menú desplegable del Código y, en la pestaña de Codespaces selecciona "Create codespace on main".

     <img src="https://user-images.githubusercontent.com/2198735/250924075-7e35b981-b983-47d4-af9e-f2e0af207103.png" alt="Crear codespace" style="width:270px;"/>
    
4. Espera mientras GitHub inicializa el Codespace.

     <img src="../../images/codespaces-initializing.png" alt="Codespaces initializing" style="width: 600px;"/>
    
5. Cuando haya terminado, verás que tu Codespace comenzará con una sección de terminal en la parte inferior. Codespaces instalará todas las extensiones requeridas en tu contenedor, luego verás npm install ejecutando. Aquí veras `dotnet restore && dotnet build` ejecutandose. Cuando termine, volverás al terminal prompt donde puedes ejecutar la aplicación web con solo escribir: `swa start`.

    Cuando se inicie la aplicación web, verá un mensaje que le indicará que se inició correctamente en el puerto 4280, y puede abrir ese sitio dentro de tu navegador:

    <img src="../../images/app-running-in-codespaces.png" alt="La aplicación web se inició en el puerto 4280" style="width: 340px;"/>

<br />

## ✨ Personalice su sitio en 4-pasos

Este proyecto está diseñado para ser fácilmente personalizable. Cada sección del sitio es un componente separado, y tu información debe establecerse en un solo lugar. Esto no es solo para facilitar la actualización, sino para que puedas ver cómo se pasan los valores a diferentes secciones de tu portafolio web.```

Para cada paso, abre el proyecto en Codespaces, luego puedes realizar y confirmar cambios mientras estás dentro de tu Codespace.

> Consulta el [uso del control de código fuente en tu codespace](https://docs.github.com/en/codespaces/developing-in-codespaces/using-source-control-in-your-codespace) para obtener más instrucciones sobre el control de código fuente de Codespaces.

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
Actualice el nombre y el título que deseas mostrar en la parte superior de tu portafolio.

Optional values (valores opcionales) son la dirección de correo electrónico y redes sociales. Estos se utilizan en el componente 'Pie de página'. Si algún elemento no está incluido en la lista, o establecido en una cadena vacía (""), no mostrará el ícono ni el enlace.

### 2️⃣ Actualizar imágenes

Este portafolio web incluye 3 imágenes: un fondo para la sección superior, un fondo para la sección "Sobre mí" y uno para la sección de portafolio (escritorio). Estas pueden ser cualquier imagen de tamaño horizontal a tu elección de tu propia colección, o que tenga una licencia que le permita usar sin atribución.

Un par de sitios posibles para encontrar fotos son [Pixabay](https://pixabay.com/) y [Unsplash](https://unsplash.com/). Fotos, ilustraciones, vectores, ¡tú eliges! Cuando encuentres tus imágenes, guarda cada una en `/src/BlazorApp/wwwroot/images` con un nombre de archivo corto y significativo.

Abre `/src/BlazorApp/wwwroot/sample-data/heroimages.json` y actualiza tus imágenes preferidas, así como el texto alternativo para cada imagen:

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

La sección "Acerca de" ayuda a brindar a las personas un poco más de información sobre tus habilidades y pasiones. Abre `/src/BlazorApp/wwwroot/sample-data/aboutme.json` y actualiza estas 3 propiedades:

* `descripción`: frase corta o dos que te describen a ti mismo, objetivo profesional y/o pasiones
* `skillsList`: un [array](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Array) de tus habilidades para enumerar en la página web, puede ser tantas o tan pocas como desees.
* `detailOrQuote`: bloque más largo para que agregues más detalles sobre ti, o incluso una cita que te guste


### 4️⃣ Agrega elementos en los que has trabajado y detalla el texto

Esta sección para actualizar es el portafolio, donde resalta los elementos en los que ha trabajado. Estos serían artículos, videos, diseños de logotipos, proyectos de GitHub, ¡cualquier cosa que lo destaque!

Abre `/src/BlazorApp/wwwroot/sample-data/projects.json` que es una matriz JSON. Cada elemento que desee resaltar necesita: título, descripción y URL.

El diseño base tiene 4, pero el número depende de usted.

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

El proyecto incluye la configuración necesaria para implementar **gratis** en [Azure Static Web Apps](https://azure.microsoft.com/products/app-service/static/?WT.mc_id=dotnet-82024-juyoo) o [GitHub Pages](https://pages.github.com/). Las instrucciones para ambas se encuentran a continuación:

### Aplicaciones web estáticas de Azure

[Azure Static Web Apps](https://azure.microsoft.com/products/app-service/static/?WT.mc_id=dotnet-82024-juyoo) es la solución de hospedaje de Microsoft para sitios estáticos (o sitios que se representan en el navegador del usuario, no en un servidor) a través de Azure. Este servicio ofrece oportunidades adicionales para expandir tu sitio a través de Azure Functions, autenticación, versiones provisionales y ¡mucho más!

Necesitarás cuentas de Azure y GitHub para implementar la aplicación web. Si aún no tienes una cuenta de Azure, puedes crearla durante el proceso de implementación o desde los siguientes vínculos:

* [Cree una cuenta de Azure para estudiantes (no se requiere tarjeta de crédito)](https://azure.microsoft.com/free/students/?WT.mc_id=dotnet-82024-juyoo)
* [Crear una nueva cuenta de Azure](https://azure.microsoft.com/free/?WT.mc_id=dotnet-82024-juyoo)

Con tu proyecto abierto en Codespaces:

1. Haga clic en el icono de Azure en la barra lateral izquierda. Inicie sesión si aún no lo ha hecho y, si es nuevo en Azure, siga las indicaciones para crear su cuenta.
1. En el menú de Azure, haga clic en el signo "➕" y luego seleccione "Crear aplicación web estática".

    <img src="../../images/deploy-to-azure.png" alt="Crear aplicación web estática" style="width: 300px;" />

1. Si no ha iniciado sesión en GitHub, se le pedirá que inicie sesión. Si tiene algún cambio de archivo pendiente, se le pedirá que confirme esos cambios.
1. Configure la información de su aplicación cuando se le solicite:
     1. **Nombre de la aplicación web estática**: ingrese el nombre de la aplicación web estática. Predeterminado a su nombre de repositorio de GitHub.
     1. **Región**: elige la más cercana a tu región
     1. **Estructura del proyecto**: seleccione "Blazor"
     1. **Ubicación del código de la aplicación**: ingrese `/src/BlazorApp`
     1. **Ubicación de salida**: ingrese `wwwroot`
1. Cuando termine, verá una notificación en la parte inferior de su pantalla y se agregará un nuevo flujo de trabajo de GitHub Action a su proyecto. Si hace clic en "Abrir acción en GitHub", verá la acción que se creó para usted y que se está ejecutando actualmente.

> 🤩 **Extra**: [Configure un dominio personalizado para su aplicación web estática de Azure](https://docs.github.com/pages/configuring-a-custom-domain-for-your-github-pages-site/managing-a-custom-domain-for-your-github-pages-site)

### Páginas de GitHub

[Las GitHub Pages (Páginas de GitHub)](https://pages.github.com/) te permite alojar sitios web directamente desde tu repositorio de GitHub. Este proyecto ya está configurado para que puedas subir tu portafolio en GitHub Pages con muy pocos pasos.

En tu repositorio de GitHub:

1. Vaya a la pestaña "Settings (Configuración)" y navegue hasta el menú "Pages (Páginas)".
1. En la sección _Crear e implementar_, seleccione el origen de **GitHub Actions (Acciones de GitHub)**.

     <img src="../../images/deploy-to-ghpages-01.png" alt="Elegir acciones de GitHub para implementar en páginas de GitHub" style="width: 600px;" />

1. Asegure la visibilidad de sus Páginas de GitHub (Github Pages) este en **Público (Public)**.
1. Ejecute un flujo de trabajo de GitHub Action insertando código o invocándolo manualmente.

     <img src="../../images/deploy-to-ghpages-02.png" alt="Invocar GitHub Actions" style="width: 600px;" />

1. Visite sus GitHub Pages (Páginas de GitHub).

     <img src="../../images/deploy-to-ghpages-03.png" alt="Visite GitHub Pages" style="width: 600px;" />

> 🤩 **Bonus**: [Configure un dominio personalizado para su sitio de páginas de GitHub](https://docs.github.com/pages/configuring-a-custom-domain-for-your-github-pages-site/managing-a-custom-domain-for-your-github-pages-site)

<br />

## 🏆 Desafíos

A continuación se presentan 4 formas adicionales en las que puede continuar personalizando su sitio de cartera y aprender algunos Codespaces, CSS, HTML y JavaScript en el camino.

   1. [Personaliza tus Codespaces](#1-personaliza-tus-codespaces)
   1. [Actualización para desplazamiento suave a una sección](#2-actualización-para-desplazamiento-suave-a-una-sección)
   1. [Animar la foto del escritorio](#3-animar-la-foto-del-escritorio)
   1. [Agregar una nueva sección](#4-agregar-una-nueva-sección)

### 1. Personaliza tus Codespaces

Tu entorno viene con extensiones preinstaladas. Puedes cambiar con qué extensiones comienza tu entorno de Codespaces, aquí te mostramos cómo:

1. Abra el archivo _.devcontainer/devcontainer.json_ y encuentra el siguiente elemento JSON extensions

   ```jsonc
   "extensions": [
     "ms-dotnettools.csharp",
     "ms-vscode.PowerShell",
     "ms-vscode.vscode-node-azure-pack",
     "VisualStudioExptTeam.vscodeintellicode"
   ]
   ```

  2. Agreguemos la extensión `indent-rainbow`. Para hacer esto, ve a la lista de **extensiones** y agrega:

   
   ```jsonc
   "oderwat.indent-rainbow"
   ```

   Lo que hiciste anteriormente fue agregar el identificador único de una extensión de [indent-rainbow](https://marketplace.visualstudio.com/items?itemName=oderwat.indent-rainbow&WT.mc_id=dotnet-82024-juyoo). Esto le permitirá a Codespaces saber que esta extensión debe estar preinstalada al inicio.

Para encontrar el identificador único de una extensión:

* Vaya a la página web de la extensión, así [https://marketplace.visualstudio.com/items?itemName=oderwat.indent-rainbow](https://marketplace.visualstudio.com/items?itemName=oderwat.indent-rainbow&WT.mc_id=dotnet-82024-juyoo)
* Ubique el campo _Unique Identifier_ (_Identificado Único_) en la sección **Más información** en su lado derecho.
   
> 💡 Más información aquí, <https://docs.github.com/codespaces/customizing-your-codespace/personalizing-github-codespaces-for-your-account>

### 2. Actualizar para desplazarse suavemente a una sección

En el encabezado de tu sitio tienes enlaces a cada siguiente sección. Haz clic en uno de estos enlaces y observa cómo se desplaza por la página hasta esa sección. No es realmente un desplazamiento, ¿verdad?

Hagamos una mejor experiencia de usuario para que el usuario tenga una idea de lo que está sucediendo y hacia dónde está navegando en la página.

1. Abre `/src/BlazorApp/wwwroot/css/app.css`, Hagamos una mejor experiencia de usuario para que el usuario tenga una idea de lo que está sucediendo y hacia dónde está navegando en la página. Necesitamos agregar un estilo para `html`. Si observas, verá que ahora los estilos `html` y `body` se están configurando juntos, así que agreguemos el siguiente fragmento de css para configurar el desplazamiento del elemento `html`:

    ```css
    html {
      scroll-behavior: smooth;
    }
    ```
Tu sitio ya debería estar ejecutándose en tu Codespace, y el cambio se volverá a cargar en la página automáticamente. Haz click en un link en el encabezado superior para ver el desplazamiento suave en acción.

### 3. Animar foto de escritorio

Las animaciones son una forma de agregar fácilmente algo de movimiento a los elementos de tu página para aumentar la interactividad del usuario y resaltar los elementos que deseas que se noten. Vamos a animar la foto de escritorio en la sección de portafolio.

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
    
    1. Ahora que hemos definido nuestra secuencia de animación `slideInLeft` podemos decirle a nuestra foto de escritorio que se anime con esa secuencia. Abre `/src/BlazorApp/Components/Portfolio.razor` y localiza la etiqueta `img`. Verás que utiliza inline CSS para establecer su estilo. Dentro de su definición de estilo, agrega lo siguiente:
    
        ```css
        animation: 1s ease-out 0s 1 slideInLeft;
        ```
    La etiqueta de tu imagen debería ser algo como:

     ```html
    <img src="@(hero.Src)" style="height: 90%; width: 100%; object-fit: cover; animation: 1s ease-out 0s 1 slideInLeft;" alt="@(hero.Alt)" />
    ```

Tu sitio web ya debería estar ejecutándose en tu Codespace, y el cambio se volverá a cargar en la página automáticamente. Desplázate hacia arriba y hacia abajo en la página y observa cómo la foto de tu escritorio se desliza sobre la página.

> 🤩 **Bonificación**: Flecha de desplazamiento hacia abajo animada

### 4. Agregar una nueva sección

Comenzamos con algunas secciones básicas para tu portafolio web, pero tienes libertad creativa para hacerlo tuyo y agregar nuevas secciones relevantes para lo que deseas en tu página.

Por ejemplo, agreguemos una sección de educación a tu portafolio.

1. Cree un nuevo componente para la sección dentro de la carpeta `Components (Componentes)`. Agrega un nuevo archivo llamado `Education.razor`.

1. En `Education.razor` agregue la función del componente, la exportación y la información que le gustaría incluir:

    ```razor
    <section class="light" id="portfolio">
        <h2>Education</h2>
    </section>
    ```

1. En `Index.razor` agregue el componente `Education` donde le gustaría que se muestre dentro de la página insertando:


    ```razor
    <Education />
    ```

En tu Codespace, tu aplicación con tu portafolio debe estar ejecutándose y volverá a cargar tu sitio web con los cambios.


<br />

## 📚 Recursos

* [Resumen de documentos de GitHub Codespaces](https://docs.github.com/codespaces/overview)
* [Guías de GitHub Codespaces](https://docs.github.com/codespaces/guides)
* [Usar contenedores de desarrollo localmente con VS Code y Docker](https://github.com/microsoft/vscode-remote-try-dotnet#vs-code-dev-containers)
* [Empezar con Blazor](https://learn.microsoft.com/training/paths/build-web-apps-with-blazor/?WT.mc_id=dotnet-82024-juyoo)
* [Desarrollo web para principiantes](https://github.com/microsoft/Web-Dev-For-Beginners)

> #### Aplicación de navegador Codespaces
>
> Si estás utilizando Edge o Chrome, verás una opción para instalar la aplicación Codespaces cuando inicies tu Codespace. La aplicación Codespaces te permite iniciar tu Codespace dentro de la aplicación para que puedas trabajar fuera del navegador. Busca el icono de la aplicación e instálalo con la ventana emergente para probarla.
>
> <img src="../../images/codespaces-app.png" alt="Aplicación de navegador Codespaces" style="width: 400px;"/>

<br />

## 🔎 ¿Encontraste un problema o tienes una idea para mejorar?

Ayúdanos a mejorar este repositorio de plantillas [informándonos y abriendo un problema](/../../issues/new).