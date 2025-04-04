class CifraNome {
    public static void Main()
    {
        Console.Write("Digite seu nome completo: ");
        string nome = Console.ReadLine();   
        short alfabetoPtBr = 26;
        char[] letras = nome.ToCharArray();
        

        for (int i = 0; i < letras.Length; i++)
        {
            char l = letras[i];
           

            if (char.IsLetter(l))
            {
                char deslocando = (char)(l + 2);
                if((char.IsUpper(l) && deslocando > 'Z') || (char.IsLower(l) && deslocando > 'z'))
                {
                    
                    deslocando = (char)(deslocando - alfabetoPtBr);
                }

                letras[i] = deslocando;
            }
           

        }

        string nomeDeslocado = new string(letras);
        Console.WriteLine("Nome deslocado: " + nomeDeslocado);
        Console.ReadKey();
    }
}

