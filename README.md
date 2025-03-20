# TwTodos

TwTodos é uma aplicação de gerenciamento de tarefas simples construída com .NET e Entity Framework Core. A aplicação permite criar, editar, visualizar e excluir tarefas, com validações personalizadas e uso do `DateOnly` para manipulação de datas.

## 🚀 Tecnologias Utilizadas

- **C#** (ASP.NET Core MVC)
- **Entity Framework Core** (ORM para persistência de dados)
- **Bootstrap** (para estilização básica da interface)
- **SQLite3** (banco de dados relacional)

## 📚 Funcionalidades

- Criar novas tarefas com título e data de entrega.
- Editar tarefas existentes.
- Excluir tarefas.
- Marcar tarefas como concluídas.
- Validações personalizadas para:
  - Garantir que a data de entrega seja hoje ou no futuro.
  - Garantir que o título tenha pelo menos 3 caracteres.


## 🔧 Instalação e Uso

1. Clone o repositório:
   
```bash
   git clone https://github.com/seu-usuario/TwTodos.git
   ```

2. Navegue até o diretório do projeto:

```bash
cd TwTodos
```

3. Restaure as dependências:

```bash
dotnet restore
```

4. Aplique as migrações:

```bash
dotnet ef database update
```

5. Execute a aplicação:

```bash
dotnet run
```

6. Acesse o projeto no navegador local:

```bash
http://localhost:<porta>
```
* Nota: a porta pode variar, pois segue a porta local atribuída ao servidor web padrão do ASP.NET (Kestrel) ou do IIS Expresso (VS Code)