using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System.Collections.Generic;

namespace PI1_AssociatingParametersToGlobal
{
    [Transaction(TransactionMode.Manual)]
    [Regeneration(RegenerationOption.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;

            var window = new CommandForm(uidoc);
            window.ShowDialog();

            return Result.Succeeded;
        }

        public void AssotiateWithGlobalParameter(Document doc, ElementId familyId, Definition familyParameterDefinition, ElementId globalParameterId)
        {
            Family family = doc.GetElement(familyId) as Family;

            ISet<ElementId> familySymbolIds = family.GetFamilySymbolIds();

            using (Transaction t = new Transaction(doc))
            {
                t.Start("Привязка глобального параметра");
                foreach (ElementId symbolId in familySymbolIds)
                {
                    Element symbol = doc.GetElement(symbolId);
                    Parameter familyParameter = symbol.get_Parameter(familyParameterDefinition);
                    familyParameter.AssociateWithGlobalParameter(globalParameterId);
                }
                t.Commit();
            }
        }

        public static string GetPath()
        {
            return typeof(Command).Namespace + "." + nameof(Command);
        }
    }
}
