# Sobre o projeto

Esse é um dos projetos feitos durante o curso de Desenvolvimento de Sistemas da ETEC Adolpho Berezin (Novo MTec)
Compomente Currícular: Desenvolvimento de Sistemas
Bimestre: 2º Bimestre
Orientadores: Oswaldo Luiz e Joelma Lucia Sartori

# Descrição Geral

O projeto é um aplicativo para gerenciar cadastros de Usuários, Clientes e Fornecedores. Com capacidades de:

- Navegar pelos cadastros
  - Botões de Anterior e Próximo, além de pesquisar pelo nome
- Criar novo cadastro
- Imprimir cadastro
- Apagar cadastro
- Alterar cadastros

Existe também a funcionalidade de gerar relatórios, onde páginas para impressão são geradas com todos os dados cadastrados

# Requisitos e especificações

## Relatórios

Geração de relatórios deve inicializar uma impressão de folhas (tipo A4 mesmo) para impressão. Todas as folhas contendo os dados devem incluir um cabeçario,
titulo (relatório de CADASTRO) e número da página.
Os dados devem estar em formato de tabela, onde todos os dados serão exibidos. Para desenhar uma tela de impressão, leve em consideração o seguinte:

- Fonte: Monospace, para padronizar tamanho de caractere
- Tamanho de fonte: 10pt
- Tamanho de folha: 80 caracteres de largura e 66 caracteres de altura

O cabeçario em cada folha deve incluir:

- Nome da instituição: ETEC Adolpho Berezin
- Título: Relatório de \[TIPO_RELATORIO\]
- Numeração da página

A tabela do relatório é padrão, cada coluna é um atributo do cadastro e cada linha é um cadastrado. Siga o exemplo da imagem para saber como fazer alinhamentos,
seja a esquerda ou a direita. Para implementação, siga o seguinte modelo de código:

```
[WIP]
```

**Para as situações onde a quantidade de atributos não cabem em uma linha, pode quebra-las em mais linhas.** Por exemplo, se é necessário 3 linhas para caber todos os campos, cada registro ocupa 3 linhas. Veja os padrões utilizados para tabelas em multiplas linhas

## Tela inicial

- Possui uma toolbar para as telas de cadastro, relatórios, e sair
- O conteúdo pode ser qualquer coisa, um background, wallpaper temático, ou atalhos para funcionalidades

## Telas de cadastro

### Descrição

- Maximo 100 cadastros de (chamados) objetos, gerando um erro caso não tenha mais espaço
- Trazer funcionalidade de visualizar cadastros, criar novo cadastro, alterar cadastros, pesquisar cadastros, imprimir cadastros e excluir cadastros
- A visualização é simplesmente preencher os campos do form, mas em apenas leitura até o usuário ter que criar ou alterar cadastros
- O nome deve estar obrigatóriamente preenchido por causa do requisito de Pesquisa

### Botões telas cadastro

1. Botão Próximo e Anterior: navegar entre objetos
2. Botão Salvar: Salvar alterações ou efetuar novo cadastro. Disponível apenas em modo cadastro/alteração
3. Botão Cancelar: Cancela operação de Novo ou Alterar. Disponível apenas em modo cadastro/alteração
4. Botão Novo: Libera tela para efetuar novo cadastro. O código é calculado automaticamente (index + 1)
5. Botão Pesquisar: Efetua pesquisa a partir do nome.
6. Botão Alterar: Altera cadastro selecionado.
7. Botão Imprimir: Imprimir dados do cadastro
8. Botão Excluir: Excluir cadastro selecionado. Inclua prompt de confirmação
9. Botão Sair: Fecha a tela

### Pesquisa cadastro

A pesquisa é uma busca de um cadastro através do campo "nome". Se for encontrado, selecionar esse cadastro e exibi-lo na tela. Se não for encontrado, avisar o usuário que o cadastro não foi encontrado (MessageBox) e fechar a tela de pesquisa. 

A tela de pesquisa é composta da seguinte forma:
- Titulo: Pesquisa \[TIPO_CADASTRO\]
- Caixa de pesquisa
- Botão Pesquisar, para efetuar pesquisa
- Botão Sair, para fechar a tela

Note: não feche a tela se o botão Pesquisar for pressionado com o campo Caixa de pesquisa vazio.

### Imprimir cadastro

Imprimir um cadastro deve seguir os seguintes parametros:

- Fonte Arial 12 em negrito
- Distancia de 50px do topo e esquerda da folha

Siga o código exemplo para implementação:

```
string page;
Graphics g = e.Graphics;
Font fonte = new Font("Arial", 12, FontStyle.Bold);
Brush color = Brushes.Black;
PointF posicao = new PointF(50, 50);

page = "FICHA DE USUÁRIO\n\n";
page += $"Código: {txtCodigo.text}";
page += $"Nome: {txtNome.text}";
page += $"Login: {txtLogin.text}";

g.DrawString(page, fonte, color, posicao);
```

# Roadmap

- Altere os campos do frmPesquisa dependendo de quem chamou seu .ShowDialog()
- Os métodos que ainda tem repetição de código são assim porque é necessário relacionar os campos do form (TextBoxes) às suas respectivas posições no cadastro (Atributo da interface IUsuario). Para resolver isso, as soluções incluem:
  1. fazer um método de obter os campos a partir da classe IEntidade (retorno Dictonary por exemplo), e adaptar as convenções de nomes para que um laço FOR possa fazer esse trabalho dentro da classe LogicaCadastro
  2. Fazer a propriedade Name das Textboxes igual ao seu nome no cadastro, e utilizar essa nomenclatura consistente para relacionar TextBoxes a IEntidades
- Adicionar um aviso em vermelho afirmando qual campo obrigatório estava nulo
  - Para isso, implementar uma forma de localizar determinado elemento a partir de seu Name como uma string
  - Essa implementação além de facilitar a interação entre a classe LogicaCadastro e frmCadastro, reduz a quantidade de propriedades arbitrarias na interface IFormCadastro
- Mover implementação Imprimir para a classe genérica (requer as melhorias mencionadas previamente)
- FIX: Quando um cadastro é apagado, a tabela na tela inicial não é atualizada. Posso remover essa tabela e colocar uma imagem placeholder, ou corrigir o erro
- Implementar impressão de relatório
