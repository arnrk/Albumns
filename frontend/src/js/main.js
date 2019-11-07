import Header from "./components/Header";
import NavBar from "./components/NavBar";
import Footer from "./components/Footer";
import Album from "./components/Album";
import Artist from "./components/Artist";
import Song from "./components/Song";
import apiAction from "./api/apiAction";
import EditAlbum from "./components/EditAlbum";
import EditArtist from "./components/EditArtist";
import EditSong from "./components/EditSong";

export default () => {
    pageBuild();
};

function pageBuild(){
    header();
    navBar();
    navAlbum();
    navArtist();
    navSong();
    footer();
}

function header(){
    const header = document.getElementById("header");
    header.innerHTML = Header();
    
}

function footer(){
    const footer = document.getElementById("footer");
    footer.innerHTML = Footer();
}

function navBar() {
    const navBar = document.querySelector("#narbar");
  
    navBar.innerHTML = NavBar();

    // const menuAnimated = document.querySelector("#menuAnimated")
    // menuAnimated.addEventListener("click", Function{
    //     if (event.target)
    // });
    // navBar.addEventListener("click", Function {
    //     event.classList.toggle("change")
    // });
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
                ".add-album__albumName"
            ).value;

            console.log(album);
            apiAction.postRequest("https://localhost:44397/api/album",
            {
                name: album
            },
            albums =>{
                console.log(albums);
                document.querySelector("#app").innerHTML = Album(albums)
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

            console.log(artist);
            apiAction.postRequest("https://localhost:44397/api/artist",
            {
                name: artist
            },
            artists =>{
                console.log(artists);
                document.querySelector("#app").innerHTML = Artist(artists)
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
                ".add-song__songName"
            ).value;

            console.log(song);
            apiAction.postRequest("https://localhost:44397/api/song",
            {
                name: song
            },
            songs =>{
                console.log(songs);
                document.querySelector("#app").innerHTML = Song(songs)
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
        if(event.target.classList.contains("update-album__submit")) {
            const albumId = event.target.parentElement.querySelector(".update-album__id")
                .value;
            const albumName = event.target.parentElement.querySelector(".update-album__name")
                .value;
            
            const albumData = {
                id: albumId,
                name: albumName
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
        if(event.target.classList.contains("update-artist__submit")) {
            const artistId = event.target.parentElement.querySelector(".update-artist__id")
                .value;
            const artistName = event.target.parentElement.querySelector(".update-artist__name")
                .value;
            
            const artistData = {
                id: artistId,
                name: artistName
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
        if(event.target.classList.contains("update-song__submit")) {
            const songId = event.target.parentElement.querySelector(".update-song__id")
                .value;
            const songName = event.target.parentElement.querySelector(".update-song__name")
                .value;
            
            const songData = {
                id: songId,
                name: songName
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