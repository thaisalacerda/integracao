---
layout: doc
title: Ficha de Cadastro Domiciliar e Territorial
id: dicionario-fcd
order: 1
---

# Ficha de Cadastro Domiciliar e Territorial

## CadastroDomiciliar

### \#1	animaisNoDomicilio
Lista de código dos animais no domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<Long\>|	Condicional|	0|	5|

**Regras:**

* Só pode ser preenchido se o campo [tipoDeImovel](#1-tipodeimovel) = 01 Domicílio.
* Não pode ser preenchido se o campo [statusTermoRecusaCadastroDomiciliarAtencaoBasica](#9-statustermorecusacadatrodomiciliaratencaobasica) = `true`.

**Referências:** [AnimalNoDomicilio]({% url dicionario %}#animalnodomicilio)

### \#2	condicaoMoradia
Condições de moradia do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
| ---| --- |---  | --- |
| CondicaoMoradia	| Condicional	| - |	-	|

**Regras:**

* Não devem ser preenchidos se o campo [tipoDeImovel](#1-tipodeimovel) = 02 Comércio, 03 Terreno baldio, 04 Ponto Estratégico, 05 Escola, 06 Creche, 12 Estabelecimento Religioso, 99 Outros.
* Não devem ser preenchidos se o campo [statusTermoRecusaCadastroDomiciliarAtencaoBasica](#9-statustermorecusacadatrodomiciliaratencaobasica) = `true`.

**Referências:** [CondicaoMoradia](#condicaomoradia)

### \#4	enderecoLocalPermanencia
Informações sobre o endereço do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
| ---| --- |---  | --- |
| EnderecoLocalPermanencia|	Condicional |  - | -|

**Regras:** Preenchimento obrigatório caso o campo [statusTermoRecusaCadastroDomiciliarAtencaoBasica](#9-statustermorecusacadatrodomiciliaratencaobasica) = `false`.

**Referências:** [EnderecoLocalPermanencia](#enderecolocalpermanencia)

### \#5	familias
Lista das famílias que residem no domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|List\<FamiliaRow>| Condicional| 	0|	4|

**Regras:**

* Só pode ser preenchido se o campo [tipoDeImovel](#1-tipodeimovel) = 01 Domicílio.
* Não pode ser preenchido caso o campo [statusTermoRecusaCadastroDomiciliarAtencaoBasica](#9-statustermorecusacadatrodomiciliaratencaobasica) = `true`.

### \#6	fichaAtualizada
Marcador que indica se a ficha é uma atualização.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Sim|	1|	1|

**Observação:** Caso seja uma ficha de atualização, o campo [uuidFichaOriginadora](#12-uuidfichaoriginadora) deve ser preenchido com o UUID da ficha que deu origem ao registro.

### \#7	quantosAnimaisNoDomicilio
Número de animais no domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String	|Condicional| 	0|	2|

**Regras:**

* Não pode ser preenchido se o campo [stAnimaisNoDomicilio](#8-stanimaisnodomicilio) = `false`.
* Não pode ser preenchido se o campo [statusTermoRecusaCadastroDomiciliarAtencaoBasica](#9-statustermorecusacadatrodomiciliaratencaobasica) = `true`.

### \#8	stAnimaisNoDomicilio
Marcador que indica se existem animais no domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Condicional| 	-	| - |

**Regras:**

* Não pode ser preenchido se o campo [statusTermoRecusaCadastroDomiciliarAtencaoBasica](#9-statustermorecusacadatrodomiciliaratencaobasica) = `true`.

### \#9	statusTermoRecusaCadatroDomiciliarAtencaoBasica
Marcador que indica se o cadastro foi utilizado o termo de recusa de cadastro do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

### \#10	tpCdsOrigem
Tipo de origem dos dados do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Integer|	Sim|	1|	1|

**Regras:** Utilizar valor 3 (sistemas terceiros).

### \#11	uuid
Código UUID para identificar a ficha na base de dados nacional.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	3|	44|

**Regras:** É recomendado concatenar o CNES na frente do UUID, de modo que os 7 digitos (CNES) + 1 de hífen somados aos 3 (32 caracteres + 4 hífen) do UUID são a limitação de 44 bytes do campo. Formato canônico.

**Referências:** Para ver a referência sobre o UUID, acesse: [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier).

### \#12	uuidFichaOriginadora
Código UUID para identificar a ficha que deu origem ao cadastro do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	3|	44|

**Regras:** Se for uma ficha de atualização, deve ser preenchido com o UUID da ficha que deu origem ao registro. Se for uma ficha de cadastro, este campo deve ser igual ao campo [UUID](#11-uuid).

**Referências:** Para ver a referência sobre o UUID, acesse: [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier).

### \#13	identificacaoImovel
Condições de moradia do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
| ---| --- |---  | --- |
| identificacaoImovel	| Condicional	| - |	-	|

**Regras:** Não devem ser preenchidos se o campo [statusTermoRecusaCadastroDomiciliarAtencaoBasica](#9-statustermorecusacadatrodomiciliaratencaobasica) = `true`.

### \#14	identificacaoResponsavelTecnico
Condições de moradia do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
| --- | --- | ---  | --- |
| identificacaoResponsavelTecnico	| Condicional	| - | - |

**Regras:** 

* Só podem ser preenchidos quando o campo [tipoDeImovel](#1-tipodeimovel) = 07 Abrigo, 08 Instituição de longa permanência para idosos, 09 Unidade prisional, 10 Unidade de medida socioeducativa e 11 Delegacia.
* Não devem ser preenchidos se o campo [statusTermoRecusaCadastroDomiciliarAtencaoBasica](#9-statustermorecusacadatrodomiciliaratencaobasica) = `true`.

### \#15 unicaLotacao
Informações sobre o profissional e a data do cadastro.

| Tipo | Obrigatório | Mínimo | Máximo |
| ---| --- |---  | --- |
| unicaLotacao|	Sim|	-|	-|

**Referências:** [unicaLotacao]({% url profissional %}#unicalotacao)

## identificacaoImovel

### \#1 tipoDeImovel
Indica o tipo de imóvel do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Referências:** [tipoDeImovel]({% url dicionario %}#tipodeimovel).

### \#2 nomeInstituicaoPermanencia
Indica o nome da instituição de permanência.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional | 0 | 100 |

**Regras:** Só pode ser preenchido quando o campo [tipoDeImovel](#1-tipodeimovel) = 07 Abrigo, 08 Instituição de longa permanência para idosos, 09 Unidade prisional, 10 Unidade de medida socioeducativa e 11 Delegacia.

### \#3 stOutrosProfissionaisVinculados

Marcador que indica se existem outros profissional de saúde vinculados à instituição (não inclui profissionais da rede pública de saúde).

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

**Regras:** Só pode ser preenchido quando o campo [tipoDeImovel](#1-tipodeimovel) = 07 Abrigo, 08 Instituição de longa permanência para idosos, 09 Unidade prisional, 10 Unidade de medida socioeducativa e 11 Delegacia.

## identificacaoResponsavelTecnico

### \#1 nomeResponsavelTecnico
Indica o nome do responsável técnico da instituição de permanência.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim | 3 | 70 |

**Regras:** Requerido espaço em branco para indicar o sobrenome.

### \#2 cnsResponsavelTecnico
Indica o CNS do responsável técnico da instituição de permanência.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim | 15 | 15 |

### \#3 cargoInstituicao
Indica o cargo do responsável técnico da instituição de permanência.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não | 0 | 100 |

### \#4 contatoResponsavelTecnico
Indica o telefone para contato do responsável técnico da instituição de permanência.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não | 0 | 100 |

## FamiliaRow

### \#1	dataNascimentoResponsavel
Data de nascimento, no formato epoch time, do cidadão responsável pela família.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Referências:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milisegundos.

### \#2	numeroCnsResponsavel
CNS do responsável familiar.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	15|	15|

**Referências:** Para ver o algoritmo utilizado, acesse: [Cartão Net Datasus](http://cartaonet.datasus.gov.br/), em "Downloads" baixe o arquivo de rotina de validação Java.

### \#3	numeroMembrosFamilia
Quantidade de membros do núcleo familiar.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Interger|	Não|	0|	2|

### \#4	numeroProntuario
Código do prontuário familiar na UBS.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	0|	30|

**Regras:** Apenas letras e números.

### \#5	rendaFamiliar
Código da renda familiar em salários mínimos.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Referências:** [RendaFamiliar]({% url dicionario %}#rendafamiliar)

### \#6	resideDesde
Mês e ano que a família começou a residir no domicílio, no formato epoch time.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Referências:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milisegundos.

### \#7	stMudanca
Marcador que indica se a familia mudou-se.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

## EnderecoLocalPermanencia

### \#1	bairro
Bairro onde está localizado o domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	0|	72|

### \#2	cep
CEP do logradouro do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
| String|	Sim|	8|	8|

**Regras:**	Apenas números.

### \#3	codigoIbgeMunicipio
Código IBGE do município.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	-|	-|

**Referências:** [Municipios]({% url municipios %})

### \#4	complemento
Complemento do endereço do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	0|	30|

### \#5	nomeLogradouro
Nome do logradouro.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	0|	72|

### \#6	numero
Número do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	1|	10|

**Regras:**

* Apenas letras e números.
* Não pode ser preenchido caso [stSemNumero](#11-stsemnumero) = `true`.

### \#7	numeroDneUf
Código indexador referente a Unidade Federativa.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	-|	-|

**Referências:** [Estados]({% url referencias %}#uf)

### \#8	telReferencial
Telefone de referência.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	10|	11|

**Regras:** Mínimo 10 dígitos, máximo 11 (DDD + 8 ou 9).

### \#9	telContato
Telefone para contato.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	10|	11|

**Regras:** Mínimo 10 dígitos, máximo 11 (DDD + 8 ou 9).

### \#10	tipoLogradouroNumeroDne
Tipo do logradouro onde está o domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Sim|	-|	-|

**Regras:** Deve ser informado o código DNE.

**Referências:** [TipoLogradouro]({% url referencias %}#tipo-de-logradouro)

### \#11	stSemNumero
Marcador que indica que o domicílio não possui número.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

### \#12	pontoReferencia
Marcador que indica que o domicílio não possui número.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String |	Não|	0|	40|

### \#13 microarea

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional | 2 | 2 |

**Regras:** Não deve ser preenchido se o campo [foraArea](#14-foraarea) = `true`. Caso contrário, o preenchimento é obrigatório.

### \#14 stforaArea
Marcador que indica que o cidadão está fora da área.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

##CondicaoMoradia

### \#1	abastecimentoAgua
Código do tipo de abastecimento de água.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Referências:** [AbastecimentoDeAgua]({% url dicionario %}#abastecimentodeagua)

### \#2	areaProducaoRural
Código da condição de posse e uso da terra.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Condicional | 	-|	-|

**Regras:** 

* Preenchimento obrigatório caso o campo [Localização](#5-localizacao) = `84 (rural)`.
* Não deve ser preenchido se o campo [tipoDeImovel](#1-tipodeimovel) = 07 Abrigo, 08 Instituição de longa permanência para idosos, 09 Unidade prisional, 10 Unidade de medida socioeducativa e 11 Delegacia.

**Referências:** [CondicaoDePosseEUsoDaTerra]({% url dicionario %}#condicaodeposseeusodaterra)

### \#3	destinoLixo
Código do destino do lixo.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Referências:** [DestinoDoLixo]({% url dicionario %}#destinodolixo)

### \#4	formaEscoamentoBanheiro
Código da forma de escoamento do banheiro ou sanitário.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Referências:** [FormaDeEscoamentoDoBanheiroOuSanitario]({% url dicionario %}#formadeescoamentodobanheiroousanitario)

### \#5	localizacao
Código do localização do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Referências:** [LocalizacaoDaMoradia]({% url dicionario %}#localizacaodamoradia)

### \#6	materialPredominanteParedesExtDomicilio
Código do tipo de material predominante nas paredes externas do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Regras:** Não deve ser preenchido se o campo [tipoDeImovel](#1-tipodeimovel) = 07 Abrigo, 08 Instituição de longa permanência para idosos, 09 Unidade prisional, 10 Unidade de medida socioeducativa e 11 Delegacia.
**Referências:** [MaterialPredominanteNaConstrucao]({% url dicionario %}#materialpredominantenaconstrucao)

### \#7	nuComodos
Número de cômodos do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	0|	2|

**Regras:** Não deve ser preenchido se o campo [tipoDeImovel](#1-tipodeimovel) = 07 Abrigo, 08 Instituição de longa permanência para idosos, 09 Unidade prisional, 10 Unidade de medida socioeducativa e 11 Delegacia.

### \#8	nuMoradores
Número de moradores do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|String|	Não|	0|	4|

### \#9 situacaoMoradiaPosseTerra
Código da situação de moradia ou de posse da terra.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|


**Regras:** Não devem ser preenchidos se o campo [tipoDeImovel](#1-tipodeimovel) = 07 Abrigo, 08 Instituição de longa permanência para idosos, 09 Unidade prisional, 10 Unidade de medida socioeducativa e 11 Delegacia.
**Referências:** [SituacaoDeMoradia]({% url dicionario %}#situacaodemoradia)

### \#10 stDiponibilidadeEnergiaeletrica
Marcador que indica se existe disponibilidade de energia elétrica.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Boolean|	Não|	-|	-|

### \#11 tipoAcessoDomicilio
Código do tipo de acesso ao domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Regras:** Não deve ser preenchido se o campo [tipoDeImovel](#1-tipodeimovel) = 07 Abrigo, 08 Instituição de longa permanência para idosos, 09 Unidade prisional, 10 Unidade de medida socioeducativa e 11 Delegacia.
**Referências:** [TipoDeAcessoAoDomicilio]({% url dicionario %}#tipodeacessoaodomicilio)

### \#12 tipoDomicilio
Código do tipo de domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Regras:** Não deve ser preenchido se o campo [tipoDeImovel](#1-tipodeimovel) = 07 Abrigo, 08 Instituição de longa permanência para idosos, 09 Unidade prisional, 10 Unidade de medida socioeducativa e 11 Delegacia.
**Referências:** [TipoDeDomicilio]({% url dicionario %}#tipodedomicilio)

### \#13 AguaConsumoDomicilio
Código do tipo do tratamento de água do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Não|	-|	-|

**Referências:** [AguaConsumoDomicilio]({% url dicionario %}#aguaconsumodomicilio)