using System.Windows.Input;

namespace lb21
{
    public static class CustomCommands
    {
        public static readonly RoutedUICommand ChangeLanguage =
            new RoutedUICommand("Change Language", "ChangeLanguage", typeof(CustomCommands));

        public static readonly RoutedUICommand InsertImage =
            new RoutedUICommand("Insert Image", "InsertImage", typeof(CustomCommands));
    }
}