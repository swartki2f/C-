namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("debut du prog");
        

        Console.WriteLine("saisir votre nom   ");
        string nom= Console.ReadLine();

        Console.WriteLine("saisir votre age  ");
        //string age=

        //pour convertir : on utulise $Parse exemple:
        // int age_int= int.Parse(age_str)//

        //int age_num= int.Parse(age_str);
        //age_p= age_num +1;

        string nombreTexte =Console.ReadLine();
        int agen = int.Parse(nombreTexte);
        int age = agen + 1; 
        

        Console.WriteLine("je suis "+nom+" j'ai "+age+"ans");
























        System.Console.WriteLine("Fin du programme");
    }
}