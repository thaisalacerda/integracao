---
layout: doc
title: Cabeçalho (headerTransport)
id: headerTransport
order: 11
---

## UnicaLotacaoHeader

### \#1	profissionalCNS
CNS do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |15 |15 |

**Regras:**	CNS validado de acordo com o algoritmo.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

Observações: Esta entidade é utilizada para representar o profissional responsável pelas fichas.

### \#2	cboCodigo_2002
Código do CBO do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |- |- |

**Regras:** Somente as CBOs apresentadas na tabela da respectiva ficha podem ser adicionadas neste campo.

**Referências:** {% link cbo %}.

Observações: Esta entidade é utilizada para representar o profissional responsável pelas fichas.

### \#3 cnes
Código do CNES da unidade de saúde que o profissional está lotado.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |7 |7 |

Observações: Esta entidade é utilizada para representar o profissional responsável pelas fichas.

### \#4 ine
Código INE da equipe do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |10 |10 |

Observações: Esta entidade é utilizada para representar o profissional responsável pelas fichas.

### \#5 dataAtendimento
Data em que está sendo realizada a ação.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Referências:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milissegundos.


### \#6 codigoIbgeMunicipio
Código IBGE do município.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |7 |7 |

**Referências:** {% link municipios %}.

## LotacaoHeader

### \#1	profissionalCNS
CNS do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |15 |15 |

**Regras:**	CNS validado de acordo com o algoritmo.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#2	cboCodigo_2002
Código do CBO do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |- |- |

**Referências:** {% link cbo %}.

### \#3 cnes
Código do CNES da unidade de saúde que o profissional está lotado.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |7 |7 |

### \#4 ine
Código INE da equipe do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |10 |10 |


## VariasLotacoesHeader

### \#1 lotacaoFormPrincipal
Profissional responsável pelo atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|LotacaoHeader |Sim |- |- |

Observações: Esta entidade é utilizada para representar o profissional responsável pela ficha.

**Regras:** Somente as {% link cbo %} apresentadas na tabela da respectiva ficha podem ser adicionadas no campo CBO do profissional responsável.

**Referências:** [LotacaoHeader](#lotacaoheader).

### \#2 lotacaoFormAtendimentoCompartilhado
Profissional auxiliar no atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|LotacaoHeader |Não |- |- |

Observações: Esta entidade é utilizada para representar um profissional que auxiliou o profissional responsável pela ficha.

**Referências:** [LotacaoHeader](#lotacaoheader).

### \#3 dataAtendimento
Data em que está sendo realizada a ação.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Referências:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milissegundos.

### \#4 codigoIbgeMunicipio
Código IBGE do município.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |7 |7 |

**Referências:** {% link municipios %}.