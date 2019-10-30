import Header from "./components/header";
import Footer from "./components/footer";

export default () => {
    pageBuild();
    
};

function pageBuild(){
    header();
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