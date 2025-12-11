# Requisitos Iniciais — Transportei

## 1. Visão Geral
Sistema TMS web para gerenciamento de frota e cargas.

## 2. Usuários principais
- Administrador
- Operador (expedição)
- Motorista
- Cliente (visualização de entregas)

## 3. Funcionalidades (escopo inicial)
- Cadastro de Veículo (placa, modelo, capacidade)
- Cadastro de Motorista (nome, CNH, contato)
- Cadastro de Cliente (nome, endereço, contato)
- Gerar Carga (vincular pedidos, atribuir veículo e motorista)
- Acompanhar Entrega (status: Pendente → Em Rota → Entregue)
- Relatórios básicos (cargas do dia, histórico por motorista)

## 4. Restrições / Exclusões iniciais
- Não incluir faturamento/integração com ERP nesta sprint
- Não incluir rastreamento GPS realtime

## 5. Critérios de aceite (exemplos)
- CRUD de veículo, motorista, cliente funcionando
- Gerar carga cadastra status inicial
- Aplicação inicia localmente com conexão ao DB
