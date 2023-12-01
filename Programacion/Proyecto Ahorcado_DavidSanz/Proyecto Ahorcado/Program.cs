using System;
namespace ProyectoAhorcado
{
    public class Practica
    {
        public static void Main()
        {
            int attempts = 0, turns = 0;
            bool solved = false;
            const string AsciiStageZero = @"                                             
                                     ___________.._______
                                    | .__________))______|
                                    | | / /      
                                    | |/ /       
                                    | | /        
                                    | |/         
                                    | |          
                                    | |    
                                    | |    
                                    | |    
                                    | |    
                                    | |    
                                    | |    
                                    | |          
                                    | |          
                                    | |          
                                    | |          
                                    | |         
                                    """"""""""""""""""""|_`-' `-' |""""""|
                                    |""|""""""""""""""\ \       '""|""|
                                    | |        \ \        | |
                                    : :         \ \       : :  
                                    . .                  . ."
            ;
            const string AsciiStageOne = @"                                             
                                     ___________.._______
                                    | .__________))______|
                                    | | / /      ||
                                    | |/ /       ||
                                    | | /        ||
                                    | |/         ||
                                    | |          ||
                                    | |          !!
                                    | |         
                                    | |       
                                    | |      
                                    | |    
                                    | |     
                                    | |       
                                    | |          
                                    | |          
                                    | |          
                                    | |         
                                    """"""""""""""""""""|_`-' `-' |""""""|
                                    |""|""""""""""""""\ \       '""|""|
                                    | |        \ \        | |
                                    : :         \ \       : :  
                                    . .          `'       . ."
            ;
            const string AsciiStageTwo = @"                                             
                                     ___________.._______
                                    | .__________))______|
                                    | | / /      ||
                                    | |/ /       ||
                                    | | /        ||.-''.
                                    | |/         |/  _  \
                                    | |          ||  `/,|
                                    | |          (\\`_.'
                                    | |        
                                    | |       
                                    | |     
                                    | |      
                                    | |     
                                    | |         
                                    | |        
                                    | |         
                                    | |          
                                    | |         
                                    """"""""""""""""""""|_`-' `-' |""""""|
                                    |""|""""""""""""""\ \       '""|""|
                                    | |        \ \        | |
                                    : :         \ \       : :  
                                    . .          `'       . ."
            ;
            const string AsciiStageThree = @"                                             
                                     ___________.._______
                                    | .__________))______|
                                    | | / /      ||
                                    | |/ /       ||
                                    | | /        ||.-''.
                                    | |/         |/  _  \
                                    | |          ||  `/,|
                                    | |          (\\`_.'
                                    | |          -`--'
                                    | |          |. .|
                                    | |          |   | 
                                    | |          | . |  
                                    | |          |   |   
                                    | |          .---.
                                    | |         
                                    | |         
                                    | |         
                                    | |         
                                    """"""""""""""""""""|_`-' `-' |""""""|
                                    |""|""""""""""""""\ \       '""|""|
                                    | |        \ \        | |
                                    : :         \ \       : :  
                                    . .          `'       . ."
            ;
            const string AsciiStageFour = @"                                             
                                     ___________.._______
                                    | .__________))______|
                                    | | / /      ||
                                    | |/ /       ||
                                    | | /        ||.-''.
                                    | |/         |/  _  \
                                    | |          ||  `/,|
                                    | |          (\\`_.'
                                    | |         .-`--'.
                                    | |        /Y . . Y\
                                    | |       // |   | \\
                                    | |      //  | . |  \\
                                    | |     ')   |   |   (`
                                    | |          .---.
                                    | |          
                                    | |          
                                    | |          
                                    | |         
                                    """"""""""""""""""""|_`-' `-' |""""""|
                                    |""|""""""""""""""\ \       '""|""|
                                    | |        \ \        | |
                                    : :         \ \       : :  
                                    . .          `'       . ."
            ;
            const string AsciiStageFive = @"                                             
                                     ___________.._______
                                    | .__________))______|
                                    | | / /      ||
                                    | |/ /       ||
                                    | | /        ||.-''.    ¡--------------¡
                                    | |/         |/  _  \   |  Asi me      |
                                    | |          ||  `/,|   |  tiene       |
                                    | |          (\\`_.'    |  la practia  |
                                    | |         .-`--'.     !______________!
                                    | |        /Y . . Y\      / /
                                    | |       // |   | \\    / /
                                    | |      //  | . |  \\  / /
                                    | |     ')   .---.   (`/-/
                                    | |          
                                    | |          
                                    | |         
                                    | |          
                                    | |         
                                    """"""""""""""""""""|_`-' `-' |""""""|
                                    |""|""""""""""""""\ \       '""|""|
                                    | |        \ \        | |
                                    : :         \ \       : :  
                                    . .          `'       . ."
            ;
            const string AsciiStageSix = @"                                             
                                     ___________.._______
                                    | .__________))______|
                                    | | / /      ||
                                    | |/ /       ||
                                    | | /        ||.-''.    ¡--------------¡
                                    | |/         |/  _  \   |              |
                                    | |          ||  `/,|   | ULTIM INTENT |
                                    | |          (\\`_.'    |              |
                                    | |         .-`--'.     !______________!
                                    | |        /Y . . Y\      / /
                                    | |       // |   | \\    / /
                                    | |      //  | . |  \\  / /
                                    | |     ')   .---.   (`/-/
                                    | |          || ||
                                    | |          || ||
                                    | |          || ||
                                    | |          || ||
                                    | |         / | | \
                                    """"""""""""""""""""|_`-' `-' |""""""|
                                    |""|""""""""""""""\ \       '""|""|
                                    | |        \ \        | |
                                    : :         \ \       : :  
                                    . .          `'       . ."
            ;
            
            const string Welcome = @"
                 _____                                                                                                                                                                         _____ 
                ( ___ )-----------------------------------------------------------------------------------------------------------------------------------------------------------------------( ___ )
                 |   |                                                                                                                                                                         |   | 
                 |   |                                                                                                                                                                         |   | 
                 |   |                                                                                                                                                                         |   | 
                 |   |      ######  ### ####### #     # #     # ####### #     # ### ######   #####        #    #             #    #     # ####### ######   #####     #    ######  #######      |   | 
                 |   |      #     #  #  #       ##    # #     # #       ##    #  #  #     # #     #      # #   #            # #   #     # #     # #     # #     #   # #   #     # #     #      |   | 
                 |   |      #     #  #  #       # #   # #     # #       # #   #  #  #     # # ### #     #   #  #           #   #  #     # #     # #     # #        #   #  #     # #     #      |   | 
                 |   |      ######   #  #####   #  #  # #     # #####   #  #  #  #  #     # # ### #    #     # #          #     # ####### #     # ######  #       #     # #     # #     #      |   | 
                 |   |      #     #  #  #       #   # #  #   #  #       #   # #  #  #     # # ####     ####### #          ####### #     # #     # #   #   #       ####### #     # #     #      |   | 
                 |   |      #     #  #  #       #    ##   # #   #       #    ##  #  #     # #          #     # #          #     # #     # #     # #    #  #     # #     # #     # #     #      |   | 
                 |   |      ######  ### ####### #     #    #    ####### #     # ### ######   #####     #     # #######    #     # #     # ####### #     #  #####  #     # ######  #######      |   | 
                 |   |                                                                                                                                                                         |   | 
                 |   |                                                                                                                                                                         |   | 
                 |___|                                                                                                                                                                         |___| 
                (_____)-----------------------------------------------------------------------------------------------------------------------------------------------------------------------(_____)   
             ";
            const string Victory = @"

            (\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)
            (/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)
            (\o/)                                                                                (\o/)
            (/|\)  |   |     \      ___|       ___|  |   |    \      \  | \ \   /   \  __ __| |  (/|\)
            (\o/)  |   |    _ \   \___ \      |      |   |   _ \      \ |  \   /   _ \    |   |  (\o/)
            (/|\)  ___ |   ___ \        |     |   |  |   |  ___ \   |\  |     |   ___ \   |  _|  (/|\)
            (\o/) _|  _| _/    _\ _____/     \____| \___/ _/    _\ _| \_|    _| _/    _\ _|  _)  (\o/)
            (/|\)                                                                                (/|\)
            (\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)(\o/)
            (/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)(/|\)

            ";
            const string Defeat = @"

            /====================================================================\
            ||                                                                  ||
            ||     __  _____   _____     ____  __________  ____  __  ________   ||
            ||    / / / /   | / ___/    / __ \/ ____/ __ \/ __ \/ / / /_  __/   ||
            ||   / /_/ / /| | \__ \    / /_/ / __/ / /_/ / / / / / / / / /      ||
            ||  / __  / ___ |___/ /   / ____/ /___/ _, _/ /_/ / /_/ / / / _ _   ||
            || /_/ /_/_/  |_/____/   /_/   /_____/_/ |_/_____/\____/ /_(_|_|_)  ||
            ||                                                                  ||
            \====================================================================/

            ";
            const string Choose = "Porfavor, escoje un nivel de dificultat: ", DifEasy = "A. FÁCIL", DifMid = "B. MEDIA", DifHard = "C. DIFICIL", DifExpert = "D. EXPERTO"; //messages first screen
            string[] arrayAscii = { AsciiStageSix, AsciiStageFive, AsciiStageFour, AsciiStageThree, AsciiStageTwo, AsciiStageOne, AsciiStageZero }; //array to order prints
            const string Error = "Escribe un valor correcto", ReadLetter = "Escribe una letra (vocal o consonante)", Minium = "Escribe una frase de minimo 2 palabras: ", Sentence = "Escribe una frase: ", Res = "(Alta resolució recomendada)";
            string choosed = " ", word = " ";
            char answer = ' ', startAlphabet = 'A';
            char[,] Alphabet = new char[3, 9];
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Welcome);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Res);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Choose);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(DifEasy);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(DifMid);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(DifHard);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(DifExpert);
            Console.ResetColor();
            choosed = Console.ReadLine().ToUpper();
            while (choosed != "A" && choosed != "B" && choosed != "C" && choosed != "D") //choose dificult
            {
                Console.WriteLine(Error);
                choosed = Console.ReadLine().ToUpper();
            }
            if (choosed == "B" || choosed == "C") Console.WriteLine(Minium);
            else Console.WriteLine(Sentence);
            string textWord = Console.ReadLine().ToUpper(); //read user sentence
            string[] palabras = textWord.Split(' '); //split string and save it on an array (posibility to add more split methods)
            for (int i = 0; i < palabras.Length - 1; i++)
            {
                for (int j = i + 1; j < palabras.Length; j++)
                {
                    if (palabras[i].Length > palabras[j].Length) //bubblesort to order strings length (- to +)
                    {
                        string aux = palabras[i];
                        palabras[i] = palabras[j];
                        palabras[j] = aux;
                    }
                }
            }
            if (choosed == "A")
            {
                attempts = 7;
                for (int i = 0; i < 1; i++) word = palabras[i]; //select smallest string
            }
            else if (choosed == "B")
            {
                attempts = 5;
                for (int i = 0; i < 1; i++) word = palabras[i+1]; //select smallest word
            }
            else if (choosed == "C")
            {
                attempts = 4;
                for (int i = palabras.Length; i > palabras.Length - 1; i--) word = palabras[i - 2]; // biggest string select
            }
            else if (choosed == "D")
            {
                attempts = 3;
                for (int i = palabras.Length; i > palabras.Length - 1; i--) word = palabras[i - 1]; // biggest string select
            }
            bool[] boolArray = new bool[word.Length]; //create bool array for (_)
            for (int i = 0; i < boolArray.Length; i++) boolArray[i] = false; //set false all values
            Console.Clear();
            Console.WriteLine("Comencem");
            Console.WriteLine();
            for (int i = 0; i < Alphabet.GetLength(0); i++)      //store matrix values
            {
                for (int j = 0; j < Alphabet.GetLength(1); j++)
                {
                    Alphabet[i, j] = startAlphabet;
                    startAlphabet++;
                    if (i == 2 && j == 8)
                    {
                        Alphabet[i, j] = 'Ñ';
                    }
                }
            }
            while (attempts >= 1 && solved == false)
            {
                Console.WriteLine($"INTENTOS RESTANTES: {attempts}");
                Console.WriteLine();
                for (int i = 0; i < Alphabet.GetLength(0); i++)  //print matrix values
                {
                    for (int j = 0; j < Alphabet.GetLength(1); j++)
                    {
                        if (Alphabet[i, j] == answer)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(Alphabet[i, j] + " ");
                            Console.ResetColor();
                            Alphabet[i, j] = '-';
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(Alphabet[i, j] + " ");
                            Console.ResetColor();
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < word.Length; i++)    //print letters or under_lines "( _ _ _ _ )"
                {
                    if (boolArray[i] == true) Console.Write($"{word[i]} ");
                    else Console.Write("_ ");
                }
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = attempts; i < attempts + 1; i++)  //print hangman 
                {
                    if (attempts >= 7) Console.WriteLine(arrayAscii[6]);  //if you have more than max attemps, print first position
                    else Console.WriteLine(arrayAscii[i - 1]);
                }
                Console.ResetColor();
                Console.WriteLine(ReadLetter);
                answer = Convert.ToChar(Console.ReadLine()); //read user answer
                answer = Char.ToUpper(answer);
                if (word.Contains(answer))
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (word[i] == answer) boolArray[i] = true;
                    }
                    attempts++;
                }
                else attempts--;
                turns++;
                Console.Clear();
                if (!boolArray.Contains(false)) solved = true;  //end program
            }
            if (solved == true) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(Victory);
            }
            else 
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(Defeat); 
            }
        }
    }
}

