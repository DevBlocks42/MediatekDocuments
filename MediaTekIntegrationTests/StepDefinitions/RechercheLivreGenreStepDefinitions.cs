using System;
using MediaTekDocuments.model;
using MediaTekDocuments.view;
using Reqnroll;

namespace MediaTekIntegrationTests.StepDefinitions
{
    [Binding]
    public class RechercheLivreGenreStepDefinitions
    {
        private readonly FrmMediatek frm = new FrmMediatek(new Utilisateur(1, "Doe", "John", 4, "blabla"));
        [Given("Je sélectionne le genre correspondant à science fiction dans le GroupBox")]
        public void GivenJeSelectionneLeGenreCorrespondantAScienceFictionDansLeGroupBox()
        {
            frm.Show();
            ComboBox cbxGenreDoc = (ComboBox)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["cbxLivresGenres"];
            cbxGenreDoc.SelectedIndex = 16;
            Assert.AreEqual("Science Fiction", cbxGenreDoc.Text);
        }

        [Then("On observe l'unique livre nommé La Planète des singes dans la DataGridView")]
        public void ThenOnObserveLuniqueLivreNommeLaPlaneteDesSingesDansLaDataGridView()
        {
            DataGridView dgvLivres = (DataGridView)frm.Controls["tabOngletsApplication"].Controls["tabLivres"].Controls["grpLivresRecherche"].Controls["dgvLivresListe"];
            Assert.AreEqual("La planète des singes", dgvLivres.Rows[0].Cells["Titre"].Value);
        }
    }
}
