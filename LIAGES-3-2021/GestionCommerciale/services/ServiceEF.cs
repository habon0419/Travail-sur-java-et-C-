using GestionCommerciale.EntityFramework;
using GestionCommerciale.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionCommerciale.services
{

   
    class ServiceEF : IService<Commande, personne>
    {
        private gestion_commercialeEntities2 ctx = new gestion_commercialeEntities2();
        public DataTable AjouterClient(Commande cmm)
        {
            throw new NotImplementedException();
        }

        public personne Article(string telephone)
        {
            return ctx.personne.Where(
               (p) => p.login.CompareTo(telephone) == 0 
               ).FirstOrDefault();
        }

        public bool CreePersonne(personne pers)
        {
            ctx.personne.Add(pers);
            return ctx.SaveChanges() != 0;
        }

        public bool GererArticle(Commande cmm, A art, string Commande, string articleCommande, string quantiteCommande)
        {
            ctx.personne.Add(cmm,);
            return ctx.SaveChanges() != 0;
        }

        public bool MettreEnFormeLaCommande(Commande cmm)
        {
           
                
                ctx.personne.Where(
                    (p) => p.CompareTo("Commande") == 0 && p.Commande_id == cmm.id
                    ).ToList();
                return null;
            
        }

        public personne SeConnecter(string login, string pwd)
        {
            return ctx.personne.Where(
               (p) => p.login.CompareTo(login) == 0 && p.pwd.CompareTo(pwd) == 0
               ).FirstOrDefault();
        }

        public List<client> SelectionnerClient()
        {
            return ctx.client.ToList();
        }
    }
}
