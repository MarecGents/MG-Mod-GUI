using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using GUI_New.Util;
using GUI_New.Models.enums;

namespace GUI_New
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

            string baseDictory = AppContext.BaseDirectory;
            text1.Text = baseDictory;
            JObject configJson = (new FileUtil()).getJsonFile(baseDictory, PathTypes.ModConfigList, "config.json");
            text1.Text = configJson.ToString();
        }
    }
}