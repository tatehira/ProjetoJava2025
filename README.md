# 🎲 SorteSua! - Sistema de Loteria Online

O **SorteSua!** é um website de loteria fictício desenvolvido com o objetivo de praticar conceitos avançados de desenvolvimento web em Java. Ele simula um sistema onde usuários podem visualizar sorteios, números premiados e realizar apostas (funcionalidade opcional para expansão futura).

Este projeto utiliza boas práticas de arquitetura e design de software, sendo estruturado com o padrão **MVC (Model-View-Controller)** e implementado com tecnologias clássicas e robustas do ecossistema Java EE.

## 🚀 Tecnologias Utilizadas
- Java 11
- JSP (JavaServer Pages)
- CDI (Contexts and Dependency Injection)
- Maven
- Servlets e JavaBeans
- HTML/CSS
- Tomcat 9

## 🧱 Arquitetura e Organização

O projeto segue uma estrutura organizada em três camadas principais:

```
/src
  └── /model      → Classes que representam os dados (JavaBeans)
  └── /controller → Servlets responsáveis pelas regras de negócio e controle
  └── /view       → Arquivos JSP que compõem a interface visual
```

Esse modelo permite uma **separação clara de responsabilidades**, facilitando manutenção, testes e futuras expansões.

## 📸 Funcionalidades (atualmente implementadas)

- [x] Página inicial com descrição da loteria
- [x] Página de consulta dos últimos sorteios
- [x] Página com números premiados
- [x] Simulação de resultado
- [ ] Registro de apostas (em desenvolvimento)
- [ ] Autenticação de usuário (para versão futura)

## 🛠️ Como Executar Localmente

### Pré-requisitos:
- Java JDK 11 ou superior
- Maven instalado
- IDE (Eclipse, IntelliJ ou VS Code)
- Apache Tomcat 9+

### Passos:
1. Clone este repositório:
   ```bash
   git clone https://github.com/seu-usuario/sortesua.git
   ```
2. Importe como projeto Maven em sua IDE.
3. Compile o projeto com:
   ```bash
   mvn clean install
   ```
4. Execute no servidor Tomcat e acesse via navegador:
   ```
   http://localhost:8080/sortesua/
   ```

## 💡 Possíveis melhorias futuras
- Integração com banco de dados real (MySQL/PostgreSQL)
- Autenticação e sessão de usuário
- Dashboard de apostas e histórico
- Interface responsiva com Bootstrap ou TailwindCSS
- CRUD de sorteios para administradores
- Exportação de resultados em PDF

## 🧠 Aprendizados

Este projeto reforça habilidades importantes como:

- Aplicação prática do padrão MVC
- Uso de CDI no contexto de aplicações web Java
- Estruturação de aplicações Java com Maven
- Manipulação de JSP e Servlets
- Organização de código limpo e modular

---

> Este projeto foi baseado nas aulas do professor **While True**, com adaptações feitas para fins de estudo e aprimoramento técnico.
