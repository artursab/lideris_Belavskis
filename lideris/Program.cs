using System;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 0;

            Console.WriteLine("\n\tVai esi derīgs vadošam darbam?");
            Console.WriteLine("\tUz šo jautājumu var saņemt samērā ticamu atbildi, kaut gan tiks pārbaudīta tikai viena īpašība – izlēmība.");
            Console.WriteLine("\tAtbildē varbūt tikai 'ja' vai 'ne': ");

            Console.WriteLine("\nA. Vai jūs parasti noliedzat savu vainu, ja jūsu rīcība izraisījusi nepatīkamas sekas?");
            string answerA = Console.ReadLine().ToLower();
            int pointsA = answerA == "ne" ? 4 : 0;
            totalPoints += pointsA;

            Console.WriteLine("\nB. Vai jūs, cilvēkam kaut ko atsakot, nosauciet patiesos motīvus vai slēpjat tos aiz dažādiem aizbildinājumiem par apstākļiem, sakritībām, vajadzībām utt.?");
            string answerB = Console.ReadLine().ToLower();
            int pointsB = answerB == "ja" ? 2 : 0;
            totalPoints += pointsB;

            Console.WriteLine("\nC. Vai diskusija par kādu jautājumu vai problēmu maina jūsu uzskatus?");
            string answerC = Console.ReadLine().ToLower();
            int pointsC = answerC == "ja" ? 3 : 0;
            totalPoints += pointsC;

            Console.WriteLine("\nD. Ja jums rodas iespēja pāriet uz labāk atalgotu darbu, vai darīsiet to nešauboties?");
            string answerD = Console.ReadLine().ToLower();
            int pointsD = answerD == "ja" ? 2 : 0;
            totalPoints += pointsD;

            Console.WriteLine("\nE. Vai jūs viegli pielāgojieties jaunā darba vietā, jauno kolēģu vidū?");
            string answerE = Console.ReadLine().ToLower();
            int pointsE = answerE == "ja" ? 4 : 0;
            totalPoints += pointsE;

            Console.WriteLine("\nF. Jūs ilgāku laiku strādājat vienā darbā, bet atnācis jauns vadītājs. Vai jums būs viegli pielāgoties (pakļauties) viņa pieprasītajām izmaiņām darbā?");
            string answerF = Console.ReadLine().ToLower();
            int pointsF = answerF == "ja" ? 3 : 0;
            totalPoints += pointsF;

            Console.WriteLine("\nG. Ja jūsu uzskati nesakrīt ar vadītāja viedokli, vai esat gatavs darba sanāksmē par to atklāti runāt?");
            string answerG = Console.ReadLine().ToLower();
            int pointsG = answerG == "ja" ? 3 : 0;
            totalPoints += pointsG;

            Console.WriteLine("\nH. Vai jūs vienmēr izpildiet to ko esiet solījis?");
            string answerH = Console.ReadLine().ToLower();
            int pointsH = answerH == "ja" ? 3 : 0;
            totalPoints += pointsH;

            Console.WriteLine("\nI. Vai jūs spējat nopirkt kādu priekšmetu, kas jums nav vajadzīgs, bet jums tas ļoti patīk?");
            string answerI = Console.ReadLine().ToLower();
            int pointsI = answerI == "ne" ? 2 : 0;
            totalPoints += pointsI;

            Console.WriteLine("\nJ. Vai pieļaujat , ka kāda cilvēka personības pievilcība var mainīt jūsu pieņemto lēmumu?");
            string answerJ = Console.ReadLine().ToLower();
            int pointsJ = answerJ == "ne" ? 3 : 0;
            totalPoints += pointsJ;

            Console.WriteLine("\nK. Vai jūs pieprasīsiet mainīt tekstu, kura saturs ir pareizs, bet forma un stils neapmierina?");
            string answerK = Console.ReadLine().ToLower();
            int pointsK = answerK == "ja" ? 2 : 0;
            totalPoints += pointsK;


            //table

            Console.WriteLine("\n\t-----------------------------------------------------");

            Console.WriteLine("\t| A | B | C | D | E | F | G | H | I | J | K | SUMMA |");
            Console.WriteLine("\t-----------------------------------------------------");
            Console.WriteLine($"\t| {pointsA} | {pointsB} | {pointsC} | {pointsD} | {pointsE} | {pointsF} | {pointsG} | {pointsH} | {pointsI} | {pointsJ} | {pointsK} | {totalPoints} |");

            Console.WriteLine("\t-----------------------------------------------------\n");

            if (totalPoints >= 28 && totalPoints <= 31)
            {
                Console.WriteLine("jums šaubas vispār ir svešas. Jūs sevi uzskatiet par ļoti zinošu cilvēku un " +
                    "noraidiet ikvienu priekšlikumu vai kritiku. Jūsu ideāls ir\r\nvaldošs cilvēks, jūs cenšaties " +
                    "viņam līdzināties. Neveiksmju gadījumā jums ir tendence vainot apstākļus, citus cilvēkus. " +
                    "Ar savu darbību jūs\r\napslāpējiet citu iniciatīvu, radošas idejas. Ieteicams ieklausīties citos, pirms noliegt, padomāt.");
            }
            else if (totalPoints >= 19 && totalPoints <= 27)
            {
                Console.WriteLine(" lēmumu pieņemšana jums nesagādā grūtības. Jūs izanalizējiet faktus un esiet " +
                    "konsekvents savā darbībā, rīcība ir ātrā un,\r\nvisbiežāk, pareiza. Jūs aizstāvat savus pieņemtos " +
                    "lēmumus, bet, ja kļūdaties, lēmumu mainiet. Tomēr uzmanieties, lai panākumi nerada pārlieku\r\npašpārliecinātību, " +
                    "ir jomas, kurās jūs neesiet pietiekami zinošs, kompetents, tāpēc peņemot lēmumu būtu ieteicams kosultēties " +
                    "ar šīs jomas\r\nspeciālistiem.\r\n");
            }
            else if (totalPoints >= 10 && totalPoints <= 18)
            {
                Console.WriteLine("lēmumus jūs pieņemiet uzmanīgi, tomēr vajadzības brīdi spējiet rīkoties izlēmīgi. " +
                    "Ja ir laiks pārdomām, jūs ļaujaties šaubām,\r\ncenšaties salīdzināt dažādu lēmumu priekšrocības vai vājās puses, " +
                    "meklējiet iespēju konsultēties ar kādu, lai gan pilnībā lēmumu variet pieņemt\r\npats. Jums ieteicams vairāk uzticēties sev.");
            }
            else
            { 
                Console.WriteLine("jāatzīst, ka nepiederiet pie izlēmīgiem cilvēkiem. Jūs ilgi pārdomājiet katru lēmumu, izvērtējot argumentus par un pret." +
                    " Jūs\r\nneiebilstat, ja kāds cits pieņem lēmumu. Gadās, ka sava bailīguma un neizlēmības dēļ pieviļat savus draugus. " +
                    "Jūsu zināšanas un darbs cieš no jūsu\r\nnedrošības. Mēģiniet mazināt nedrošību, neizlēmību. Sakumā pieņemiet lēmumus, " +
                    "kas saistīti tieši ar jums pašu, centieties izpildīt nolemto.\r\n");
            }
        }
    }
}


