import Header from "./components/Header";
import Footer from "./components/Footer";
import Album from "./components/Album";
import Artist from "./components/Artist";
import Song from "./components/Song";
import apiAction from "./api/apiAction";

export default () => {
    pageBuild();
};

function pageBuild(){
    header();
    footer();
    navAlbum();
    navArtist();
    navSong();
}

function header(){
    const header = document.getElementById("header");
    header.innerHTML = Header();
    
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
                ".add-album__albumName"
            ).value;

            console.log(album);
            apiAction.postRequest("https://localhost:44397/api/album",
            album,
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
            artist,
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
            song,
            songs =>{
                console.log(songs);
                document.querySelector("#app").innerHTML = Song(songs)
            })
        }
    })

}