## Projeto de Anonimização de Dados
Este projeto está sendo desenvolvido com o objetivo de anonimizar dados pessoais, especificamente nomes e CPFs, utilizando funções hash e a API do OpenAI para gerar nomes falsos. O projeto segue a arquitetura CQRS (Command Query Responsibility Segregation) e está organizado em pastas para Domínio, API e Infraestrutura.

# Funcionalidades

# *Anonimização de Dados*

 Receber dados originais: O endpoint recebe nome e CPF originais.

 Gerar dados anonimizados: Os dados são passados por uma função hash para anonimização e, em seguida, a API do OpenAI é utilizada para gerar nomes falsos.

Retornar dados anonimizados: O endpoint retorna o nome e CPF anonimizados.

Retornar dados originais: Um endpoint adicional permite a recuperação dos dados originais a partir dos dados anonimizados.

Segurança
Hashing: Utiliza a função hash SHA256 para anonimizar dados, garantindo que os dados originais não possam ser facilmente revertidos.

API do OpenAI: Gera nomes falsos realistas, mantendo o gênero do nome original.

# Arquitetura
# Domínio
Entidades: Definição das entidades principais do sistema, como User.
Serviços: Lógica de negócio relacionada à anonimização de dados.
Interfaces: Definição de contratos para serviços, como IOpenAiService.
Infraestrutura
Data: Configuração do contexto de banco de dados e migrações.
Serviços: Implementação dos serviços definidos no domínio, incluindo a integração com a API do OpenAI.
API
Controllers: Definição dos endpoints da API, como AnonymizationController.
Programação e Configuração: Configuração do aplicativo, incluindo injeção de dependência, middleware e Swagger para documentação da API.

# Arquivos Importantes
Program.cs: Configura o host da aplicação.
Startup.cs: Configura os serviços e o middleware da aplicação.
AppDbContext.cs: Configura o contexto do banco de dados.
AnonymizationService.cs: Contém a lógica de anonimização dos dados.
OpenAiService.cs: Integração com a API do OpenAI para gerar nomes falsos.
AnonymizationController.cs: Define os endpoints da API para anonimização de dados.
