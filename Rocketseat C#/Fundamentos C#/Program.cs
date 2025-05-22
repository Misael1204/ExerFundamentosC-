// Exercicio 1
Console.WriteLine("Digite seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Olá, " + nome + "! Seja muito bem-vindo");

//Exercicio 2
Console.WriteLine("Qual seu nome?");
string name = Console.ReadLine();
Console.WriteLine("Digite seu sobrenome: ");
string sobreNome = Console.ReadLine();
Console.WriteLine(name + " " + sobreNome);

//Exercicio 3
double valor1 = 10;
double valor2 = 2;

Console.WriteLine(valor1 + valor2);
Console.WriteLine(valor1 - valor2);
Console.WriteLine(valor1 * valor2);
if (valor2 != 0) {
    Console.WriteLine(valor1 / valor2);
}
Console.WriteLine((valor1 + valor2) / 2);

//Exercico 4

Console.WriteLine("Digite uma ou mais palavras");
var palavra = Console.ReadLine();

if (palavra.Contains(" ")) {
    var palavraSemEspaco = palavra.Replace(" ", "");
    var qtdPalavras = palavraSemEspaco.Count();
    Console.WriteLine(qtdPalavras);
}
var resultado = palavra.Count();
Console.WriteLine(resultado);

//Execicio 5

Console.WriteLine("digite a placa do carro (exemplo:abc1234): ");
var placa = Console.ReadLine();

if (placa.Count() == 7 && char.IsLetter(placa[0])
                            && char.IsLetter(placa[1])
                            && char.IsLetter(placa[2])
                            && char.IsNumber(placa[3])
                            && char.IsNumber(placa[4])
                            && char.IsNumber(placa[5])
                            && char.IsNumber(placa[6])) {
    Console.WriteLine("verdadeiro");
} else {
    Console.WriteLine("falso");
}

//Exercicio 6

Console.WriteLine("Escolha o formato da data:");
Console.WriteLine("1 - Formato completo");
Console.WriteLine("2 - Apenas a data (dd/MM/yyyy)");
Console.WriteLine("3 - Apenas a hora (HH:mm:ss)");
Console.WriteLine("4 - Data com mês por extenso");

Console.Write("Opção: ");
string opcao = Console.ReadLine();

DateTime agora = DateTime.Now;


switch (opcao) {
    case "1":
        Console.WriteLine(agora.ToString("dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss"));
        break;
    case "2":
        Console.WriteLine(agora.ToString("dd/MM/yyyy"));
        break;
    case "3":
        Console.WriteLine(agora.ToString("HH:mm:ss"));
        break;
    case "4":
        Console.WriteLine(agora.ToString("dd 'de' MMMM 'de' yyyy"));
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
