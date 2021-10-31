using NUnit.Framework;

namespace Framework
{
    public class SearchProductTest : BaseTest
    {

        [Test]
        public void SearchProduct()
        {
            string elementResult = new HomePage(driver)
                 .SearchProduct("Pucio")
                 .Result("h1");


            Assert.AreEqual("Wyniki wyszukiwania", elementResult);

        }


        [Test]
        public void SearchProductWithoutName()
        {
            string elementResult = new HomePage(driver)
                 .SearchProduct("")
                 .Result("h2");


            Assert.AreEqual("Brak produktów!", elementResult);

        }

    }
}