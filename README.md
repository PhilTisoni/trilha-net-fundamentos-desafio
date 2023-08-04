# DIO Parking

<img style = "width: 200px" src = "https://hermes.dio.me/tracks/169e3d0f-263a-4efb-86c5-244bdf1ce8d6.png" alt = "Formação .Net Developer"> <img style = "width: 200px" src = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdjqTkPkxvNF5yqLhPRNhYXnwXuW422OWMGMyn2KkNTjRyuqZriAq26YEAK35FIOgKAwY&usqp=CAU" alt = "DIO"> 


# Sobre o Projeto

Desenolvido em Agosto de 2023 durante a **Formação .Net Developer** oeferecido pela **Digital Innovation One (DIO)**, o projeto apresenta uma aplicação console simulando um sistema de estacionamento. Ele adiciona, remove e lista os carros estacionados, além de calcular o preço final para o usuário. Foram implementadas funções extras, afim de aperfeiçoar o modelo sugerido.

<details><summary>Desafio</summary>

# DIO - Trilha .NET - Fundamentos
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


## Solução
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

</details>

<details><summary>Solução</summary>

# Método Adicionar

Para adicionar um veículo no estacionamento, foi utilizado o método **Add()** para incluir itens em uma lista. Além disso, foram inseridos elementos visuais e uma
frase para informar o resultado do processo para o usuário:

```c#
        public void AdicionarVeiculo()
        {  
            Cabecalho.ExibirAdicionar();
            string placa = Console.ReadLine();            
            veiculos.Add(placa);
            Console.WriteLine("Veículo adicionado com sucesso!\n");
            Menu.RetornarMenu();
        }
```


## Método Remover:

Foi implementado a solicitação das informações da placa e da quantidade de horas que o veículo permaneceu estacionado, assim como o cálculo
do valor total que será cobrado. O veículo também foi removido da lista e foram adicionados elementos visuais para melhorar a experiência
do usuário:

```c#
        public void RemoverVeiculo()
        {
            Cabecalho.ExibirRemover();
            string placa = Console.ReadLine();
     
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");                
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas; 
       
                veiculos.Remove(placa);
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: {valorTotal:C}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

            Menu.RetornarMenu();
        }        
```

## Método Listar:

Para exibir os carros presentes na lista, foi utilizado um **foreach** com a inserção de um emoji:

```c#
   [...]

   foreach(string veiculo in veiculos)
  {
      Console.WriteLine("● " + veiculo);                    
  }
              
  [...]
```
 
## Extras:

- Foram inseridas as classes: **Cabecalho** e **Menu** para separar as funções e diminuir a sobrecarga de responsábilidade da classe **Program**
- Na classe **Menu** foi adicionado o método **RetornarMenu()** para evitar a repetição de código
- Na última linha da classe **Program** foi inserido o comando **Environment.Exit(0)**, afim de fechar a aplicação após o encerramento do programa 

</details>

# Tecnologias Utilizadas

- [.Net 7.0.302](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) 
- [Visual Studio Code](https://code.visualstudio.com/download)

# Como Clonar o Projeto

- Instale o [Git](https://git-scm.com/downloads) no seu computador. Durante a instalação, certifique-se se a opção **Git Bash** está adicionada.
- Após a instalação, crie uma pasta em sua área de trabalho
- Dentro da pasta, clique com o botão direito e selecione **Git Bash Here**
- Após abrir o terminal, copie o seguinte comando:
   
```bash
git clone https://github.com/PhilTisoni/trilha-net-fundamentos-desafio.git
```
O projeto deverá ser clonado para a sua pasta. Abra a solução em seu compilador de preferência.


# Autor

- [Phelipe Augusto Tisoni](https://www.linkedin.com/in/phelipetisoni "Phelipe Linkedin")


