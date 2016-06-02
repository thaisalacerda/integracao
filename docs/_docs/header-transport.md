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

**Regras:**	CNS válido de acordo com o algoritmo.

**Referência:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

Observações: Esta entidade é utilizada para representar o profissional responsável pelas fichas.

### \#2	cboCodigo_2002
Código do CBO do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |- |- |

**Referência:** {% link cbo %}.

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

**Referência:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milissegundos.

Observações: Esta entidade é utilizada para representar o profissional responsável pelas fichas.

### \#6 codigoIbgeMunicipio
Código IBGE do município.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |- |- |

**Referência:** {% link municipios %}.

Observações: Esta entidade é utilizada para representar o profissional responsável pelas fichas.

## VariasLotacoesHeader

### \#1 lotacaoForm
Profissional responsável pela ação.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|UnicaLotacaoHeader |Sim |- |- |

Observações: Esta entidade é utilizada para representar o profissional responsável pela ficha e os outros que o auxiliaram na atividade.

**Referências:** [UnicaLotacaoHeader](#unicalotacaoheader).

### \#2 profissionalCNS1
CNS do profissional1.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |15 |15 |

**Regras:** CNS válido de acordo com o algoritmo.

**Referência:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

Observações: Esta entidade é utilizada para representar o profissional responsável pela ficha e os outros que o auxiliaram na atividade.

### \#3 cboCodigo\_2002\_1
Código do CBO do profissional1.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |- |- |

**Regras:** Deve ser preenchido somente se profissionalCNS1 estiver preenchido.

**Referência:** {% link cbo %}.

Observações: Esta entidade é utilizada para representar o profissional responsável pela ficha e os outros que o auxiliaram na atividade.

------------------------------------------

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

-------------------------------------------

## ProfissionalCboRowItem

### \#1 cns
CNS do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |15 |15 |

**Regras:** CNS válido de acordo com o algoritmo.

**Referência:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

Observações: Esta entidade é utilizada para representar os profissionais que participaram da atividade coletiva

### \#2 codigoCbo2002
Código CBO do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |- |- |

**Referência:** {% link cbo %}.

Observações: Esta entidade é utilizada para representar os profissionais que participaram da atividade coletiva.
