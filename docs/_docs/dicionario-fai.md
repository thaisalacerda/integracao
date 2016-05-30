---
layout: doc
title: Ficha de Atendimento Individual
id: dicionario-fai
order: 2
---


## FichaAtendimentoIndividualMaster

### \#1	headerTransport
Profissionais que realizaram o atendimento

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|VariasLotacoesHeader|	Sim|	-|	-|

**Referência:** [headerTransport]({% url profissional %}#headertransport).

### \#2	atendimentosIndividuais
Registro individualizado dos atendimentos.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<FichaAtendimentoIndividualChild>|	Sim	|1	|13|

**Regras:** No máximo 13 atendimentos podem ser registrados.

**Referências:** [FichaAtendimentoIndividualChild](#fichaatendimentoindividualchild).

### \#3	uuidFicha
Código UUID para identificar a ficha na base de dados nacional.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	36|	44|

**Regras:** É recomendado concatenar o CNES na frente do UUID, de modo que os 7 dígitos (CNES) + 1 de hífen somados aos 36 (32 caracteres + 4 hífen) do UUID são a limitação de 44 bytes do campo. Formato canônico.

**Referências:** Para ver a referência sobre o UUID, acesse: [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier).

### \#4	tpCdsOrigem
Tipo de origem dos dados do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Sim|	1	|1|

**Regras:** Utilizar valor 3 (sistemas terceiros).

## FichaAtendimentoIndividualChild

### \#1	numeroProntuario
Número do prontuário.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	0|	30|

**Regras:** Apenas letras e números são aceitos.

### \#2	cns
CNS do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	15|	15|

**Regras:** CNS válido de acordo com o algoritmo.

**Referência:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#3	dataNascimento
Data de nascimento do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Regras:** Não pode ser posterior a [dataAtendimento]({% url profissional %}#5-dataatendimento) e anterior a 130 anos a partir da [dataAtendimento]({% url profissional %}#5-dataatendimento).

**Refererência**: [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milisegundos.

### \#4	localDeAtendimento
Código do local onde o atendimento foi realizado.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Regras:** Apenas valores de `1` a `10`.

**Referências:** [LocalDeAtendimento]({% url dicionario %}#localdeatendimento).

### \#5	sexo
Código do sexo do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Referências:** [Sexo]({% url dicionario %}#sexo).

### \#6	turno
Código do turno em que o atendimento foi realizado.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Referências:** [Turno]({% url dicionario %}#turno).

### \#7	tipoAtendimento
Código do tipo de atendimento realizado.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Regras:** Apenas valores de `1` a `6`.

**Referências:** [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento).

### \#8	pesoAcompanhamentoNutricional
Peso do cidadão em Quilogramas.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Double|	Não|	1|	7|

**Regras:**

* Apenas números e vírgula (`,`);
* Máximo de 3 números após a vírgula;
* Valor mínimo 0,5 e máximo 500.

### \#9	alturaAcompanhamentoNutricional
Altura do cidadão em centímetros.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Double|	Não|	2|	5|

**Regras:**

* Apenas números e vírgula (`,`);
* Máximo de 1 número após a vírgula;
* Valor mínimo 20 e máximo 250.

### \#10	aleitamentoMaterno
Código do marcador referente ao aleitamento materno.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Referências:**	[AleitamentoMaterno]({% url dicionario %}#aleitamentomaterno).

### \#11	dumDaGestante
Data da última menstruação da gestante.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Regras:**

* Não pode ser superior a [dataAtendimento]({% url profissional %}#5-dataatendimento), nem inferior a data de nascimento;
* Não pode ser preenchido quando [Sexo](#5-sexo) = `0 (masculino)`.

**Referências:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milissegundos.

### \#12	idadeGestacional
Idade gestacional em semanas.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Não|	0|	2|

**Regras**

* Valor mínimo 1 e máximo 42;
* Não pode ser preenchido quando [Sexo](#5-sexo) = `0 (masculino)`.

### \#13	atencaoDomiciliarModalidade
Código do modalidade AD do cidadão atendido.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Regras:** Apenas valores de `1` a `3`.

**Referências:**	[ModalidadeAD]({% url dicionario %}#modalidadead).

### \#14	problemaCondicaoAvaliada
Situações de saúde avaliadas no atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|ProblemaCondicaoAvaliacaoAI|	Sim|	-|	-|

**Referências:**
[ProblemaCondicaoAvaliacaoAI](#problemacondicaoavaliacaoai).

### \#15	examesSolicitados
Lista de exames solicitados que são apresentados na ficha.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<String>|	Não|	0|	23|

**Regras:** Não pode conter dois exames iguais.

**Referências:** [ListaExameSolicitado](#listaexamesolicitado).

### \#16	examesAvaliados
Lista de exames avaliados que são apresentados na ficha.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<String>|	Não|	0|	23|

**Regras:** Não pode conter dois exames iguais.

**Referências:** [ListaExameSolicitado](#listaexamesolicitado).

### \#17	outrosSia
Lista de outros exames.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<OutrosSia>|	Não|	0|	3|

**Referências:** [OutrosSia](#outrossia).

### \#18	vacinaEmDia
Marcador referente a vacinação em dia do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

### \#20	ficouEmObservacao
Marcador referente se o cidadão ficou em observação no atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

### \#21	nasfs
Código das ações realizadas pelo Núcleo de Atenção a Saúde da Família.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long>|	Não|	0|	3|

**Referências:** [Nasf]({% url dicionario %}#nasf).

### \#22	condutas
Código das condutas adotadas no atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long>|	Sim|	1|	12|

**Regras:** Não deve conter duas condutas iguais.

**Referências:** [CondutaEncaminhamento]({% url dicionario %}#condutaencaminhamento).

### \#23	stGravidezPlanejada
Marcador que indica se a gravidez é planejada.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

**Regras:** Não pode ser preenchido quando [Sexo](#5-sexo) = `0 (masculino)`.

### \#24	nuGestasPrevias
Número de gestações prévias.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Não|	0|	2|

**Regras:** Não pode ser preenchido quando [Sexo](#5-sexo) = `0 (masculino)`.

### \#25	nuPartos
Número de partos que a mulher já teve.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Não|	0|	2|

**Regras:** Não pode ser preenchido quando [Sexo](#5-sexo) = `0 (masculino)`.

### \#26	racionalidadeSaude
Código da racionalidade em saúde utilizada. 

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Referências:**	[racionalidadeSaude]({% url dicionario %}#racionalidadesaude).

### \#27	perimetroCefalicoNutricional
Perímetro cefálico do cidadão em centímetros.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Double|	Não|	0|	2|

## OutrosSia

### \#1	codigoExame
Código do exame solicitado ou avaliado.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	-|	-|

**Regras:** Deve ser um procedimento com um código válido.

**Referências:** Para ver a referência da tabela do SIGTAP acesse: [Tabela Unificada SIGTAP](http://sigtap.datasus.gov.br/tabela-unificada/app/sec/procedimento/publicados/consultar).

**Observações**: Sem ponto ou hífen, ex: `0101010010`.

### \#2	solicitadoAvaliado
Código do indicador se o exame foi `Solicitado` e / ou `Avaliado`.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<String>|	Sim|	-|	-|

**Referências:** [SituacaoExame]({% url dicionario %}#situacaoexame).

## ProblemaCondicaoAvaliacaoAI

### \#1	ciaps
Código dos CIAPs apresentados na lista.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<String>|	Condicional |	0 |	22 |

**Regras:**

* Não deve conter dois "Problemas / Condições" iguais;
* É Requerido o preenchimento de pelo menos um dos itens de `#1` a `#5`.

**Referências:** [ListaCiapCondicaoAvaliada](#listaciapcondicaoavaliada).

### \#2	outroCiap1
Código do CIAP2 registrado no antedimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Condicional | 	-|	-|

**Regras:**

* Não pode ser igual a [outroCiap2](#3-outrociap2);
* É Requerido o preenchimento de pelo menos um dos itens de `#1` a `#5`.

### \#3	outroCiap2
Código do CIAP2 registrado no antedimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Condicional|	-|	-|

**Regras:**

* Não pode ser igual a [outroCiap1](#2-outrociap1);
* É Requerido o preenchimento de pelo menos um dos itens de `#1` a `#5`.

### \#4	cid10
Código do CID10 registrado no atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String| Condicional| - | - |

**Regras:** É Requerido o preenchimento de pelo menos um dos itens de `#1` a `#5`.

### \#5	cid10_2
Código do CID10 registrado no atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String| Condicional| - | - |

**Regras:** 

* Não pode ser igual a [cid10](#4-cid10);
* É Requerido o preenchimento de pelo menos um dos itens de `#1` a `#5`.

## ListaCiapCondicaoAvaliada
|Código| Descrição|
|---|---|
|ABP009|	Asma|
|ABP019|	Dengue|
|ABP008|	Desnutrição|
|ABP006|	Diabetes|
|ABP010|	DPOC|
|ABP020|	DST|
|ABP018|	Hanseníase|
|ABP005|	Hipertensão Arterial|
|ABP007|	Obesidade|
|ABP001|	Pré-natal|
|ABP004|	Puericultura|
|ABP002|	Puerpério (até 42 dias)|
|ABP023|	Rastreamento de Câncer de mama|
|ABP022|	Rastreamento de Câncer do colo do útero|
|ABP024|	Rastreamento de Risco cardiovascular|
|ABP015|	Reabilitação|
|ABP014|	Saúde Mental|
|ABP003|	Saúde Sexual e Reprodutiva|
|ABP011|	Tabagismo|
|ABP017|	Tuberculose|
|ABP012|	Usuário de álcool|
|ABP013|	Usuário de outras drogas|

## ListaExameSolicitado
|Código| Descrição|
|---|---|
|ABEX002|		Colesterol total|
|ABEX003|		Creatinina|
|ABEX027|		EAS / EQU|
|ABEX004|		Eletrocardiograma|
|ABEX030|		Eletroforese de Hemoglobina|
|ABEX005|		Espirometria|
|ABEX006|		Exame de escarro|
|ABEX026|		Glicemia|
|ABEX007|		HDL|
|ABEX008|		Hemoglobina glicada|
|ABEX028|		Hemograma|
|ABEX009|		LDL|
|ABEX013|		Retinografia/Fundo de olho com oftalmologista|
|ABEX019|		Sorologia de Sífilis (VDRL)|
|ABEX016|		Sorologia para Dengue|
|ABEX018|		Sorologia para HIV|
|ABEX031|		Teste indireto de antiglobulina humana (TIA)|
|ABEX020|		Teste da orelhinha|
|ABEX023|		Teste de gravidez|
|ABEX022|		Teste do olhinho|
|ABEX021|		Teste do pezinho|
|ABEX024|		Ultrassonografia obstétrica|
|ABEX029|		Urocultura|
