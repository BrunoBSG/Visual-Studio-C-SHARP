class Personagem
{
    public string Nome {  get; set; } 
    public  Classes Classe { get; set; }
    public double Vida { get; set; } = 1000;
    public double maxVida { get; set; } = 1000;
    public double Ataque { get; set; } = 100;
    public int Defesa { get; set; } = 5;
    //public double Sorte { get; set; } = 1;
    public enum Classes
    {
        Guerreiro,
        Mago,
        Assasino
    }
    

    private static Random random = new Random();

    public Personagem(string nome, Classes classe, double vida, int ataque)  // Metodo construtor
    {
        this.Nome = nome;
        this.Classe = classe;
        this.Vida = vida;
        this.Ataque = ataque;



        if (this.Classe == Classes.Guerreiro)
        {
            this.Ataque = this.Ataque * 1.35; // 35% a mais de dano
            this.Vida = this.Vida * 1.25;

            this.Defesa = 40;
        }


        if (this.Classe == Classes.Mago)
        {
            this.Ataque = this.Ataque * 2.5; // 2 vezes e meia do ataque
            this.Vida = this.Vida * 0.75; // 75% da vida


            this.Defesa = 15;

        }


        if (this.Classe == Classes.Assasino)
        {
            this.Vida = this.Vida * 1.2;
            this.Ataque = this.Ataque * 1.75; // 25% a mais de dano
            //this.Sorte = this.Sorte = 2.5;
            this.Defesa = 30;

        }
        this.maxVida = this.Vida;

    
    }
    public void Golpe(Personagem alvo)
    {
        Ataque ataqueInfo = new Ataque();

        ataqueInfo.AtaqueBase = random.Next(1, (int)Ataque + 1);
        ataqueInfo.DefesaSorteada = random.Next(0, alvo.Defesa + 1);

        ataqueInfo.DanoBloqueado =
            ataqueInfo.AtaqueBase * (ataqueInfo.DefesaSorteada / 100.0);

        ataqueInfo.DanoFinal =
            ataqueInfo.AtaqueBase - ataqueInfo.DanoBloqueado;

        alvo.Vida = Math.Max(0, alvo.Vida - ataqueInfo.DanoFinal);

        Console.WriteLine($"{Nome} atacou {alvo.Nome}");
        Console.WriteLine($"Ataque: {ataqueInfo.AtaqueBase}");
        Console.WriteLine($"Defesa ativada: {ataqueInfo.DefesaSorteada}%");
        Console.WriteLine($"Dano bloqueado: {ataqueInfo.DanoBloqueado:F1}");
        Console.WriteLine($"Dano causado: {ataqueInfo.DanoFinal:F1}");
        Console.WriteLine($"Vida de {alvo.Nome}: {alvo.Vida:F1}/{alvo.maxVida:F1}");
    }


}



class Ataque
{
    public int AtaqueBase { get; set; }
    public int DefesaSorteada { get; set; }
    public double DanoBloqueado { get; set; }
    public double DanoFinal { get; set; }
}


class Guerra
{
    public Guerra(){ } // Metodo construtor

    public void Batalha(Personagem player1, Personagem player2)
    {
        Random random = new Random();

        int turno = 1;

        while (player1.Vida > 0 && player2.Vida > 0)
        {
            Console.WriteLine($"\n--- Turno {turno} ---");

            int rP1 = random.Next(0, 101);
            int rP2 = random.Next(0, 101);

            if (rP1 > rP2)
            {
                Console.WriteLine($"{player1.Nome} ataca!");
                player1.Golpe(player2);
            }
            else if (rP2 > rP1)
            {
                Console.WriteLine($"{player2.Nome} ataca!");
                player2.Golpe(player1);
            }
            else
            {
                Console.WriteLine("Empate! Ninguém atacou.");
            }
            
            Console.WriteLine("\nPressione Enter para o próximo turno...");
            Console.ReadLine();




            turno++;
        }

        Console.WriteLine("\n=== FIM DA BATALHA ===");

        if (player1.Vida <= 0)
        {
            Console.WriteLine($"{player2.Nome} venceu!");
        }
        else
        {
            Console.WriteLine($"{player1.Nome} venceu!");
        }
    }
}







class Inimigo
{
    public double Vida { get; set; }
    public double Ataque { get; set; }
    public int Defesa { get; set; }
    public tipoInimigo Tipo { get; set; }

    public enum tipoInimigo
    {
        Goblin,
        Esqueleto,
        Dragao
    }

    public Inimigo(tipoInimigo tipo)
    {
        Tipo = tipo;

        switch (tipo)
        {
            case tipoInimigo.Goblin:
                Vida = 300;
                Ataque = 50;
                Defesa = 10;
                break;

            case tipoInimigo.Esqueleto:
                Vida = 600;
                Ataque = 90;
                Defesa = 20;
                break;

            case tipoInimigo.Dragao:
                Vida = 2500;
                Ataque = 200;
                Defesa = 35;
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        Personagem p1 = new Personagem("Bruno", Personagem.Classes.Mago, 1000, 100);
        Personagem p2 = new Personagem("John", Personagem.Classes.Guerreiro, 1000, 100);
        Guerra g1 = new Guerra();
        g1.Batalha(p1, p2);

    }
}


//Classe de armas exemplo personagem guerreiro com um machado e outro guerreiro com uma espada,
//mago com um cetro e outro com um grimorio

//Classe de loja/vendas ex:um merecador que você encontra e ele pode vender ou trocar seus itens por equipamentos como espadas e poçã ode vida

//Classe armadura com resiste fixa