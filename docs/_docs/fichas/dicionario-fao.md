---
layout: doc
title: Ficha de Atendimento Odontológico Individual
id: dicionario-fao
parent: index_dicionario
order: 4
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

**Regras:** Somente as CBOs apresentadas na [Tabela 4 - CBOs que podem registrar ficha de atendimento odontológico individual]({% url cbo %}#ficha-de-atendimento-odontol-gico-individual) podem ser adicionadas no campo CBO do profissional principal.

**Referências:** [VariasLotacoesHeader]({% url headerTransport %}#variaslotacoesheader).

### \#3	atendimentosOdontologicos
Registro individualizado dos atendimentos.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<FichaAtendimentoOdontologicoChild>|	Sim|0|99|

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

**Regras:** CNS validado de acordo com o algoritmo.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

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

**Regras:** Apenas as opções `2`, `4`, `5` ou `6` são aceitas.

**Referências:** [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento).

### \#8	tiposEncamOdonto
Código das condutas adotadas e possíveis encaminhamentos.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long>|	Sim|	1|	17|

**Regras:** 

* A opção `15 - Tratamento concluído` só pode ser selecionada se no campo [tiposConsultaOdonto](#11-tiposconsultaodonto) for selecionada uma das opções `1 - Primeira consulta odontológica programática` ou `2 - Consulta de retorno em odontologia`.
* A opção `17 - Alta do episódio` não pode ser selecionada se no campo [tiposConsultaOdonto](#11-tiposconsultaodonto) for selecionada uma das opções `1 - Primeira consulta odontológica programática` ou `2 - Consulta de retorno em odontologia`.


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
|List\<Long>|	Condicional |	0	|1|

**Regras:**

* É de preenchimento obrigatório se o [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento) = `2 (consulta agendada)`;
* Não pode ser preenchido se o [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento) = `4 (escuta inicial ou orientação)`;
* Se o [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento) = `6 (atendimento de urgência)`, a opção de `2 (consulta de retorno)` não pode ser marcada;
* Se [TipoDeAtendimento]({% url dicionario %}#tipodeatendimento) = `5 (consulta no dia)`, o campo é opcional;
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
|List\<ProcedimentoQuantidade>|	Não|	-|	-|

**Regras:**

* Não pode conter procedimentos da [ListaProcedimentosRealizados](#listaprocedimentosrealizados);
* Não podem haver procedimentos com o mesmo código.

**Referências:** [ProcedimentoQuantidade](#procedimentoquantidade).

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

**Regras:** 

- Quando a lista partir da estrutura [procedimentosRealizados](#12-procedimentosrealizados), somente os procedimentos **AB** listados em [ListaProcedimentosRealizados](#listaprocedimentosrealizados) podem ser adicionados. Verificar o procedimento AB correspondente ao procedimento SIGTAP desejado;
- Quando a lista partir da estrutura [outrosSiaProcedimentos](#13-outrossiaprocedimentos), ela não pode conter procedimentos da [ListaProcedimentosRealizados](#listaprocedimentosrealizados) e só podem ser inseridos procedimentos cujo grupo é igual a `01` - Ações de promoção e prevenção em saúde, `02` - Procedimentos com finalidade diagnóstica, `03` - Procedimentos clínicos ou `04` - Procedimentos cirúrgicos.

**Referência:** Tabela do SIGTAP, competência 03/2017 disponível em: [Tabela Unificada SIGTAP](http://sigtap.datasus.gov.br/tabela-unificada/app/sec/procedimento/publicados/consultar).

Observações: 

- Inserir o código do procedimento SIGTAP sem ponto ou hífen, ex: `0201010010`.
- Inserir o código do procedimento AB em caracteres maiúsculos, sem espaços.

### \#2	quantidade
Quantidade de procedimentos realizados.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Sim|	0|	2|

**Regras:** O valor mínimo que pode ser registrado é 1 e o valor máximo é 99.

## ListaProcedimentosRealizados
|Código SIGTAP *| Descrição AB | Código AB correspondente |
|---|---|---|---|
|03.07.02.001-0 | Acesso a polpa dentária e medicação (por dente) | ABPO001 |
|03.07.04.014-3 | Adaptação de Prótese Dentária | ABPO002 |
|01.01.02.005-8 | Aplicação de cariostático (por dente)| ABPO003 |
|01.01.02.006-6 | Aplicação de selante (por dente) | ABPO004 |
|01.01.02.007-4 | Aplicação tópica de flúor (individual por sessão) | ABPO005 |
|03.07.01.001-5 | Capeamento pulpar | ABPO006 |
|03.07.04.013-5 | Cimentação de prótese dentária | ABPO007 |	
|03.07.02.002-9 | Curativo de demora c/ ou s/ preparo biomecânico | ABPO008 |	
|04.01.01.003-1 | Drenagem de abscesso |ABPG008 | 
|01.01.02.008-2 | Evidenciação de placa bacteriana | ABPO010 |
|04.14.02.012-0 | Exodontia de dente decíduo | ABPO011 |
|04.14.02.013-8 | Exodontia de dente permanente | ABPO012 |
|03.07.04.016-0 | Instalação de prótese dentária | ABPO013 |
|03.07.04.007-0 | Moldagem dento-gengival p/ construção de prótese dentária | ABPO014 |
|Não possui     | Orientação de Higiene Bucal | ABPO015 |
|03.07.03.004-0 | Profilaxia / Remoção de placa bacteriana | ABPO016 |
|03.07.02.007-0 | Pulpotomia dentária | ABPO017 |
|02.04.01.018-7 | Radiografia Periapical / Interproximal| ABPO018 |
|03.07.03.005-9 | Raspagem alisamento e polimento supragengivais (por sextante)| ABPO019 |
|03.07.03.002-4 | Raspagem alisamento subgengivais (por sextante)| ABPO020 |
|03.07.01.002-3 | Restauração de dente decíduo | ABPO021 |
|03.07.01.003-1 | Restauração de dente permanente anterior | ABPO022 |
|03.07.01.004-0 | Restauração de dente permanente posterior | ABPO023 |
|03.01.10.015-2 | Retirada de pontos de cirurgias básicas (por paciente) | ABPG018 |
|01.01.02.009-0 | Selamento provisório de cavidade dentária | ABPO025 |
|04.14.02.038-3 | Tratamento de alveolite | ABPO026 |
|04.14.02.040-5 | Ulotomia / Ulectomia | ABPO027 |
_* Procedimentos pertencentes a competência **03/2017** do SIGTAP._