/* 
    Intermediário 6- Faça um programa que leia três números,
     verifique (usando if e else), e mostre o maior deles.  
*/


int num1, num2, num3;
Console.WriteLine("Digite 3 números para comparar o maior entre eles:");
num1 = int.Parse(Console.ReadLine());
num2 = int.Parse(Console.ReadLine());
num3 = int.Parse(Console.ReadLine());

if (num1 >= num2 && num1 >= num3)
{
    Console.WriteLine($"O maior número é: {num1}");
}
else if (num2 >= num1 && num2 >= num3)
{
    Console.WriteLine($"O maior número é: {num2}");
}
else
{
    Console.WriteLine($"O maior número é: {num3}");
} 

//Intermediário 9- Faça um programa que leia três números e mostre-os em ordem decrescente.  


int[] ListaNum = new int[] { 9,1,8,2,7,3,4,6,5};

Array.Sort(ListaNum);

Array.Reverse(ListaNum);

foreach (int i in ListaNum)
{
    Console.WriteLine(i);
} 

/* 
Difícil 11- As organizações CSM resolveram dar um aumento de salário aos seus colaboradores
 e lhe contrataram para desenvolver o programa que calculará os reajustes.  
    a. Faça um programa que recebe o salário de um colaborador e o reajuste segundo o seguinte critério, baseado no salário atual;
    b. Salários até R$ 280,00 (incluindo): aumento de 20%;
    c. Salários entre R$ 280,00 e R$700,00: aumento de 15%;
    d. Salários entre R$ 700,00 e R$ 1500,00: aumento de 10%;
    e. Salários de R$ 1500,00 em diante: aumento de 5%
Após o aumento ser realizado; informe na tela;

    a. O salário antes do reajuste;
    b. O percentual de aumento aplicado;
    c. O valor do aumento;
    d. O novo salário, após o aumento.  
*/




Console.WriteLine("Insira o valor do seu salario para reajuste com base na categoria: ");
double salario =double.Parse(Console.ReadLine());
double reajust;
if (salario <= 280)
{
    reajust = salario*0.20;
    Console.WriteLine($"Seu aumento de salario é de 20% {salario+reajust} o reajuste foi de {reajust}");
} else if(salario <= 281 && salario <= 700)
{
    reajust = salario*0.15;
    Console.WriteLine($"Seu aumento de salario é de 15% {salario+reajust} o reajuste foi de {reajust}");
}else if(salario <= 701 && salario <=1500)
{
    reajust = salario*0.10;
    Console.WriteLine($"Seu aumento de salario é de 10% {salario+reajust} o reajuste foi de {reajust}");
}else{
    reajust = salario*0.05;
    Console.WriteLine($"Seu aumento de salario é de 05% {salario+reajust} o reajuste foi de {reajust}");
}


/*
    Difícil 12- Faça um programa para o cálculo de uma folha de pagamento, sabendo que os descontos são do imposto de Renda,
   que depende do salário bruto (conforme tabela abaixo) e 3% para o Sindicato e que o FGTS corresponde a 11% do salário bruto, mas não é descontado (é a empresa que deposita.)

        O salário líquido corresponde ao salário bruto menos os descontos. O programa deverá pedir ao usuário o valor da sua hora e a quantidade de horas trabalhadas no mês.    a. Desconto do IR;
        b. Salário Bruto ate R$900,00 (inclusive) – Isento;
        c. Salário Bruto de R$ 1500, 00 (inclusive) – desconto de 5%;
        d. Salario bruto até R$ 2500,00 (Inclusive) – desconto de 10%;
        e. Salário bruto acima de 2500 – Desconto de 20%.
*/

double aliquota, aumento, novoSalario, percentual;

Console.WriteLine("Insira o salario por horas trabalhadas: \n");
double salarioHora = double.Parse(Console.ReadLine());
Console.WriteLine("\n Insira a quantidade de horas trabalhadas: ");
double hora = double.Parse(Console.ReadLine());

novoSalario = salarioHora * hora;

if(novoSalario <= 900)
{
    Console.WriteLine("O salario base é isento de aliquota \n");
} else if(novoSalario <= 1500)
{   
    Console.WriteLine($"O salario é {novoSalario} a aliquota é de {novoSalario*0.05} \n");
} else if (novoSalario <= 2500)
{
    Console.WriteLine($"O salario é {novoSalario} a aliquota é de {novoSalario*0.01} \n ");
}else{
    Console.WriteLine($"O salario é {novoSalario} a aliquota é de {novoSalario*0.02} ");
}



