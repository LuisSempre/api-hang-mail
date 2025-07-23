
# 📬 ApiHangMail

API simples em .NET 6 com integração ao [Hangfire](https://www.hangfire.io/) para execução de tarefas em segundo plano (ex: envio de e-mail de boas-vindas após cadastro).

---

## ✅ Funcionalidades

- Cadastro de usuários via API
- Envio de "e-mail" de boas-vindas (simulado no console)
- Execução assíncrona com Hangfire
- Dashboard web do Hangfire para monitoramento dos jobs

---

## 🚀 Como executar o projeto

### 1. Clone o repositório

```bash
git clone https://github.com/seu-usuario/ApiHangMail.git
cd ApiHangMail
```

### 2. Restaure os pacotes e compile

```bash
dotnet restore
dotnet build
```

### 3. Execute a API

```bash
dotnet run
```

A aplicação estará disponível em:  
📌 `http://localhost:5000`

A dashboard do Hangfire:  
📌 `http://localhost:5000/hangfire`

---

## 🧪 Teste o cadastro de usuário

### Requisição:

**POST** `http://localhost:5000/api/users/cadastrar`

#### Corpo da requisição JSON:

```json
{
  "nome": "João",
  "email": "joao@email.com"
}
```

Você verá no console algo como:

```bash
Usuário cadastrado: João <joao@email.com>
[EMAIL] Enviando boas-vindas para João <joao@email.com> às 22/07/2025 19:00
```

E na dashboard do Hangfire, um job com status de sucesso.

---

## 🛠 Tecnologias

- .NET 6
- Hangfire
- Hangfire.MemoryStorage (para testes locais)
- C#

---

## 📝 Licença

Este projeto está sob a licença MIT.  
Criado por [Seu Nome](https://github.com/seu-usuario)
