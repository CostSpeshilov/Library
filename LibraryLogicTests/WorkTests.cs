using LibraryLogic;

namespace LibraryLogicTests
{
    public class WorkTests
    {
        [Fact]
        public void Work_creation_is_successfull()
        {
            //Arrange

            //Act
            var actual = new Work("Му-му", "Тургенев", "Рассказ", 0);
            //Assert
            Assert.Equal("Му-му", actual.Name);
            Assert.Equal("Тургенев", actual.Author);
            Assert.Equal("Рассказ", actual.Genre);
            Assert.Equal(0, actual.AgeRestriction);
        }

        [Fact]
        public void Work_creation_with_null_genre_is_impossible()
        {
            //arrange
            //act
            //assert

            Assert.Throws<ArgumentException>(
                () => new Work("Му-му", "Тургенев", null, 0)
                );
        }

        [Fact]
        public void Work_creation_with_empty_genre_is_impossible()
        {
            //arrange
            //act
            //assert

            Assert.Throws<ArgumentException>(
                () => new Work("Му-му", "Тургенев", string.Empty, 0)
                );
        }

        [Fact]
        public void Work_creation_with_whitespace_genre_is_impossible()
        {
            //arrange
            //act
            //assert

            Assert.Throws<ArgumentException>(
                () => new Work("Му-му", "Тургенев", "   ", 0)
                );
        }
    }
}