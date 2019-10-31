import Header from "./components/Header";
import Footer from "./components/Footer";
import Album from "./components/Album";
import Artist from "./components/Artist";
import Song from "./components/Song";

export default () => {
    pageBuild();
};

function pageBuild(){
    header();
    footer();
    album();
    artist();
    song();
}

function header(){
    const header = document.getElementById("header");
    header.innerHTML = Header();
    
}

function footer(){
    const footer = document.getElementById("footer");
    footer.innerHTML = Footer();
}

function album(){
    const album = document.getElementById("album")
    album.innerHTML = Album();
}

function artist(){
    const album = document.getElementById("artist")
    album.innerHTML = Artist();
}

function song(){
    const album = document.getElementById("song")
    album.innerHTML = Song();
}