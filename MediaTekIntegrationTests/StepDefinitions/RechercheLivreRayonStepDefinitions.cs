using System;
using MediaTekDocuments.model;
using MediaTekDocuments.view;
using Reqnroll;

namespace MediaTekIntegrationTests.StepDefinitions
{
    [Binding]
    public class RechercheLivreRayonStepDefinitions
    {
        private readonly FrmMediatek frm = new FrmMediatek(new Utilisateur(1, "Doe", "John", 4, "blabla"));
        [Given("Je sélectionne le type de rayon {string} dans le CBX")]
        public void GivenJeSelectionneLeTypeDeRayonDansLeCBX(string p0)
        {
            frm.Show();
            ComboBox cbxRayonDoc = (ComboBox)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["cbxLivresRayons"];
            cbxRayonDoc.SelectedIndex = 3;
            Assert.AreEqual(p0, cbxRayonDoc.Text);
        }

        [Then("On observe le seul livre présent dans la DGV nommé {string}")]
        public void ThenOnObserveLeSeulLivrePresentDansLaDGVNomme(string p0)
        {
            DataGridView dgvLivres = (DataGridView)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["dgvLivresListe"];
            Assert.AreEqual(p0, dgvLivres.Rows[0].Cells["Titre"].Value);
        }
    }
}
