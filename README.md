# 🎬 App08 - Cinema Management System

> Uma aplicação desktop educacional para gerenciamento de cinemas, desenvolvida em C# com Windows Forms e SQL Server. Projeto escolar com sistema inovador de mudança entre máquinas de laboratório.

**Status:** Concluída

---

## 📋 Descrição da Aplicação

Esta é uma aplicação **Windows Forms em C#** criada em ambiente educacional (escola) que funciona como um sistema de gerenciamento completo de cinemas. Foi desenvolvida num ambiente controlado com máquinas compartilhadas de laboratório, por isso conta com um sistema único de mudança dinâmica entre máquinas.

### Funcionalidades Principais

A aplicação possui 4 módulos principais acessíveis através do menu:

#### 1. 👤 **Gestão de Usuários** (`FmUsuario.cs`)
- Criar novos usuários
- Atualizar dados de usuários existentes
- Deletar usuários com confirmação
- Visualizar lista completa em Grid
- Validações de entrada de dados

#### 2. 🎭 **Gestão de Gêneros** (`fmGenero.cs`)
- Cadastrar categorias de filmes (Ação, Drama, Comédia, etc.)
- Editar e remover gêneros

#### 3. 🎪 **Gestão de Cinemas** (`fmCinema.cs`)
- Cadastrar informações de cinemas
- Dados: nome do cinema, endereço e número de salas
- Gerenciar múltiplas unidades

#### 4. 🛋️ **Gestão de Salas** (`fmRoom.cs`)
- Criar e configurar salas de cinema
- Dados: número da sala, quantidade de poltronas, tipo de sala
- Associação com cinemas

---

## 🔧 Sistema de Mudança de Máquinas

### O Diferencial do Projeto

Como o projeto foi desenvolvido em **ambiente escolar com máquinas compartilhadas**, implementamos um sistema inteligente de mudança de laboratório. Cada aluno mudava frequentemente de computador, então criamos um mecanismo dinâmico para conectar automaticamente ao servidor SQL da máquina correta.

### Como Funciona

```
┌─────────────────────────────────────────────────────────┐
│  Seleção de Laboratório                                 │
│  ┌─────────────────────────────────────────────────┐   │
│  │  ComboBox Lab:  [202 ▼]  ou  [208 ▼]          │   │
│  └─────────────────────────────────────────────────┘   │
│                         ↓                               │
│  Seleção de PC Dinâmica                                 │
│  ┌─────────────────────────────────────────────────┐   │
│  │  Lab 202 → 41 PCs   (PC01 até PC41)            │   │
│  │  Lab 208 → 25 PCs   (PC01 até PC25)            │   │
│  └─────────────────────────────────────────────────┘   │
│                         ↓                               │
│  Construção Automática da String de Conexão            │
│  ┌─────────────────────────────────────────────────┐   │
│  │  Servidor: C{Lab}-PC{Número}\SQLEXPRESS        │   │
│  │  Exemplo: C202-PC05\SQLEXPRESS                 │   │
│  └─────────────────────────────────────────────────┘   │
│                         ↓                               │
│  Conexão ao SQL Server Local da Máquina                │
│  ┌─────────────────────────────────────────────────┐   │
│  │  Conecta à instância SQL daquele PC específico │   │
│  └─────────────────────────────────────────────────┘   │
└─────────────────────────────────────────────────────────┘
```

### Implementação Técnica

No construtor de `FmUsuario.cs`:
```csharp
cbLab.Items.Add("202");  // Laboratório 202
cbLab.Items.Add("208");  // Laboratório 208
cbLab.SelectedIndexChanged += cbLab_SelectedIndexChanged;
```

Quando o laboratório é selecionado:
```csharp
private void AtualizarListaPCs()
{
    cbPC.Items.Clear();
    int totalPCs = cbLab.SelectedItem.ToString() == "202" ? 41 : 25;
    
    for (int i = 1; i <= totalPCs; i++)
    {
        cbPC.Items.Add(i.ToString().PadLeft(2, '0')); // PC01, PC02...
    }
}
```

Conexão dinâmica:
```csharp
string sala = cbLab.SelectedItem.ToString();
string pcNumero = cbPC.SelectedItem.ToString().PadLeft(2, '0');
string servidor = $"C{sala}-PC{pcNumero}\\SQLEXPRESS";

string strConn = $@"Data Source={servidor};
                    Initial Catalog=SolucaoCinema;
                    Integrated Security=True;
                    Connect Timeout=30;
                    Encrypt=False;
                    TrustServerCertificate=False;
                    ApplicationIntent=ReadWrite;
                    MultiSubnetFailover=False";
```

### Vantagens do Sistema

✅ **Zero Reconfiguração** - Muda de máquina automaticamente  
✅ **Suporte a Múltiplos Labs** - Fácil adicionar mais laboratórios  
✅ **Escalável** - Cada lab pode ter quantidade diferente de PCs  
✅ **Autenticação Integrada** - Usa Windows Authentication  
✅ **Tratamento de Erros** - Valida conexão antes de usar  

---

## 💾 Banco de Dados

### Estrutura

O banco de dados `SolucaoCinema` contém 4 tabelas principais:

**Usuario** - Gerenciamento de usuários
```sql
CREATE TABLE Usuario (
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    Usuario VARCHAR(10) NOT NULL,
    Senha VARCHAR(10)
);
```

**Genero** - Categorias de filmes
```sql
CREATE TABLE Genero (
    idGenero INT IDENTITY(1,1) PRIMARY KEY,
    dsGenero VARCHAR(20) NOT NULL
);
```

**Cinema** - Informações dos cinemas
```sql
CREATE TABLE Cinema (
    idCinema INT IDENTITY(1,1) PRIMARY KEY,
    nmCinema VARCHAR(30) NOT NULL,
    dsEndereco VARCHAR(150) NOT NULL,
    nrSalas INT NOT NULL
);
```

**Sala** - Salas de cinema
```sql
CREATE TABLE Sala (
    idSala INT IDENTITY(1,1) PRIMARY KEY,
    nrSala INT NOT NULL,
    nrPoltronas INT NOT NULL,
    tpSala CHAR(10) NOT NULL,
    idCinema INT NOT NULL
);
```

### Script de Inicialização

Veja o arquivo `Banco de dados.sql` para criar e popular o banco com dados iniciais.

---

## 🛠️ Stack Tecnológico

| Tecnologia | Descrição |
|---|---|
| **Linguagem** | C# (.NET Framework) |
| **Interface** | Windows Forms |
| **Banco de Dados** | SQL Server / SQL Server Express |
| **Acesso a Dados** | ADO.NET (SqlClient) |
| **Padrão** | CRUD com tratamento de exceções |

---

## 📊 Composição do Projeto

- **97.4%** C# - Lógica da aplicação
- **2.6%** T-SQL - Scripts do banco de dados

---

## 📁 Estrutura do Projeto

```
app08-cinema/
├── app8/
│   ├── FmUsuario.cs              # Gerenciamento de usuários
│   ├── FmUsuario.Designer.cs
│   ├── fmGenero.cs               # Gerenciamento de gêneros
│   ├── fmGenero.Designer.cs
│   ├── fmCinema.cs               # Gerenciamento de cinemas
│   ├── fmCinema.Designer.cs
│   ├── fmRoom.cs                 # Gerenciamento de salas
│   ├── fmRoom.Designer.cs
│   ├── frmPrincipal.cs           # Formulário principal
│   ├── frmPrincipal.Designer.cs
│   ├── Program.cs                # Ponto de entrada
│   ├── App.config                # Configuração da app
│   └── app8.csproj
├── app8.sln                      # Solução Visual Studio
├── Banco de dados.sql            # Script SQL
└── README.md                      # Este arquivo
```

---

## 🚀 Como Usar

### Pré-requisitos

- **Visual Studio 2019+** ou similar
- **SQL Server 2019+** ou SQL Server Express
- **.NET Framework 4.7+**

### Instalação

1. **Clone o repositório**
   ```bash
   git clone https://github.com/ThomyThom/app08-cinema.git
   cd app08-cinema
   ```

2. **Execute o script SQL**
   - Abra `Banco de dados.sql` no SQL Server Management Studio
   - Execute para criar o banco e as tabelas

3. **Abra a solução**
   - Abra `app8.sln` no Visual Studio

4. **Compile e execute**
   - Build da solução
   - F5 para executar

### Primeiro Acesso

- **Usuário padrão:** `Thomaz`
- **Senha padrão:** `123`

---

## 📝 Notas Educacionais

Este projeto foi desenvolvido como um **trabalho escolar demonstrativo** num ambiente educacional bem configurado e controlado. As características principais são:

- ✅ Demonstra CRUD completo (Create, Read, Update, Delete)
- ✅ Integração com banco de dados SQL Server
- ✅ Tratamento robusto de exceções
- ✅ Uso de Windows Forms para interface gráfica
- ✅ Validação de dados de entrada
- ✅ Sistema inovador de mudança entre máquinas de laboratório
- ✅ Boas práticas de programação

**Ideal para:** Aprender conceitos de desenvolvimento desktop, banco de dados e gerenciamento de recursos em ambientes escolares.

---

## 🎓 Conceitos Demonstrados

- Windows Forms e Event-driven programming
- ADO.NET e SQL Client
- Conexões dinâmicas a bancos de dados
- Tratamento de exceções
- Validação de entrada
- CRUD Operations
- DataGridView binding
- ComboBox dinâmicos
- Integração com SQL Server

---

## 📄 Licença

Projeto educacional - Livre para uso e modificação.

---

## 👨‍💻 Autor

**ThomyThom** - Desenvolvido como projeto escolar

---

**Última atualização:** Novembro/2025  
**Status:** 🔄 Em desenvolvimento
