# Auth com Identity e MySQL
Este projeto � uma aplica��o .NET 8 que utiliza MySQL como banco de dados. Abaixo est�o as instru��es para configurar o ambiente de desenvolvimento, incluindo a configura��o do banco de dados MySQL com Docker e a configura��o inicial do Entity Framework.

## Pr�-requisitos
Docker
.NET 8 SDK

## Configura��o do Banco de Dados
Para configurar o banco de dados MySQL, siga os seguintes passos:

### Baixar a Imagem do MySQL:
```
docker pull mysql
```

### Iniciar o Cont�iner do MySQL:

Execute o comando abaixo para iniciar um cont�iner do MySQL. Este comando configura a senha do root, cria um banco de dados chamado MicroservicesDB e mapeia a porta 3306 para o host.
```
docker run --name microservicesdb -e MYSQL_ROOT_PASSWORD=Hw8vup5e -e MYSQL_DATABASE=MicroservicesDB -p 3306:3306 -d mysql
```

## Configura��o do Entity Framework
Para configurar o Entity Framework para trabalhar com o banco de dados, execute os seguintes comandos:

### Adicionar Migra��o:
```
dotnet ef migrations add Auth
```

### Atualizar o Banco de Dados:
```
dotnet ef database update
```
## Executando o Projeto
Ap�s configurar o banco de dados e o Entity Framework, voc� pode executar o projeto utilizando o comando:
```
dotnet run
```


## Contribui��es
Contribui��es para o projeto s�o bem-vindas. Sinta-se � vontade para criar um fork e enviar um pull request com suas melhorias.

## Licen�a
Este projeto est� sob a licen�a [MIT](https://chat.openai.com/c/LICENSE).
