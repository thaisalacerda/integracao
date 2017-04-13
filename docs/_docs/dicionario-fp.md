---
layout: doc
title: Ficha de Procedimentos
id: dicionario-fp
order: 5
---


## FichaProcedimentoMaster

### \#1 uuidFicha
Código UUID para identificar a ficha na base de dados nacional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |36 |44 |

**Regras:** É recomendado concatenar o CNES na frente do UUID, de modo que os 7 dígitos (CNES) + 1 de hífen somados aos 36 (32 caracteres + 4 hífen) do UUID são a limitação de 44 bytes do campo. Formato canônico.

**Referências:** Para ver a referência sobre o UUID, acesse [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier).

### \#2 tpCdsOrigem
Tipo de origem dos dados do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Integer |Sim |1 |1 |

**Regras:** Utilizar valor `3 (sistemas terceiros)`.

### \#3 headerTransport
Profissional que realizou os procedimentos.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|UnicaLotacaoHeader |Sim |- |- |

**Regras:** Somente as CBOs apresentadas na [Tabela 6 - CBOs que podem registrar ficha de procedimento]({% url cbo %}#ficha-de-procedimento) podem ser adicionadas no campo CBO do profissional.

**Referências:** [UnicaLotacaoHeader]({% url headerTransport %}#unicalotacaoheader).

### \#4 atendProcedimentos
Registro dos procedimentos realizados.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<FichaProcedimentoChild\> |Condicional |0 |99 |

**Referências:** [FichaProcedimentoChild](#fichaprocedimentochild).

Observação: É requerido pelo menos um dentre os itens `#4` a `#11`.

### \#5 numTotalAfericaoPa
Quantidade de aferições de pressão realizadas.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |0 |3 |

**Regras:** 

- Não pode ser preenchido com o valor "0" (zero);
- É requerido pelo menos um dentre os itens `#4` a `#11`.

### \#6 numTotalGlicemiaCapilar
Quantidade de aferições de glicemia capilar.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |0 |3 |

**Regras:** 

- Não pode ser preenchido com o valor "0" (zero);
- É requerido pelo menos um dentre os itens `#4` a `#11`.

### \#7 numTotalAfericaoTemperatura
Quantidade de aferições de temperatura realizadas.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |0 |3 |

**Regras:** 

- Não pode ser preenchido com o valor "0" (zero);
- É requerido pelo menos um dentre os itens `#4` a `#11`.

### \#8 numTotalMedicaoAltura
Quantidade de aferições de altura.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |0 |3 |

**Regras:** 

- Não pode ser preenchido com o valor "0" (zero);
- É requerido pelo menos um dentre os itens `#4` a `#11`.

### \#9 numTotalCurativoSimples
Quantidade de curativos simples realizados.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |0 |3 |

**Regras:** 

- Não pode ser preenchido com o valor "0" (zero);
- É requerido pelo menos um dentre os itens `#4` a `#11`.

### \#10 numTotalMedicaoPeso
Quantidade de aferições de peso.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |0 |3 |

**Regras:** 

- Não pode ser preenchido com o valor "0" (zero);
- É requerido pelo menos um dentre os itens `#4` a `#11`..

### \#11 numTotalColetaMaterialParaExameLaboratorial
Quantidade de coletas para exame laboratorial.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |0 |3 |

**Regras:** 

- Não pode ser preenchido com o valor "0" (zero);
- É requerido pelo menos um dentre os itens `#4` a `#11`.

## FichaProcedimentoChild

### \#1 numProntuario
Número do prontuário do cidadão na UBS.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |0 |30 |

### \#2 cnsCidadao
CNS do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |15 |15 |

**Regras**: Validado por algoritmo.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#3 dtNascimento
Data de nascimento do cidadão no formato epoch time.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Regras:** Não pode ser posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento) e anterior a 130 anos a partir da [dataAtendimento]({% url headerTransport %}#5-dataatendimento).

**Referências:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milissegundos.

### \#4 sexo
Código do sexo do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Referências:** [Sexo]({% url dicionario %}#sexo).

### \#5 localAtendimento
Código do local onde o atendimento foi realizado.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Regras:** Apenas valores de `1` a `10`.

**Referências:** [LocalDeAtendimento]({% url dicionario %}#localdeatendimento).

### \#6 turno
Código do turno onde aconteceu o atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Referências:** [Turno]({% url dicionario %}#turno).

### \#7 statusEscutaInicialOrientacao
Indica a realização da escuta inicial.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#8 procedimentos
Lista dos códigos dos procedimentos que são registrados na ficha de procedimentos.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<String\> |Condicional |0 |33 |

**Regras:** 

- Preencher apenas com o código **AB** do procedimento.
- É requerido pelo menos um dentre os itens `#8` e `#9`.
- Se o campo [statusEscutaInicialOrientacao](#7-statusescutainicialorientacao) = `true`, este campo é opcional.

**Referências:** [Procedimentos da Ficha](#procedimentos-da-ficha).

Observação: Inserir o código do procedimento AB em caracteres maiúsculos, sem espaços.

### \#9 outrosSiaProcedimentos
Código dos outros procedimentos do SIGTAP ou SISAB.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<String\> |Condicional | - | - |

**Regras:**

- Só é permitido inserir procedimentos cujo grupo é igual a `01` - Ações de promoção e prevenção em saúde, `02` - Procedimentos com finalidade diagnóstica, `03` - Procedimentos clínicos ou `04` - Procedimentos cirúrgicos.
- Não podem haver procedimentos que estão na tabela [Procedimentos da Ficha](#procedimentos-da-ficha).
- Não podem haver procedimentos com o mesmo código.
- É requerido pelo menos um dentre os itens `#8` e `#9`.
- Se o campo [statusEscutaInicialOrientacao](#7-statusescutainicialorientacao) = `true`, este campo é opcional.

**Referências:** Para ver a referência da tabela do SIGTAP acesse: [Tabela unificada SIGTAP](http://sigtap.datasus.gov.br/tabela-unificada/app/sec/procedimento/publicados/consultar).

Observação: Inserir o código do procedimento sem ponto ou hífen, ex: `0201010010`. 

## Procedimentos da Ficha

|Código SIGTAP *| Descrição AB | Código AB correspondente |
|--- |--- |--- |
|03.09.05.002-2|Acupuntura com inserção de agulhas |ABPG001 |
|01.01.04.005-9|Administração de vitamina A |ABPG002 |
|03.01.10.004-7|Cateterismo vesical de alívio |ABPG003 |
|03.03.08.001-9|Cauterização química de pequenas lesões |ABPG004 |
|04.01.02.017-7|Cirurgia de unha (cantoplastia) |ABPG005 |
|03.01.10.006-3|Cuidado de estomas |ABPG006 |
|Não possui    |Curativo especial |ABPG007 |
|04.01.01.003-1|Drenagem de abscesso |ABPG008 |
|02.11.02.003-6|Eletrocardiograma |ABEX004 |
|02.01.02.003-3|Coleta de citopatológico de colo uterino |ABPG010 |
|03.01.04.009-5|Exame do pé diabético |ABPG011 |
|04.01.01.007-4|Exérese / Biópsia / Punção de tumores superficiais de pele |ABPG012 |
|02.11.06.010-0|Fundoscopia (exame de fundo de olho) |ABPG013 |
|03.03.09.003-0|Infiltração em cavidade sinovial |ABPG014 |
|04.04.01.030-0|Remoção de corpo estranho da cavidade auditiva e nasal |ABPG015 |
|04.01.01.011-2|Remoção de corpo estranho subcutâneo |ABPG016 |
|Não possui    |Retirada de cerume |ABPG017 |
|03.01.10.015-2|Retirada de pontos de cirurgias |ABPG018 |
|04.01.01.006-6|Sutura simples |ABPG019 |
|02.11.06.027-5|Triagem oftalmológica |ABPG020 |
|04.04.01.034-2|Tamponamento de epistaxe |ABPG021 |
|02.14.01.006-6|Teste rápido de gravidez |ABPG022 |
|Não possui    |Teste rápido para dosagem de proteinúria |ABPG040 |
|02.14.01.005-8|Teste rápido para HIV |ABPG024 |
|02.14.01.009-0|Teste rápido para hepatite C |ABPG025 |
|02.14.01.007-4|Teste rápido para sífilis |ABPG026 |
|Não possui    |Administração de medicamentos via Oral |ABPG027 |
|Não possui    |Administração de medicamentos via Intramuscular |ABPG028 |
|Não possui    |Administração de medicamentos via Endovenosa |ABPG029 |
|03.01.10.010-1|Administração de medicamentos via Inalação / Nebulização |ABPG030 |
|Não possui    |Administração de medicamentos via Tópica |ABPG031 |
|Não possui    |Administração de Penicilina para tratamento de sífilis |ABPG032 |
|Não possui    |Administração de medicamentos via Subcutânea (SC) |ABPG041 |

_* Procedimentos pertencentes a competência **07/2016** do SIGTAP._