---
layout: doc
title: Ficha complementar - Síndrome neurológica por Zika / Microcefalia
id: dicionario-fczm
order: 10
---


# FichaComplementar

### \#1 headerTransport
Dados referentes ao profissional e a data do cadastro.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|UnicaLotacaoHeader |Sim |- |- |

**Referência:** [headerTransport]({% url profissional %}#headertransport).

### \#2	uuidFicha
Código UUID para identificar a ficha na base de dados nacional.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	36|	44|

**Regras:** É recomendado concatenar o CNES na frente do UUID, de modo que os 7 dígitos (CNES) + 1 de hífen somados aos 36 (32 caracteres + 4 hífen) do UUID são a limitação de 44 bytes do campo. Formato canônico.

**Referência:** [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier)

### \#3	tpCdsOrigem
Tipo de origem dos dados do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Obrigatório|	1|	1|

Observações: Utilizar valor 3 (sistemas terceiros).

### \#4	cdsTurno
Código do turno onde aconteceu o atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Referências:** [Turno]({% url dicionario %}#turno)

### \#5 cnsCidadao
CNS do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |15 |15 |

**Regras:** Validado por algoritmo.

**Referência:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#6 cnsResponsavelFamiliar
CNS do responsável do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |15 |15 |

**Regras:** Validado por algoritmo.

**Referência:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#7 dataRealizacaoTesteOlhinho
Data de resultado do "Teste de olhinho (Reflexo vermelho)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** Não pode ser posterior a [dataAtendimento]({% url profissional %}#5-dataatendimento);

### \#8 coResultadoTesteOlhinho
Resultado do "Teste de olhinho (Reflexo vermelho)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Referência:** [testeOlhinho]({% url dicionario %}#testeolhinho).

### \#9 dataRealizacaoExameFundoOlho
Data de resultado do "Exame de fundo de olho (02.11.06.010-0 - Fundoscopia)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** Não pode ser posterior a [dataAtendimento]({% url profissional %}#5-dataatendimento);


### \#10 coResultadoExameFundoOlho
Resultado do "Exame de fundo de olho (02.11.06.010-0 - Fundoscopia)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Referência:** [exameFundoOlho]({% url dicionario %}#examefundoolho).

### \#11 dataRealizacaoExameOrelhinha
Data de resultado do "Teste da orelhinha - PEATE (02.11.07.027-0 - Potencial evocado auditivo para triagem auditiva)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** Não pode ser posterior a [dataAtendimento]({% url profissional %}#5-dataatendimento);

### \#12 coResultadoExameOrelhinha
Resultado do "Teste da orelhinha - PEATE (02.11.07.027-0 - Potencial evocado auditivo para triagem auditiva)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Referência:** [testeOrelhinha]({% url dicionario %}#testeorelhinha).

### \#13 dataRealizacaoUSTransfontanela
Data de resultado do exame de imagem "US transfontanela (02.05.02.017-8 - Ultrassonografia transfontanela)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** Não pode ser posterior a [dataAtendimento]({% url profissional %}#5-dataatendimento);

### \#14 coResultadoUsTransfontanela
Resultado do exame de imagem "US transfontanela (02.05.02.017-8 - Ultrassonografia transfontanela)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Referência:** [usTransfontanela]({% url dicionario %}#ustransfontanela).

### \#15 dataRealizacaoTomografiaComputadorizada
Data de resultado do exame de imagem "Tomografia computadorizada (02.06.01.007-9 - Tomografia computadorizada do crânio)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** Não pode ser posterior a [dataAtendimento]({% url profissional %}#5-dataatendimento);

### \#16 coResultadoTomografiaComputadorizada
Resultado do exame de imagem "Tomografia computadorizada (02.06.01.007-9 - Tomografia computadorizada do crânio)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Referência:** [tomografiaComputadorizada]({% url dicionario %}#tomografiacomputadorizada).

### \#17 dataRealizacaoRessonanciaMagnetica
Data de resultado do exame de imagem "Ressonância magnética (02.07.01.006-4 - Ressonância magnética de crânio)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** Não pode ser posterior a [dataAtendimento]({% url profissional %}#5-dataatendimento);

### \#18 coResultadoRessonanciaMagnetica
Resultado do exame de imagem "Ressonância magnética (02.07.01.006-4 - Ressonância magnética de crânio)".

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Referência:** [ressonanciaMagnetica]({% url dicionario %}#ressonanciamagnetica).

