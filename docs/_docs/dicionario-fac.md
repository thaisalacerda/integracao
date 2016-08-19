---
layout: doc
title: Ficha de Atividade Coletiva
id: dicionario-fac
order: 4
---

## FichaAtividadeColetiva

### \#1	uuidFicha
Código UUID para identificar a ficha na base de dados nacional.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	36|	44|

**Regras:** É recomendado concatenar o CNES na frente do UUID, de modo que os 7 dígitos (CNES) + 1 de hífen somados aos 36 (32 caracteres + 4 hífen) do UUID são a limitação de 44 bytes do campo. Formato canônico.

**Referências:** [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier).

### \#2	outraLocalidade
Descrição do local onde é realizada a atividade coletiva.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	0|	250|

**Regras:** Preencher somente um dos itens `2`, `3` ou `12`.

### \#3	inep
Número INEP da instituição.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	0|	8|

**Regras:** Preencher somente um dos itens `2`, `3` ou `12`.

### \#4	numParticipantes
Número de participantes da atividade.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Sim|	0|	3|

**Regras:**

- Valores entre 1 e 999;
- Deve ser maior ou igual a quantidade de participantes inseridos em [participantes](#10-participantes).

### \#5	numAvaliacoesAlteradas
Número de avaliações alteradas.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Não|	0|	3|

**Regras:**	

- Valores entre 0 e 999.
- O valor do campo deve ser igual ao número de participantes que tiveram o campo [avaliacaoAlterada](#3-avaliacaoalterada) = `true`.

### \#6 profissionais
Lista dos profissionais que participaram da atividade.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<ProfissionalCboRowItem\> |Não |-	|- |

**Referências:**	[ProfissionalCboRowItem](#profissionalcborowitem).

### \#7 atividadeTipo
Código do tipo da atividade que será realizada.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Obrigatório |	-|	-|

**Referências**: [TipoAtividadeColetiva]({% url dicionario %}#tipoatividadecoletiva).

### \#8 temasParaReuniao
Temas para reunião.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|	List\<Long\>|	Condicional |0 |	7|

**Regras:**

* É de preenchimento obrigatório se [atividadeTipo](#7-atividadetipo) for `1`, `2` ou `3`;
* Não pode ser preenchido se [atividadeTipo](#7-atividadetipo) for `4`, `5`, `6` ou `7`.

**Referências:** [TemasParaReuniao]({% url dicionario %}#temasparareuniao).

### \#9	publicoAlvo
Código do público alvo da atividade.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long\>|	Condicional |	0|	17|

**Regras:**

* É de preenchimento obrigatório se [atividadeTipo](#7-atividadetipo) for `4`, `5`, `6` ou `7`;
* Não pode ser preenchido se [atividadeTipo](#7-atividadetipo) for `1`, `2` ou `3`.

**Referências:** [PublicoAlvo]({% url dicionario %}#publicoalvo).

### \#10	participantes
Cidadãos que participaram da atividade coletiva.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<ParticipanteRowItem\>|	Condicional|	-|-|

**Regras:** É de preenchimento obrigatório se [atividadeTipo](#7-atividadetipo) for `5` ou `6`.

**Referências:** [ParticipanteRowItem](#participanterowitem).

### \#11	tbCdsOrigem
Tipo de origem dos dados do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Sim|	1|	1|

**Observações**: Utilizar valor 3 (sistemas terceiros).

### \#12	cnesLocalAtividade
CNES do local de atividade.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	-|	-|

**Regras:** Preencher somente um dos itens `2`, `3` ou `12`.


### \#13	procedimento
Código do SIGTAP do procedimento coletivo realizado.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	-|	-|

**Regras:** Só pode ser preenchido se o campo [praticasEmSaude](#17-praticasemsaude) possuir o valor `30`.

**Referências:** [OutroProcedimentoColetivo](#outroprocedimentocoletivo).

### \#14	turno
Turno de realização da atividade.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Referências:** [Turno]({% url dicionario %}#turno).

### \#15 headerTransport
Dados referentes ao profissional responsável e a data do cadastro.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|UnicaLotacaoHeader |Sim |- |- |

**Referências:** [UnicaLotacaoHeader]({% url headerTransport %}#unicalotacaoheader).

### \#16	temasParaSaude
Códigos dos temas para saúde abordados na atividade.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long\>|	Condicional| 	0|	16|

**Regras:**

* Não pode ser preenchido se [atividadeTipo](#7-atividadetipo) = `1`, `2` ou `3`;
* É de preenchimento obrigatório se [atividadeTipo](#7-atividadetipo) = `4`, `5` ou `7`;

**Referências:** [TemasParaSaude]({% url dicionario %}#temasparasaude).

### \#17	praticasEmSaude
Códigos das práticas em saúde abordadas na atividade.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long\>|	Condicional| 	0|	14|

**Regras:**

* Não pode ser preenchido se [atividadeTipo](#7-atividadetipo) = `1`, `2`, `3`, `4` ou `7`;
* É de preenchimento obrigatório se [atividadeTipo](#7-atividadetipo) = `6`;
* Os itens `2 - Aplicação tópica de flúor` e `9 - Escovação dental supervisionada` só podem ser utilizados se [atividadeTipo](#7-atividadetipo) = `6`.

**Referências:** [PraticasEmSaude]({% url dicionario %}#praticasemsaude).

## ParticipanteRowItem

### \#1	cnsParticipante
CNS do cidadão que participou da atividade.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Condicional|	15|	15|

**Regras:** 

- CNS validado de acordo com o algoritmo.
- É de preenchimento obrigatório se [atividadeTipo](#7-atividadetipo) for `5` ou `6`.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#2	dataNascimento
Data de nascimento do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|	Long|	Sim|	-|	-|

**Regras:** Não pode ser posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento) e anterior a 130 anos a partir da [dataAtendimento]({% url headerTransport %}#5-dataatendimento).


**Referências**: [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milissegundos.

### \#3	avaliacaoAlterada
Marcador que indica que a avaliação do cidadão teve um valor diferente dos considerados normais.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

### \#4	peso
Peso do cidadão em quilogramas.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|	Double|	Não|	1|	7|

**Regras:**

* Apenas números e vírgula (`,`);
* Máximo de 3 números após a vírgula;
* Valor mínimo 0,5 e máximo 500.

### \#5	altura
Altura do cidadão em centímetros.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Double|	Não| 	2|	5|

**Regras:**

* Apenas números e vírgula (`,`);
* Máximo de 1 número após a vírgula;
* Valor mínimo 20 e máximo 250.

### \#6	cessouHabitoFumar
Marcação se o cidadão cessou o hábito de fumar.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

**Regras:** Não deve ser preenchido se o campo [praticasEmSaude](#17-praticasemsaude) for diferente de `25`, `26`, `27` ou `28` (referentes ao PNCT).

### \#7	abandonouGrupo
Marcação se o cidadão abandonou o grupo de tabagismo.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

**Regras:** Não deve ser preenchido se o campo [praticasEmSaude](#17-praticasemsaude) for diferente de `25`, `26`, `27` ou `28` (referentes ao PNCT).

## \#8	sexo
Sexo do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|	Long|	Sim|	-|	-|

**Referências:** [Sexo]({% url dicionario %}#sexo).

## ProfissionalCboRowItem

### \#1 cnsProfissional
CNS do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |15 |15 |

**Regras:** CNS validado de acordo com o algoritmo.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

Observações: Esta entidade é utilizada para representar os profissionais que participaram da atividade coletiva

### \#2 codigoCbo2002
Código CBO do profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |- |- |

**Referências:** {% link cbo %}.

Observações: Esta entidade é utilizada para representar os profissionais que participaram da atividade coletiva.

## OutroProcedimentoColetivo

|Código SIGTAP *|	Descrição|
|--- |---|
|01.01.01.004-4 | PRÁTICAS CORPORAIS EM MEDICINA TRADICIONAL CHINESA
|01.01.02.008-2 | EVIDENCIAÇÃO DE PLACA BACTERIANA
|01.01.01.005-2 | TERAPIA COMUNITARIA
|01.01.01.006-0 | DANÇA CIRCULAR/BIODANÇA
|01.01.01.007-9 | IOGA
|01.01.01.008-7 | OFICINA DE MASSAGEM/AUTO-MASSAGEM
|01.01.02.002-3 | AÇÃO COLETIVA DE BOCHECHO FLUORADO
|01.01.02.004-0 | AÇÃO COLETIVA DE EXAME BUCAL COM FINALIDADE EPIDEMIOLÓGICA


_* Procedimentos pertencentes a competência **07/2016** do SIGTAP._