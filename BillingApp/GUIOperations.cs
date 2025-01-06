using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;

namespace BillingApp
{
    public class GUIOperations
    {

        public void materialSkinSetup(MainForm testGUI)
        {
            var materialManager = MaterialSkinManager.Instance;
            materialManager.AddFormToManage(testGUI);

            materialManager.Theme = MaterialSkinManager.Themes.DARK;
            materialManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey800,
                Primary.Grey600, Accent.DeepOrange100,
                TextShade.WHITE
            );
        }

        public void LoginPageSkinSetup(LoginForm loginForm)
        {
            var materialManager = MaterialSkinManager.Instance;
            materialManager.AddFormToManage(loginForm);

            materialManager.Theme = MaterialSkinManager.Themes.DARK;
            materialManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey800,
                Primary.Grey600, Accent.DeepOrange100,
                TextShade.WHITE
            );
        }

        public void AddCustomerPageSkinSetup(AddCustomerForm addCustomerForm)
        {
            var materialManager = MaterialSkinManager.Instance;
            materialManager.AddFormToManage (addCustomerForm);

            materialManager.Theme = MaterialSkinManager.Themes.DARK;
            materialManager.ColorScheme = new ColorScheme(
                Primary.Grey800, Primary.Grey800,
                Primary.Grey600, Accent.DeepOrange100,
                TextShade.WHITE);
        }
    }
}
