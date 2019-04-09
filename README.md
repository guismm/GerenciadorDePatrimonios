# Gerenciador De Patrimonio

## Configuração inicial - Passo a passo

1 - Criar um banco de dados para o projeto 
`CREATE DATABASE GerenciadorDePatrimonio`

2 - Trocar a ConnectionString do arquivo \GereciadorDePatrimonio\GereciadorDePatrimonio.Infrastructure.Data\Contexts\GereciadorDePatrimonioContext.cs na linha 16 pela ConnectionString do banco que você criou no passo 1.

3 - Para gerar as tabelas basta abrir o powershell ou cmd na pasta do projeto GereciadorDePatrimonio.Infrastructure.Data e rodar o seguinte comando:
`dotnet ef database update`

