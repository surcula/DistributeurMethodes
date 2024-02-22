/*
  Un magasin en ligne propose 3 articles
    Coca : 1€ (stock 4)
    Sandwich : 5€ (stock 2)
    Porte : 200€ (stock 3)

    Tant que l'utiliseur veut continuer ses achats, le programme
    continue à lui proposer la liste des articles en stock
    et lui demande de faire son choix (1 2 ou 3 )

    Quand il choisit d'arrêter, le programme affiche le total à payer
 
    L'affichage des articles (stocké dans une collection) 
    se fera à l'aide d'une méthode (void)


    le retrait d'un article du stock se fait via méthode

 */

using DistributeurMethodes;

string userMenu;
double total = 0;


Outils.Initialize();
do
{
    Console.WriteLine($"Voici le total à payer : {total}");
    userMenu = Outils.Menu(ref Outils.dictionnaryDistributeur);
    total += Outils.Choix(userMenu, ref Outils.dictionnaryDistributeur);

} while (userMenu != "4");

Console.WriteLine($"Voici le total à payer : {total}");


