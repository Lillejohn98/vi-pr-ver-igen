using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace contains._1
{
    class Program
    {
        static void Main(string[] args)
        {// vi starter med erklære vores forskelige variabler //
            string temp = "", fejl = "";
            string tegn = "";
            /* vi laver koden i et (do while loop) sådan så den vil gentage mindst engang
             * alt i looper vil gentage sig hvis der er erklærede andre tegn end tal  */

            do
            {// vi skriver fejl sådan så loopet kan identificere hvor dan skal starte igen hvis der var fejl i programmet første gang 
                fejl = "";
                //disse 2 sætninger nedenunder er bare til for at få vores information 
                Console.Write("indtast et nummer ; ");
                temp = Console.ReadLine();

                for (int pos = 0; pos <= temp.Length - 1; pos++) // dette er en bare for at tæle hvor mange karaktere vi har //
                {
                    tegn = temp.Substring(pos, 1);// arbejde er at læse en karakter af gangen

                    if ("0123456798".Contains(tegn)) /* læs den her kode bagfra så giver den mere menning
                                                      vi skriver lige her at det kun er de forskellige numre vi vil have */
                    {    
                    }
                    else// hvis personnen har skrevet andet end de numre vi har sat ind i contains så vil den gå her ned og identificere det som en fejl//
                    { 
                      fejl = "Not valid number found!";
                    }
                }
            } while (fejl != "");// og her har vi så sagt at hvis den identificere en fejl går den her ned og starter for fra 


            Console.Write("Number approved!");/* hvis du har skrevet et et tal uden numre vil den skrive number approved 
                                               * vi ku også bare skrive det var dejligt fordi det her er bare
                                               betyder bare at linjen er blevet identificeret som et nummer hvilket vi bedte om */ 
            Console.ReadKey();
        }
    }
}

