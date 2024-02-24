using System;

namespace GenerateurMotDePasse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int minNumber = 4; 
            const int maxNumber = 16; 
            
            int lenghOfThePassword = AskNumberOfCharacters(minNumber, maxNumber, "Combien de caractères voulez-vous mettre dans votre mot de passe ? "); 
            System.Console.WriteLine($"Votre mot de passe doit contenir {lenghOfThePassword} caractères.");

        }

        public static int AskANumber(string question)
        {
            int userAnswerInt = 0; 
            bool verifyAnswerUser = false; 

            while (!verifyAnswerUser)
            {
                System.Console.Write(question);
                string userAnswer = Console.ReadLine(); 
                try
                {
                    userAnswerInt = int.Parse(userAnswer); 
                    verifyAnswerUser = true; 
                }
                catch (System.Exception)
                {

                    System.Console.WriteLine("ERREUR ! Merci de mettre un chiffre/nombre ! ");
                }
            }
            return userAnswerInt; 
        }

        public static int AskNumberOfCharacters(int min, int max, string question)
        {
            int isTrueNumberOfCharacters = 0; 
            while (isTrueNumberOfCharacters < min || isTrueNumberOfCharacters > max )
            {
                isTrueNumberOfCharacters = AskANumber(question); 
            }
            return isTrueNumberOfCharacters; 
        }

        public static int NumberIsPositiveAndNotNull(string question)
        {
            
            return 7; 
        }
    }
}
