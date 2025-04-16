<h1>SorteSua! - README</h1>


    <h1>🎲 SorteSua! - Sistema de Loteria Online</h1>

    <p>O <strong>SorteSua!</strong> é um website de loteria fictício desenvolvido com o objetivo de praticar conceitos avançados de desenvolvimento web em Java. Ele simula um sistema onde usuários podem visualizar sorteios, números premiados e realizar apostas (funcionalidade opcional para expansão futura).</p>

    <p>Este projeto utiliza boas práticas de arquitetura e design de software, sendo estruturado com o padrão <strong>MVC (Model-View-Controller)</strong> e implementado com tecnologias clássicas e robustas do ecossistema Java EE.</p>

    <h2>🚀 Tecnologias Utilizadas</h2>
    <ul>
        <li>Java 11</li>
        <li>JSP (JavaServer Pages)</li>
        <li>CDI (Contexts and Dependency Injection)</li>
        <li>Maven</li>
        <li>Servlets e JavaBeans</li>
        <li>HTML/CSS</li>
        <li>Tomcat 9</li>
    </ul>

    <h2>🧱 Arquitetura e Organização</h2>
    <p>O projeto segue uma estrutura organizada em três camadas principais:</p>

    <pre>
/src
  └── /model      → Classes que representam os dados (JavaBeans)
  └── /controller → Servlets responsáveis pelas regras de negócio e controle
  └── /view       → Arquivos JSP que compõem a interface visual
    </pre>

    <p>Esse modelo permite uma <strong>separação clara de responsabilidades</strong>, facilitando manutenção, testes e futuras expansões.</p>

    <h2>📸 Funcionalidades (atualmente implementadas)</h2>
    <ul>
        <li>[x] Página inicial com descrição da loteria</li>
        <li>[x] Página de consulta dos últimos sorteios</li>
        <li>[x] Página com números premiados</li>
        <li>[x] Simulação de resultado</li>
        <li>[ ] Registro de apostas (em desenvolvimento)</li>
        <li>[ ] Autenticação de usuário (para versão futura)</li>
    </ul>

    <h2>🛠️ Como Executar Localmente</h2>
    <h3>Pré-requisitos:</h3>
    <ul>
        <li>Java JDK 11 ou superior</li>
        <li>Maven instalado</li>
        <li>IDE (Eclipse, IntelliJ ou VS Code)</li>
        <li>Apache Tomcat 9+</li>
    </ul>

    <h3>Passos:</h3>
    <ol>
        <li>Clone este repositório:<br><code>git clone https://github.com/seu-usuario/sortesua.git</code></li>
        <li>Importe como projeto Maven em sua IDE.</li>
        <li>Compile o projeto com:<br><code>mvn clean install</code></li>
        <li>Execute no servidor Tomcat e acesse:<br><code>http://localhost:8080/sortesua/</code></li>
    </ol>

    <h2>💡 Possíveis melhorias futuras</h2>
    <ul>
        <li>Integração com banco de dados real (MySQL/PostgreSQL)</li>
        <li>Autenticação e sessão de usuário</li>
        <li>Dashboard de apostas e histórico</li>
        <li>Interface responsiva com Bootstrap ou TailwindCSS</li>
        <li>CRUD de sorteios para administradores</li>
        <li>Exportação de resultados em PDF</li>
    </ul>

    <h2>🧠 Aprendizados</h2>
    <p>Este projeto reforça habilidades importantes como:</p>
    <ul>
        <li>Aplicação prática do padrão MVC</li>
        <li>Uso de CDI no contexto de aplicações web Java</li>
        <li>Estruturação de aplicações Java com Maven</li>
        <li>Manipulação de JSP e Servlets</li>
        <li>Organização de código limpo e modular</li>
    </ul>

    <div class="creditos">
        <p>Este projeto foi baseado nas aulas do professor <strong>While True</strong>, com adaptações feitas para fins de estudo e aprimoramento técnico.</p>
    </div>

