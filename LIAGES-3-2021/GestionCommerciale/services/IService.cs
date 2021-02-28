using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommerciale.services
{
    interface IService<C, P>
    {

        DataTable AjouterClient(C cmm);
        bool MettreEnFormeLaCommande(C cmm);
        List<C> SelectionnerClient();
        bool CreePersonne(P pers);
        P SeConnecter(String login, String pwd);
        P Article(String telephone);
        bool GererArticle(C cmm, A art, String Commande, String articleCommande, String quantiteCommande);
        

       

    }
}
