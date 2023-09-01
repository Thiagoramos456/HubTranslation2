using System.Configuration;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Windows;
using System.Windows.Controls;
using HubFiles;
using LibreTranslate;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace HubTranslationUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IConfiguration Configuration;

        public MainWindow()
        {
            InitializeComponent();
            //InitializeConfiguration();
        }

        private void selectFolderBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void InitializeConfiguration()
        //{
        //    Configuration = new ConfigurationBuilder()
        //        .AddJsonFile("appsettings.json")
        //        .Build();

        //    var userSelectedFolder = Configuration.GetSection("AppSettings")["UserSelectedFolder"];

        //    if (!string.IsNullOrEmpty(userSelectedFolder))
        //    {
        //        folder_text.Text = userSelectedFolder;
        //    }
        //}

        //private void selectFolderBtn_Click(object sender, RoutedEventArgs e)
        //{
        //    CommonOpenFileDialog dialog = new CommonOpenFileDialog();
        //    dialog.IsFolderPicker = true;
        //    if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
        //    {
        //        folder_text.Text = dialog.FileName;
        //        var json = JsonSerializer.Serialize(new AppSettingsJson
        //        {
        //            AppSettings = new AppSettings
        //            {
        //                UserSelectedFolder = dialog.FileName
        //            }
        //        });

        //        File.WriteAllText("appsettings.json", json);

        //    }
        //}

        //private async void translate_button_Click(object sender, RoutedEventArgs e)
        //{
        //    Translation translation = new Translation();
        //    TranslationManager translationManager = new TranslationManager();

        //    var englishText = await translation.Translate(textToTranslate.Text, "en");
        //    var italianText = await translation.Translate(textToTranslate.Text, "it");
        //    var spanishText = await translation.Translate(textToTranslate.Text, "es");

        //    enDisplay.Content = englishText;
        //    itDisplay.Content = italianText;
        //    esDisplay.Content = spanishText;

        //    translationManager.AddTranslationToFile(folder.Text + "\\Bexcell.xml", key.Text, englishText);
        //    translationManager.AddTranslationToFile(folder.Text + "\\Bexcell-it-IT.xml", key.Text, italianText);
        //    translationManager.AddTranslationToFile(folder.Text + "\\Bexcell-pt-BR.xml", key.Text, textToTranslate.Text);
        //    translationManager.AddTranslationToFile(folder.Text + "\\Bexcell-es.xml", key.Text, spanishText);
        //}
    }
}
