# bridge-docs

Repositório base para documentação de projetos, utilizando [Jekyll](https://jekyllrb.com/) para geração de sites estáticos de documentação através de arquivos escritos em Markdown.

## Como adicionar a um projeto

Adicione este sistema de documentação a um projeto com o comando:

```sh
$ git subtree add --squash --prefix docs/ git@github.com:laboratoriobridge/docs.git master
```

Uma pasta `docs/` será criada com os fontes deste repositório. Modifique os arquivos de acordo com as necessidades do projeto.

## Como atualizar

A partir da raiz de um projeto usando este sistema de documentação, execute:

```sh
$ git subtree pull --squash --prefix docs/ git@github.com:laboratoriobridge/docs.git master
```

Sendo `docs/` o nome da pasta que contém os fontes do sistema de documentação.

Este comando irá atualizar a versão local da documentação com as últimas atualizações do repositório base. Os arquivos específicos da versão local serão mantidos. Resolva os conflitos, caso existam, e commite o resultado.
