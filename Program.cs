string continuar;
do
{
    //coletando os dados da pessoa
    Console.WriteLine("Informe seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Qual sua idade? ");
    double idade= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Qual sua altura? ");
    double altura= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Qual seu peso? ");
    double peso= Convert.ToDouble(Console.ReadLine());


    //calculo do IMC
    double imc= peso / (altura * altura);
    string imcFormatado = imc.ToString("N2");


    string status;
    if (imc < 18.5)
    {
        status = "Abaixo do peso!";
    }
    else if (imc >= 18.5 && imc <= 24.9)
    {
        status = "Normal!";
    }
    else if (imc >= 25 && imc <= 29.9)
    {
        status = "Sobrepeso!";
    }
    else
    {
        status = "Obeso!";
    }

//calculo da faixa etária

    string faixa;
    if(idade <=12)
    {
        faixa= " Criança.";
    }
    else if (idade >=13 && idade<= 19){
        faixa= " Adolecente.";
    }
    else if (idade >=20 && idade<= 59){
        faixa= "Adulto.";
    }    
    else{
        faixa= "Idoso.";
    }

    //gerando relatório
    Console.WriteLine("------ Relatório de ìndice de Massa Corporal------");
    Console.WriteLine("Nome: " + nome);
    Console.WriteLine($"Seus dados: {idade} anos, {peso}kg, {altura}m");
    Console.WriteLine($"Seu IMC = {imcFormatado}" );
    Console.WriteLine("Categoria do seu IMC: " + status);
    Console.WriteLine("Sua faixa etária: " + faixa);

    //perguntar se deseja continuar
    Console.WriteLine("Deseja gerar um novo relatório? (s/n)");
    continuar = Console.ReadLine().ToLower();

}while (continuar == "s");
Console.WriteLine("Obrigado por usar este gerador de Relatório de IMC");