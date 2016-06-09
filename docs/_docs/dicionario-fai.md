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

**Referência:** [VariasLotacoesHeader]({% url headerTransport %}#variaslotacoesheader).

### \#2	atendimentosIndividuais
Registro individualizado dos atendimentos.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<FichaAtendimentoIndividualChild>|	Sim	|-	|-|

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

**Regras:** Não pode ser posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento) e anterior a 130 anos a partir da [dataAtendimento]({% url headerTransport %}#5-dataatendimento).

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

* Não pode ser superior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento), nem inferior a data de nascimento;
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

**Regras:** 

- Não pode conter dois exames iguais;
- Preencher apenas com o código **AB** do exame.

**Referências:** [ListaExames](#listaexames).

### \#16	examesAvaliados
Lista de exames avaliados que são apresentados na ficha.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<String>|	Não|	0|	23|

**Regras:** 

- Não pode conter dois exames iguais;
- Preencher apenas com o código **AB** do exame.

**Referências:** [ListaExames](#listaexames).

### \#17	outrosSia
Lista de outros exames.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<OutrosSia>|	Não|	-|	-|

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
|List\<Long>|	Não|	0|	6|

**Referências:**	[racionalidadeSaude]({% url dicionario %}#racionalidadesaude).

### \#27	perimetroCefalicoNutricional
Perímetro cefálico do cidadão em centímetros.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Double|	Não|	0|	6|

**Regras:**

* Apenas números e vírgula (`,`);
* Máximo de 2 números após a vírgula;
* Valor mínimo 10 e máximo 200.

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
|List\<String>|	Sim|	1|	2|

**Referências:** [SituacaoExame]({% url dicionario %}#situacaoexame).

## ProblemaCondicaoAvaliacaoAI

### \#1	ciaps
Código dos CIAPs apresentados na lista.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<String>|	Condicional |	0 |	22 |

**Regras:**

* Não deve conter dois "Problemas / Condições" iguais;
* Preencher apenas com o código **AB** relacionado a CIAP2 desejada;
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

**Regras:** 

- Não pode ser igual a [cid10_2](#5-cid10_2);
- É Requerido o preenchimento de pelo menos um dos itens de `#1` a `#5`.


### \#5	cid10_2
Código do CID10 registrado no atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String| Condicional| - | - |

**Regras:** 

* Não pode ser igual a [cid10](#4-cid10);
* É Requerido o preenchimento de pelo menos um dos itens de `#1` a `#5`.

## ListaCiapCondicaoAvaliada
|CIAP2 relacionada| Descrição AB | Código AB|
|---|---|---|
|R96|Asma|ABP009|
|A77|Dengue|ABP019|
|T91|Desnutrição|ABP008|
|T90|Diabetes|ABP006|
|R95|DPOC|ABP010|
|A78|DST|ABP020|
|A78|Hanseníase|ABP018|
|K86|Hipertensão Arterial|ABP005|
|T82|Obesidade|ABP007|
|W78|Pré-natal|ABP001|
|A98|Puericultura|ABP004|
|W18|Puerpério (até 42 dias)|ABP002|
|Não possui|Rastreamento de Câncer de mama|ABP023|
|Não possui|Rastreamento de Câncer do colo do útero|ABP022|
|K22|Rastreamento de Risco cardiovascular|ABP024|
|A57|Reabilitação|ABP015|
|Não possui|Saúde Mental|ABP014|
|Não possui|Saúde Sexual e Reprodutiva|ABP003|
|P17|Tabagismo|ABP011|
|A70|Tuberculose|ABP017|
|P16|Usuário de álcool|ABP012|
|P19|Usuário de outras drogas|ABP013|

## ListaExames
|Código SIGTAP| Descrição AB | Código AB correspondente |
|---|---|---|
|02.02.01.029-5|Colesterol total|ABEX002|
|02.02.01.031-7|Creatinina|ABEX003|
|02.02.05.001-7|EAS / EQU|ABEX027|
|02.11.02.003-6|Eletrocardiograma|ABEX004|
|??????????????|Eletroforese de Hemoglobina|ABEX030|
|02.11.08.005-5|Espirometria|ABEX005|
|02.02.08.011-0|Exame de escarro|ABEX006|
|02.02.01.047-3|Glicemia|ABEX026|
|02.02.01.027-9|HDL|ABEX007|
|02.02.01.050-3|Hemoglobina glicada|ABEX008|
|02.02.02.038-0|Hemograma|ABEX028|
|02.02.01.028-7|LDL|ABEX009|
|Não possui    |Retinografia/Fundo de olho com oftalmologista|ABEX013|
|02.02.03.111-0|Sorologia de Sífilis (VDRL)|ABEX019|
|02.02.03.090-3|Sorologia para Dengue|ABEX016|
|02.02.03.030-0|Sorologia para HIV|ABEX018|
|02.02.12.009-0|Teste indireto de antiglobulina humana (TIA)|ABEX031|
|02.11.07.014-9|Teste da orelhinha|ABEX020|
|02.02.06.021-7|Teste de gravidez|ABEX023|
|Não possui    |Teste do olhinho|ABEX022|
|02.02.11.005-2|Teste do pezinho|ABEX021|
|02.05.02.014-3|Ultrassonografia obstétrica|ABEX024|
|02.02.08.008-0|Urocultura|ABEX029|
