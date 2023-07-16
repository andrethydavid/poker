// See https://aka.ms/new-console-template for more information
//using System.Drawing;
//Console.WriteLine("Hello, World!");


int player = 0;
int casino = 0;
int card = 0;
int coins = 0;
string message = "";
string controlNuevaCarta = "";
string switchControl = "menu";
System.Random random = new System.Random();

while (true)
{
    Console.WriteLine("Bienvenidos al C A S I N O de Blackjack");
    Console.WriteLine("Cuantas monedas deseas para iniciar a jugar? Ingresa un numero entero.\n " +
        "Te recuerdo que cada ronda te cuesta una moneda.");
    coins = int.Parse(Console.ReadLine());

    for (int i = 0; i < coins; i++)
    {

        player = 0;
        casino = 0;

        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Si deseas empezar a jugar escribre '21'");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;

            case "21":
                do
                {
                    card = random.Next(1, 13);
                    player = player + card;
                    Console.WriteLine("Toma una carta");
                    Console.WriteLine($"Te salio el numero: {card}");
                    Console.WriteLine("Deseas otra carta?");
                    controlNuevaCarta = Console.ReadLine();
                } while (controlNuevaCarta == "Si" ||
                        controlNuevaCarta == "si" ||
                        controlNuevaCarta == "yes" ||
                        controlNuevaCarta == "Yes");

                casino = random.Next(13, 23);
                Console.WriteLine($"El casino saco un: {casino} !");

                if (player > casino && player < 22)
                {
                    message = "Ganaste la partida";
                    switchControl = "menu";
                }
                else if (player >= 22)
                {
                    message = "Te pasaste del limite, vuelve a intentarlo";
                    switchControl = "menu";
                }
                else if (player <= casino)
                {
                    message = "Perdiste vs el casino, vuelve a intentarlo";
                    switchControl = "menu";
                }
                else
                {
                    message = "Condicion no valida";
                    switchControl = "menu";
                }
                Console.WriteLine(message);
                break;

            default:
                Console.WriteLine("Valor ingresado no valido para el C A S I N O");
                break;
        }
    }
}
