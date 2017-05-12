---
layout: doc
title: Ficha de Visita Domiciliar e Territorial
id: dicionario-fvd
order: 6
---


## FichaVisitaDomiciliarMaster

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

**Regras:** Utilizar valor 3 (sistemas terceiros).

### \#3 headerTransport
Profissional que realizou a visita.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|UnicaLotacaoHeader |Sim |- |- |

**Regras:** Somente as CBOs apresentadas na [Tabela 7 - CBOs que podem registrar ficha de visita domiciliar e territorial]({% url cbo %}#ficha-de-visita-domiciliar-e-territorial) podem ser adicionadas no campo CBO do profissional.

**Referências:** [UnicaLotacaoHeader]({% url headerTransport %}#unicalotacaoheader).

### \#4 visitasDomiciliares
Lista de Fichas de Visita Domiciliar e Territorial.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<FichaVisitaDomiciliarChild\> |Sim |0 |99 |

**Referências:** [FichaVisitaDomiciliarChild](#fichavisitadomiciliarchild).

## FichaVisitaDomiciliarChild

### \#1 turno
Código do turno onde aconteceu o atendimento.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Referências:** [Turno]({% url dicionario %}#turno).

### \#2 numProntuario
Número do prontuário do cidadão na UBS.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |0 |30 |

**Regras:** 

* Somente letras e números;
* Não deve ser preenchido se o campo [tipoDeImovel](#11-tipodeimovel) = `02` comércio, `03` terreno baldio, `04` Ponto Estratégico, `05` Escola, `06` Creche ou `12` Estabelecimento religioso.

### \#3 cnsCidadao
CNS do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |15 |15 |

**Regras:**

* Validado pelo algoritmo;
* Não deve ser preenchido se o campo [tipoDeImovel](#11-tipodeimovel) = `02` comércio, `03` terreno baldio, `04` Ponto Estratégico, `05` Escola, `06` Creche ou `12` Estabelecimento religioso.
* Para visita periódica ou visita domiciliar para controle vetorial preencher este campo com o CNS do responsável familiar.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#4 dtNascimento
Data de nascimento do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** 

* Não pode ser posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento) e anterior a 130 anos a partir da [dataAtendimento]({% url headerTransport %}#5-dataatendimento);
* Não deve ser preenchido se o campo [tipoDeImovel](#11-tipodeimovel) = `02` comércio, `03` terreno baldio, `04` Ponto Estratégico, `05` Escola, `06` Creche ou `12` Estabelecimento religioso.
* É de preenchimento obrigatório somente se [tipoDeImovel](#11-tipodeimovel) = `01` Domicílio, `07` Abrigo, `08` Instituição de longa permanência para idosos, `09` Unidade prisional, `10` Unidade de medida sócio educativa, `11` Delegacia ou `99` Outros **e** pelo menos uma das condições a seguir seja obedecida:
	
	- Campo [motivosVisita](#7-motivosvisita) possuir qualquer opção dos grupos `#BUSCA_ATIVA` ou `#ACOMPANHAMENTO` inserida;
	- Campo [motivosVisita](#7-motivosvisita) possuir pelo menos uma das opções `25`	Egresso de internação ou `31` Orientação / Prevenção inseridas;
	- Pelo menos um dos campos [pesoAcompanhamentoNutricional](#12-pesoacompanhamentonutricional) e [alturaAcompanhamentoNutricional](#13-alturaacompanhamentonutricional) for preenchido.

**Referências:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milissegundos.

### \#5 sexo
Código do sexo do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:**

* Não deve ser preenchido se o campo [tipoDeImovel](#11-tipodeimovel) = `02` comércio, `03` terreno baldio, `04` Ponto Estratégico, `05` Escola, `06` Creche ou `12` Estabelecimento religioso.
* É de preenchimento obrigatório somente se [tipoDeImovel](#11-tipodeimovel) =`01` Domicílio, `07` Abrigo, `08` Instituição de longa permanência para idosos, `09` Unidade prisional, `10` Unidade de medida sócio educativa, `11` Delegacia ou `99` Outros **e** pelo menos uma das condições a seguir seja obedecida:
	
	- Campo [motivosVisita](#7-motivosvisita) possuir qualquer opção dos grupos `#BUSCA_ATIVA` ou `#ACOMPANHAMENTO` inserida;
	- Campo [motivosVisita](#7-motivosvisita) possuir pelo menos uma das opções `25` Egresso de internação ou `31` Orientação / Prevenção inseridas;
	- Pelo menos um dos campos [pesoAcompanhamentoNutricional](#12-pesoacompanhamentonutricional) e [alturaAcompanhamentoNutricional](#13-alturaacompanhamentonutricional) estiver preenchido.


**Referências:** [Sexo]({% url dicionario %}#sexo).

### \#6 statusVisitaCompartilhadaOutroProfissional
Marcador que indica se a visita foi compartilhada com outro profissional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#7 motivosVisita
Código dos motivos da visita.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<Long\> |Condicional |0 |36 |

**Regras:**

* Não deve ser preenchido caso o campo [desfecho](#8-desfecho) = `3` Ausente ou `2` Visita Recusada;;

* Se o campo [tipoDeImovel](#11-tipodeimovel) = `02` comércio, `03` terreno baldio, `04` Ponto Estratégico, `05` Escola, `06` Creche ou `12` Estabelecimento religioso, então as opções selecionadas deste campo só podem ser:

	- `1` Cadastramento / Atualização;
	- `34` Ação educativa;
	- `35` Imóvel com foco;
	- `36` Ação mecânica;
	- `37` Tratamento focal;
	- `27` Convite para atividades coletivas / campanha de saúde;
	- `31` Orientação / Prevenção;
	- `28` Outros.

**Referências:** [MotivoVisita]({% url dicionario %}#motivovisita).

### \#8 desfecho
Código dos resultados da ação de visita.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Referências:** [Desfecho]({% url dicionario#desfecho %}).

### \#9 microarea

Microárea na qual o cidadão se encontra.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional | 2 | 2 |

**Regras:** Não deve ser preenchido se o campo [stForaArea](#10-stforaarea) = `true`. Caso contrário, o preenchimento é obrigatório.


### \#10 stForaArea
Marcador que indica que o cidadão está fora da área.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |


### \#11 tipoDeImovel
Indica o tipo de imóvel do domicílio.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Long|	Sim|	-|	-|

**Referências:** [tipoDeImovel]({% url dicionario %}#tipodeimovel).

### \#12 pesoAcompanhamentoNutricional
Peso do cidadão em Quilogramas.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Double|	Não|	1|	7|

**Regras:**

* Apenas números e vírgula (`,`);
* Máximo de 3 números após a vírgula;
* Valor mínimo 0,5 e máximo 500;
* Não deve ser preenchido se o campo [tipoDeImovel](#11-tipodeimovel) = `02` comércio, `03` terreno baldio, `04` Ponto Estratégico, `05` Escola, `06` Creche ou `12` Estabelecimento religioso.
* Não deve ser preenchido caso o campo [desfecho](#8-desfecho) = `3` Ausente ou `2` Visita Recusada;

### \#13 alturaAcompanhamentoNutricional
Altura do cidadão em centímetros.

| Tipo | Obrigatório | Mínimo | Máximo |
|---| --- |---  | --- |
|Double|	Não|	2|	5|

**Regras:**

* Apenas números e vírgula (`,`);
* Máximo de 1 número após a vírgula;
* Valor mínimo 20 e máximo 250;
* Não deve ser preenchido se o campo [tipoDeImovel](#11-tipodeimovel) = `02` comércio, `03` terreno baldio, `04` Ponto Estratégico, `05` Escola, `06` Creche ou `12` Estabelecimento religioso.
* Não deve ser preenchido caso o campo [desfecho](#8-desfecho) = `3` Ausente ou `2` Visita Recusada;