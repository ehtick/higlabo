﻿using Google.Protobuf.WellKnownTypes;
using HigLabo.Core;
using HigLabo.Data;
using HigLabo.DbSharp.MetaData;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Tls.Crypto;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DbSharpApplication
{
    public partial class MainWindow : Window
    {
        public MainWindowViewModel ViewModel { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.SetText();

            ConfigData.Load();
            ConfigData.Current.EnsureFileExists();

            this.ViewModel = new MainWindowViewModel();
            this.DataContext = this.ViewModel;

            this.SchemeFileListComboBox.ItemsSource = ConfigData.Current.SchemeFilePathList;
            this.SchemeFileListComboBox.SelectionChanged += SchemeFileListComboBox_SelectionChanged;
            this.SchemeFileListComboBox.SelectedValue = ConfigData.Current.SchemeFilePathList[0];

            this.LanguageListComboBox.ItemsSource = this.ViewModel.LanguageList;
            this.LanguageListComboBox.SelectedItem = this.ViewModel.LanguageList.FirstOrDefault(el => el.Name == CultureInfo.CurrentCulture.Name);
            this.LanguageListComboBox.SelectionChanged += LanguageListComboBox_SelectionChanged;

            this.DatabaseServerComboBox.ItemsSource = this.ViewModel.DatabaseServerList;
            this.DatabaseServerComboBox.SelectedItem = this.ViewModel.DatabaseServerList[0];

            this.GenerateSettingListView.SelectionChanged += GenerateSettingListView_SelectionChanged;
            this.GenerateSettingListView.ItemsSource = SchemeData.Current.GenerateSettingList;

            this.ConnectionStringListComboBox.ItemsSource = ConfigData.Current.ConnectionStringList;
            this.ConnectionStringListComboBox.SelectionChanged += ConnectionStringListComboBox_SelectionChanged;

            this.GeneratePanel.Visibility = Visibility.Hidden;

            this.DatabaseObjectListView.ItemsSource = this.ViewModel.DatabaseObjectList;
            this.DatabaseObjectListView.MouseDoubleClick += DatabaseObjectListView_MouseDoubleClick;
            var cView = CollectionViewSource.GetDefaultView(this.ViewModel.DatabaseObjectList);
            cView.Filter = this.FilterDatabaseObject;
            this.FilterObjectTextBox.TextChanged += FilterObjectTextBox_TextChanged;

            this.Closing += MainWindow_Closing;
        }

        private void LanguageListComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var language = this.LanguageListComboBox.SelectedItem as MainWindowViewModel.LanguageSetting;
            if (language == null) { return; }

            CultureInfo.CurrentCulture = new CultureInfo(language.Name);
            this.SetText();
        }

        private void SetText()
        {
            this.OpenFilePathButton.Content = T.Text.Open;
            this.SaveFilePathButton.Content = T.Text.Save;
            this.DeleteFilePathButton.Content = T.Text.Delete;

            this.SettingListLabel.Content = T.Text.ConnectionList;
            this.AddSettingButton.Content = T.Text.Add;

            this.ManageConnectionStringButton.Content = T.Text.Settings;

            this.LoadStoredProcedureButton.Content = T.Text.LoadStoredProcedure + "(_S)";
            this.LoadUserDefinedTypeButton.Content = T.Text.LoadUserDefinedType + "(_U)";
            this.GenerateDefinitionButton.Content = T.Text.GenerateDefinition + "(_D)";
            this.OpenOutputFolderButton.Content = T.Text.OpenOutputFolder + "(_F)";
            this.GenerateButton.Content = T.Text.Generate + "(_G)";
        }
  
        private void GenerateSettingListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            this.GeneratePanel.Visibility = Visibility.Hidden;
            var setting = this.GetSelectedGenerateSetting();
            if (setting != null)
            {
                this.ConnectionStringListComboBox.SelectedItem = ConfigData.Current.ConnectionStringList.Find(el => el.Name == setting.ConnectionStringName);
            }
            this.ViewModel.DatabaseObjectList.Clear();
        }
        private GenerateSetting? GetSelectedGenerateSetting()
        {
            return this.GenerateSettingListView.SelectedItem as GenerateSetting;
        }

        private void SchemeFileListComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.SchemeFileListComboBox.SelectedValue == null) { return; }
            var filePath = this.SchemeFileListComboBox.SelectedValue.ToString();
            if (filePath == null) { return; }

            ConfigData.Current.SchemeFilePath = filePath;
            ConfigData.Current.LoadSchemeFile(filePath);
            this.GenerateSettingListView.ItemsSource = SchemeData.Current.GenerateSettingList;
        }
        private void OpenFilePathButton_Click(object sender, RoutedEventArgs e)
        {
            var dg = new System.Windows.Forms.OpenFileDialog();
            dg.InitialDirectory = System.IO.Path.GetDirectoryName(ConfigData.Current.SchemeFilePath);
            dg.Filter = "XMLファイル (*.xml)|*.xml|すべてのファイル (*.*)|*.*";
            if (dg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }
            ConfigData.Current.SchemeFilePath = dg.FileName;
            ConfigData.Current.SchemeFilePathList.Add(ConfigData.Current.SchemeFilePath);
            this.SchemeFileListComboBox.ItemsSource = null;
            this.SchemeFileListComboBox.ItemsSource = ConfigData.Current.SchemeFilePathList;
     
            ConfigData.Current.LoadSchemeFile(ConfigData.Current.SchemeFilePath);

            this.SchemeFileListComboBox.SelectedValue = ConfigData.Current.SchemeFilePath;
            this.GenerateSettingListView.ItemsSource = SchemeData.Current.GenerateSettingList;
        }
        private void SaveFilePathButton_Click(object sender, RoutedEventArgs e)
        {
            var dg = new System.Windows.Forms.SaveFileDialog();
            dg.InitialDirectory = System.IO.Path.GetDirectoryName(ConfigData.Current.SchemeFilePath);
            dg.FileName = System.IO.Path.GetFileName(ConfigData.Current.SchemeFilePath);
            dg.Filter = "XMLファイル (*.xml)|*.xml|すべてのファイル (*.*)|*.*";
            if (dg.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }

            ConfigData.Current.SchemeFilePath = dg.FileName;
            ConfigData.Current.SchemeFilePathList.Add(ConfigData.Current.SchemeFilePath);
            this.SchemeFileListComboBox.ItemsSource = null;
            this.SchemeFileListComboBox.ItemsSource = ConfigData.Current.SchemeFilePathList;

            ConfigData.Current.LoadSchemeFile(ConfigData.Current.SchemeFilePath);
      
            this.SchemeFileListComboBox.SelectedValue = ConfigData.Current.SchemeFilePath;
            this.GenerateSettingListView.ItemsSource = SchemeData.Current.GenerateSettingList;

        }
        private void DeleteFilePathButton_Click(object sender, RoutedEventArgs e)
        {
            if (this.SchemeFileListComboBox.SelectedValue == null) { return; }
            var filePath = this.SchemeFileListComboBox.SelectedValue.ToString();
            if (filePath == null) { return; }

            if (ConfigData.Current.SchemeFilePathList.Count == 1)
            {
                MessageBox.Show("You can't delete. You need at least one scheme file path.");
                return;
            }

            ConfigData.Current.SchemeFilePathList.Remove(filePath);
            this.SchemeFileListComboBox.ItemsSource = null;
            this.SchemeFileListComboBox.ItemsSource = ConfigData.Current.SchemeFilePathList;
            this.SchemeFileListComboBox.SelectedValue = ConfigData.Current.SchemeFilePathList[0];

            ConfigData.Current.LoadSchemeFile(ConfigData.Current.SchemeFilePath);
            this.GenerateSettingListView.ItemsSource = SchemeData.Current.GenerateSettingList;
        }

        private void AddSettingButton_Click(object sender, RoutedEventArgs e)
        {
            var c = new GenerateSetting();
            c.DatabaseServer = DatabaseServer.SqlServer;
            c.Name = "New Setting";
            SchemeData.Current.GenerateSettingList.Add(c);
        }

        private void ConnectionStringListComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.ConnectionStringListComboBox.SelectedItem == null)
            {
                this.GeneratePanel.Visibility = Visibility.Hidden;
            }
            else
            {
                this.GeneratePanel.Visibility = Visibility.Visible;
            }
        }
        private void ManageConnectionStringButton_Click(object sender, RoutedEventArgs e)
        {
            var w = new ConnectionStringWindow();
            w.ShowDialog();

            this.ConnectionStringListComboBox.ItemsSource = null;
            this.ConnectionStringListComboBox.ItemsSource = ConfigData.Current.ConnectionStringList;
        }

        private ConfigData.ConnectionStringSetting? GetConnectionStringSetting()
        {
            return this.ConnectionStringListComboBox.SelectedValue as ConfigData.ConnectionStringSetting;
        }
        private DatabaseSchemaReader? GetDatabaseSchemaReader()
        {
            var setting = this.GetSelectedGenerateSetting();
            if (setting == null) { return null; }
            var c = this.GetConnectionStringSetting();
            if (c == null) { return null; }
            return setting.CreateDatabaseSchemaReader(c.ConnectionString);
        }
   
        private async void LoadStoredProcedureButton_Click(object sender, RoutedEventArgs e)
        {
            var reader = this.GetDatabaseSchemaReader();
            if (reader == null) { return; }
            this.ViewModel.DatabaseObjectList.Clear();

            try
            {
                var l = await reader.GetStoredProceduresAsync();
                foreach (var item in l.OrderByDescending(el => el.LastAlteredTime))
                {
                    this.ViewModel.DatabaseObjectList.Add(item);
                }
                this.SaveConnectionStringName();
            }
            catch
            {
                MessageBox.Show(T.Text.ConnectionFailed);
            }
        }
        private async void LoadUserDefinedTypeButton_Click(object sender, RoutedEventArgs e)
        {
            var reader = this.GetDatabaseSchemaReader();
            if (reader == null) { return; }

            this.ViewModel.DatabaseObjectList.Clear();
            try
            {
                var l = await reader.GetUserDefinedTableTypesAsync();
                foreach (var item in l.OrderByDescending(el => el.LastAlteredTime))
                {
                    this.ViewModel.DatabaseObjectList.Add(item);
                }
                this.SaveConnectionStringName();
            }
            catch
            {
                MessageBox.Show(T.Text.ConnectionFailed);
            }
        }
        private void GenerateDefinitionButton_Click(object sender, RoutedEventArgs e)
        {
            var c = this.GetConnectionStringSetting();
            if (c == null) { return; }
            var w = new DatabaseDefinitionWindow(c.ConnectionString);
            w.ShowDialog();

            this.SaveConnectionStringName();
        }
        private void OpenOutputFolderButton_Click(object sender, RoutedEventArgs e)
        {
            var setting = this.GetSelectedGenerateSetting();
            if (setting == null || setting.OutputFolderPath.IsNullOrEmpty()) { return; }
            try
            {
                System.Diagnostics.Process.Start("EXPLORER.EXE", $"/e,/root,\"{setting.OutputFolderPath}\"");
            }
            catch
            {
                MessageBox.Show($"Failed to open folder. Path is {setting.OutputFolderPath}");
            }
        }
        private void SaveConnectionStringName()
        {
            var setting = this.GetSelectedGenerateSetting();
            if (setting != null)
            {
                var c = this.GetConnectionStringSetting();
                setting.ConnectionStringName = c?.Name ?? "";
            }
        }

        private void FilterObjectTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var cView = CollectionViewSource.GetDefaultView(this.ViewModel.DatabaseObjectList);
            cView.Refresh();
        }
        private Boolean FilterDatabaseObject(object obj)
        {
            var o = (DatabaseObject)obj;
            if (this.FilterObjectTextBox.Text.IsNullOrEmpty()) { return true; }
            if (o.Name.Contains(this.FilterObjectTextBox.Text, StringComparison.OrdinalIgnoreCase)) { return true; }
            return false;
        }

        private async void DatabaseObjectListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            await this.OpenGenerateWindow();
        }
        private async void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            await this.OpenGenerateWindow();
        }
        private async Task OpenGenerateWindow()
        {
            var setting = this.GetSelectedGenerateSetting();
            if (setting == null) { return; }

            var o = this.DatabaseObjectListView.SelectedItem as DatabaseObject;
            if (o == null)
            {
                MessageBox.Show(T.Text.PleaseSelect);
                return;
            }

            var reader = this.GetDatabaseSchemaReader();
            if (reader == null) { return; }

            switch (o.ObjectType)
            {
                case DatabaseObjectType.StoredProcedure:
                    {
                        var sp = await reader.GetStoredProcedureAsync(o.Name);
                        var w = new StoredProcedureWindow(new StoredProcedureWindowViewModel(reader.ConnectionString, setting, sp));
                        w.ShowDialog();
                        break;
                    }
                case DatabaseObjectType.UserDefinedTableType:
                    {
                        var u = await reader.GetUserDefinedTableTypeAsync(o.Name);
                        var w = new UserDefinedTableTypeWindow(new UserDefinedTableTypeWindowViewModel(setting, u));
                        w.ShowDialog();
                        break;
                    }
                case DatabaseObjectType.Unknown:
                case DatabaseObjectType.Table:
                case DatabaseObjectType.View:
                case DatabaseObjectType.StoredFunction:
                    throw new InvalidOperationException();
                default: throw SwitchStatementNotImplementException.Create(o.ObjectType);
            }
        }

        private void MainWindow_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            ConfigData.Current.Save();
        }

    }
}
