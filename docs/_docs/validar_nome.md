---
layout: doc
title: Validar nome
id: validar_nome
order: 18
---

Essas regras foram baseadas nas regras oficiais definidas pelo CADSUS na Especificação Técnica para integração PIX/PDQ
<a href="dicionario/Especificacao_CADSUS.pdf" title="Clique para visualizar o documento de Especificação Técnica para integração PIX/PDQ">
	<img src="dicionario/pdf.jpg" width="20" height="20"/>
</a>

No documento essa regras são definidas na **RN002. Informação do “Nome do Usuário”**. Nem todas as regras do manual são implementadas no PEC.

###1. Regras aplicadas

**1.** A informação deve conter pelo menos três caracteres;

**2.** A informação que contiver um único termo, não entrará na base de dados (Ex: JOAQUIM);

**3.** A informação não deve permitir a inserção de espaço duplicado;

**4.** A informação deve ser padronizada para letra maiúscula, ou seja, letras minúsculas deverão ser convertidas para maiúsculas (Ex: Maria da Paz é convertida para MARIA DA PAZ);

**5.** A informação que contiver, após o 1o termo, um termo com apenas um caractere não entrará na base de dados, exceto se o termo for a letra E ou Y (Ex: JOAQUIM MARIA A SILVA não entra, mas JOAQUIM MARIA E SILVA é admissível; JOAQUIM RODRIGUEZ Y RODRIGUEZ é admissível);

**6.** A informação só pode conter letras do alfabeto romano (incluindo K, W, Y), além dos acentos gráficos (agudo, circunflexo, til e trema) e do caractere apóstrofo (‘), para possibilitar a inserção de nomes como JOÃO D’ÁVILA, sendo vedada a utilização de outros caracteres especiais;

**7.** A informação que contiver o primeiro e segundo termos com apenas um caractere em cada um deles não entrará na base de dados (Ex. A A DA SILVA);

**8.** A informação que contiver apenas dois termos, ambos com apenas dois caracteres, não entrará na base de dados;

As outras regras da especificação que não são citadas acima, serão validadas apenas pelo serviço do CADSUS, no módulo de cidadão, no momento em que o cadastro for enviado ao serviço PIX do CADSUS.