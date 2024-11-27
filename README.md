# gerenciar tarefas, desenvolvido com ASP.NET Core Razor Pages. Ele permite criar, listar, editar e excluir tarefas, além de categorizar por prioridade e status.

## estrutura basíca resumida de organização do diretório do projeto:
```
TaskManager/
├── Pages/
│   ├── Tasks/
│   │   ├── Index.cshtml          # Página inicial (lista de tarefas)
│   │   ├── Index.cshtml.cs       # Lógica da página inicial
│   │   ├── Create.cshtml         # Página de criação de tarefa
│   │   ├── Create.cshtml.cs      # Lógica de criação de tarefa
│   │   ├── Edit.cshtml           # Página de edição de tarefa
│   │   ├── Edit.cshtml.cs        # Lógica de edição de tarefa
│   │   ├── Delete.cshtml         # Página de confirmação de exclusão
│   │   ├── Delete.cshtml.cs      # Lógica de exclusão de tarefa
│   ├── _ViewStart.cshtml         # Configura layout padrão
│   └── _Layout.cshtml            # Layout principal
├── wwwroot/                      # Arquivos estáticos (CSS, JS, etc.)
├── Models/
│   ├── TaskItem.cs               # Modelo de dados de uma tarefa
├── Data/
│   ├── TaskContext.cs            # DbContext para acesso ao banco de dados
├── Program.cs                    # Configurações do app e roteamento
├── appsettings.json              # Configurações gerais (incluindo conexão com o banco)
└── README.md                     # Documentação do projeto
```
## Requisitos do Sistema
Certifique-se de ter os seguintes requisitos instalados em sua máquina antes de iniciar o projeto:

.NET SDK (versão 6.0 ou superior)
SQLite ou outro banco de dados compatível, dependendo de sua escolha.
Editor de texto, como o Visual Studio Code.
Linux ou outro sistema operacional compatível com .NET Core.

## Configuração do Projeto
1. Clonar o repositório
Abra o terminal na sua maquina local 
Faça o clone do repositório para sua máquina local digitando o seguinte comando:    
``git clone https://github.com/seu-usuario/taskmanager.git``   
1.1 posteriormente digite no seu terminal o seguinte comando:   
``cd taskmaneger``

1.2. após isso digite no seu terminal o seguinte comando:
   ``dotnet restore``
   
3. Rodar o projeto
tendo feito tudo certo até aqui rode o projeto com seguinte comando:   
``dotnet run``
