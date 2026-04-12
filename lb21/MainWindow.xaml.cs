using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace lb21
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies;

            cmbFontSize.ItemsSource = new double[]
            {
                8, 10, 12, 14, 16, 18, 20, 24, 28, 32, 36
            };
        }

        private void Open_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Files|*.txt|Rich Text Format|*.rtf";

            if (dlg.ShowDialog() == true)
            {
                TextRange range = new TextRange(
                    rtbEditor.Document.ContentStart,
                    rtbEditor.Document.ContentEnd);

                using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open))
                {
                    if (Path.GetExtension(dlg.FileName).ToLower() == ".rtf")
                        range.Load(fs, DataFormats.Rtf);
                    else
                        range.Load(fs, DataFormats.Text);
                }
            }
        }

        private void Save_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text Files|*.txt|Rich Text Format|*.rtf";

            if (dlg.ShowDialog() == true)
            {
                TextRange range = new TextRange(
                    rtbEditor.Document.ContentStart,
                    rtbEditor.Document.ContentEnd);

                using (FileStream fs = new FileStream(dlg.FileName, FileMode.Create))
                {
                    if (Path.GetExtension(dlg.FileName).ToLower() == ".rtf")
                        range.Save(fs, DataFormats.Rtf);
                    else
                        range.Save(fs, DataFormats.Text);
                }
            }
        }

        private void New_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            new MainWindow().Show();
        }

        private int langIndex = 0;

        private void ChangeLanguage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            string[] langs =
            {
        "Resources/StringsEn.xaml",
        "Resources/StringsUk.xaml",
        "Resources/StringsPl.xaml"
    };

            langIndex = (langIndex + 1) % langs.Length;

            var dict = new ResourceDictionary
            {
                Source = new Uri(langs[langIndex], UriKind.Relative)
            };
            var dictionaries = Application.Current.Resources.MergedDictionaries;

            var oldLangDict = dictionaries
                .FirstOrDefault(d => d.Source != null &&
                                     d.Source.OriginalString.Contains("Strings"));

            if (oldLangDict != null)
            {
                int index = dictionaries.IndexOf(oldLangDict);
                dictionaries.Remove(oldLangDict);

                dictionaries.Insert(index, dict);
            }
            else
            {
                dictionaries.Add(dict);
            }
        }

        private void InsertImage_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";

            if (dlg.ShowDialog() == true)
            {
                Image img = new Image();
                img.Source = new BitmapImage(new Uri(dlg.FileName));
                img.Width = 200;

                var para = new Paragraph();
                para.Inlines.Add(new InlineUIContainer(img));
                rtbEditor.Document.Blocks.Add(para);
            }
        }

        private void cmbFontFamily_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null)
            {
                rtbEditor.Selection.ApplyPropertyValue(
                    TextElement.FontFamilyProperty,
                    cmbFontFamily.SelectedItem);
            }
        }

        private void cmbFontSize_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (double.TryParse(cmbFontSize.Text, out double size))
            {
                rtbEditor.Selection.ApplyPropertyValue(
                    TextElement.FontSizeProperty,
                    size);
            }
        }

        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp;


            temp = rtbEditor.Selection.GetPropertyValue(TextElement.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) &&
                                ((FontWeight)temp == FontWeights.Bold);

        
            temp = rtbEditor.Selection.GetPropertyValue(TextElement.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) &&
                                  ((FontStyle)temp == FontStyles.Italic);

            var dec = rtbEditor.Selection.GetPropertyValue(Inline.TextDecorationsProperty);
            btnUnderline.IsChecked =
                (dec != DependencyProperty.UnsetValue) &&
                (dec is TextDecorationCollection collection) &&
                collection.Count > 0;

   
            temp = rtbEditor.Selection.GetPropertyValue(TextElement.FontFamilyProperty);
            cmbFontFamily.SelectedItem = temp;

            temp = rtbEditor.Selection.GetPropertyValue(TextElement.FontSizeProperty);
            cmbFontSize.Text = temp.ToString();
        }
    }
    }