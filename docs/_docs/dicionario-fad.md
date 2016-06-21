---
layout: doc
title: Ficha de Atendimento Domiciliar
id: dicionario-fad
order: 9
---

## FichaAtendimentoDomiciliarMaster

### \#1	uuidFicha
Código UUID para identificar a ficha na base de dados nacional.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Obrigatório|	36|	44|

**Regras:** É recomendado concatenar o CNES na frente do UUID, de modo que os 7 dígitos (CNES) + 1 de hífen somados aos 36 (32 caracteres + 4 hífen) do UUID são a limitação de 44 bytes do campo.

**Referências:** Formato canônico.	Para ver a referência sobre o UUID, acesse: [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier).

### \#2	tpCdsOrigem
Tipo de origem dos dados do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Obrigatório|	1|	1|

Observações: Utilizar valor 3 (sistemas terceiros).

### \#3	headerTransport
Profissional que realizou a visita.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|UnicaLotacaoHeader|	Obrigatório|	-|	-|

**Referência:** [UnicaLotacaoHeader]({% url headerTransport %}#unicalotacaoheader).

### \#4	atendimentosDomiciliares
Lista dos atendimentos realizados pelo profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<FichaAtendimentoDomiciliarChild\>|	Obrigatório|	-|	-|

## FichaAtendimentoDomiciliarChild

### \#1	turno
Código do turno onde aconteceu o atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Obrigatório|	-|	-|

**Referências:** [Turno]({% url dicionario %}#turno).

### \#2	cns
CNS do cidadão que participou da atividade.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	15|	15|

**Regras:** Validado pelo algoritmo.

**Referência:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#3	dataNascimento
Data de nascimento do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Obrigatório|	-|	-|

**Regras:** Não pode ser posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento) e anterior a 130 anos a partir da [dataAtendimento]({% url headerTransport %}#5-dataatendimento).

**Referencias:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milissegundos.

### \#4	sexo
Código do sexo do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Obrigatório|	-|	-|

**Referências:**	[Sexo]({% url dicionario%}#sexo).

### \#5	localDeAtendimento
Código do local onde o atendimento foi realizado.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Obrigatório|	-|	-|

**Referências:** [LocalDeAtendimento]({% url dicionario%}#localdeatendimento).

### \#6	atencaoDomiciliarModalidade
Código da modalidade AD do cidadão atendido.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Obrigatório|	-|	-|

**Regras:** Apenas as opções `1`, `2` e `3` são aceitas.

**Referências:** [ModalidadeAD]({% url dicionario %}#modalidadead).

### \#7	tipoAtendimento
Código do tipo de atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Obrigatório|	-|	-|

**Regras:** Apenas as opções `7` e `8` são aceitas.

**Referências:** [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento).

### \#8	situacoesPresentes
Marcadores das situações presentes.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long\>|	Não|	0|	24|

### \#9	cid
Código do CID registrado no atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	-|	-|

### \#10	ciap
Código do CIAP registrado no atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	-	|-|

### \#11	procedimentos
Código dos procedimentos registrados no atendimento disponíveis na ficha.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<String\>|	Não|	0|	20|

**Referências:** [Procedimentos da Atencao Domiciliar](#procedimentos-da-atencao-domiciliar)

### \#12	outrosProcedimentos
Código dos procedimentos SIGTAP registrados no atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<String\>|	Não	|-|	-|

**Regras:**

* Não podem ser iguais aos procedimentos à cima.
* Não podem conter procedimentos repetidos.

### \#13	condutaDesfecho
Código do desfecho do atendimento do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Regras:**	Não podem conter as opções `7` ou `8`.

**Referências:**	[CondutaDesfecho]({% url dicionario %}#condutadesfecho).

### \#14	statusInicioAcompanhamentoPosObito
Marcador que indica se a família irá receber acompanhamento pós-óbito.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

## Questionário de Situações Presentes

|Nome|	Código|
|--- |---|
|Acamado	|1|
|Domiciliado	|2|
|Úlceras / Feridas (grau III ou IV)	|3|
|Acompanhamento nutricional	|4|
|Uso de sonda naso-gástrica - SNG	|5|
|Uso de sonda naso-enteral - SNE	|6|
|Uso de gastrostomia	|7|
|Uso de colostomia	|8|
|Uso de cistostomia	|9|
|Uso de sonda vesical de demora - SVD	|10|
|Acompanhamento pré-operatório	|11|
|Acompanhamento pós-operatório	|12|
|Adaptação ao uso de órtese / prótese	|13|
|Reabilitação domiciliar	|14|
|Cuidados paliativos oncológico	|15|
|Cuidados paliativos não-oncológico	|16|
|Oxigenoterapia domiciliar	|17|
|Uso de traqueostomia	|18|
|Uso de aspirador de vias aéreas para higiene brônquica	|19|
|Suporte ventilatório não invasivo - CPAP	|20|
|Suporte ventilatório não invasivo - BiPAP	|21|
|Diálise peritonial | 22|
|Paracentese | 23|
|Medicação  parenteral	|24|

## Procedimentos da Atencao Domiciliar

|Nome			|Código|
|--- |---|
|Acompanhamento de paciente em reabilitação em comunicação alternativa			|0301070024|
|Antibioticoterapia parenteral			|0301050082|
|Atendimento / acompanhamento de paciente em reabilitação do desenvolvimento neuropsicomotor			|0301070075|
|Atendimento fisioterapêutico paciente com transtorno respiratório sem complicações sistêmicas			|0302040021|
|Atendimento médico com finalidade de atestar óbito			|0301050090|
|Atendimento / acompanhamento em reabilitação nas múltiplas deficiências			|0301070067|
|Cateterismo vesical de alívio			|0301100047|
|Cateterismo vesical de demora			|0301100055|
|Coleta de material para exame laboratorial			|0201020041|
|Cuidados com estomas			|0301100063|
|Cuidados com traqueostomia			|0301100071|
|Enema			|0301100098|
|Oxigenoterapia			|0301100144|
|Retirada de pontos de cirurgias básicas (por paciente)			|0301100152|
|Sondagem gástrica			|0301100179|
|Terapia de reidratação oral			|0301100187|
|Terapia de reidratação parenteral			|0301050120|
|Terapia fonoaudiológica individual			|0301070113|
|Tratamento de traumatismos de localização especificada / não especificada			|0308010019|
|Tratamento em reabilitação			|0303190019|