# Auth com Identity e MySQL
Este projeto é uma aplicação .NET 8 que utiliza MySQL como banco de dados. Abaixo estão as instruções para configurar o ambiente de desenvolvimento, incluindo a configuração do banco de dados MySQL com Docker e a configuração inicial do Entity Framework.

## Pré-requisitos
Docker
.NET 8 SDK

## Configuração do Banco de Dados
Para configurar o banco de dados MySQL, siga os seguintes passos:

### Baixar a Imagem do MySQL:
```
docker pull mysql
```

### Iniciar o Contêiner do MySQL:

Execute o comando abaixo para iniciar um contêiner do MySQL. Este comando configura a senha do root, cria um banco de dados chamado MicroservicesDB e mapeia a porta 3306 para o host.
```
docker run --name microservicesdb -e MYSQL_ROOT_PASSWORD=Hw8vup5e -e MYSQL_DATABASE=MicroservicesDB -p 3306:3306 -d mysql
```

## Configuração do Entity Framework
Para configurar o Entity Framework para trabalhar com o banco de dados, execute os seguintes comandos:

### Adicionar Migração:
```
dotnet ef migrations add Auth
```

### Atualizar o Banco de Dados:
```
dotnet ef database update
```
## Executando o Projeto
Após configurar o banco de dados e o Entity Framework, você pode executar o projeto utilizando o comando:
```
dotnet run
```


## Contribuições
Contribuições para o projeto são bem-vindas. Sinta-se à vontade para criar um fork e enviar um pull request com suas melhorias.

## Licença
Este projeto está sob a licença [MIT](https://chat.openai.com/c/LICENSE).
