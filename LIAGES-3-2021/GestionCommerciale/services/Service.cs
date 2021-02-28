using GestionCommerciale.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommerciale.services
{
    class Service
    {

        private DaoCommande daoCommande;
        private DaoPersonne daoPersonne;
        private DaoDetailcommande daoDetailcommande;

        public Service()
        {

            daoCommande = new DaoCommande();
            daoPersonne = new DaoPersonne();
            daoDetailcommande = new DaoDetailcommande();

        }

        public DataTable AjouterClient(Commande commande)
        {
            return daoPersonne.findByCommande(commande);
        }


        public bool MettreEnFormeLaCommande(Commande commande)
        {

            return daoCommande.Insert(commande) != 0;
        }

        public List<Commande> SelectionnerClient()
        {
            return daoCommande.FindAll();
        }


        public bool CreerPersonne(Personne pers)
        {
            return daoPersonne.Insert(pers) != 0;

        }

        public Article rechercherClient(String telephone)
        {

            return daoPersonne.FindClientByTelephone(telephone);

        }

        public bool GererArticle(Commande command, Article article, String Commande, String articleCommande, String quantiteCommande)
        {


            return daoPersonne.Insert(article) != 0;
        }

        public Personne SeConnecter(String login, String pwd)
        {
            return daoPersonne.FindUserConnect(login, pwd);
        }

     
    }
}

