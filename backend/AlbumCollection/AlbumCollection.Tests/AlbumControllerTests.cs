using System;
using System.Collections.Generic;
using System.Linq;
using AlbumCollection.Controllers;
using AlbumCollection.Models;
using AlbumCollection.Repository;
using NSubstitute;
using Xunit;

namespace AlbumCollection.Tests
{
    public class AlbumControllerTests
    {
        private AlbumController underTest;
        IRepository<Albums> albumRepo;

        public AlbumControllerTests()
        {
            albumRepo = Substitute.For<IRepository<Albums>>();
            underTest = new AlbumController(albumRepo);
        }

        [Fact]
        public void Get_Returns_List_of_Albums()
        {
            var expectedAlbum = new List<Albums>()
            {
                new Albums(1, "First album", "recordlabel", 1, "imgage"),
                new Albums(2, "Second album", "recordlabel", 2, "imgage"),
            };

            albumRepo.GetAll().Returns(expectedAlbum);

            var result = underTest.Get();

            Assert.Equal(expectedAlbum, result.ToList());
        }

        [Fact]
        public void Post_Creates_New_Album()
        {
            var newAlbum = new Albums(1, "New album", "recordlabel", 1, "imgage");
            var albumList = new List<Albums>();

            albumRepo.When(t => t.Create(newAlbum))
                .Do(t => albumList.Add(newAlbum));

            albumRepo.GetAll().Returns(albumList);

            var result = underTest.Post(newAlbum);

            Assert.Contains(newAlbum, result);
        }

        [Fact]
        public void Delete_Removes_Album()
        {
            var albumId = 1;
            var deletedAlbum = new Albums(albumId, "First Album", "recordlabel", 1, "imgage");
            var albumList = new List<Albums>()
            {
                deletedAlbum,
                new Albums(2, "Second album", "recordlabel", 2, "imgage")
            };

            albumRepo.GetByID(albumId).Returns(deletedAlbum);
            albumRepo.When(d => d.Delete(deletedAlbum))
                .Do(d => albumList.Remove(deletedAlbum));

            albumRepo.GetAll().Returns(albumList);
            var result = underTest.Delete(albumId);
            Assert.DoesNotContain(deletedAlbum, result);
            //Assert.All(result, item => Assert.Contains("second item", item.Name));

        }

        [Fact]
        public void Put_Updates_Album()
        {
            var originalAlbum = new Albums(1, "First Album", "recordlabel", 1, "imgage");
            var expectedAlbum = new List<Albums>()
            {
                originalAlbum
            };

            var updatedAlbum = new Albums(1, "Updated album", "recordlabel", 1, "imgage");

            albumRepo.When(t => albumRepo.Update(updatedAlbum))
                .Do(Callback.First(t => expectedAlbum.Remove(originalAlbum))
                .Then(t => expectedAlbum.Add(updatedAlbum)));

            albumRepo.GetAll().Returns(expectedAlbum);
            var result = underTest.Put(updatedAlbum);

            //Assert.Equal(expectedTodo, result.ToList());
            Assert.All(result, item => Assert.Contains("Updated item", item.Name));
        }
    }
}
