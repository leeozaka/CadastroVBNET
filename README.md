# Cadastro de Clientes
Aplicação de cadastro de clientes e corretores desenvolvida em Visual Basic .NET.

# Instalação do App
## Pré-requisitos
- .NET Framework: Certifique-se de que o .NET 8 Framework está instalado na máquina.
- SQL Server: Um servidor SQL Server deve estar disponível para a aplicação.

## Clonar o Repositório
Clone o repositório da aplicação para a sua máquina local:
```bash
git clone https://github.com/leeozaka/CadastroVB.git"
```

## Configuração do Banco de Dados
1. Abra o SQL Server Management Studio.
1. Conecte-se ao servidor SQL Server.
1. Crie um banco db-cadastro.
1. Execute os scripts em `CadastroVB/Scripts/`
1. Altere a string de conexão no arquivo `CadastroVB/App.config`.
1. A string de conexão padrão é `Data Source=.\SQLEXPRESS;Initial Catalog=db-cadastro;Integrated Security=True`.

## Restaura as dependências
Abra o projeto no Visual Studio e restaure os pacotes NuGet:
```bash
dotnet restore
```

## Compilação
Compile o projeto no Visual Studio:
```bash
dotnet build
```

## Execução
Execute o projeto no Visual Studio:
```bash
dotnet run
```