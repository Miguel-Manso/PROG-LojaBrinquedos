# PROG-LojaBrinquedos

<p>Repositório dedicado para exercicos da matéria de programação apresentada pelo professor Lucas, feitos no segundo ano de ensino (2024)</p>

<p>Prova prática avaliativa: Deverá ser criada uma aplicação Windows Forms utilizando os conhecimentos adquiridos até o momento, seguindo as instruções abaixo.

Desenvolva uma rotina de cadastro de brinquedos para uma loja de departamentos (Ex: 1,99, Americanas, etc...).

Requisitos:
-Utilizar Windows Forms Application .Net Framework
-Manipulação de Arquivo (.txt)
-Validação de campos com ErrorProvider
-O Programa deve conter 3 telas.

1 - Tela Principal:
Primeira tela a ser apresentada para o usuário.
-Menu para acessar o cadastro
-Nome do Software
-Nome dos participantes
-Imagem de fundo com o tema da aplicação

2 - Tela de Brinquedos:
Tela que irá realizar o cadastro de um novo brinquedo.
Campos necessários para o cadastro:
Fabricante
-CNPJ
-Nome
Produto
-Código de Barras
-Descrição
-Preço
Brinquedo
-Categoria
-Idade Mínima

Validações Campos:
-Validação em todos os campos
-Campos de texto validar que se não estão vazios
-Campos numéricos devem aceitar somente números
-Campo CNPJ é obrigatório informar 14 caracteres numéricos
-Campo código de barras é obrigatório informar 13 caracteres numéricos
-Campo preço deve aceitar apenas números e vírgula

Arquivo:
-O nome do arquivo será o código de barras do produto (Ex: 987654321123.txt).
-Validar se já existe um arquivo com o mesmo nome.
-Deverá conter todos os dados referentes ao cadastro.
     Exemplo:
     CNPJ: 12345678912345
     Nome: Mattel
     Código de Barras: 987654321123
     ...
-Botão Salvar: Ao clicar, deverá validar se já existe um arquivo com o mesmo nome. Caso exista, apresentar uma mensagem de confirmação, se deseja substituir o arquivo. Caso não exista, não realizar nenhuma ação. O arquivo só será salvo caso o usuário confirme a substituição ou altere o código de barras. Salvar um arquivo .txt com todos os dados informados no cadastro, onde o nome do arquivo será o código de barras.
-Botão Limpar: Ao clicar, deverá limpar todos os campos da tela.
-Botão Cancelar: Ao clicar, deverá fechar a tela de cadastro após a confirmação de fechamento do usuário.

 3 - Tela de Visualização de Brinquedos:
Tela irá exibir todos os dados do cadastro de brinquedos salvo no arquivo(.txt) selecionado.
-Campo para exibição do conteúdo do arquivo.
-Campo com o caminho da pasta selecionada.
-Campo com para informar o Código de Barras do produto.
-Botão Selecionar: Ao clicar, deverá permitir ao usuário selecionar o caminho da pasta e carregar o arquivo em tela.

OBS: Podem ser adicionados mais campos conforme julgar necessário, mas deve possuir no mínimo todos os requisitos acima.

Realizar um print screen de cada tela do sistema. 
Anexar os prints e a pasta do projeto compactada. 
Apenas um dos participantes deve anexar uma cópia dos arquivos. 
Destacar o nome dos participantes nos comentários do classroom ao anexar o arquivo. 
Entrega até as 22:45 do dia 26/04/2023.

</p>
