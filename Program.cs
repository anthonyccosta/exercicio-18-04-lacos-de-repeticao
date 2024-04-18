
//(1) faça um programa que leia o numero inicial e um numero final mostrando entre eles
// quais sao os valores pares e impares

//int num1 = 0, num2 = 0, contador = 0;

//Console.WriteLine("Digite o número inicial:");
//num1 = int.Parse(Console.ReadLine());
//Console.WriteLine("Digite o número final:");
//num2 = int.Parse(Console.ReadLine());

//num1 nao pode ser maior
//if (num1 > num2)
//{
//    Console.WriteLine("O número inicial deve ser menor ou igual ao número final.");
//}
//else
//{
//    Console.WriteLine("Números pares: ");
//    contador recebe o valor do num1 para ele nao mudar
//    contador = num1;
//    while (contador <= num2)
//    {
//        if (contador % 2 == 0)
//            feita a conta para par ou impar usando o % 2 e no final seja igual a 0
//        {
//            mostra o valor atribuido como num1 e começa a partir dele ate o valor final
//            Console.Write(contador + " ");
//        }
//        ele segue adicionando valores ate que o valor atinga o num final
//        contador++;
//    }

//    Console.WriteLine("\nNúmeros ímpares:");
//    contador = num1;
//    while (contador <= num2)
//    {
//        a conta de % 2 != para fazer a conta e saber de o resto da conta é maior que 0
//        if (contador % 2 != 0)
//        {
//            Console.Write(contador + " ");
//        }
//        contador++;
//    }
//}
//Console.ReadLine();


//(2 faça um programa que leia um numero inteiro positivo e imprima a sua tabuada 1-10
//int positivo = 0, aux = 0;

//Console.WriteLine("Digite um número inteiro positivo:");
//positivo = int.Parse(Console.ReadLine());

//// se o valor digitado for menos que 0 da erro, nao da para fazer a tabuada
//if (positivo <= 0)
//{
//    Console.WriteLine("O número digitado deve ser positivo.");
//}
//else
//{
//    // o aux recebe o valor de 1, para que mostre o valor digitado e comece com ele a partir
//    // dai 
//    aux = 1;
//    // o aux vai seguir com a tabuada até que ela va ao 10
//    while (aux <= 10)
//    {
//        Console.WriteLine($"{positivo} x {aux} = {positivo * aux}");
//        //o aux++ vai fazer com que nao seja apenas uma linha da tabuada,ele segue adicionando
//        // até que o valor seja menor ou igual a 10
//        aux++;
//    }
//}
//Console.ReadLine();