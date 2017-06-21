using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Urgence_N_4_Formation_Neo_Solution
{
    class Program
    {
        /* Encore une fois nous avons besoin de vous en urgence...
         * Connaissez vous le chiffrement de César? Parfait!
         * A vous de décrypter ce message !
         * 
         * Au cas où, le chiffrement de César est un chiffrement par décallage.
         * En utilisant les fonctions fournies, à vous de déchiffrer ces messages codés!
         * 
         * Pour plus se simplicité, ces messages ne contiendrons pas de ponctuation ni accent,
         * et seront écrit en minuscule. Il y aura tout de même des espaces (on est pas
         * sur Twitter!). A vous de vous renseigner pour savoir comment 
         * parcourir une string pour y trouver chaque élément, puis comment
         * remplacer chaque lettre par son équivalent...
         * 
         * TIPS : C'est quoi la table ASCII? Et une string, ne serait-ce pas une chaine de char?
         * Si on utilise une string comme un tableau de char, il est facile de le parcourir...
         * 
         * Attention, le décallage peut être négatif, ou supérieur à 26! Attention à votre décallage!
        */
        static void Main(string[] args)
        {
            string Message = "nfn mflj rmvq mirzdvek ivljjz sirmf vk av ufzj uziv hlv av jlzj zdgivjzfeev";

            Console.WriteLine(ChiffrementDeCesar(Message, 9));
        }

        static string ChiffrementDeCesar(string message, int decallage)
        {
            string NewMessage = "";

            // L'alphabet en entier!
            char[] alpha = { 'a', 'b', 'c', 'd', 'e', 'f', 'g',
                             'h', 'i', 'j', 'k', 'l', 'm', 'n',
                             'o', 'p', 'q', 'r', 's', 't', 'u',
                             'v', 'w', 'x', 'y', 'z' };

            decallage %= 26;
            if (decallage < 0)
            {
                decallage += 26;
            }

            // Decryptage!
            int indexDuChar = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] != ' ')
                {
                    for (int y = 0; y < alpha.Length; y++)
                    {
                        if (message[i] == alpha[y])
                        {
                            indexDuChar = y;
                        }
                    }

                    // Si décallage est positif, ne pas le faire dépasser 25
                    int decallageDuChar = indexDuChar + decallage;
                    if (decallageDuChar > 25)
                    {
                        decallageDuChar = decallageDuChar - 26;
                    }

                    // On ajoute la nouvelle lettre au message qu'on va imprimer
                    NewMessage = NewMessage + alpha[decallageDuChar];
                }
                else
                    // On n'oublie pas les espaces!
                    NewMessage = NewMessage + " ";
            }
            return NewMessage;
        }
    }
}
