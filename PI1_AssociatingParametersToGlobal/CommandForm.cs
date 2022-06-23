using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PI1_AssociatingParametersToGlobal
{
    public partial class CommandForm : System.Windows.Forms.Form
    {
        #region prevate members

        private UIDocument uidoc = null;

        private Document doc = null;

        private ElementId familyId { get; set; }

        private Definition familyParameterDefinition { get; set; }

        private ElementId globalParameterId { get; set; }

        #endregion

        #region constructor

        public CommandForm(UIDocument uIDocument)
        {
            uidoc = uIDocument;
            doc = uidoc.Document;
            InitializeComponent();
        }


        #endregion

        #region events

        private void CommandForm_Load(object sender, EventArgs e)
        {
            PopulateFamilyList();
            PopulateGlobalParameterList();
        }

        private void cmbFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            familyId = ((KeyValuePair<string, ElementId>)cmbFamily.SelectedItem).Value;

            if (familyId != null)
            {
                PopulateFamilyParameterList(familyId);
            }
        }

        private void cmbFamilyParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            familyParameterDefinition = ((KeyValuePair<string, Definition>)cmbFamilyParameter.SelectedItem).Value;
        }

        private void cmbGlobalParameter_SelectedIndexChanged(object sender, EventArgs e)
        {
            globalParameterId = ((KeyValuePair<string, ElementId>)cmbGlobalParameter.SelectedItem).Value;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Command cm = new Command();
            cm.AssotiateWithGlobalParameter(doc, familyId, familyParameterDefinition, globalParameterId);
        }

        #endregion

        #region private methods

        private void PopulateFamilyList()
        {
            var families = new FilteredElementCollector(doc)
                .OfClass(typeof(Family));

            var list = new List<KeyValuePair<string, ElementId>>();
            foreach (var family in families)
            {
                list.Add(new KeyValuePair<string, ElementId>(family.Name, family.Id));
            }

            cmbFamily.DataSource = new BindingSource(list, null);
            cmbFamily.DisplayMember = "Key";
            cmbFamily.ValueMember = "Value";
        }

        private void PopulateFamilyParameterList(ElementId familyId)
        {
            Family family = doc.GetElement(familyId) as Family;
            ElementId familySymbolId = family.GetFamilySymbolIds().ToList().First();
            ParameterSet symbolParameters = doc.GetElement(familySymbolId).Parameters;

            var list = new List<KeyValuePair<string, Definition>>();
            foreach (Parameter parameter in symbolParameters)
            {
                Definition parameterDefinition = parameter.Definition;
                string parameterName = parameterDefinition.Name;
                list.Add(new KeyValuePair<string, Definition>(parameterName, parameterDefinition));
            }

            cmbFamilyParameter.DataSource = new BindingSource(list, null);
            cmbFamilyParameter.DisplayMember = "Key";
            cmbFamilyParameter.ValueMember = "Value";
        }

        private void PopulateGlobalParameterList()
        {
            var globalParameterIds = GlobalParametersManager.GetAllGlobalParameters(doc);

            var list = new List<KeyValuePair<string, ElementId>>();
            foreach (ElementId parameterId in globalParameterIds)
            {
                Element globalParameter = doc.GetElement(parameterId);
                list.Add(new KeyValuePair<string, ElementId>(globalParameter.Name, globalParameter.Id));
            }

            cmbGlobalParameter.DataSource = new BindingSource(list, null);
            cmbGlobalParameter.DisplayMember = "Key";
            cmbGlobalParameter.ValueMember = "Value";
        }

        #endregion

    }
}
