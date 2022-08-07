using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using KitX_Dashboard.ViewModels.Pages;

namespace KitX_Dashboard.Views.Pages
{
    public partial class RepoPage : UserControl
    {
        private readonly RepoViewModel viewModel = new();

        public RepoPage()
        {
            InitializeComponent();

            DataContext = viewModel;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}

//
// @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
// @@@@@@@@@@@@@@@@@@@@@@@'~~~     ~~~`@@@@@@@@@@@@@@@@@@@@@@@@@
// @@@@@@@@@@@@@@@@@@'                     `@@@@@@@@@@@@@@@@@@@@
// @@@@@@@@@@@@@@@'                           `@@@@@@@@@@@@@@@@@
// @@@@@@@@@@@@@'                               `@@@@@@@@@@@@@@@
// @@@@@@@@@@@'                                   `@@@@@@@@@@@@@
// @@@@@@@@@@'                                     `@@@@@@@@@@@@
// @@@@@@@@@'                                       `@@@@@@@@@@@
// @@@@@@@@@                                         @@@@@@@@@@@
// @@@@@@@@'                      n,                 `@@@@@@@@@@
// @@@@@@@@                     _/ | _                @@@@@@@@@@
// @@@@@@@@                    /'  `'/                @@@@@@@@@@
// @@@@@@@@a                 &lt;~    .'                a@@@@@@@@@@
// @@@@@@@@@                 .'    |                 @@@@@@@@@@@
// @@@@@@@@@a              _/      |                a@@@@@@@@@@@
// @@@@@@@@@@a           _/      `.`.              a@@@@@@@@@@@@
// @@@@@@@@@@@a     ____/ '   \__ | |______       a@@@@@@@@@@@@@
// @@@@@@@@@@@@@a__/___/      /__\ \ \     \___.a@@@@@@@@@@@@@@@
// @@@@@@@@@@@@@/  (___.'\_______)\_|_|        \@@@@@@@@@@@@@@@@
// @@@@@@@@@@@@|\________                       ~~~~~\@@@@@@@@@@
//
