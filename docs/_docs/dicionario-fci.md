---
layout: doc
title: Ficha de Cadastro Individual
id: dicionario-fci
order: 0
---

## CadastroIndividual

### \#1 condicoesDeSaude
Formulário referente as condições de saúde do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|CondicoesDeSaude |Condicional |- |- |

**Regras:** Não deve ser preenchido se o campo [statusTermoRecusaCadastroIndividualAtencaoBasica](\#6-statustermorecusacadastroindividualatencaobasica) = `true`.

**Referências:** [CondicoesDeSaude](#condicoesdesaude).

### \#2 emSituacaoDeRua
Formulário referente a informações de situação de rua (se o cidadão se encontrar nessa situação).

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|EmSituacaoDeRua |Condicional |- |- |

**Regras:** Não deve ser preenchido se o campo [statusTermoRecusaCadastroIndividualAtencaoBasica](#6-statustermorecusacadastroindividualatencaobasica) = `true`.

**Referências:** [EmSituacaoDeRua](#emsituacaoderua).

### \#3 fichaAtualizada
Marcador que indica se a ficha é uma atualização.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Sim |- |- |

**Observação:** Caso seja uma ficha de atualização, o campo [uuidFichaOriginadora](#9-uuidfichaoriginadora) deve ser preenchido com o UUID da ficha que deu origem ao registro.

### \#4 identificacaoUsuarioCidadao
Dados que identificam o cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|IdentificacaoUsuarioCidadao |Condicional |- |- |

**Regras:** Opcional se o campo [statusTermoRecusaCadastroIndividualAtencaoBasica](#6-statustermorecusacadastroindividualatencaobasica) = `true`.

**Referências:** [IdentificacaoUsuarioCidadao](#identificacaousuariocidadao).

### \#5 informacoesSocioDemograficas
Informações sócio-demográficas fornecidas pelo cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|InformacoesSocioDemograficas |Condicional |- |- |

**Regras:** Não deve ser preenchido se o campo [statusTermoRecusaCadastroIndividualAtencaoBasica](#6-statustermorecusacadastroindividualatencaobasica) = `true`.

**Referências:** [InformacoesSocioDemograficas](#informacoessociodemograficas)

### \#6 statusTermoRecusaCadastroIndividualAtencaoBasica
Marcador que indica se o termo de recusa foi assinalado.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#7 tpCdsOrigem
Tipo de origem dos dados do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Integer |Sim |1 |1 |

**Regras:** Utilizar valor 3 (sistemas terceiros).

### \#8 uuid
Código UUID para identificar a ficha na base de dados nacional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional |36 |44 |

**Regras:** É recomendado concatenar o CNES na frente do UUID, de modo que os 7 dígitos (CNES) + 1 de hífen somados aos 36 (32 caracteres + 4 hífen) do UUID são a limitação de 44 bytes do campo. Formato canônico.

**Referências:** Para ver a referência sobre o UUID, acesse: [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier).

### \#9 uuidFichaOriginadora
Código UUID para identificar a ficha que deu origem ao cadastro do registro.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |36 |44 |

**Regras:** Se for uma ficha de atualização, deve ser preenchido com o UUID da ficha que deu origem ao registro. Se for a ficha de cadastro, este campo deve ser igual ao campo uuid.

**Referências:** Para ver a referência sobre o UUID, acesse: [UUID Wikipedia](https://en.wikipedia.org/wiki/Universally_unique_identifier).

### \#10 saidaCidadaoCadastro
Dados referentes ao profissional e a data do cadastro.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|SaidaCidadaoCadastro |Não |- |- |

**Referências:** [SaidaCidadaoCadastro](#saidacidadaocadastro).

### \#11 headerTransport
Dados referentes ao profissional e a data do cadastro.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|UnicaLotacaoHeader |Sim |- |- |

**Regras:** Somente as CBOs apresentadas na [Tabela 1 - CBOs que podem registrar ficha de cadastro individual]({% url cbo %}#ficha-de-cadastro-individual) podem ser adicionadas no campo CBO do profissional.

**Referências:** [UnicaLotacaoHeader]({% url headerTransport %}#unicalotacaoheader).

## CondicoesDeSaude

### \#1 descricaoCausaInternacaoEm12Meses
Descrição da causa de internação do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional |0 |100 |

Observação: Não deve ser preenchido se o campo [statusTeveInternadoem12Meses](#27-statusteveinternadoem12meses) = `false`.

### \#2 descricaoOutraCondicao1
Condição de saúde informada pelo cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |0 |100 |

### \#3 descricaoOutraCondicao2
Condição de saúde informada pelo cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |0 |100 |

### \#4 descricaoOutraCondicao3
Condição de saúde informada pelo cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |0 |100 |

### \#5 descricaoPlantasMedicinaisUsadas
Descrição das plantas medicinais utilizadas.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |0 |100 |

**Regras:** Não deve ser preenchido se o campo [statusUsaPlantasMedicinais](#29-statususaplantasmedicinais) = `false`.

### \#6 doencaCardiaca
Código das doenças cardíacas que o cidadão informou.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<Long\> |Condicional |0 |3 |

**Regras:**

* Requerido preenchimento de pelo menos um item se o campo [statusTeveDoencaCardiaca](#25-statustevedoencacardiaca) = `true`;
* Não deve ser preenchido se o campo [statusTeveDoencaCardiaca](#25-statustevedoencacardiaca) = `false`.

**Referências:** [DoencaCardiaca]({% url dicionario %}#doencacardiaca).

### \#7 doencaRespiratoria
Código das doenças respiratórias que o cidadão informou.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<Long\> |Condicional |0 |4 |

**Regras:**

* Requerido preenchimento de pelo menos um item se o campo [statusTemDoencaRespiratoria](#18-statustemdoencarespiratoria) = `true`;
*  Não deve ser preenchido o campo [statusTemDoencaRespiratoria](#18-statustemdoencarespiratoria) = `false`.

**Referências:** [DoencaRespiratoria]({% url dicionario %}#doencarespiratoria).

### \#8 doencaRins
Código das doenças renais que o cidadão informou.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<Long\> |Condicional |0 |3 |

**Regras:**

* Requerido preenchimento de pelo menos um item se o campo [statusTemTeveDoencasRins](#22-statustemtevedoencasrins) = `true`;
* Não deve ser preenchido se o campo [statusTemTeveDoencasRins](#22-statustemtevedoencasrins) = `false`.

**Referências:** [ProblemaRins]({% url dicionario %}#problemarins).

### \#9 maternidadeDeReferencia
Nome da maternidade de referência.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |0 |100 |

**Regras:** Não pode ser preenchido se o campo [statusEhGestante](#14-statusehgestante) = `false`.

### \#10 situacaoPeso
Código da situação referente ao peso corporal.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Referências:** [ConsideracaoPeso]({% url dicionario %}#consideracaopeso).

### \#11 statusEhDependenteAlcool
Marcador se o cidadão faz uso de álcool.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#12 statusEhDependenteOutrasDrogas
Marcador se o cidadão faz uso de outras drogas.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#13 statusEhFumante
Marcador se o cidadão é fumante.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#14 statusEhGestante
Marcador se a cidadã está gestante.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

**Regras:** Não pode ser preenchido se:

* Campo [sexoCidadao](#15-sexocidadao) = `0 - Masculino`;
* Campo [dataNascimentoCidadao](#3-datanascimentocidadao) for menor que 9 anos ou maior que 60 anos a partir da [dataAtendimento]({% url headerTransport %}#5-dataatendimento).

### \#15 statusEstaAcamado
Marcador se o cidadão está acamado.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#16 statusEstaDomiciliado
Marcador se o cidadão está domiciliado.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#17 statusTemDiabetes
Marcador se o cidadão tem diabetes.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#18 statusTemDoencaRespiratoria
Marcador se o cidadão tem doença respiratória.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#19 statusTemHanseniase
Marcador se o cidadão tem hanseníase.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#20 statusTemHipertensaoArterial
Marcador se o cidadão tem hipertensão arterial.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#21 statusTemTeveCancer
Marcador se o cidadão tem ou teve câncer.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#22 statusTemTeveDoencasRins
Marcador se o cidadão tem ou teve doenças nos rins.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#23 statusTemTuberculose
Marcador se o cidadão tem tuberculose.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#24 statusTeveAvcDerrame
Marcador se o cidadão teve AVC.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#25 statusTeveDoencaCardiaca
Marcador se o cidadão teve doença cardíaca.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#26 statusTeveInfarto
Marcador se o cidadão teve infarto.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#27 statusTeveInternadoem12Meses
Marcador se o cidadão esteve internado nos últimos 12 meses.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#28 statusUsaOutrasPraticasIntegrativasOuComplementares
Marcador se o cidadão utiliza outras práticas integrativas complementares.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#29 statusUsaPlantasMedicinais
Marcador se o cidadão utiliza plantas medicinais.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#30 statusDiagnosticoMental
Marcador que indica se o cidadão teve diagnóstico de problema mental.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

## EmSituacaoDeRua

### \#1 grauParentescoFamiliarFrequentado
Grau de parentesco do familiar que frequenta.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional |0 |100 |

**Regras:**

* Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`;
* Não pode ser preenchido se o campo [statusVisitaFamiliarFrequentemente](#11-statusvisitafamiliarfrequentemente) = `false`.

### \#2 higienePessoalSituacaoRua
Código das condições de higiene que o cidadão tem acesso.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<Long\> |Condicional |0 |4 |

**Regras:**

* Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`;
* Requerido preenchimento de pelo menos um item se o campo [statusTemAcessoHigienePessoalSituacaoRua](#10-statustemacessohigienepessoalsituacaorua) = `true`.

**Referências:** [AcessoHigiene]({% url dicionario %}#acessohigiene).

### \#3 origemAlimentoSituacaoRua
Código da origem da alimentação do cidadão em situação de rua.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<Long\> |Não |0 |5 |

**Regras:** Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`.

**Referências:** [OrigemAlimentacao]({% url dicionario %}#origemalimentacao).

### \#4 outraInstituicaoQueAcompanha
Nome de outra instituição que acompanha o cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |0 |100 |

**Regras:**

* Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`;
* Não pode ser preenchido se o campo [statusAcompanhadoPorOutraInstituição](#6-statusacompanhadoporoutrainstituicao) = `false`.

### \#5 quantidadeAlimentacoesAoDiaSituacaoRua
Código da quantidade de vezes que o cidadão se alimenta por dia.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Regras:** Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`.

**Referências:** [QuantasVezesAlimentacao]({% url dicionario %}#quantasvezesalimentacao).

### \#6 statusAcompanhadoPorOutraInstituicao
Marcador que indica se o cidadão é acompanhado por outra instituição.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

**Regras:** Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`.

### \#7 statusPossuiReferenciaFamiliar
Marcador que indica se o cidadão possuiu alguma referência familiar.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

**Regras:** Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`.

### \#8 statusRecebeBeneficio
Marcador que indica se o cidadão recebe algum benefício.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

**Regras:** Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`.

### \#9 statusSituacaoRua
Marcador que indica se o cidadão está em situação de rua.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Sim |- |- |

### \#10 statusTemAcessoHigienePessoalSituacaoRua
Marcador que indica se o cidadão tem acesso a higiene pessoal.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

**Regras:** Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`.

### \#11 statusVisitaFamiliarFrequentemente
Marcador que indica se o cidadão visita algum familiar frequentemente.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

**Regras:** Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`.

### \#12 tempoSituacaoRua
Código do tempo que o cidadão está em situação de rua.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Regras:** Não pode ser preenchido se o campo [statusSituacaoRua](#9-statussituacaorua) = `false`.

**Referências:** [TempoSituacaoDeRua]({% url dicionario %}#temposituacaoderua).

## IdentificacaoUsuarioCidadao

### \#1 nomeSocial
Nome social do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |0 |70 |

**Regras:** Somente texto e apóstrofo (`'`).

### \#2 codigoIbgeMunicipioNascimento
Código IBGE do município.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional |7 |7 |

**Regras:** Só pode ser preenchido se o campo [nacionalidadeCidadao](#6-nacionalidadecidadao) = `1` (Brasileiro). Neste caso é de preenchimento obrigatório.

**Referências:** [Municipios]({% url municipios %}).

### \#3 dataNascimentoCidadao
Data de nascimento do cidadão no formato epoch time.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Regras:** Não pode ser posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento) ou mais anterior que 130 anos a partir da [dataAtendimento]({% url headerTransport %}#5-dataatendimento).

**Referências:** [Epoch Wikipedia](https://pt.wikipedia.org/wiki/Era_Unix) em milissegundos.

### \#4 desconheceNomeMae
Marcador que indica que o cidadão desconhece o nome da mãe

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#5 emailCidadao
E-mail do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |6 |100 |

**Regras:** Requerido seguir o padrão `endereco@domínio.extensao`.

### \#6 nacionalidadeCidadao
Código do marcador que indica se o cidadão é brasileiro, naturalizado ou estrangeiro.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Referências:** [Nacionalidade]({% url dicionario %}#nacionalidade).

### \#7 nomeCidadao
Nome completo do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Sim |3 |70 |

**Regras:** As regras de validação de um nome estão descritas em {% link validar_nome %}.

### \#8 nomeMaeCidadao
Nome da mãe do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional |3 |70 |

**Regras:**

* As regras de validação de um nome estão descritas em {% link validar_nome %};
* Não deve ser preenchido se o campo [desconheceNomeMae](#4-desconhecenomemae) = `true`.

### \#9 cnsCidadao
CNS do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |15 |15 |

**Regras:** Validado por algoritmo.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#10 cnsResponsavelFamiliar
CNS do responsável do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |15 |15 |

**Regras:**

* Validado por algoritmo;
* Só pode ser preenchido se o campo [statusEhResponsavel](#16-statusehresponsavel) = `false`.

**Referências:** O algoritmo de validação está presente em {% link algoritmo_CNS %}.

### \#11 telefoneCelular
Número de celular do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |10 |11 |

**Regras:** Apenas números.

### \#12 numeroNisPisPasep
Número do NIS (PIS / PASEP) do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |11 |11 |

**Regras:** Apenas números.

### \#13 paisNascimento
Código do país de nascimento do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** 

* Só pode ser preenchido se o campo [nacionalidadeCidadao](#6-nacionalidadecidadao) = `3 (Estrangeiro)`. Neste caso o preenchimento é obrigatório;
* Se o campo [nacionalidadeCidadao](#6-nacionalidadecidadao) for igual a `1 (Brasileira)`, este campo deve ser preenchido com `31 (BRASIL)`.

**Referências:** [País]({% url referencias %}#pa-s).

### \#14 racaCorCidadao
Código da raça / cor do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Referências:** [RacaCor]({% url dicionario %}#racacor).

### \#15 sexoCidadao
Código do sexo do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Sim |- |- |

**Referências:** [Sexo]({% url dicionario %}#sexo).

### \#16 statusEhResponsavel
Marcador que indica se o cidadão é responsável familiar.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

## \#17 etnia
Etnia do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |-|- |

**Regras:** Só deve ser preenchido se o campo [racaCorCidadao](#14-racacorcidadao) = `5`. Neste caso o preenchimento é obrigatório.

**Referências:** [etnia]({% url dicionario %}#etnia).

### \#18 nomePaiCidadao
Nome do pai do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional |3 |70 |

**Regras:**

* As regras de validação de um nome estão descritas em {% link validar_nome %};
* Não deve ser preenchido se o campo [desconheceNomePai](#19-desconhecenomepai) = `true`. Caso contrário, o preenchimento é obrigatório.

### \#19 desconheceNomePai
Marcador que indica que o cidadão desconhece o nome do pai.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#20 dtNaturalizacao
Data de naturalização do cidadão no formato epoch time.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:**

* Só deve ser preenchido se o campo [nacionalidadeCidadao](#6-nacionalidadecidadao) = `2`. Neste caso, é de preenchimento obrigatório;
* Não pode ser posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento);
* Não pode ser anterior a [dataNascimentoCidadao](#3-datanascimentocidadao).

### \#21 portariaNaturalizacao
Portaria de naturalização do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional |0 |16 |

**Regras:** Só deve ser preenchido se o campo [nacionalidadeCidadao](#6-nacionalidadecidadao) = `2`. Neste caso o preenchimento é obrigatório.

### \#22 dtEntradaBrasil
Data em que o cidadão entrou no Brasil. 

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:**

* Só deve ser preenchido se o campo [nacionalidadeCidadao](#6-nacionalidadecidadao) = `3`. Neste caso o preenchimento é obrigatório;
* Não pode ser posterior a [dataAtendimento]({% url headerTransport %}#5-dataatendimento);
* Não pode ser anterior a [dataNascimentoCidadao](#3-datanascimentocidadao).

### \#23 microarea

Microárea na qual o cidadão se encontra.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Condicional | 2 | 2 |

**Regras:** Não deve ser preenchido se o campo [stForaArea](#24-stforaarea) = `true`. Caso contrário, o preenchimento é obrigatório.


### \#24 stForaArea
Marcador que indica que o cidadão está fora da área.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |


## InformacoesSocioDemograficas

### \#1 deficienciasCidadao
Código das deficiências que o cidadão possui.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<Long\> |Condicional |1 |5 |

**Regras:**

* Requerido preenchimento de pelo menos um item se o campo [statusTemAlgumaDeficiencia](#14-statustemalgumadeficiencia) = `true`;
* Não deve ser preenchido se o campo [statusTemAlgumaDeficiencia](#14-statustemalgumadeficiencia) = `false`.

**Referências:** [DeficienciaCidadao]({% url dicionario %}#deficienciacidadao).

### \#2 grauInstrucaoCidadao
Código do curso mais elevado que o cidadão frequenta ou frequentou.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Referências:** [CursoMaisElevado]({% url dicionario %}#cursomaiselevado).

### \#3 ocupacaoCodigoCbo2002
Código do CBO que representa a ocupação do cidadão.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |6 |6 |

**Regras:**

* Deve ser um código de CBO válido.

**Referências:** [CBO]({% url cbo %}).

### \#4 orientacaoSexualCidadao
Código da orientação sexual informada pelo cidadão.  

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Regras:** Não pode ser preenchido se o campo [statusDesejaInformarOrientacaoSexual](#8-statusdesejainformarorientacaosexual) = `false`.

**Referências:** [OrientacaoSexual]({% url dicionario %}#orientacaosexual).

### \#5 povoComunidadeTradicional
Nome da comunidade tradicional que o cidadão pertence.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |0 |100 |

**Regras:** Não deve ser preenchido se o campo [statusMembroPovoComunidadeTradicional](#11-statusmembropovocomunidadetradicional) = `false`.

### \#6 relacaoParentescoCidadao
Código da relação de parentesco com o responsável familiar.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Regras:** Só pode ser preenchido se o campo [statusEhResponsavel](#16-statusehresponsavel) = `false`.

**Referências:** [RelacaoParentesco]({% url dicionario %}#relacaoparentesco).

### \#7 situacaoMercadoTrabalhoCidadao
Código da situação do cidadão no mercado de trabalho.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Referências:** [SituacaoMercadoTrabalho]({% url dicionario %}#situacaomercadotrabalho).

### \#8 statusDesejaInformarOrientacaoSexual
Marcador que indica se o cidadão deseja informar sua orientação sexual.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#9 statusFrequentaBenzedeira
Marcador que indica se o cidadão frequenta cuidador tradicional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#10 statusFrequentaEscola
Marcador que indica se o cidadão frequenta escola ou creche.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Sim |- |- |

### \#11 statusMembroPovoComunidadeTradicional
Marcador que indica se o cidadão é membro de um povo ou comunidade tradicional.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#12 statusParticipaGrupoComunitario
Marcador que indica se o cidadão participa de algum grupo comunitário.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#13 statusPossuiPlanoSaudePrivado
Marcador que indica se o cidadão possui plano de saúde privado.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#14 statusTemAlgumaDeficiencia
Marcador que indica se cidadão tem alguma deficiência.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Sim |- |- |

### \#15 identidadeGeneroCidadao
Código da identidade de gênero informada pelo cidadão.  

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Regras:** Não pode ser preenchido se o campo [statusDesejaInformarIdentidadeGenero](#16-statusdesejainformaridentidadegenero) = `false`.

**Referências:** [identidadeGeneroCidadao]({% url dicionario %}#identidadegenerocidadao).

### \#16 statusDesejaInformarIdentidadeGenero

Marcador que indica se o cidadão deseja informar sua identidade de gênero.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Boolean |Não |- |- |

### \#17 responsavelPorCrianca
Código do responsável por crianças de até 9 anos.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|List\<Long\> |Não | 0 | 6 |

**Regras:** Não pode ser preenchido se a [dataNascimentoCidadao](#3-datanascimentocidadao) for anterior ou igual a 10 anos a partir da [dataAtendimento]({% url headerTransport %}#5-dataatendimento).

**Referências:** [ResponsavelCrianca]({% url dicionario %}#responsavelcrianca).

## SaidaCidadaoCadastro

### \#1 motivoSaidaCidadao
Código do motivo da saída do cidadão do cadastro.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Não |- |- |

**Referências:** [MotivoSaida]({% url dicionario %}#motivosaida).

### \#2 dataObito
Data de óbito do cidadão no formato epoch time.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|Long |Condicional |- |- |

**Regras:** Só pode ser preenchido se o campo [motivoSaidaCidadao](#1-motivosaidacidadao) = `135`. Neste caso o preenchimento é obrigatório.

### \#3 numeroDO
Data de óbito do cidadão no formato epoch time.

| Tipo | Obrigatório | Mínimo | Máximo |
|--- |--- |--- |--- |
|String |Não |9 |9 |

**Regras:** Só pode ser preenchido se o campo [motivoSaidaCidadao](#1-motivosaidacidadao) = `135`.