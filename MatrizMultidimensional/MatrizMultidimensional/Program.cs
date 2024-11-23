// See https://aka.ms/new-console-template for more information
//string list[,] = new string[] { {"joão", "Maria", "Arthur",},{"laranja", "tomate", "cebelo",}, {"1", "2", "3",}};
//Console.WriteLine(list[0,1]);

/*int[,] numeros = new int[2,3];

numeros[0,0] = 10;
numeros[0,2] = 20;
numeros[0,3] = 30;

numeros[1,0] = 100;
numeros[1,2] = 150;
numeros[1,3] = 200;

Console.WriteLine(numeros[0,1]);
*/

int[,] numeros = new int[2, 3] { { 10, 20, 30 }, { 100, 150, 200 } };

string[,] nomes = 
{
    { "Silas", "Victor", "Lara" },
    { "Julia", "Livia", "Maria" },
    {"1","2","3"}
};

Console.WriteLine(nomes[2,1]);

foreach (string indice in nomes){
    Console.WriteLine(indice);
}