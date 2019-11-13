import SideNav from "./components/SideNav";
import Header from "./components/Header";
import Logo from "./components/Logo";
import Footer from "./components/Footer";
import Album from "./components/Album";
import Artist from "./components/Artist";
import Song from "./components/Song";
import apiAction from "./api/apiAction";
import EditAlbum from "./components/EditAlbum";
import EditArtist from "./components/EditArtist";
import EditSong from "./components/EditSong";
import SingleArtistPage from "./components/SingleArtistPage";
import SingleAlbumPage from "./components/SingleAlbumPage";

export default () => {
    pageBuild();
};

function pageBuild(){
    header();
    sideNav();
    footer();
    navAlbum();
    navArtist();
    navSong();
    logo();
}

function header(){
    const header = document.querySelector(".headerblock");
    header.innerHTML = Header();
}

function logo(){
    const app = document.querySelector("#app");
    app.innerHTML = Logo();
}

function sideNav(){
    const sideNav = document.getElementById("sideNav");
    sideNav.innerHTML = SideNav();

    sideNav.addEventListener("click", function(){
        if(event.target.classList.contains("nav__home")){
            const display = document.querySelector("#app");
            display.innerHTML = Logo();
        }
    })
}

function footer(){
    const footer = document.getElementById("footer");
    footer.innerHTML = Footer();
}

function navAlbum(){
    const albumButton = document.querySelector(".albums");
    
    albumButton.addEventListener("click", function(){
        apiAction.getRequest("https://localhost:44397/api/album", albums => {
            document.querySelector("#app").innerHTML = Album(albums);
        });
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
        if(event.target.classList.contains("add-album__submit")) {
            const album = event.target.parentElement.querySelector(
                ".add-album__albumName",
            ).value;
            const albumRecordLabel = event.target.parentElement.querySelector(
                ".add-album__albumRecordLabel",
            ).value;
            const artistId = event.target.parentElement.querySelector(".artist__id")
            .value;
            const addAlbumImage = "./images/genericAlbum.svg"

            console.log(album);
            apiAction.postRequest("https://localhost:44397/api/album",
            {
                name: album,
                recordLabel: albumRecordLabel,
                image: addAlbumImage,
                artistsID: artistId
            },
            albums =>{
                console.log(albums);
                document.querySelector("#app").innerHTML = Album(albums)
            })
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("delete-album__submit")) {
            const albumId = event.target.parentElement.querySelector(".album__id")
                .value;
            console.log("delete " + albumId);
            apiAction.deleteRequest(`https://localhost:44397/api/album/${albumId}`,
            albums =>{
               document.querySelector("#app").innerHTML = Album(albums)
            })
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("edit-album__submit")) {
            const albumId = event.target.parentElement.querySelector(".album__id")
                .value;
            console.log("edit " + albumId);
            apiAction.getRequest(`https://localhost:44397/api/album/${albumId}`, 
            album => {
            document.querySelector("#app").innerHTML = EditAlbum(album);
            })
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("update-album__submit")) {
            const albumId = event.target.parentElement.querySelector(".update-album__id")
                .value;
            const albumImage = event.target.parentElement.querySelector(".update-album__image")
                .value;
            const albumName = event.target.parentElement.querySelector(".update-album__name")
                .value;
            const albumRecordLabel = event.target.parentElement.querySelector(".update-album__RecordLabel")
                .value;
                
            
            const albumData = {
                id: albumId,
                name: albumName,
                recordLabel: albumRecordLabel,
                image: albumImage

            }
            apiAction.putRequest(`https://localhost:44397/api/album/${albumId}`,
            albumData,
            album => {
                document.querySelector("#app").innerHTML = Album(album)
            }
            );
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("albumImage")) {
            const albumId = event.target.parentElement.querySelector(".album__id")
                .value;
                apiAction.getRequest(`https://localhost:44397/api/album/${albumId}`, 
                album => {
                    console.log("Displaying Album: " + album.name);
            document.querySelector("#app").innerHTML = SingleAlbumPage(album);
            })
        }
    })
}

function navArtist(){
    const artistButton = document.querySelector(".artists");
    
    artistButton.addEventListener("click", function(){
        apiAction.getRequest("https://localhost:44397/api/artist", artists => {
            document.querySelector("#app").innerHTML = Artist(artists);
        });
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
        if(event.target.classList.contains("add-artist__submit")) {
            const artist = event.target.parentElement.querySelector(
                ".add-artist__artistName"
            ).value;
            const artistAge = event.target.parentElement.querySelector(
                ".add-artist__artistAge",
            ).value;
            const artistHometown = event.target.parentElement.querySelector(
                ".add-artist__artistHometown",
            ).value;
            const artistRecordLabel = event.target.parentElement.querySelector(
                ".add-artist__artistRecordLabel",
            ).value;
            const addArtistImage = "./images/genericArtist.svg"

            console.log(artist);
            apiAction.postRequest("https://localhost:44397/api/artist",
            {
                name: artist,
                age: artistAge,
                hometown: artistHometown,
                recordLabel: artistRecordLabel,
                image: addArtistImage
            },
            artists =>{
                console.log(artists);
                document.querySelector("#app").innerHTML = Artist(artists)
            })
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("delete-artist__submit")) {
            const artistId = event.target.parentElement.querySelector(".artist__id")
                .value;
            console.log("delete " + artistId);
            apiAction.deleteRequest(`https://localhost:44397/api/artist/${artistId}`,
            artists =>{
               document.querySelector("#app").innerHTML = Artist(artists)
            })
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("edit-artist__submit")) {
            const artistId = event.target.parentElement.querySelector(".artist__id")
                .value;
            console.log("edit " + artistId);
            apiAction.getRequest(`https://localhost:44397/api/artist/${artistId}`, 
            artist => {
            document.querySelector("#app").innerHTML = EditArtist(artist);
            })
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("update-artist__submit")) {
            const artistId = event.target.parentElement.querySelector(".update-artist__id")
                .value;
            const artistImage = event.target.parentElement.querySelector(".update-artist__image")
                .value;
            const artistName = event.target.parentElement.querySelector(".update-artist__name")
                .value;
            const artistAge = event.target.parentElement.querySelector(".update-artist__age")
                .value;
            const artistHometown = event.target.parentElement.querySelector(".update-artist__hometown")
                .value;
            const artistRecordLabel = event.target.parentElement.querySelector(".update-artist__RecordLabel")
                .value;
            
            const artistData = {
                id: artistId,
                name: artistName,
                age: artistAge,
                hometown: artistHometown,
                recordLabel: artistRecordLabel,
                image: artistImage
            }
            apiAction.putRequest(`https://localhost:44397/api/artist/${artistId}`,
            artistData,
            artist => {
                document.querySelector("#app").innerHTML = Artist(artist)
            }
            );
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("artistImage")) {
            const artistId = event.target.parentElement.querySelector(".artist__id")
                .value;
                apiAction.getRequest(`https://localhost:44397/api/artist/${artistId}`, 
                artist => {
                    console.log("Displaying Artist: " + artist.name);
            document.querySelector("#app").innerHTML = SingleArtistPage(artist);
            })
        }
    })

}

function navSong(){
    const songButton = document.querySelector(".songs");
    
    songButton.addEventListener("click", function(){
        apiAction.getRequest("https://localhost:44397/api/song", songs => {
            document.querySelector("#app").innerHTML = Song(songs);
        });
    });

    const app = document.querySelector("#app");
    app.addEventListener("click", function(){
        if(event.target.classList.contains("add-song__submit")) {
            const song = event.target.parentElement.querySelector(
                ".add-song__songName",
            ).value;
            const songDuration = event.target.parentElement.querySelector(
                ".add-song__songDuration",
            ).value;
            const albumId = event.target.parentElement.querySelector(".album__id")
            .value;

            console.log(song);
            apiAction.postRequest("https://localhost:44397/api/song",
            {
                name: song, 
                duration: songDuration,
                albumsID: albumId
            },
            
            songs =>{
                console.log(songs);
                document.querySelector("#app").innerHTML = Song(songs)
            })
        }
       
    })
    
    app.addEventListener("click", function(){
        if(event.target.classList.contains("delete-song__submit")) {
            const songId = event.target.parentElement.querySelector(".song__id")
                .value;
            console.log("delete " + songId);
            apiAction.deleteRequest(`https://localhost:44397/api/song/${songId}`,
            songs =>{
               document.querySelector("#app").innerHTML = Song(songs)
            })
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("edit-song__submit")) {
            const songId = event.target.parentElement.querySelector(".song__id")
                .value;
            console.log("edit " + songId);
            apiAction.getRequest(`https://localhost:44397/api/song/${songId}`, 
            song => {
            document.querySelector("#app").innerHTML = EditSong(song);
            })
        }
    })

    app.addEventListener("click", function(){
        if(event.target.classList.contains("update-song__submit")) {
            const songId = event.target.parentElement.querySelector(".update-song__id")
                .value;
            const songName = event.target.parentElement.querySelector(".update-song__name")
                .value;
            const songDuration = event.target.parentElement.querySelector(".update-song__duration")
                .value;

            const songData = {
                id: songId,
                name: songName,
                duration: songDuration
            }
            apiAction.putRequest(`https://localhost:44397/api/song/${songId}`,
            songData,
            song => {
                document.querySelector("#app").innerHTML = Song(song)
            }
            );
        }
    }) 
}
