---
layout: doc
title: Principais alterações da v2.0 para a v2.1
id: principais_alteracoes
order: 20
---

######Este documento consiste em tabelas representando as estruturas de cada ficha que tiveram alterações em relação a versão 2.0 do e-SUS AB (PEC). As tabelas apesentam os campos alterados, mostrando a situação dos mesmos nas versões 2.0 e 2.1, conforme segue abaixo:  

- [Ficha de Cadastro Individual](#ficha-de-cadastro-individual);
- [Ficha de Cadastro Domiciliar e Territorial](#ficha-de-cadastro-domiciliar-e-territorial);
- [Ficha de Atendimento Individual](#ficha-de-atendimento-individual);
- [Ficha de Atendimento Odontológico Individual](#ficha-de-atendimento-odontol-gico-individual);
- [Ficha de Atividade Coletiva](#ficha-de-atividade-coletiva);
- [Ficha de Procedimentos](#ficha-de-procedimentos);
- [Ficha de Visita Domiciliar e Territorial](#ficha-de-visita-domiciliar-e-territorial);
- [Marcadores de Consumo Alimentar](#marcadores-de-consumo-alimentar);
- [Ficha de Avaliação de Elegibilidade](#ficha-de-avalia-o-de-elegibilidade);
- [Ficha de Atendimento Domiciliar](#ficha-de-atendimento-domiciliar);
- [Cabeçalho (headerTransport)](#cabe-alho-headertransport).

**Obs:** As alterações de regras e obrigatoriedade dos campos se encontram descritas nos documentos de cada ficha. 

<br>
<hr>

##Ficha de Cadastro Individual

##### CadastroIndividual

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| HeaderCdsCadastro **dadosGerais** | Não existe |
| Não existe | SaidaCidadaoCadastro **saidaCidadaoCadastro** |
| Não existe | UnicaLotacaoHeader **headerTransport** |

##### CondicoesDeSaude

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| boolean **statusTratamentoPsiquicoOuProblemaMental** | Não existe |
| Não existe  | boolean **statusDiagnosticoMental** |

##### IdentificacaoUsuarioCidadao

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| string **nomeSocialCidadao** | string **nomeSocial** |
| long **dataNascimentoResponsavel** | Não existe |
| string **numeroCartaoSus** | string **cnsCidadao**|
| string **numeroCartaoSusResponsavel** | string **cnsResponsavelFamiliar** |
| string **numeroCelularCidadao** | string **telefoneCelular** |
| Não existe | long **etnia**|
| Não existe | string **nomePaiCidadao**|
| Não existe | boolean **desconheceNomePai**|
| Não existe | long **dtNaturalizacao**|
| Não existe | string **portariaNaturalizacao**|
| Não existe | long **dtEntradaBrasil**|
| Não existe | string **microArea**|
| Não existe | boolean **stForaArea**|


##### InformacoesSocioDemograficas

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| long **motivoSaidaCidadao** | Não existe |
| long **responsavelPorCrianca** | Não existe |
| Não existe |  long **identidadeGeneroCidadao**|
| Não existe |  boolean **statusDesejaInformarIdentidadeGenero**|
| Não existe |  list\<long\> **responsavelPorCrianca**|

##### SaidaCidadaoCadastro (nova estrutura)

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| Não existe   | long **motivoSaidaCidadao** |
| Não existe   | long **dataObito** |
| Não existe   | string **numeroDO** |

##Ficha de Cadastro Domiciliar e Territorial

#####InstituicaoPermanencia (nova estrutura)

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| Não existe | string **nomeInstituicaoPermanencia** |
| Não existe | boolean **stOutrosProfissionaisVinculados**|
| Não existe | string **nomeResponsavelTecnico**|
| Não existe | string **cnsResponsavelTecnico**|
| Não existe | string **cargoInstituicao**|
| Não existe | string **telefoneResponsavelTecnico**|

##### CondicaoMoradia

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| boolean **stDiponibilidadeEnergiaeletrica** | boolean **stDisponibilidadeEnergiaEletrica**|
| long **tratamentoAguaDomicilio**  | long **aguaConsumoDomicilio** |

##### CadastroDomiciliar

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| HeaderCdsCadastro **dadosGerais** | Não existe |
| boolean **statusTermoRecusaCadastroDomiciliarAtencaoBasica** | boolean **statusTermoRecusa** |
| Não existe | long **tipoDeImovel** |
| Não existe | InstituicaoPermanencia **instituicaoPermanencia** |
| Não existe | UnicaLotacaoHeader **headerTransport** |

##### EnderecoLocalPermanencia

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| string **telReferencial** |  string **telefoneContato** |
| string **telResidencial** |  string **telefoneResidencia** |
| Não existe | string **pontoReferencia** |
| Não existe | string **microArea** |
| Não existe | boolean **stForaArea** |

##Ficha de Atendimento Individual

##### ProblemaCondicaoAvaliacaoAI

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| Não existe   | string **cid10_2**|

##### FichaAtendimentoIndividualChild

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| Não existe   |  long **racionalidadeSaude** |
| Não existe   |  double **perimetroCefalico** |

##Ficha de Atendimento Odontológico Individual

##### FichaAtendimentoOdontologicoChild

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| string **numCartaoSus**  |  string **cnsCidadao**|

##Ficha de Atividade Coletiva

##### ParticipanteRowItem

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| string **cns**| string **cnsParticipante** |
| Não existe   | long **sexo** |

##### ProfissionalCboRowItem

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
|  string **cns** | string **cnsProfissional**|

##### FichaAtividadeColetiva

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| long **dtAtividadeColetiva** | Não existe |
| int **numParticipantesProgramados** | Não existe |
| string **localAtividade** | string **outraLocalidade** |
| long **horaInicio** | Não existe |
| long **horaFim** | Não existe |
| string **responsavelCns** | Não existe |
| string **responsavelCnesUnidade** | Não existe |
| string **responsavelNumIne** | Não existe |
| list\<long\> **praticasTemasParaSaude**| Não existe |
| string **codigoIbgeMunicipio** | Não existe | 
| Não existe | string **cnesLocalAtividade**|
| Não existe | string **procedimento**|
| Não existe | long **turno**|
| Não existe | UnicaLotacaoHeader **headerTransport**|
| Não existe | list\<long\> **temasParaSaude**|
| Não existe | list\<long\> **praticasEmSaude**|

##Ficha de Procedimentos

##### FichaProcedimentoChild

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| string **numCartaoSus**  | string **cnsCidadao**|

##Ficha de Visita Domiciliar e Territorial

##### FichaVisitaDomiciliarChild

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| string **numCartaoSus**  | string **cnsCidadao**|
| Não existe | string **microArea**|
| Não existe | boolean **stForaArea**|
| Não existe | long **tipoDeImovel**|
| Não existe | double **pesoAcompanhamentoNutricional**|
| Não existe | double **alturaAcompanhamentoNutricional**|

##Marcadores de Consumo Alimentar

##### FichaConsumoAlimentar

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| string **numCartaoSus**  | string **cnsCidadao**|

##Ficha de Avaliação de Elegibilidade

##### FichaAvaliacaoElegibilidade

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| UnicaLotacaoHeader **headerTransport** | Não existe |
| string **numeroCartaoSus** | string **cnsCidadao** |
| long **codigoNacionalidade** | long **nacionalidadeCidadao** |
| long **atencaoDomiciliarOrigem** | long **atencaoDomiciliarProcedencia** |
| list\<long\> **situacoesPresentes** | list\<long\> **condicoesAvaliadas** |
| string **cid10Segundo** | string **cid10SecundarioUm** |
| string **cid10Terceiro**| string **cid10SecundarioDois** |
| Não existe | long **turno** |
| Não existe |  VariasLotacoesHeader **headerTransport** |
| Não existe |  string **nomePaiCidadao** |
| Não existe |  boolean **desconheceNomePai**|
| Não existe |  long **dtNaturalizacao**|
| Não existe |  string **portariaNaturalizacao**|
| Não existe |  long **dtEntradaBrasil**|
| Não existe |  long **paisNascimento**|
| Não existe |  long **etnia**|
| Não existe |  string **cnsCuidador**|

##### EnderecoLocalPermanencia

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| string **telReferencial** | string **telefoneContato** |
| string **telResidencial** | string **telefoneResidencia** |
| Não existe | string **pontoReferencia** |

##Ficha de Atendimento Domiciliar

##### FichaAtendimentoDomiciliarChild

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| string **cns** | string **cnsCidadao**|
| list\<long\> **situacoesPresentes** | list\<long\> **condicoesAvaliadas**|
| boolean **statusInicioAcompanhamentoPosObito**| Não existe |

##### FichaAtendimentoDomiciliarMasterThrift

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| UnicaLotacaoHeader **headerTransport** | Não existe|
| Não existe | VariasLotacoesHeader **headerTransport** |

##Cabeçalho (headerTransport)

##### HeaderCdsCadastro (estrutura inutilizada)

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
|  string **cnesUnidadeSaude** | Não existe |
|  string **cnsProfissional**| Não existe |
|  string **codigoIbgeMunicipio** | Não existe |
|  long **dataAtendimento** | Não existe |
|  string **ineEquipe** | Não existe |
|  long **microarea** | Não existe |

##### LotacaoHeader (nova estrutura)

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| Não existe | string **profissionalCNS**|
| Não existe | string **cboCodigo_2002**|
| Não existe | string **cnes**|
| Não existe | string **ine**|

##### VariasLotacoesHeader

| Tipo e nome do campo na v2.0 | Tipo e nome do campo na v2.1 |
| ---------------------------- | ---------------------------- |
| UnicaLotacaoHeader **lotacaoForm** | Não existe |
|  string **profissionalCNS1**| Não existe |
|  string **cboCodigo\_2002\_1**| Não existe |
|  string **profissionalCNS2**| Não existe |
|  string **cboCodigo\_2002\_2** | Não existe |
| Não existe | LotacaoHeader **lotacaoFormPrincipal**|
| Não existe | LotacaoHeader **lotacaoFormAtendimentoCompartilhado**|
| Não existe | long **dataAtendimento**|
| Não existe | string **codigoIbgeMunicipio**|