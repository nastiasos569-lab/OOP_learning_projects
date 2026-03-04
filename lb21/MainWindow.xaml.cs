using Microsoft.Win32;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace lb21
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cmbFontFamily.ItemsSource = Fonts.SystemFontFamilies;
            cmbFontSize.ItemsSource = new double[] { 8, 10, 12, 14, 16, 18, 20, 22, 24, 28, 36, 48, 72 };
        }
        private bool isHighlighting = false;

        private void rtbEditor_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isHighlighting) return;

            isHighlighting = true;
            HighlightSyntax();
            isHighlighting = false;
        }

        private void HighlightSyntax()
        {
            TextPointer caretPosition = rtbEditor.CaretPosition;

            TextRange fullRange = new TextRange(
                rtbEditor.Document.ContentStart,
                rtbEditor.Document.ContentEnd);

            fullRange.ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Black);

            string[] keywords =
            {
        "int","double","float","string",
        "if","else","for","while",
        "return","class","public",
        "private","void","using","namespace"
    };

            foreach (string keyword in keywords)
            {
                TextPointer position = rtbEditor.Document.ContentStart;

                while (position != null &&
                       position.CompareTo(rtbEditor.Document.ContentEnd) < 0)
                {
                    if (position.GetPointerContext(LogicalDirection.Forward)
                        == TextPointerContext.Text)
                    {
                        string text = position.GetTextInRun(LogicalDirection.Forward);
                        int index = text.IndexOf(keyword);

                        if (index >= 0)
                        {
                            TextPointer start = position.GetPositionAtOffset(index);
                            TextPointer end = start.GetPositionAtOffset(keyword.Length);

                            new TextRange(start, end)
                                .ApplyPropertyValue(TextElement.ForegroundProperty, Brushes.Blue);
                        }
                    }
                    position = position.GetNextContextPosition(LogicalDirection.Forward);
                }
            }

            rtbEditor.CaretPosition = caretPosition;
        }


        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Text Files|*.txt|Rich Text Format|*.rtf";
            if (dlg.ShowDialog() == true)
            {
                MessageBox.Show(dlg.FileName);

                TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                using (FileStream fs = new FileStream(dlg.FileName, FileMode.Open))
                {
                    string ext = Path.GetExtension(dlg.FileName).ToLower();
                    if (ext == ".rtf")
                        range.Load(fs, DataFormats.Rtf);
                    else if (ext == ".txt")
                        range.Load(fs, DataFormats.Text);
                    else
                        MessageBox.Show("Непідтримуваний формат файлу");
                }
            }
        }
       
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "Text Files|*.txt|Rich Text Format|*.rtf";
            if (dlg.ShowDialog() == true)
            {
                TextRange range = new TextRange(rtbEditor.Document.ContentStart, rtbEditor.Document.ContentEnd);
                using (FileStream fs = new FileStream(dlg.FileName, FileMode.Create))
                {
                    if (Path.GetExtension(dlg.FileName).ToLower() == ".rtf")
                        range.Save(fs, DataFormats.Rtf);
                    else
                        range.Save(fs, DataFormats.Text);
                }
            }
        }

        private void NewWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow newWin = new MainWindow();
            newWin.Show();
        }

        private void InsertImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp;*.gif";
            if (dlg.ShowDialog() == true)
            {
                var img = new System.Windows.Controls.Image();
                img.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(dlg.FileName));
                img.Width = 200;
                InlineUIContainer container = new InlineUIContainer(img, rtbEditor.CaretPosition);
            }
        }

        private void cmbFontFamily_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cmbFontFamily.SelectedItem != null)
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontFamilyProperty, cmbFontFamily.SelectedItem);
        }


        private void cmbFontSize_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(cmbFontSize.Text, out double size))
                rtbEditor.Selection.ApplyPropertyValue(Inline.FontSizeProperty, size);
        }


        private void rtbEditor_SelectionChanged(object sender, RoutedEventArgs e)
        {
            object temp = rtbEditor.Selection.GetPropertyValue(Inline.FontWeightProperty);
            btnBold.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontWeights.Bold));

            temp = rtbEditor.Selection.GetPropertyValue(Inline.FontStyleProperty);
            btnItalic.IsChecked = (temp != DependencyProperty.UnsetValue) && (temp.Equals(FontStyles.Italic));
        }

        public enum Language
        {
            Ukrainian,
            English,
            Chinese
        }

        private Language currentLanguage = Language.Ukrainian;

        private void ChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            switch (currentLanguage)
            {
                case Language.Ukrainian:
                    btnOpen.Content = "📂 Open";
                    btnSave.Content = "💾 Save";
                    btnNew.Content = "📄 New Window";
                    this.Title = "Text Editor";
                    btnLang.Content = "🌐 Language";
                    currentLanguage = Language.English;
                    break;

                case Language.English:
                    btnOpen.Content = "📂 打开";
                    btnSave.Content = "💾 保存";
                    btnNew.Content = "📄 新窗口";
                    this.Title = "文本编辑器";
                    btnLang.Content = "🌐 语言";
                    currentLanguage = Language.Chinese;
                    break;

                case Language.Chinese:
                    btnOpen.Content = "📂 Відкрити";
                    btnSave.Content = "💾 Зберегти";
                    btnNew.Content = "📄 Нове вікно";
                    this.Title = "Текстовий редактор";
                    currentLanguage = Language.Ukrainian;
                    btnLang.Content = "🌐Мова";
                    break;
            }
        }
    }
    }