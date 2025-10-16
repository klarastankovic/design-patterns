namespace Primjeri.FactoryMethod.Document
{
    public class TechnicalReport : Document
    {
        protected override void CreatePages()
        {
            Pages.Add(new IntroductionPage());
            Pages.Add(new ResultsPage());
            Pages.Add(new ConclusionPage());
            Pages.Add(new BibliographyPage());
        }
    }
}
