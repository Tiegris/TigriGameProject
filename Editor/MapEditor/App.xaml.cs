using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Drawing;

namespace MapEditor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Document document;
       
        public Document Document { get => document; }

        public void NewScenario() {
            if (document is null) {
                newScenario();
            } else {
                var result = MessageBox.Show("Are you sure? All unsaved progress will be lost!",
                    "Save warning", MessageBoxButton.YesNo,
                    MessageBoxImage.Warning, MessageBoxResult.No);
                if (result == MessageBoxResult.Yes)
                    newScenario();
            }
        }

        public void Save() {

        }

        private void newScenario() {

        }

        private void save() {

        }


    }
}
