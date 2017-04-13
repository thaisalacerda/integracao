---
layout: doc
title: Ficha complementar - Síndrome neurológica por Zika / Microcefalia
id: dicionario-fczm
order: 10
---


## FichaComplementarZikaMicrocefalia

### \#1 headerTransport
Dados referentes ao profissional e a data do cadastro.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|UnicaLotacaoHeader |Sim |- |- |

**Regras:** Somente as CBOs apresentadas na [Tabela 11 - CBOs que podem registrar ficha complementar - Síndrome neurológica por Zika / Microcefalia]({% url cbo %}#ficha-complementar-s-ndrome-neurol-gica-por-zika-microcefalia) podem ser adicionadas no campo CBO do profissional.

**Referências:** [UnicaLotacaoHeader]({% url headerTransport %}#unicalotacaoheader).

### \#2	uuidFicha
Código UUID para identificar a ficha na base de dados nacional.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	36|	44|

**Regras:** É recomendado concatenar o CNES na frente do UUID, de modo que os 7 dígitos (CNES) + 1 de hífen somados aos 36 (32 caracteres + 4 hífen) do UUID são a limitação de 44 bytes do campo. Formato canônico.

**Referências:** [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier).

### \#3	tpCdsOrigem
Tipo de origem dos dados do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Obrigatório|	1|	1|

Observações: Utilizar valor 3 (sistemas terceiros).

### \#4	turno
Código do turno onde aconteceu o atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Referências:** [Turno]({% url dicionario %}#turno).

### \#5 cnsCidadao
CNS do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |15 |15 |

**Regras:** Validado por algoritmo.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#6 cnsResponsavelFamiliar
CNS do responsável do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |15 |15 |

**Regras:** Validado por algoritmo.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#7 dataRealizacaoTesteOlhinho
Data de realização do "Teste de olhinho (Reflexo vermelho)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** 

- Não pode ser anterior em 20 anos ou posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento).
- Se este campo for preenchido, o campo [coResultadoTesteOlhinho](#8-coresultadotesteolhinho) é obrigatório.

### \#8 coResultadoTesteOlhinho
Resultado do "Teste de olhinho (Reflexo vermelho)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:**

- É obrigatório o preenchimento de pelo menos um destes campos: `8`, `10`, `12`, `14`, `16` e `18`.
- Se este campo for preenchido, o campo [dataRealizacaoTesteOlhinho](#7-datarealizacaotesteolhinho) é obrigatório.

**Referências:** [testeOlhinho]({% url dicionario %}#testeolhinho).

### \#9 dataRealizacaoExameFundoOlho
Data de realização do "Exame de fundo de olho (02.11.06.010-0 - Fundoscopia)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** 

- Não pode ser anterior em 20 anos ou posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento).
- Se este campo for preenchido, o campo [coResultadoExameFundoOlho](#10-coresultadoexamefundoolho) é obrigatório.


### \#10 coResultadoExameFundoOlho
Resultado do "Exame de fundo de olho (02.11.06.010-0 - Fundoscopia)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:**

- É obrigatório o preenchimento de pelo menos um destes campos: `8`, `10`, `12`, `14`, `16` e `18`.
- Se este campo for preenchido, o campo [dataRealizacaoExameFundoOlho](#9-datarealizacaoexamefundoolho) é obrigatório.

**Referências:** [exameFundoOlho]({% url dicionario %}#examefundoolho).

### \#11 dataRealizacaoTesteOrelhinha
Data de realização do "Teste da orelhinha - PEATE (02.11.07.027-0 - Potencial evocado auditivo para triagem auditiva)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** 

- Não pode ser anterior em 20 anos ou posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento).
- Se este campo for preenchido, o campo [coResultadoTesteOrelhinha](#12-coresultadotesteorelhinha) é obrigatório.

### \#12 coResultadoTesteOrelhinha
Resultado do "Teste da orelhinha - PEATE (02.11.07.027-0 - Potencial evocado auditivo para triagem auditiva)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:**

- É obrigatório o preenchimento de pelo menos um destes campos: `8`, `10`, `12`, `14`, `16` e `18`.
- Se este campo for preenchido, o campo [dataRealizacaoTesteOrelhinha](#11-datarealizacaotesteorelhinha) é obrigatório.

**Referências:** [testeOrelhinha]({% url dicionario %}#testeorelhinha).

### \#13 dataRealizacaoUSTransfontanela
Data de realização do exame de imagem "US transfontanela (02.05.02.017-8 - Ultrassonografia transfontanela)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** 

- Não pode ser anterior em 20 anos ou posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento).
- Se este campo for preenchido, o campo [coResultadoUsTransfontanela](#14-coresultadoustransfontanela) é obrigatório.

### \#14 coResultadoUsTransfontanela
Resultado do exame de imagem "US transfontanela (02.05.02.017-8 - Ultrassonografia transfontanela)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:**

- É obrigatório o preenchimento de pelo menos um destes campos: `8`, `10`, `12`, `14`, `16` e `18`.
- Se este campo for preenchido, o campo [dataRealizacaoUSTransfontanela](#13-datarealizacaoustransfontanela) é obrigatório.

**Referências:** [usTransfontanela]({% url dicionario %}#ustransfontanela).

### \#15 dataRealizacaoTomografiaComputadorizada
Data de realização do exame de imagem "Tomografia computadorizada (02.06.01.007-9 - Tomografia computadorizada do crânio)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** 

- Não pode ser anterior em 20 anos ou posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento).
- Se este campo for preenchido, o campo [coResultadoTomografiaComputadorizada](#16-coresultadotomografiacomputadorizada) é obrigatório.

### \#16 coResultadoTomografiaComputadorizada
Resultado do exame de imagem "Tomografia computadorizada (02.06.01.007-9 - Tomografia computadorizada do crânio)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:**

- É obrigatório o preenchimento de pelo menos um destes campos: `8`, `10`, `12`, `14`, `16` e `18`.
- Se este campo for preenchido, o campo [dataRealizacaoTomografiaComputadorizada](#15-datarealizacaotomografiacomputadorizada) é obrigatório.

**Referências:** [tomografiaComputadorizada]({% url dicionario %}#tomografiacomputadorizada).

### \#17 dataRealizacaoRessonanciaMagnetica
Data de realização do exame de imagem "Ressonância magnética (02.07.01.006-4 - Ressonância magnética de crânio)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** 

- Não pode ser anterior em 20 anos ou posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento).
- Se este campo for preenchido, o campo [coResultadoRessonanciaMagnetica](#18-coresultadoressonanciamagnetica) é obrigatório.

### \#18 coResultadoRessonanciaMagnetica
Resultado do exame de imagem "Ressonância magnética (02.07.01.006-4 - Ressonância magnética de crânio)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:**

- É obrigatório o preenchimento de pelo menos um destes campos: `8`, `10`, `12`, `14`, `16` e `18`.
- Se este campo for preenchido, o campo [dataRealizacaoRessonanciaMagnetica](#17-datarealizacaoressonanciamagnetica) é obrigatório.

**Referências:** [ressonanciaMagnetica]({% url dicionario %}#ressonanciamagnetica).

