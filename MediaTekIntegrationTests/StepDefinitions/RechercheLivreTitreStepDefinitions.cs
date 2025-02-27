using System;
using MediaTekDocuments.model;
using MediaTekDocuments.view;
using Reqnroll;

namespace MediaTekIntegrationTests.StepDefinitions
{
    [Binding]
    public class RechercheLivreTitreStepDefinitions
    {
        private readonly FrmMediatek frm = new FrmMediatek(new Utilisateur(1, "Doe", "John", 4, "blabla"));
        [Given("Je saisis le début du titre {string} dans la barre de recherche")]
        public void GivenJeSaisisLeDebutDuTitreDansLaBarreDeRecherche(string cata)
        {
            frm.Show();
            TextBox tbxTitreDoc = (TextBox)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["txbLivresTitreRecherche"];
            tbxTitreDoc.Text = cata;
            Assert.AreEqual(cata, tbxTitreDoc.Text);
        }

        [Then("Les informations du livre Catastrophes au brésil s'affichent dans la DataGridView")]
        public void ThenLesInformationsDuLivreCatastrophesAuBresilSaffichentDansLaDataGridView()
        {
            DataGridView dgvLivres = (DataGridView)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["dgvLivresListe"];
            Assert.AreEqual("Catastrophes au Brésil", dgvLivres.Rows[0].Cells["Titre"].Value);
        }
    }
}
