using LibraryLogic;

namespace LibraryLogicTests
{
    public class WorkTests
    {
        [Fact]
        public void Create_work_with_null_genre_is_impossible()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Work("��-��", "��������", null, 0));
        }

        [Fact]
        public void Create_work_with_empty_genre_is_impossible()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Work("��-��", "��������", string.Empty, 0));
        }

        [Fact]
        public void Create_work_with_whitespace_genre_is_impossible()
        {
            // Assert
            Assert.Throws<ArgumentException>(() => new Work("��-��", "��������", "   ", 0));
        }

        [Fact]
        public void Create_work()
        {
            //Act
            var actual = new Work(
                "��-��", "��������", "�������", 0);

            // Assert
            Assert.Equal("��-��", actual.Name);
            Assert.Equal("��������", actual.Author);
            Assert.Equal("�������", actual.Genre);
            Assert.Equal(0, actual.AgeRestriction);
        }
    }
}