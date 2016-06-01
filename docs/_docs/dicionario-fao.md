---
layout: doc
title: Ficha de Atendimento Odontológico Individual
id: dicionario-fao
order: 3
---


## FichaAtendimentoOdontologicoMaster

### \#1	uuidFicha
Código UUID para identificar a ficha na base de dados nacional.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	36|	44|

**Regras:** É recomendado concatenar o CNES na frente do UUID, de modo que os 7 dígitos (CNES) + 1 de hífen somados aos 36 (32 caracteres + 4 hífen) do UUID são a limitação de 44 bytes do campo. Formato canônico.

**Referências:** Para ver a referência sobre o UUID, acesse: [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier).

### \#2	headerTransport
Profissionais que realizaram o atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|VariasLotacoesHeader|	Sim|	-|	-|

**Referência:** [VariasLotacoesHeader]({% url headerTransport %}#variaslotacoesheader).

### \#3	atendimentosOdontologicos
Registro individualizado dos atendimentos.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<FichaAtendimentoOdontologicoChild>|	Sim|-|-|

**Regras:** No máximo 13 atendimentos podem ser registrados.

**Referências:** [FichaAtendimentoOdontologicoChild](#fichaatendimentoodontologicochild).

### \#4	tpCdsOrigem
Tipo de origem dos dados do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Sim|	1|	1|

**Regras:** Utilizar valor 3 (sistemas terceiros).

## FichaAtendimentoOdontologicoChild

### \#1	dtNascimento
Data de nascimento do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Regras:** Não pode ser posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento) e anterior a 130 anos a partir da [dataAtendimento]({% url headerTransport %}#5-dataatendimento).

**Referências:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milissegundos.

### \#2	cnsCidadao
CNS do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	15|	15|

**Regras:** CNS válido de acordo com o algoritmo.

**Referência:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#3	numProntuario
Número do prontuário do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String	|Não|	0|	30|

**Regras:** Apenas letras e números são aceitos.

### \#4	gestante
Marcador que indica se o cidadão está gestante.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

**Regras:** Só pode ser preenchido se o campo [Sexo](#14-sexo) = `1 (feminino)`.

### \#5	necessidadesEspeciais
Marcador que indica se o cidadão é portador de necessidades especiais.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

### \#6	localAtendimento
Código do local onde o atendimento foi realizado.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Regras:** Apenas valores de `1` a `10`.

**Referências:** [LocalDeAtendimento]({% url dicionario %}#localdeatendimento).

### \#7	tipoAtendimento
Código do tipo de atendimento realizado.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Regras:** Apenas valores de `2` a `6`.

**Referências:**	[TipoDeAtendimento]({% url dicionario %}#tipodeatendimento).

### \#8	tiposEncamOdonto
Código das condutas adotadas e possíveis encaminhamentos.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long>|	Sim|	1|	16|

**Referências:** [CondutaEncaminhamentoOdonto]({% url dicionario %}#condutaencaminhamentoodonto).

### \#9	tiposFornecimOdonto
Código dos materiais fornecidos durante o atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long>|	Não	|0|	3|

**Referências:** [FornecimentoOdonto]({% url dicionario %}#fornecimentoodonto).

### \#10	tiposVigilanciaSaudeBucal
Código dos marcadores referentes a situação de vigilância em saúde bucal.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long>|	Sim|	1|	7|

**Referências:** [VigilanciaEmSaudeBucal]({% url dicionario %}#vigilanciaemsaudebucal).

### \#11	tiposConsultaOdonto
Código do tipo de consulta odontológica realizada.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long>|	Condicional |	-	|-|

**Regras:**

* É Requerido se o [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento) = `2 (consulta agendada)`;
* Não pode ser preenchido se o [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento) = `4 (escuta inicial ou orientação)`;
* Se o [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento) = `6 (atendimento de urgência)`, a opção de `2 (consulta de retorno)` não pode ser marcada;
* Se [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento) = `5 (consulta no dia)`, o campo é opcional.
* Aceita apenas um registro.

**Referências:** [TipoDeConsultaOdonto]({% url dicionario %}#tipodeconsultaodonto)

### \#12	procedimentosRealizados
Código dos procedimentos que são apresentados na ficha.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<ProcedimentoQuantidade>|	Não|	0|	27|

**Regras:**

* Não podem haver procedimentos com o mesmo código.
* Somente os procedimentos **AB** listados em [ListaProcedimentosRealizados](#listaprocedimentosrealizados) podem ser adicionados. Verificar o procedimento AB correspondente ao procedimento SIGTAP desejado.

**Referências:** [ProcedimentoQuantidade](#procedimentoquantidade).

### \#13	outrosSiaProcedimentos
Lista de outros códigos de procedimentos.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<ProcedimentoQuantidade>|	Não|	0|	24|

**Regras:**

* Não pode conter procedimentos da [ListaProcedimentosRealizados](#listaprocedimentosrealizados);
* Não podem haver procedimentos com o mesmo código.

**Referências:** 

- [ProcedimentoQuantidade](#procedimentoquantidade).
- Para ver a referência da tabela do SIGTAP acesse: [Tabela Unificada SIGTAP](http://sigtap.datasus.gov.br/tabela-unificada/app/sec/procedimento/publicados/consultar).

### \#14	sexo
Código do sexo do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Referências:** [Sexo]({% url dicionario %}#sexo).

### \#15 turno
Código do turno em que o atendimento foi realizado.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Referências:** [Turno]({% url dicionario %}#turno).

## ProcedimentoQuantidade

### \#1	coMsProcedimento
Código do procedimento no MS.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	-|	-|

**Regras:** Deve ser um procedimento com um código válido.

### \#2	quantidade
Quantidade de procedimentos realizados.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Sim|	0|	2|

**Regras:** Valor máximo que pode ser registrado é 99.

## ListaProcedimentosRealizados
|Código SIGTAP| Descrição SIGTAP | Código AB correspondente |
|---|---|---|---|
|03.07.02.001-0 | Acesso a polpa dentária e medicação (por dente) |ABPO001|
|03.07.04.014-3 | Adaptação de Prótese Dentária | ABPO002 |
|01.01.02.005-8 | Aplicação de cariostático (por dente)| ABPO003 |
|01.01.02.006-6 | Aplicação de selante (por dente)| ABPO004|
|01.01.02.007-4 | Aplicação tópica de flúor (individual por sessão)| ABPO005|
|03.07.01.001-5 | Capeamento pulpar | ABPO006|
|03.07.04.013-5 | Cimentação de prótese dentária|ABPO007|	
|03.07.02.002-9 | Curativo de demora c/ ou s/ preparo biomecânico|ABPO008|	
|04.01.01.003-1 | Drenagem de abscesso|ABPG008| 
|01.01.02.008-2 | Evidenciação de placa bacteriana|ABPO010|
|04.14.02.012-0 | Exodontia de dente decíduo|ABPO011|
|04.14.02.013-8 | Exodontia de dente permanente|ABPO012|
|ABPO013|	Instalação de prótese dentária|
|ABPO014|	Moldagem dento-gengival p/ construção de prótese dentária|
|ABPO015|	Orientação de Higiene Bucal|
|ABPO016|	Profilaxia / Remoção de placa bacteriana|
|ABPO017|	Pulpotomia dentária|
|ABPO018|	Radiografia Periapical / Interproximal|
|ABPO019|	Raspagem alisamento e polimento supragengivais (por sextante)|
|ABPO020|	Raspagem alisamento subgengivais (por sextante)|
|ABPO021|	Restauração de dente decíduo|
|ABPO022|	Restauração de dente permanente anterior|
|ABPO023|	Restauração de dente permanente posterior|
|ABPG018|	Retirada de pontos de cirurgias básicas (por paciente)|
|ABPO025|	Selamento provisório de cavidade dentária|
|ABPO026|	Tratamento de alveolite|
|ABPO027|	Ulotomia / Ulectomia|
