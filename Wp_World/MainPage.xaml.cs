using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Wp_World.Models;
using Wp_World.Services;
using System.Net;
using System.Text;
using HtmlAgilityPack;
using Windows.Web.Http;
using System.ComponentModel;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Popups;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Wp_World
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page, INotifyPropertyChanged
    {
        // Point to calculate manipulation translate length
        Point ManipulationInitialPont;

        public static string ArticleAdressBeg = "http://wordpress-dachu.home.pl/app/article.php?id=";

        // Chciwlowe
        private bool message = false;

        public ObservableCollection<Article> Articles
        {
            get
            {
                return articles;
            }

            set
            {
                articles = value;
            }
        }

        public Article SelectedArticle
        {
            get
            {
                return selectedArticle;
            }

            set
            {
                if(ArticleContent.Visibility == Visibility.Collapsed)
                {
                    ArticleContent.Visibility = Visibility.Visible;
                    ArticlesListView.Visibility = Visibility.Collapsed;
                    
                }
                selectedArticle = value;
                RaisePropertyChanged("SelectedArticle");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private ObservableCollection<Article> articles;

        private Article selectedArticle;

        public MainPage()
        {
     
            this.InitializeComponent();

            this.DataContext = this;

            ApplicationView.GetForCurrentView().Title = "WpWorld.pl Insider";
            
            if (MainVisualStateGroup.CurrentState.Name.Equals("NarrowState"))
            {

                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;

                SystemNavigationManager.GetForCurrentView().BackRequested += (s, e) =>
                {
                    if (ArticleContent.Visibility == Visibility.Visible)
                    {
                        ArticleContent.Visibility = Visibility.Collapsed;
                        ArticlesListView.Visibility = Visibility.Visible;
                        e.Handled = true;
                    }
                };
            }

            if (MainVisualStateGroup.CurrentState.Name.Equals("NarrowState"))
            {
                ArticleContent.Visibility = Visibility.Collapsed;
            }

            InitialiseSwipeModes();

            // Message += new MessageEventHandler(showMessage);
            LoadArticles();
            
        }

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainSplitView.IsPaneOpen){
                MainSplitView.IsPaneOpen = false;
            }
            else
            {
                MainSplitView.IsPaneOpen = true;
            }
        }

        private void ArticleWebView_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            calculateArticleHeight();

            ArticleMask.Visibility = Visibility.Collapsed;
            ArticleProgressRing.IsActive = false;
        }

        private async void calculateArticleHeight()
        {
            var _HeightString = await ArticleWebView.InvokeScriptAsync("eval",
             new[] { "document.body.scrollHeight.toString()" });

            double height = Window.Current.Bounds.Height;
            ArticleWebView.Height = height;
        }

        private async void LoadArticles()
        {
            Rss.RSS_adress = "https://wpworld.pl/feed/";
            //ArticlesListProgressRing.IsActive = true;
            List<Article> articles;
            try
            {
                articles = await Rss.loadArticles();
            }
            catch (Exception ex)
            {
                MessageDialog md = new MessageDialog("Błąd ładowania artykułów");
                await md.ShowAsync();
                articles = new List<Article>();
            }
            GlobalProgressRing.IsActive = false;
            //ArticlesListProgressRing.IsActive = false;
            Articles = new ObservableCollection<Article>(articles);
            ArticlesListView.ItemsSource = Articles;
            DateTime dateTime = Articles[0].publishDate;
            string date = Articles[0].ParsedDateTime;
            if (!MainVisualStateGroup.CurrentState.Name.Equals("NarrowState"))
            {
                SelectedArticle = Articles[0];
                loadArticle();
            }
        }

        private async Task loadArticle()
        {
            //var uri = new Uri(ArticleAdressBeg + SelectedArticle.ID);
            /*var uri = new Uri(SelectedArticle.link);
            var HttpClient = new HttpClient();
            string resultHTML = "";
            string finalHTML = "";

            // Always catch network exceptions for async methods
            try
            {
                resultHTML = await HttpClient.GetStringAsync(uri);
            }
            catch (Exception ex)
            {
                // TODO
            }
           

            HtmlDocument htmlDoc = new HtmlDocument();
            htmlDoc.LoadHtml(resultHTML);
            HtmlNode node = htmlDoc.GetElementbyId("content");
            HtmlNodeCollection nodeCollection = node.ChildNodes;
            foreach (HtmlNode child in nodeCollection)
            {
                if (child.Name.Equals("article"))
                {
                    HtmlNodeCollection articleNodeCollection = child.ChildNodes;
                    foreach (HtmlNode articleChild in articleNodeCollection)
                    {
                        if (articleChild.GetAttributeValue("class", "").Equals("entry-content"))
                        {*/
            // finalHTML = articleChild.OuterHtml;
            /*HtmlNodeCollection contentNodeCollection = child.ChildNodes;
            foreach (HtmlNode contentChild in contentNodeCollection)
            {
                if (contentChild.Name.Equals("p"))
                {
                    finalHTML += contentChild.OuterHtml;
                }
            }*/
            /*}
        }
    }
}*/
            //this.ArticleWebView.Height = 0;
            //string finalHtml = (String)uri
            Uri uri = new Uri(ArticleAdressBeg + SelectedArticle.ID);
            ArticleWebView.Navigate(uri);

        }

        private void ArticleWebView_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            //ArticleStackPanel.Visibility = Visibility.Collapsed;
            if (!ArticleProgressRing.IsActive){
                ArticleProgressRing.IsActive = true;
            }
        }

        private async void StackPanel_Tapped(object sender, TappedRoutedEventArgs e)
        {

            // Loading mask
            ArticleMask.Visibility = Visibility.Visible;
            ArticleProgressRing.IsActive = true;

            // Gets the selected article
            var frameworkElement = e.OriginalSource as Windows.UI.Xaml.FrameworkElement;
            SelectedArticle = frameworkElement.DataContext as Article;

            await loadArticle();

        }


        //-------------------------------------------------------------------------------------------------------------------------------------
        // Home cathegory clicked events
        //-------------------------------------------------------------------------------------------------------------------------------------
        private void HomeButton_Click_1(object sender, RoutedEventArgs e)
        {
            HomeCathegoryChosen();
        }

        // for the cathegory name textblock
        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            HomeCathegoryChosen();
        }

        private void HomeCathegoryChosen()
        {
            if (ArticleContent.Visibility == Visibility.Visible && MainVisualStateGroup.CurrentState.Name.Equals("NarrowState"))
            {
                ArticleContent.Visibility = Visibility.Collapsed;
                ArticlesListView.Visibility = Visibility.Visible;
            }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------
        // Swipes
        //-------------------------------------------------------------------------------------------------------------------------------------

        private void InitialiseSwipeModes()
        {
            ArticleStackPanel.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateInertia | ManipulationModes.System;
            ArticleStackPanel.AddHandler(ManipulationDeltaEvent, new ManipulationDeltaEventHandler(StackPanel_ManipulationDelta_1), true);
            ArticleStackPanel.AddHandler(ManipulationStartedEvent, new ManipulationStartedEventHandler(StackPanel_ManipulationStarted_1), true);
            ArticleStackPanel.AddHandler(ManipulationCompletedEvent, new ManipulationCompletedEventHandler(StackPanel_ManipulationCompleted_1), true);


            //ArticlesListViewStackPanel.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateInertia | ManipulationModes.System;
            //ArticlesListViewStackPanel.AddHandler(ManipulationDeltaEvent, new ManipulationDeltaEventHandler(StackPanel_ManipulationDelta), true);
            //ArticlesListViewStackPanel.AddHandler(ManipulationStartedEvent, new ManipulationStartedEventHandler(StackPanel_ManipulationStarted), true);

            MainGrid.ManipulationMode = ManipulationModes.TranslateX | ManipulationModes.TranslateInertia;// | ManipulationModes.System;
            MainGrid.AddHandler(ManipulationDeltaEvent, new ManipulationDeltaEventHandler(MainGrid_ManipulationDelta), true);
            MainGrid.AddHandler(ManipulationStartedEvent, new ManipulationStartedEventHandler(MainGrid_ManipulationStarted), true);
            //ArticleStackPanel.AddHandler(ManipulationCompletedEvent, new ManipulationCompletedEventHandler(StackPanel_ManipulationCompleted_1), true);

        }

        //MainGrid manipulation start (for hamburger menu swaping)
        private void MainGrid_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            FrameworkElement control = e.Container as FrameworkElement;
            if(control != null)
            {
                ManipulationInitialPont = e.Position;
            }
         
        }

        //MainGrid manipulation delta (for hamburger menu swaping)
        private void MainGrid_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            FrameworkElement control = e.Container as FrameworkElement;
            if (control != null) {
                SwipeHamburgerMenu(e.Position);
            }
        }

        //Articles ListView manipulation start
        private void ArticlesListViewStackPanel_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            ManipulationInitialPont = e.Position;
        }

        //Articles ListView manipulation delta
        private void ArticlesListViewStackPanel_ManipulationDelta(object sender, ManipulationDeltaRoutedEventArgs e)
        {
            SwipeHamburgerMenu(e.Position);
        }

        //Article manipulation start
        private void StackPanel_ManipulationStarted_1(object sender, ManipulationStartedRoutedEventArgs e)
        {
            ManipulationInitialPont = e.Position;
        }

        //Article manipulation delta
         private  void StackPanel_ManipulationDelta_1(object sender, ManipulationDeltaRoutedEventArgs e)
         {
                    if (e.IsInertial)
                    {
                        Point currentpoint = e.Position;
                        if (currentpoint.X - ManipulationInitialPont.X <= -500)
                        {
                            message = true;
                            //Message.Invoke(this, null);
                        }
                        else
                        {
                            SwipeHamburgerMenu(currentpoint);
                        }
                    }
                    e.Handled = true;
                }
       
        //Article manipulation completed
        private void StackPanel_ManipulationCompleted_1(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            if (message)
            {
                message = false;
                showMessage();
            }
        }

        private void SwipeHamburgerMenu(Point currentpoint)
        {
            if (currentpoint.X - ManipulationInitialPont.X >= 500)//500 is the threshold value, where you want to trigger the swipe right event
            {
                if (MainSplitView.IsPaneOpen == false)
                {
                    MainSplitView.IsPaneOpen = true;
                }
            }
            else if (currentpoint.X - ManipulationInitialPont.X <= -500)
            {
                if (MainSplitView.IsPaneOpen == true)
                {
                    MainSplitView.IsPaneOpen = false;
                }
            }
        }

        // Chwilowwe, zamiast komentarzy do artykulu
        private async void showMessage()
        {
            MessageDialog md = new MessageDialog("Komentarze ;)");
            
            await md.ShowAsync();
        }

 
        //-------------------------------------------------------------------------------------------------------------------------------------
        //-------------------------------------------------------------------------------------------------------------------------------------


        //private delegate void MessageEventHandler(object sender, EventArgs e);
        //private event MessageEventHandler Message;
    }
    
}
