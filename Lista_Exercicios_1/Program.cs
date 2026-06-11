//Desenvolva uma aplicação console em C# que solicite ao usuário que informe a
//quantidade de vendas realizadas. Em seguida, solicite que o usuário digite a quantidade de
//itens de cada venda. Ao final, imprima o total de itens vendidos.

////Console.WriteLine("Digite a quantidade de vendas:");
////int quantidadeVendas = int.Parse(Console.ReadLine());
////int totalItens = 0;

////for (int i = 0; i < quantidadeVendas; i++)
////{
////    Console.WriteLine("Digite a quantidade de itens da venda {0}:", i + 1);
////    int itensVenda = int.Parse(Console.ReadLine());
////    totalItens += itensVenda;
////}

////Console.WriteLine("O total de itens vendidos é: {0}", totalItens);

//Desenvolva uma aplicação console em C# que solicite ao usuário que informe a
//quantidade de itens vendidos em cada venda, de forma contínua. Ou seja, após digitar a
//quantidade de uma venda, o sistema automaticamente solicitará a quantidade da próxima
//venda. Para encerrar a digitação o usuário deve digitar 0 (zero) quando for solicitado a
//quantidade. Ao final, o programa deve exibir o número de vendas realizadas e o total de
//itens vendidos.

//Console.WriteLine("Digite a quantidade de de itens:");
//int quantidadeVendidos = int.Parse(Console.ReadLine());
//int totalItensVendidos = 0;
//int totalVendas = 0;

//while (quantidadeVendidos != 0)
//{
//    totalVendas++;
//    totalItensVendidos += quantidadeVendidos;
//    Console.WriteLine("Digite a quantidade de de itens:");
//    quantidadeVendidos = int.Parse(Console.ReadLine());
//}
//Console.WriteLine("O total de vendas realizadas é: {0}", totalVendas);
//Console.WriteLine("O total de itens vendidos é: {0}", totalItensVendidos);

//Desenvolva uma aplicação console em C# que receba e armazene as notas para cada um
//dos cinco critérios avaliados. Após a digitação das notas, imprima no console a média das
//notas e o resultado de cada critério (se aprovado ou reprovado).

//Console.WriteLine("Avaliação de fornecedores");
//int somaNotas = 0;
//int[] nota = new int[5];

//for (int i = 0; i < 5; i++)
//{
//    Console.WriteLine("Digite a nota para o critério {0}:", i + 1);
//    nota[i] = int.Parse(Console.ReadLine());
//    somaNotas += nota[i];
//}
//Console.WriteLine("****************************");
//Console.WriteLine("Média {0}", (double)somaNotas / 5);
//Console.WriteLine("****************************");
//for (int i = 0; i < 5; i++)
//{
//    string situacao = nota[i] >= 7 ? "APROVADO" : "REPROVADO";
//    Console.WriteLine($"Critério {i + 1}: {situacao}");
//}



