<div id="top"></div>
<!-- PROJECT LOGO -->
<br />
  <h3 align="center">Minimal API</h3>

  <p align="center">
    Repositório exemplo da utilização do recuro de Minimal API disponível a partir do SDK 6.0 .NET Core!
  </p>
</div>



<!-- TABLE OF CONTENTS -->
<details>
  <summary>Conteúdo</summary>
  <ol>
    </li>
    <li>
      <a href="#getting-started">Início rápido</a>
      <ul>
        <li><a href="#prerequisites">Pré-Requisitos</a></li>
      </ul>
  </ol>
</details>



<!-- ABOUT THE PROJECT -->
## Sobre o projeto

Esse projeto visa a implementação simples do recurso 
de Minimal APIs, que representam pequenas APIs ou projetos 
que tenham rotas mais simples. Com isso, diminui-se a 
quantidade de arquivos e é possível focar apenas no que 
é necessário para o desenvolvimento da aplicação. 

A simplicidade também está presente em várias tecnologias
como GO, Phthon, Node.JS, assim com o recurso é possível 
ter uma rota escutando e retornando informações de uma forma mais
simples e clara. 



### Criado com

* [.NET](https://dotnet.microsoft.com/download/dotnet/6.0)
* [Flunt](https://github.com/andrebaltieri/Flunt)
* [Entity Framework Core](https://docs.microsoft.com/pt-br/ef/core/)


### Pré-Requisitos

Necessário possuir o SDK do .NET Core 6.0:
* Disponível em: https://dotnet.microsoft.com/download/dotnet/6.0

<!-- USAGE EXAMPLES -->
## Utilização

Será necessário gerar as Migrations para representação do banco de dados SQLite, para isso digite o comando:

```dotnet ef migrations add InitialCreate```

Com isso o Entity Framework Core, criará um diretório chamado Migrations em seu projeto e gerará alguns arquivos. Posteriormente, será necessário que o EF crie seu banco de dados e seu esquema a partir da migração. Isso pode ser feito por meio do seguinte comando: 

```dotnet ef database update```

Com isso, o aplicativo está pronto para ser executado no novo banco de dados.


<!-- LICENSE -->
## License

Distributed under the MIT License. See `LICENSE.txt` for more information.


<!-- MARKDOWN LINKS & IMAGES -->
<!-- https://www.markdownguide.org/basic-syntax/#reference-style-links -->
[contributors-shield]: https://img.shields.io/github/contributors/othneildrew/Best-README-Template.svg?style=for-the-badge
[contributors-url]: https://github.com/othneildrew/Best-README-Template/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/othneildrew/Best-README-Template.svg?style=for-the-badge
[forks-url]: https://github.com/othneildrew/Best-README-Template/network/members
[stars-shield]: https://img.shields.io/github/stars/othneildrew/Best-README-Template.svg?style=for-the-badge
[stars-url]: https://github.com/othneildrew/Best-README-Template/stargazers
[issues-shield]: https://img.shields.io/github/issues/othneildrew/Best-README-Template.svg?style=for-the-badge
[issues-url]: https://github.com/othneildrew/Best-README-Template/issues
[license-shield]: https://img.shields.io/github/license/othneildrew/Best-README-Template.svg?style=for-the-badge
[license-url]: https://github.com/othneildrew/Best-README-Template/blob/master/LICENSE.txt
[linkedin-shield]: https://img.shields.io/badge/-LinkedIn-black.svg?style=for-the-badge&logo=linkedin&colorB=555
[linkedin-url]: https://linkedin.com/in/othneildrew
[product-screenshot]: images/screenshot.png
