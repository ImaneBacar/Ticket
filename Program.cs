using static System.Console;
using System.Threading;


int vCompt=1,rCompt=1,iCompt=1;

int type;
string nom,prenom;
string response ="";

string dossier = "system";


bool nomValide(string name)
{
    return !string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter);
}

string GetNomValide(string message)
{
    string nom;
    do
    {
        WriteLine(message);
        nom = ReadLine().Trim();
        if (!nomValide(nom))
        {
            WriteLine("Le nom ou le prenom ne doivent pas être vide et ne doit contenir que des lettres.");
        }
    } while (!nomValide(nom));

    return nom;
}

if (!File.Exists(dossier))
        {
            Directory.CreateDirectory(dossier);
        }

string filePath = Path.Combine(dossier, "fnumero.txt");
string clientFilePath = Path.Combine(dossier, "client.txt");

       

        if (!File.Exists(filePath))
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {   
                writer.WriteLine(vCompt);
                writer.WriteLine(rCompt);
                writer.WriteLine(iCompt);
            }
        }
    
    nom = GetNomValide("Veuillez saisir votre nom : ");
    prenom = GetNomValide("Veuillez saisir votre prénom : ");
do{
   
    WriteLine("\nBonjour !\n\nQuel type d'operation vous êtes venu faire ? \n");

    WriteLine("1: Versement ");
    WriteLine("2: Retrait ");
    WriteLine("3: Informations");
    WriteLine("4: Quittez");
    WriteLine("\n");

while (true)
{
    try
    {
        WriteLine("\nVeuillez saisir le type.\n");
        type = int.Parse(ReadLine());
        break;
    }
    catch (FormatException)
    {
        WriteLine("\nVous devez saisir un nombre pour le type (1, 2 , 3 ou 4). Veuillez réessayer.\n");

        WriteLine("\nBonjour !\n\nQuel type d'operation vous êtes venu faire ? \n");

        WriteLine("1: Versement ");
        WriteLine("2: Retrait ");
        WriteLine("3: Informations");
        WriteLine("4: Quittez");
        WriteLine("\n");

    }
}

using (StreamReader reader = new StreamReader(filePath))
        {
            vCompt = int.Parse(reader.ReadLine());
            rCompt = int.Parse(reader.ReadLine());
            iCompt = int.Parse(reader.ReadLine());
        }

switch(type){
   
    case 1 :{
        WriteLine("\n\tV- votre numero est "+vCompt+" il y'a "+(vCompt-1)+" personnes qui attendent avant vous.\n");
        vCompt++;
        Thread.Sleep(1500);
        break;
    }
     case 2 :{
        WriteLine("\n\tR- votre numero "+rCompt+" il y'a "+(rCompt-1)+" personnes qui attendent avant vous.\n");
        rCompt++;
        Thread.Sleep(1500);
        break;
    }
     case 3 :{
        WriteLine("\n\tI- votre numero "+iCompt+" il y'a "+(iCompt-1)+" personnes qui attendent avant vous.\n");
        iCompt++;
        Thread.Sleep(1500);
        break;
    }
   case 4 : {
    WriteLine("\nLe programme va maintenant se fermer.\n\n");
    
    WriteLine("\nLes informations des clients sont les suivantes :\n");
    using (StreamReader reader = new StreamReader(clientFilePath)) {
        string line;
        while ((line = reader.ReadLine()) != null) {
            WriteLine(line);
        }
    }
    
    WriteLine("\n\n");
    File.Delete(filePath); 
    File.Delete(clientFilePath);
    Environment.Exit(0); 
    break;
}
    default :{
        WriteLine("\nVous devez saisir un nombre pour le type (1, 2 , 3 ou 4). Veuillez réessayer.\n");
        Thread.Sleep(1500);
        continue;
    }
}  
    string typeOp = (type == 1) ? "V" : (type == 2) ? "R" : (type == 3) ? "I" : " ";
    int typeNum = (type == 1) ? vCompt : (type == 2) ? rCompt : (type == 3) ? iCompt : 0;


    using (StreamWriter writer = new StreamWriter(clientFilePath, true))
      {
        writer.WriteLine($"Nom: {nom}, Prénom: {prenom}, type: {typeOp} - {typeNum-1}");
      }

    while(true){

    try{

        WriteLine("\nVous voulez prendre un autre ticket ?\n( OUI/oui OU NON/non)\n");
        response = ReadLine().Trim().ToUpper(); 
        if (response == "OUI"){
            break;
        }else if (response == "NON")
        {   
           nom = GetNomValide("Veuillez saisir votre nom : ");
           prenom= GetNomValide("Veuillez saisir votre prénom : ");
            break;    
        } else
                {
                    Console.WriteLine("\n Veuillez saisir OUI/oui ou NON/non.\n");
                }
    }catch(FormatException){
        WriteLine("\nVous devez saisir (OUI/oui ou NON/non).\n");
        Thread.Sleep(1500);
        }

    }
    using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(vCompt);
            writer.WriteLine(rCompt);
            writer.WriteLine(iCompt);
        }

    
}while(true);