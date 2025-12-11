## Caso de Uso: Cadastrar Veículo
- Ator: Administrador / Operador
- Pré-condição: Usuário autenticado
- Fluxo principal:
  1. Usuário acessa "Veículos" → Clicar "Novo Veículo"
  2. Preencher Placa, Modelo, Capacidade, Ano
  3. Clicar "Salvar"
  4. Sistema persiste veículo e exibe mensagem de sucesso
- Exceções:
  - Placa já existente → exibir erro
- Critério de aceite:
  - Registro criado e visível na lista
