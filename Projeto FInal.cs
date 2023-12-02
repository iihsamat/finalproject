//Stefeson

Console.Clear();

Console.WriteLine("Forme seu time de basquete dos sonhos");
Console.WriteLine(" ");

Thread.Sleep(2000);

Console.WriteLine("Top 20 MELHORES jogadores do mundo:");
Console.WriteLine(" ");

Console.WriteLine("+===================================+" );
Console.WriteLine("| TOP |       NOME      |  POSIÇÃO  |" );
Console.WriteLine("+===================================+" );

Dictionary<int, string[]> topJogadores = new Dictionary<int, string[]>
 {
            { 1, new string[] { " Michael Jordan ", "Armador" } },
            { 2, new string[] { "  LeBron James  ", "  Ala  "  } },
            { 3, new string[] { "  Kareem Abdul  ", "  Pivô "} },
            { 4, new string[] { "  Magic Johnson ", "Armador"} },
            { 5, new string[] { "Wilt Chamberlain","  Pivô "} },
            { 6, new string[] { "  Bill Russell  ", "  Pivô "} },
            { 7, new string[] { "   Larry Bird   ", "  Ala  "} },
            { 8, new string[] { "   Tim Duncan  ", "Ala-Pivô"} },
            { 9, new string[] { " Oscar Robertson", "Armador"} },
            { 10,new string[] { "  Kobe Bryant  ", "Armador"} },
            { 11,new string[] { "Shaquille O\'Neal", " Pivô "} },
            { 12,new string[] { "  Kevin Durant ", "  Ala  "} },
            { 13,new string[] { "Hakeem Olajuwon", "  Pivô "} },
            { 14,new string[] { " Julius Erving ", "  Ala  "} },
            { 15,new string[] { " Moses Malone  ", " Pivô  "} },
            { 16,new string[] { " Stephen Curry ", "Armador"} },
            { 17,new string[] { "Dirk Nowitzki ", "Ala-Pivô"} },
            { 18,new string[] { "  Giannis A.  ", "Ala-Pivô"} },
            { 19,new string[] { "  Jerry West   ", "Armador"} },
            { 20,new string[] { " Elgin Baylor  ", "  Ala  "} },
 };
foreach (var jogador in topJogadores)
        {
            Console.WriteLine($"| #{jogador.Key} | {jogador.Value[0]} |  {jogador.Value[1]}  |");
        }
Console.WriteLine("+===================================+");
Console.WriteLine(" ");

string[] time = new string[5];
 
for (int i = 0; i < 5; i++)
{
     string classe = "";
     if (i == 0)
         classe = "Armador";
     else if (i == 1 || i == 3) 
         classe = "Ala";
     else if (i == 2 || i == 4)
         classe = "Pivô";
     
    Console.WriteLine($"Adicione um jogador escolhendo o número dele");
    Console.WriteLine($"{i} jogador(es) selecionado(s).");
    Console.WriteLine(" ");
 
    int escolha;
    do
    {
                Console.Write($"Digite o número do jogador da classe {classe} para a posição {i + 1}: ");
                escolha = Convert.ToInt32(Console.ReadLine());
 
               
                if (topJogadores.ContainsKey(escolha))
                {
                    
                    if (!Array.Exists(time, jogador => jogador == null) && i == 2)
                    {
                        Console.WriteLine("Você já escolheu os dois pivôs.");
                    }
                    else if (time[i] != null)
                    {
                        Console.WriteLine("Escolha outra posição, esta posição já está preenchida.");
                    }
                    else if (topJogadores[escolha][1] == "Armador" && i != 0)
                    {
                        Console.WriteLine("Escolha outra opção, esta posição é para um ARMADOR.");
                    }
                    else if (topJogadores[escolha][1] == "Ala" && (i != 1 && i != 3))
                    {
                        Console.WriteLine("Escolha outra opção, esta posição é para uma ALA.");
                    }
                    else if (topJogadores[escolha][1] == "Pivô" && i != 2)
                    {
                        Console.WriteLine("Escolha outra opção, esta posição é para um PIVÔ.");
                    }
                    else
                    {
                        time[i] = topJogadores[escolha][0];
                        Console.WriteLine($"{topJogadores[escolha][0]} adicionado à posição {i + 1} do time.");
                    }
                }
                else
                {
                    Console.WriteLine("Número inválido. Tente novamente.");
                }
            } while (!topJogadores.ContainsKey(escolha) || time[i] == null);
 
            Console.WriteLine(" ");
        }
 Console.Clear();

Console.WriteLine("Seu time dos sonhos é:");
Console.WriteLine("+====================================+" );
Console.WriteLine("| TOP |      NOME        |  POSIÇÃO  |" );
Console.WriteLine("+====================================+" );
for (int i = 0; i < 5; i++)
{
     string classe = "";
     if (i == 0)
         classe = "Armador";
     else if (i == 1 || i == 3)
         classe = "Ala";
     else if (i == 2 || i == 4)
         classe = "Pivô";
     
    Console.WriteLine($"| {i + 1}ª  | {time[i],-16} |  {classe,-9}|");
}
Console.WriteLine("+====================================+");