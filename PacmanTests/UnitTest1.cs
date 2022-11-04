namespace PacmanTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //var s = new Pacman_Zagorschi_Franco.Form1();
        }

        [Test]
        public void Create_Page()
        {
            var page = new Pacman_Zagorschi_Franco.Form1();
            bool s = true;
            bool x = true;
            Assert.IsTrue(s);
        }

        [Test]
        public void X()
        {
            Assert.IsTrue(true);    
        }
    }
}