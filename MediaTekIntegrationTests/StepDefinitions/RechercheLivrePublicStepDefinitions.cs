using System;
using MediaTekDocuments.model;
using MediaTekDocuments.view;
using Reqnroll;

namespace MediaTekIntegrationTests.StepDefinitions
{
    [Binding]
    public class RechercheLivrePublicStepDefinitions
    {
        private readonly FrmMediatek frm = new FrmMediatek(new Utilisateur(1, "Doe", "John", 4, "blabla"));
        [Given("Je saisis le type de public {string} dans le combobox")]
        public void GivenJeSaisisLeTypeDePublicDansLeCombobox(string jeunesse)
        {
            frm.Show();
            ComboBox cbxPublicDoc = (ComboBox)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["cbxLivresPublics"];
            cbxPublicDoc.SelectedIndex = 2;
            Assert.AreEqual(jeunesse, cbxPublicDoc.Text);
        }

        [Then("On observe l'unique livre nommé {string} dans la DataGridView")]
        public void ThenOnObserveLuniqueLivreNommeDansLaDataGridView(string p0)
        {
            DataGridView dgvLivres = (DataGridView)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["dgvLivresListe"];
            Assert.AreEqual(p0, dgvLivres.Rows[0].Cells["Titre"].Value);
        }
    }
}
