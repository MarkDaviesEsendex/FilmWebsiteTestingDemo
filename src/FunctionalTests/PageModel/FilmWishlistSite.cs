using NUnit.Framework.Constraints;
using OpenQA.Selenium.Chrome;

namespace FunctionalTests.PageModel
{
    public class FilmWishlistSite
    {
        public readonly Homepage Homepage;
        public readonly DetailsPage DetailsPage;
        public readonly ListPage ListPage;

        public FilmWishlistSite(ChromeDriver driver, string baseUrl)
        {
            Homepage = new Homepage(driver, baseUrl);
            DetailsPage = new DetailsPage(driver, baseUrl);
            ListPage = new ListPage(driver, baseUrl);
        }
    }

    public class ListPage

    {
        private string baseUrl;
        private ChromeDriver driver;

        public ListPage(ChromeDriver driver, string baseUrl)
        {
            this.driver = driver;
            this.baseUrl = baseUrl;
        }

        public string Url() => $"{baseUrl}list";

        public void GoToPage()
        {
            driver.Navigate().GoToUrl(Url());
        }

        public string FilmTable()
        {
            return driver.FindElementByCssSelector("tbody tr td").Text;
        }
    }
}