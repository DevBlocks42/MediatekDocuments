using System;
using MediaTekDocuments.view;
using Reqnroll;
using MediaTekDocuments.model;

namespace MediaTekIntegrationTests.StepDefinitions
{
    [Binding]
    public class RechercheLivreNumeroStepDefinitions
    {
        private readonly FrmMediatek frm = new FrmMediatek(new Utilisateur(1, "Doe", "John", 4, "blabla"));
        [Given("Je saisis l'identifiant {string} dans la TextBox de recherche.")]
        public void GivenJeSaisisLidentifiantDansLaTextBoxDeRecherche_(string p0)
        {
            frm.Show();
            TextBox tbxNumDoc = (TextBox)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["txbLivresNumRecherche"];
            tbxNumDoc.Text = p0;
            Assert.AreEqual(p0, tbxNumDoc.Text);
        }

        [When("Je clique sur le bouton de recherche.")]
        public void WhenJeCliqueSurLeBoutonDeRecherche_()
        {
            Button btnRecherche = (Button)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["btnLivresNumRecherche"];
            btnRecherche.PerformClick();
        }

        [Then("Le résultat s'affiche dans la DataGridView")]
        public void ThenLeResultatSafficheDansLaDataGridView()
        {
            DataGridView dgvLivres = (DataGridView)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["dgvLivresListe"];
            Assert.AreEqual("Catastrophes au Brésil", dgvLivres.Rows[0].Cells["Titre"].Value);
        }
    }
}
