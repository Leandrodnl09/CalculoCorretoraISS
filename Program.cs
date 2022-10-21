
string mes = DateTime.Now.Month.ToString("D2");
string ano = DateTime.Now.Year.ToString("D4");
int opcao = 1;
double valor;
double bradesco = 0.00;
double allianz = 0.00;
double azul = 0.00;
double hdi = 0.00;
double sompo = 0.00;
double portoSeguro = 0.00;
double sulAmerica = 0.00;
double liberty = 0.00;
double mapfreVida = 0.00;
double mapfreGeral = 0.00;
double tokioMarine = 0.00;
double total = 0.00;

while (opcao != 0)
{
    Console.WriteLine();
    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////");
    Console.WriteLine("---------------------- DIGITE A SEGURADORA DESEJADA -------------------------");
    Console.WriteLine();
    Console.WriteLine("--------------------------- 1 - BRADESCO       ------------------------------");
    Console.WriteLine("--------------------------- 2 - ALLIANZ        ------------------------------");
    Console.WriteLine("--------------------------- 3 - AZUL           ------------------------------");
    Console.WriteLine("--------------------------- 4 - HDI            ------------------------------");
    Console.WriteLine("--------------------------- 5 - SOMPO          ------------------------------");
    Console.WriteLine("--------------------------- 6 - PORTO SEGURO   ------------------------------");
    Console.WriteLine("--------------------------- 7 - SUL AMÉRICA    ------------------------------");
    Console.WriteLine("--------------------------- 8 - LIBERTY        ------------------------------");
    Console.WriteLine("--------------------------- 9 - TÓQUIO MARINE  ------------------------------");
    Console.WriteLine("-------------------------- 10 - MAPFRE (VIDA)  ------------------------------");
    Console.WriteLine("-------------------------- 11 - MAPFRE (GERAL) ------------------------------");
    Console.WriteLine("--------------------------- 0 - SAIR           ------------------------------");
    Console.WriteLine("/////////////////////////////////////////////////////////////////////////////");
    Console.WriteLine();
    Console.Write(" DIGITE A OPÇÃO DESEJADA -->>  ");
    opcao = int.Parse(Console.ReadLine());

    if(opcao != 0){
    Console.WriteLine();
    Console.WriteLine("Opção Invalida!");
    }

    switch (opcao){
        case 1:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor do BRADESCO R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        bradesco = bradesco + (valor * 100 / 97.99); break;

        case 2:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor da ALLIANZ R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        allianz = allianz + (valor * 100 / 97.99); break;

        case 3:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor da AZUL R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        azul = azul + (valor * 100 / 97.99); break;

        case 4:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor da HDI R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        hdi = hdi + (valor * 100 / 97.99); break;

        case 5:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor da SOMPO R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        sompo = sompo + (valor * 100 / 97.99); break;

        case 6:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor da PORTO SEGURO R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        portoSeguro = portoSeguro + (valor * 100 / 97.99); break;

        case 7:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor da SUL AMÉRICA R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        sulAmerica = sulAmerica + (valor * 100 / 97.99); break;

        case 8:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor da LIBERTY R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        liberty = liberty + (valor * 100 / 97.99); break;

        case 9:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor da TÓKIO MARINE R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        tokioMarine = tokioMarine + (valor * 100 / 97.99); break;

        case 10:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor da MAPFRE (VIDA) R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        mapfreVida = mapfreVida + (valor * 100 / 97.99); break;

        case 11:
        Console.Clear();
        Console.WriteLine();
        Console.Write("Digite o valor da MAPFRE (GERAL) R$:  ");
        valor = double.Parse(Console.ReadLine());
        total = total + valor;
        mapfreGeral = mapfreGeral + (valor * 100 / 97.99); break;
    }
}
Console.Clear();
Console.WriteLine("///////////////////////////////////////////////////////////////////////////////////////////////////////////");
Console.WriteLine();
Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<< RELATORIO FINAL!! >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
Console.WriteLine();
Console.WriteLine($"Comissão referênte à competência {mes}/{ano}. Empresa optante pelo Simples Nacional. (Trib. aprox. de 6%).");
Console.WriteLine();
Console.WriteLine(" TOTAL DE COMISSÃO: " + total.ToString("C2"));
Console.WriteLine();
total = total * 100 / 97.99;
Console.WriteLine(" TOTAL DE COMISSÃO S/ IMPOSTO: " + total.ToString("C2"));
Console.WriteLine();
Console.WriteLine();
Console.WriteLine(" BRADESCO - MUNICÍPIO (CNPJ: 51.990.695/0006-41):");
Console.WriteLine(" Valor da Nota Fiscal  " + bradesco.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine(" ALLIANZ - MUNICÍPIO (CNPJ: 61.573.796/0116-05):");
Console.WriteLine(" Valor da Nota Fiscal  " + allianz.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine(" AZUL - OUTRO MUNICÍPIO (CNPJ: 33.448.150/0011-93):");
Console.WriteLine(" Valor da Nota Fiscal  " + azul.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine(" HDI - MUNICÍPIO (CNPJ: 29.980.158/0022-81):");
Console.WriteLine(" Valor da Nota Fiscal  " + hdi.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine(" SOMPO - MUNICÍPIO (CNPJ: 61.383.493/0013-14):");
Console.WriteLine(" Valor da Nota Fiscal  " + sompo.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine(" PORTO SEGURO - MUNICÍPIO (61.198.164/0065-24):");
Console.WriteLine(" Valor da Nota Fiscal  " + portoSeguro.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine(" SUL AMÉRICA - MUNICÍPIO (CNPJ: -- Consultar):");
Console.WriteLine(" Valor da Nota Fiscal  " + sulAmerica.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine(" LIBERTY - MUNICÍPIO (CNPJ: 61.550.141/0024-69):");
Console.WriteLine(" Valor da Nota Fiscal  " + liberty.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine(" TÓQUIO MARINE - MUNICÍPIO (CNPJ: 33.164.021/0105-98):");
Console.WriteLine(" Valor da Nota Fiscal  " + tokioMarine.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine(" MAPFRE (VIDA) - OUTRO MUNICÍPIO (CNPJ: 54.484.753/0001-49):");
Console.WriteLine(" Valor da Nota Fiscal  " + mapfreVida.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();
Console.WriteLine(" MAPFRE (GERAL) - MUNICÍPIO (CNPJ: 61.074.175/0075-74):");
Console.WriteLine(" Valor da Nota Fiscal  " + mapfreGeral.ToString("C3"));
Console.WriteLine("-----------------------------------------------------------------------------------------------------------");
Console.WriteLine();

