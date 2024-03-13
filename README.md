[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://github.com/codespaces/new?hide_repo_select=true&ref=main&repo=education/codespaces-project-template-dotnet) 

# GitHub Codespaces로 닷넷 (Blazor) 포트폴리오 사이트 만들기 

_몇 분만에 자기만의 포트폴리오 사이트를 생성, 커스텀, 그리고 배포까지 할 수 있습니다_ ✨

이 템플릿 레포지토리에는 개발 환경과 기본 양식 있어 바로 시작할 수 있습니다. Codespaces를 즉시 실행해서 환경 셋팅 과정없이 포트폴리오 사이트 양식을 커스텀할 수 있습니다.


- **누구를 대상으로 하나요?** __모두__ 포트폴리오 사이트를 만들고자 하거나, 웹 개발을 배우고 싶거나, 코드스페이스를 사용해보고 싶은 모든 사람들을 대상입니다.
- **관련 경험이 있어야 하나요?** __필요 없음__. 경험과 가능한 시간에 따라 포트폴리오 사이트 양식 커스텀을 어느 정도할지 결정핧핧 수 있습니다.
- **필요한 준비물 :** _없음_. 설치해야 하는 것이 없습니다! 웹 브라우저(Edge, Chrome 등)만 있으면 됩니다.
- **전제 조건:** _없음_. 이 템플릿에는 자신만의 포트폴리오 사이트를 만들 수 있는 개발 환경과 배포 가능한 웹 앱이 포함되어 있습니다.

## 포트폴리오 사이트 양식에 대해서

    
이 "choose your own adventure" 템플릿 포트폴리오에는 웹 브라우저만 사용하여 쉽게 사용자 정의하고 배포할 수 있는, [Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor?WT.mc_id=dotnet-82024-juyoo) 웹 어플리케이션이 있습니다.

![Blazor WebAssembly profile web application](./images/blazorwasm-portfolio-site.gif "Blazor WebAssembly profile web application")

### 빠르게 시작하기

1.  **Use this Template** 버튼을 클릭합니다.

   [![Use this Template](/images/template-button.svg)](https://github.com/education/codespaces-project-template-dotnet/generate)

1. 레포지토리 소유자를 선택합니다. (예시: 자신의 GitHub 계정)
1. 새 저장소의 고유한 이름을 입력합니다.
1. **Code** 버튼을 클릭합니다.
1. **Create Codespace on main** 버튼을 클릭합니다.
1. [포트폴리오 사이트 커스텀하기](#-customize-your-site-in-4-steps)
1. [사이트 배포하기](#-deploy-your-web-application)

<details>
   <summary><b>🎥 Codespaces에 대해 자세히 알아보기 위해 튜토리얼 영상 시리즈를 시청하실 수 있습니다.</b></summary>

   [![Codespaces Tutorial](https://img.youtube.com/vi/ozuDPmcC1io/0.jpg)](https://aka.ms/CodespacesVideoTutorial "Codespaces Tutorial")
</details>

<br />

## 🗃️ 닷넷 (블레이저) 포트폴리오 양식


이 레포지토리는 Blazor WebAssembly 프레임워크를 사용하여 닷넷 개인 포트폴리오 프런트엔드 웹 애플리케이션을 빌드하기 위한 GitHub 양식입니다. Codespaces를 통해 자신만의 웹사이트를 만드는 데 바로 활용할 수 있는 양식 제공을 목표로 합니다.

이 레포지토리는 다음 내용을 담고 있습니다:

- `/.devcontainer`
  - `.devcontainer/Dockerfile`: 운영 체제 및 기타 세부 정보를 결정하기 위해 Codespaces에서 사용하는 구성 파일
  - `.devcontainer/devcontainer.json`: Configuration file used by Codespaces to configure Visual Studio Code settings, such as the enabling of additional extensions.
  - `.devcontainer/on-create.sh`: 추가 확장 활성화와 같은 Visual Studio Code 설정을 구성하기 위해 Codespaces에서 사용하는 구성 파일
- `/src`: 포트폴리오 사이트를 구축하기 위한 Blazor WebAssembly 프로젝트
- `.editorconfig`: Codespaces에서 일관된 코딩 스타일을 유지하는 데 도움이 되는 [EditorConfig](https://editorconfig.org/)에 대한 설정
- `global.json`: 사전 출시된 .NET 버전을 사용하지 않도록 Blazor WebAssembly 앱 설정을 위한 json 파일
- `swa-cli.config.json`: Codespaces에서 Blazor WebAssembly 앱을 실행하기 위한 [Azure SWA CLI](https://azure.github.io/static-web-apps-cli/)에 대한 설정
- `MyPortfolio.sln`: Blazor WebAssembly 애플리케이션 프로젝트가 포함된 솔루션 파일

<br />

## 🚀 시작하기

이 포트폴리오 사이트 프로젝트는 샘플 데이터로 채워져 있어, 바로 Codespaces를 열어 실행을 확인하고 언제든지 배포할 수 있습니다.

시작하기 위한 개발 환경이 모두 마련되어 있습니다. [닷넷 Codespaces 템플릿](https://github.com/education/codespaces-teaching-template-dotnet)을 기반으로 이미 설정된 사용할 수 있는 항목:

- 포트폴리오 사이트의 각 섹션에 대한 구성 요소가 포함된 간단한 [블레이저 WebAssembly](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor?WT.mc_id=dotnet-82024-juyoo) 애플리케이션
- 배포 시 사이트를 구축하기 위한 [SWA CLI](https://azure.github.io/static-web-apps-cli/)
- 코드 일관성을 위해 [EditorConfig](https://editorconfig.org/)를 사용한 코드 린팅 및 형식 지정.

### 자신만의 포트폴리오 생성하기

1. 이 템플릿에서 저장소를 만듭니다. 이 [저장소 링크 생성](https://github.com/education/codespaces-teaching-template-dotnet/generate)을 사용하시면 됩니다. 리포지토리 소유자를 선택하고, 원하는 경우 이름과 설명을 제공하고, 새 레포지토리를 공개 또는 비공개 중 무엇으로 지정할 것인지 입력합니다.
1. 새로 생성된 저장소의 메인 페이지로 이동합니다.
1. 레포지토리 이름 아래에서 코드 드롭다운 메뉴를 사용하고 Codespaces 탭에서 "Create codespace on main"을 선택합니다.

    <img src="./images/new-codespace-button.png" alt="Create codespace" style="width:270px;"/>

1. GitHub에서 Codespaces를 초기화하는 것을 기다립니다.

    <img src="./images/codespaces-initializing.png" alt="Codespaces initializing" style="width: 600px;"/>

1. 완료되면 하단에 터미널 섹션과 함께 Codespaces 로드가 표시됩니다. 여기서 `dotnet Restore && dotnet build`가 실행되는 것을 볼 수 있습니다. 완료되면 `swa start`를 실행하여 웹 애플리케이션을 실행할 수 있는 터미널 프롬프트로 돌아갑니다.

   웹 애플리케이션이 시작되면 포트 4280에서 성공적으로 시작되었음을 알리는 메시지가 표시되고 브라우저 내에서 해당 사이트를 열 수 있습니다. :

   <img src="./images/app-running-in-codespaces.png" alt="Web application started on port 4280" style="width: 340px;"/>

<br />

## ✨ Customize your site in 4 steps

This project is built to be easily customizable. Each section of the site is a separate component, and your information needs to be set in only one spot. This is not only for ease of updating, but so you can see how values are passed to Blazor components.

For each step, open the project in Codespaces, then you can make and commit your changes while within your Codespaces.

> See [Using source control in your codespaces](https://docs.github.com/codespaces/developing-in-codespaces/using-source-control-in-your-codespace) for more Codespaces source control how-tos

### 1️⃣ Add your details and social media accounts

Open `/src/BlazorApp/wwwroot/sample-data/siteproperties.json`. This is a JSON object that hold the key value pairs needed to customize your name, title, email, and social media accounts.

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

Update to the name and title you'd like displayed at the top of your site.

_Optional values_ are email address and social accounts. These are used in the `Footer` component. If any item is not included in the list or set to an empty string ("") it will not display the icon and link.

### 2️⃣ Update images

This portfolio site includes 3 images: top section background, "About me" background and portfolio section (desk). These can be any **landscape** sized images of your choosing from your own collection, or found that have a license allowing you to use without attribution.

A couple possible sites to find photos are [Pixabay](https://pixabay.com/) and [Unsplash](https://unsplash.com). Photos, illustrations, vectors, your choice! When you find your images, save each one to `/src/BlazorApp/wwwroot/images` with a short, meaningful file name.

Open `/src/BlazorApp/wwwroot/sample-data/heroimages.json` and update images with your preferred ones, as well as the alt text for each image:

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

### 3️⃣ Add your "about me"

The about section helps to give people a bit more information about your skills and passions. Open `/src/BlazorApp/wwwroot/sample-data/aboutme.json` and update those 3 properties:

* `description`: short sentence or two describing yourself, career goal, and/or passions
* `skillsList`: an [array](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Array) of your skills to list on the site, can be as many or little as you wish
* `detailOrQuote`: longer block for you to add more detail about yourself, or even a quote you like

### 4️⃣ Add items you've worked on and detail text

This section to update is portfolio, where you highlight items you've worked on. These would be articles, videos, logo designs, GitHub projects, anything that highlights you!

Open `/src/BlazorApp/wwwroot/sample-data/projects.json` that is a JSON array. Each item you want to highlight needs: title, description, and URL.

The sample design has 4, but the number you include is up to you.

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

## 🏃 Deploy your web application

Project includes the setup needed for you to deploy **free** to both [Azure Static Web Apps](https://azure.microsoft.com/products/app-service/static/?WT.mc_id=dotnet-82024-juyoo) and [GitHub Pages](https://pages.github.com/)</a>.

### Azure Static Web Apps

[Azure Static Web Apps](https://azure.microsoft.com/products/app-service/static/?WT.mc_id=dotnet-82024-juyoo) is Microsoft's hosting solution for static sites (or sites that are rendered in the user's browser, not on a server) through Azure. This service provides additional opportunities to expand your site through Azure Functions, authentication, staging versions and more.

You'll need both Azure and GitHub accounts to deploy your web application. If you don't yet have an Azure account you can create it from within during the deploy process, or from below links:

* [Create a (no Credit Card required) Azure For Students account](https://azure.microsoft.com/free/students/?WT.mc_id=dotnet-82024-juyoo)
* [Create a new Azure account](https://azure.microsoft.com/free/?WT.mc_id=dotnet-82024-juyoo)

With your project open in Codespaces:

1. Click Azure icon in the left sidebar. Log in if you are not already, and if new to Azure, follow the prompts to create your account.
1. From Azure menu click "➕" sign and then choose "Create Static Web App".

   <img src="./images/deploy-to-azure.png" alt="Create Static Web App" style="width: 300px;" />

1. If you are not logged into GitHub you will be prompted to log in. If you have any pending file changes you will then be prompted to commit those changes.
1. Set you application information when prompted:
    1. **Name for Static Web App**: enter the name for the Static Web App. Default to your GitHub repository name.
    1. **Region**: pick the one closest to your region
    1. **Project structure**: select "Blazor"
    1. **Location of application code**: enter `/src/BlazorApp`
    1. **Output location**: enter `wwwroot`
1. When complete you will see notification at the bottom of your screen, and a new GitHub Action workflow will be added to your project. If you click "Open Action in GitHub" you will see the action that was created for you, and it is currently running.

> 🤩 **Bonus**: [Setup a custom domain for your Azure Static Web App](https://learn.microsoft.com/shows/azure-tips-and-tricks-static-web-apps/how-to-set-up-a-custom-domain-name-in-azure-static-web-apps-10-of-16--azure-tips-and-tricks-static-w/?WT.mc_id=dotnet-82024-juyoo)

### GitHub Pages

[GitHub Pages](https://pages.github.com/) allows you to host websites directly from your GitHub repository. This project is already set up for you to get your portfolio deployed to GitHub pages with minimal steps.

On your GitHub repository:

1. Go to the "Settings" tab and navigate to the "Pages" menu.
1. Under the _Build and deployment_ section, select the source to **GitHub Actions**.

    <img src="./images/deploy-to-ghpages-01.png" alt="Choose GitHub Actions for deployment to GitHub Pages" style="width: 600px;" />

1. Ensure your GitHub Pages visibility to **Public**.
1. Run a GitHub Action workflow by pushing code or manually invoke it.

    <img src="./images/deploy-to-ghpages-02.png" alt="Invoke GitHub Actions" style="width: 600px;" />

1. Visit your GitHub Pages.

    <img src="./images/deploy-to-ghpages-03.png" alt="Visit GitHub Pages" style="width: 600px;" />

> 🤩 **Bonus**: [Setup a custom domain for your GitHub pages site](https://docs.github.com/pages/configuring-a-custom-domain-for-your-github-pages-site/managing-a-custom-domain-for-your-github-pages-site)

<br />

## 🏆 Challenges

Below are 4 additional ways you can continue to customize your portfolio site and learn some Codespaces, CSS, HTML and JavaScript along the way.

  1. [Customize your Codespaces](#1-customize-your-codespaces)
  1. [Update to smooth scroll to a section](#2-update-to-smooth-scroll-to-a-section)
  1. [Animate the desk photo](#3-animate-desk-photo)
  1. [Add a new section](#4-add-a-new-section)

### 1. Customize your Codespaces

Your environment comes with preinstalled extensions. You can change which extensions your Codespaces environment starts with, here's how:

1. Open file _.devcontainer/devcontainer.json_ and locate the following JSON element **extensions**

    ```jsonc
    "extensions": [
      "GitHub.copilot",
      "GitHub.copilot-chat",
      "ms-dotnettools.csdevkit",
      "ms-vscode.PowerShell",
      "ms-vscode.vscode-node-azure-pack",
      "VisualStudioExptTeam.vscodeintellicode"
    ]
    ```

1. Let's add the `indent-rainbow` extension. To do this, go to the **extensions** list and add:

    ```jsonc
    "oderwat.indent-rainbow"
    ```
  
   What you did above was to add the unique identifier of an extension of the [indent-rainbow](https://marketplace.visualstudio.com/items?itemName=oderwat.indent-rainbow&WT.mc_id=dotnet-82024-juyoo). This will let Codespaces know that this extension should be pre-installed upon startup.

To find the unique identifier of an extension:

* Navigate to the extension's web page, like so [https://marketplace.visualstudio.com/items?itemName=oderwat.indent-rainbow](https://marketplace.visualstudio.com/items?itemName=oderwat.indent-rainbow&WT.mc_id=dotnet-82024-juyoo)
* Locate the _Unique Identifier_ field under **More info** section on your right side.

> 💡 Learn more here, <https://docs.github.com/codespaces/customizing-your-codespace/personalizing-github-codespaces-for-your-account>

### 2. Update to smooth scroll to a section

In your site header you have links to each section below. Click one of these links and watch it scroll the page to that section. Not really a scroll, right?

Let's make this a better user experience by slowing that down so the user has a sense of what is happening, and where they are navigating to on the page. 

1. Open `/src/BlazorApp/wwwroot/css/app.css`, which is the stylesheet for your portfolio application. We need to add a style for `html`. If you look, you'll see right now `html` and `body` styles are being set together, so let's add the following css snippet to set the scrolling for the `html` element:

    ```css
    html {
      scroll-behavior: smooth;
    }
    ```

Your site should already be running in your Codespaces, and the change will reload onto the page automatically. Click a link in the top header to see the smooth scroll in action.

### 3. Animate desk photo

Animations are a way you can easily add some motion to elements on your page to increase user interactivity and highlight items you want to make sure they notice. Let's animate the desk photo in the portfolio section.

1. Open your site's stylesheet, `/src/BlazorApp/wwwroot/css/app.css` within your Codespaces. Add the animation sequence by adding a `@keyframes` definition to slide in from the left:

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

1. Now that we have defined our `slideInLeft` animation sequence we can tell our desk photo to animate itself with that sequence. Open `/src/BlazorApp/Components/Portfolio.razor` and locate the `img` tag. You will see it utilizes inline CSS to set it's styling. Within it's style definition add the following:

    ```css
    animation: 1s ease-out 0s 1 slideInLeft;
    ```

    Your image tag should look something like:

    ```html
    <img src="@(hero.Src)" style="height: 90%; width: 100%; object-fit: cover; animation: 1s ease-out 0s 1 slideInLeft;" alt="@(hero.Alt)" />
    ```

Your site should already be running in your Codespaces, and the change will reload onto the page automatically. Scroll up and down the page and watch your desk photo slide onto the page.

> 🤩 **Bonus**: Animate scroll down arrow

### 4. Add a new section

We started you off with a few basic sections for your portfolio site, but you have creative freedom to make it your own and add new sections relevant to what you want on your site.

For an example, let's add an education section to your portfolio site. 

1. Create a new component for the section within the `Components` folder. Add a new file called `Education.razor`.

1. In `Education.razor` add the component function, export and information you'd like to include:

    ```razor
    <section class="light" id="portfolio">
        <h2>Education</h2>
    </section>
    ```

1. In `Index.razor` add the `Education` component where you would like it to render within the page by inserting:

    ```razor
    <Education />
    ```

In your Codespaces, your portfolio application should be running and will reload your site with the changes.

<br />

## 📚 Resources

* [GitHub Codespaces docs overview](https://docs.github.com/codespaces/overview)
* [GitHub Codespaces guides](https://docs.github.com/codespaces/guides)
* [Use dev containers locally with VS Code and Docker](https://github.com/microsoft/vscode-remote-try-dotnet#vs-code-dev-containers)
* [Get started with Blazor](https://learn.microsoft.com/training/paths/build-web-apps-with-blazor/?WT.mc_id=dotnet-82024-juyoo)
* [Web Development for Beginners](https://github.com/microsoft/Web-Dev-For-Beginners)

> #### Codespaces Browser App
>
> If you are using Edge or Chrome you will see an option to install the Codespaces app when you launch your Codespaces. The Codespaces app lets you launch your Codespaces within the app so you can work outside of the browser.  Look for the app icon and install pop-up to try it out.
>
> <img src="./images/codespaces-app.png" alt="Codespaces browser app" style="width: 400px;"/>

<br />

## 🔎 Found an issue or have an idea for improvement?

Help us make this template repository better by [letting us know and opening an issue!](/../../issues/new).
