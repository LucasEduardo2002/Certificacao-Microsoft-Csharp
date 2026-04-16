string idAnimal = "";
string especieAnimal = "";
string idadeAnimal = "";
string apelidoAnimal = "";
string caracteristicasAnimal = "";
string personalidadeAnimal = "";


int maxPet = 8;
string menuSelection = "";

string[,] ourAnimals = new string[maxPet, 6];

for (int i = 0; i < maxPet; i++)
{

    switch (i)
    {
        case 0:
            idAnimal = "d1";
            especieAnimal = "Cachorro";
            idadeAnimal = "9";
            apelidoAnimal = "Baleia";
            caracteristicasAnimal = "Gordo, branco e feio";
            personalidadeAnimal = "Gosta de comer bolachas";
            break;

        case 1:
            idAnimal = "d2";
            especieAnimal = "Gato";
            idadeAnimal = "7";
            apelidoAnimal = "Tutu";
            caracteristicasAnimal = "Malhado, preto e magro";
            personalidadeAnimal = "Caga em todo canto";
            break;

        case 2:
            idAnimal = "d3";
            especieAnimal = "Cachorro";
            idadeAnimal = "15";
            apelidoAnimal = "Rex";
            caracteristicasAnimal = "Pequeno, só o osso";
            personalidadeAnimal = "Brabo e agressivo";
            break;

        default:
            idAnimal = "";
            especieAnimal = "";
            idadeAnimal = "";
            apelidoAnimal = "";
            caracteristicasAnimal = "";
            personalidadeAnimal = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + idAnimal;
    ourAnimals[i, 1] = "Especie: " + especieAnimal;
    ourAnimals[i, 2] = "Idade: " + idadeAnimal;
    ourAnimals[i, 3] = "Apelido: " + apelidoAnimal;
    ourAnimals[i, 4] = "Caracteristicas: " + caracteristicasAnimal;
    ourAnimals[i, 5] = "Personalidade: " + personalidadeAnimal;

}

do
{
    Console.WriteLine("Bem-vindo ao Contoso PetFriends app. Selecione uma opção do menu abaixo:");
    Console.WriteLine("1. Listar todas as nossas informações atuais sobre animais de estimação.");
    Console.WriteLine("2. Atribuir valores aos campos da matriz ourAnimals.");
    Console.WriteLine("3. Verificar se as idades dos animais e as descrições físicas estão concluídas.");
    Console.WriteLine("4. Verificar se os apelidos de animais e as descrições de personalidade estão concluídas.");
    Console.WriteLine("5. Editar a idade de um animal.");
    Console.WriteLine("6. Editar a descrição de personalidade de um animal.");
    Console.WriteLine("7. Exibir todos os gatos com uma característica especificada.");
    Console.WriteLine("8. Exibir todos os cães com uma característica especificada.");
    Console.WriteLine("9. Sair do programa.");

    string?readResult = Console.ReadLine();

    if(readResult != null)
    menuSelection = readResult.ToLower();


    switch (menuSelection)
    {
        case "1":

            for (int i = 0; i < maxPet; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine(ourAnimals[i, j]);
                }
            }
            break;

        case "2":
            int contPet = 0;
            for (int i = 0; i < maxPet; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    contPet += 1;
                }

                if (contPet < maxPet)
                {
                    Console.WriteLine($"Agora temos {contPet} animais que precisam de um lar. Nós podemos cuidar de mais {(maxPet - contPet)} animais.");
                
                
                    Console.WriteLine("Informe o ID do animal: ");
                    idAnimal = Console.ReadLine();
                    Console.WriteLine("Informe a especie do animal: ");
                    especieAnimal = Console.ReadLine();
                    Console.WriteLine("Informe a idade do animal: ");
                    idadeAnimal = Console.ReadLine();
                    Console.WriteLine("Informe o apelido do animal: ");
                    apelidoAnimal = Console.ReadLine();
                    Console.WriteLine("Informe as caracteristicas do animal: ");
                    caracteristicasAnimal = Console.ReadLine();
                    Console.WriteLine("Informe a personalidade do animal: ");
                    personalidadeAnimal = Console.ReadLine();

                    ourAnimals[i, 0] = "ID #: " + idAnimal;
                    ourAnimals[i, 1] = "Especie: " + especieAnimal;
                    ourAnimals[i, 2] = "Idade: " + idadeAnimal;
                    ourAnimals[i, 3] = "Apelido: " + apelidoAnimal;
                    ourAnimals[i, 4] = "Caracteristicas: " + caracteristicasAnimal;
                    ourAnimals[i, 5] = "Personalidade: " + personalidadeAnimal;

                    Console.WriteLine("\n\rPressione Enter para continuar.");
                    readResult = Console.ReadLine();

                }
                else
                {
                    Console.WriteLine("Nossa capacidade de animais atingiu o limite.");
                    Console.WriteLine("\n\rPressione Enter para continuar.");
                    readResult = Console.ReadLine();
                }
            }

        case "3":
        case "4":
        case "5":
        case "6":
        case "7":
        case "8":
        case "9":
            break;

        default:
    }

} while (menuSelection != "9");

