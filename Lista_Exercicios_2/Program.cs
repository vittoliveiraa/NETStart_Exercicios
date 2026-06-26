//Gerador de Jogos Mega Sena

//Console.WriteLine("Gerador de jogos Mega Sena");
//Console.WriteLine("--------------------------");
//int[] numerosSorteados = new int[6];

//for (int i = 0; i < numerosSorteados.Length; i++)
//{
//    int numeroGerado = Random.Shared.Next(1, 60);
//    numerosSorteados[i] = numeroGerado;
//    Console.WriteLine(numerosSorteados[i]);
//}


//Console.WriteLine("Gerador de jogos");
//Console.WriteLine("Digite a opção desejada");
//Console.WriteLine("1. Mega Sena / 2.Lotofacil / 3. Quina");
//Console.WriteLine("-------------------------------------");

//var escolha = Console.ReadLine();

//switch (escolha)
//{
//    case "1":
//        GerarJogoMegaSena();
//        break;
//    case "2":
//        GerarJogoLotofacil();
//        break;
//    case "3":
//        GerarJogoQuina();
//        break;
//    default:
//        Console.WriteLine("Digite um número válido");
//        break;
//}

//void GerarJogoMegaSena()
//{
//    for (int i = 0; i < 6; i++)
//    {
//        var numero = Random.Shared.Next(1, 60);
//        Console.Write($"{numero:00} ");
//    }
//}
//void GerarJogoLotofacil()
//{


//    for (int i = 0; i < 15; i++)
//    {
//        var numero = Random.Shared.Next(1, 25);
//        Console.Write($"{numero:00} ");
//    }
//}

//void GerarJogoQuina()
//{
//    for (int i = 0; i < 6; i++)
//    {
//        var numero = Random.Shared.Next(1, 80);
//        Console.Write($"{numero:00} ");
//    }
//}