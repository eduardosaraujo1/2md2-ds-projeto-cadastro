# Sobre o projeto

Esse é um dos projetos feitos durante o curso de Desenvolvimento de Sistemas da ETEC Adolpho Berezin (Novo MTec)
Compomente Currícular: Desenvolvimento de Sistemas
Bimestre: 2º Bimestre
Orientadores: Oswaldo Luiz e Joelma Lucia

# Tela Inicial

-   Possui uma toolbar para as telas de cadastro, relatórios, e sair
-   O conteúdo é uma tabela com quantos cadastros estão contidos de Usuários, Fornecedores e Clientes

# Requisitos telas cadastro

-   Dados de cada cadastro
-   Maximo 100 cadastros de (chamados) objetos, gerando um erro caso não tenha mais espaço
-   A funcionalidade da tela é de trazer funcionalidade de visualizar objetos, cadastrar objetos, alterar objetos e excluir objetos
-   A visualização é simplesmente preencher os campos do form, mas deixa-los apenas leitura até o usuário ter que cadastrar ou alterar objetos
-   O único campo que deve estar obrigatoriamente preenchido é o Nome

## Botões telas cadastro

1. Botão Próximo e Anterior: navegar entre objetos
2. Botão Salvar: Salvar alterações/cadastro de novo objeto (disponível apenas em modo cadastro/edição)
3. Botão Cancelar: Cancela alterações/cadastro de novo objeto (disponível apenas em modo cadastro/edição)
4. Botão Novo: Libera tela para cadastrar um novo objeto, já definindo qual o código
5. Botão Pesquisar: Veja Funcionalidade Pesquisa Cadastro
6. Botão Alterar: Edita objeto exibido na tela
7. Botão Imprimir: Imprimir dados do objeto exibido na tela
8. Botão Excluir: Excluir objeto exibido na tela (recomendado prompt de confirmação)
9. Botão Sair: Fecha a tela

## Funcionalidade Pesquisa Cadastro

A funcionalidade pesquisa cadastro vai adicional um novo Panel nas telas de cadastro. Por padrão, esse panel será invisivel, e será mostrado quando apertar "Pesquisar" da tela.
O panel terá os campos:

-   Titulo (Exemplo: Pesquisa Usuário)
-   Campo de pesquisa (por exemplo, textbox nome)
-   Botão Pesquisar, que vai efetuar a pesquisa
-   Botão Sair, que vai esconder o Panel
    A pesquisa deve seguir as seguintes caracteristicas:
-   Ao apertar em Pesquisar (do panel), certifique-se que a pesquisa não é vazia
-   Se a pesquisa retornar um resultado, colocar esse resultado no formulário, e depois esconder a tela de pesquisa.
-   Se a pesquisa não encontrar nenhum resultado, exibir uma MessageBox avisando o usuário que não foi encontrado.

## Funcionalidade cadastro impressão

Imprimir um cadastro deve seguir os seguintes parametros:

-   Fonte Arial 12 em negrito
-   Distancia de 50px do topo e esquerda da folha
    Exemplo:

```
string page;
Graphics impressao = e.Graphics;
Font fonte = new Font("Arial", 12, FontStyle.Bold);
Brush color = Brushes.Black;
PointF posicao = new PointF(50, 50);

page = "FICHA DE USUÁRIO\n\n";
page += $"Código: {txtCodigo.text}";
page += $"Nome: {txtNome.text}";
page += $"Login: {txtLogin.text}";

impressao.DrawString(page, fonte, color, posicao);
```

# Ideias de implementação

-   Os métodos que ainda tem repetição de código são assim porque é necessário relacionar os campos do form (TextBoxes) às suas respectivas posições no cadastro (Atributo da interface IUsuario). Para resolver isso, as soluções incluem:
    1. fazer um método de obter os campos a partir da classe IEntidade (retorno Dictonary por exemplo), e adaptar as convenções de nomes para que um laço FOR possa fazer esse trabalho dentro da classe LogicaCadastro
    2. Fazer a propriedade Name das Textboxes igual ao seu nome no cadastro, e utilizar essa nomenclatura consistente para relacionar TextBoxes a IEntidades
