using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repository;
using NSubstitute;
using Xunit;

namespace AlbumCollection.Tests
{
    public class SongControllerTests
    {
        private SongController underTest;
        IRepository<Songs> songRepo;

        public SongControllerTests()
        {
            songRepo = Substitute.For<IRepository<Songs>>();
            underTest = new SongController(songRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Songs()
        {
            var expectedSong = new List<Songs>()
            {
                new Songs(1, "First song", "duration", 1),
                new Songs(1, "Second song", "duration", 1),
            };

            songRepo.GetAll().Returns(expectedSong);

            var result = underTest.Get();

            Assert.Equal(expectedSong, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Song()
        {
            var newSong = new Songs(1, "New song", "duration", 1);
            var songList = new List<Songs>();

            songRepo.When(t => t.Create(newSong))
                .Do(t => songList.Add(newSong));

            songRepo.GetAll().Returns(songList);

            var result = underTest.Post(newSong);

            Assert.Contains(newSong, result);
        }

        [Fact]
        public void Delete_Removes_Song()
        {
            var songId = 1;
            var deletedSong = new Songs(1, "First song", "duration", 1);
            var songList = new List<Songs>()
            {
                deletedSong,
                 new Songs(2, "Second song", "duration", 2)
            };

            songRepo.GetByID(songId).Returns(deletedSong);
            songRepo.When(d => d.Delete(deletedSong))
                .Do(d => songList.Remove(deletedSong));

            songRepo.GetAll().Returns(songList);
            var result = underTest.Delete(songId);
            Assert.DoesNotContain(deletedSong, result);
            //Assert.All(result, item => Assert.Contains("second item", item.Name));

        }

        [Fact]
        public void Put_Updates_Song()
        {
            var originalSong = new Songs(1, "First song", "duration", 1);
            var expectedSong = new List<Songs>()
            {
                originalSong
            };

            var updatedSong = new Songs(1, "Updated song", "duration", 1);

            songRepo.When(t => songRepo.Update(updatedSong))
                .Do(Callback.First(t => expectedSong.Remove(originalSong))
                .Then(t => expectedSong.Add(updatedSong)));

            songRepo.GetAll().Returns(expectedSong);
            var result = underTest.Put(updatedSong);

            //Assert.Equal(expectedTodo, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }
    }
}
