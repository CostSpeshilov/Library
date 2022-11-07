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
            var actual = new Work("��-��", "��������", "�������", 0);
            //Assert
            Assert.Equal("��-��", actual.Name);
            Assert.Equal("��������", actual.Author);
            Assert.Equal("�������", actual.Genre);
            Assert.Equal(0, actual.AgeRestriction);
        }

        [Fact]
        public void Work_creation_with_null_genre_is_impossible()
        {
            //arrange
            //act
            //assert

            Assert.Throws<ArgumentException>(
                () => new Work("��-��", "��������", null, 0)
                );
        }

        [Fact]
        public void Work_creation_with_empty_genre_is_impossible()
        {
            //arrange
            //act
            //assert

            Assert.Throws<ArgumentException>(
                () => new Work("��-��", "��������", string.Empty, 0)
                );
        }

        [Fact]
        public void Work_creation_with_whitespace_genre_is_impossible()
        {
            //arrange
            //act
            //assert

            Assert.Throws<ArgumentException>(
                () => new Work("��-��", "��������", "   ", 0)
                );
        }
    }
}