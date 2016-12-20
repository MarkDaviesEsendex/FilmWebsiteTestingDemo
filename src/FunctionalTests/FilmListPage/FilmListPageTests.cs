using NUnit.Framework;
using TestHelpers;

namespace FunctionalTests.FilmListPage
{
    public class FilmListPageTests
    {
        [Test]
        public void WhenClickListPageLinkOnHomePageThenUserIsNavToListPage()
        {
            var homepage = BrowserContext.Site.Homepage;
            var list = BrowserContext.Site.ListPage;
            homepage.GoToPage();
            homepage.ClickLinkToListPage();

            Assert.That(BrowserContext.CurrentUrl(), Is.EqualTo(list.Url()));
        }

        [Test]
        public void WhenUserClicksOnPagePageHasList()
        {
            SqlHelper.TruncateFilmsTable();
            SqlHelper.AddFilm("Inception", 2010);

            var list = BrowserContext.Site.ListPage;
            list.GoToPage();

            Assert.That(list.FilmTable(), Contains.Substring("Inception"));
        }

    }
}