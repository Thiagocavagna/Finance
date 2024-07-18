# Sistema de Gerenciamento Financeiro

## Visão Geral

O Sistema de Gerenciamento Financeiro é um aplicativo Windows Forms projetado para ajudar os usuários a gerenciar suas transações financeiras. Ele permite que os usuários registrem categorias, adicionem transações e visualizem seus dados financeiros de maneira estruturada.

## Funcionalidades

- **Registro de Usuário:** Registrar um único usuário com nome, email e senha.
- **Gerenciamento de Categorias:** Adicionar, editar e excluir categorias.
- **Gerenciamento de Transações:** Adicionar, visualizar e excluir transações financeiras.
- **Integração com DataGridView:** Exibir transações em um DataGridView com campos editáveis.
- **Atualizações em Tempo Real:** Atualizar automaticamente o DataGridView quando novas transações ou categorias são adicionadas.
- **Localização:** Valores exibidos em Real Brasileiro (R$).

## Instalação

### Pré-requisitos

- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

### Passos

1. **Clonar o Repositório**

   ```bash
   git clone https://github.com/Thiagocavagna/Finance.git
   cd Finance

### Configurar o Banco de Dados

Crie um novo banco de dados no SQL Server.
Atualize a string de conexão no FinanceDbContext com os detalhes do seu banco de dados.
Compilar a Solução

Abra a solução no Visual Studio.
Restaure os pacotes NuGet.
Compile a solução.
Executar o Aplicativo

Inicie o aplicativo a partir do Visual Studio.
Uso
Adicionar uma Categoria
Abra o formulário "Categorias".
Insira o nome e a descrição da categoria.
Clique em "Adicionar Categoria" para salvar.
Adicionar uma Transação
Abra o formulário "Transações".
Insira os detalhes da transação, incluindo descrição, valor, data, tipo (Entrada/Saída) e categoria.
Clique em "Adicionar Transação" para salvar.
Visualizar Transações
As transações são exibidas em um DataGridView no formulário principal.
Você pode editar os valores diretamente no DataGridView.
Use o botão de exclusão para remover transações.
Capturas de Tela
Adicione algumas capturas de tela do seu aplicativo aqui.

Arquitetura
O sistema é projetado usando o padrão MVC (Model-View-Controller):

Modelo: Contém as entidades de dados (User, Category, Transaction) e o contexto do banco de dados (FinanceDbContext).
Visualização: Windows Forms usados para interagir com o usuário.
Controlador: Gerencia a interação entre a visualização e o modelo, manipulando a entrada do usuário e atualizando o modelo.
Estrutura do Projeto
Finance.Model: Contém os modelos de dados e o contexto do banco de dados.
Finance.View: Contém os Windows Forms.
Finance.Controller: Contém os controladores para manipulação da lógica de negócios.
Finance.Data: Contém as classes de repositório para acesso a dados.
Contribuindo
Faça um fork do repositório.
Crie uma nova branch (git checkout -b feature/sua-funcionalidade).
Faça commit das suas alterações (git commit -am 'Adicione uma nova funcionalidade').
Envie para a branch (git push origin feature/sua-funcionalidade).
Crie um novo Pull Request.
Licença
Este projeto é licenciado sob a Licença MIT - veja o arquivo LICENSE para mais detalhes.

Contato
Se você tiver alguma dúvida ou sugestão, sinta-se à vontade para entrar em contato.
