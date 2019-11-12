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
    public class ArtistControllerTests
    {
        private ArtistController underTest;
        IRepository<Artists> artistRepo;

        public ArtistControllerTests()
        {
            artistRepo = Substitute.For<IRepository<Artists>>();
            underTest = new ArtistController(artistRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Artists()
        {
            var expectedArtist = new List<Artists>()
            {
                new Artists(1, "First artist", 1, "recordlabel", "hometown", "image"),
                new Artists(2, "Second artist", 2, "recordlabel", "hometown", "image"),
            };

            artistRepo.GetAll().Returns(expectedArtist);

            var result = underTest.Get();

            Assert.Equal(expectedArtist, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Artist()
        {
            var newArtist = new Artists(1, "New artist", 1, "recordlabel", "hometown", "image");
            var artistList = new List<Artists>();

            artistRepo.When(t => t.Create(newArtist))
                .Do(t => artistList.Add(newArtist));

            artistRepo.GetAll().Returns(artistList);

            var result = underTest.Post(newArtist);

            Assert.Contains(newArtist, result);
        }

        [Fact]
        public void Delete_Removes_Artist()
        {
            var artistId = 1;
            var deletedArtist = new Artists(artistId, "First artist", 1, "recordlabel", "hometown", "image");
            var artistList = new List<Artists>()
            {
                deletedArtist,
                new Artists(2, "Second artist", 2, "recordlabel", "hometown", "image")
            };

            artistRepo.GetByID(artistId).Returns(deletedArtist);
            artistRepo.When(d => d.Delete(deletedArtist))
                .Do(d => artistList.Remove(deletedArtist));

            artistRepo.GetAll().Returns(artistList);
            var result = underTest.Delete(artistId);
            Assert.DoesNotContain(deletedArtist, result);
            //Assert.All(result, item => Assert.Contains("second item", item.Name));

        }

        [Fact]
        public void Put_Updates_Artist()
        {
            var originalArtist = new Artists(1, "First artist", 1, "recordlabel", "hometown", "image");
            var expectedArtist = new List<Artists>()
            {
                originalArtist
            };

            var updatedArtist = new Artists(1, "Updated artist", 1, "recordlabel", "hometown", "image");

            artistRepo.When(t => artistRepo.Update(updatedArtist))
                .Do(Callback.First(t => expectedArtist.Remove(originalArtist))
                .Then(t => expectedArtist.Add(updatedArtist)));

            artistRepo.GetAll().Returns(expectedArtist);
            var result = underTest.Put(updatedArtist);

            //Assert.Equal(expectedTodo, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }
    }
}
