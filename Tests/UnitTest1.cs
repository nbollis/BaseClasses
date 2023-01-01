using CoinCollection;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SetupCollection()
        {

            string directoryPath = Path.Combine(TestContext.CurrentContext.TestDirectory, "CoinDataFiles");
            var textFiles = Directory.GetFiles(directoryPath);
            Collection collection = new();

            foreach (var file in textFiles)
            {
                var allText = File.ReadAllText(file);
                var eachLine = allText.Split("\n");
                int books = Int32.Parse(eachLine.First().Split("\t").Last());


                // parse each line in text file into relevant info
                var lineInfo = new List<LineInfo>();
                foreach (var line in eachLine.Where(p => !p.Equals("")))
                {
                    var splits = line.Split("\t");
                    var firstSplit = splits.First().Split(" ");

                    double year = double.Parse(firstSplit[0]);
                    string? spec = firstSplit.Length > 1 ? firstSplit[1] : null;
                    string mint = splits[1] == "" ? "None" : splits[1];
                    int have = splits[2] == "" ? 0 : int.Parse(splits[2]);

                    lineInfo.Add(new LineInfo(year, spec, mint, have));
                }

                // create book objects
                for (int i = 0; i < books; i++)
                {
                    // create coin objects
                    List<Coin> coins = new();
                    for (var index = 0; index < lineInfo.Count; index++)
                    {
                        var coin = lineInfo[index];
                        var mint = Enum.Parse<MintLocation>(coin.Mint);

                        bool have = false;
                        if (coin.Have > 0)
                        {
                            have = true;
                            coin.Have--;
                        }

                        coins.Add(new(CoinType.Penny, mint, coin.Date, have, coin.Spec));
                    }

                    Book book = new(Path.GetFileNameWithoutExtension(file), BookType.USPenny, coins);
                    collection.AddBook(book);
                }

            }
        }
    }

    public class LineInfo
    {
        public double Date { get; set; }
        public string? Spec { get; set; }
        public string Mint { get; set; }
        public int Have { get; set; }

        public LineInfo(double date, string? spec, string mint, int have)
        {
            Date = date;
            Spec = spec;
            Mint = mint;
            Have = have;
        }
    }

}