export default function Song(song){
    return`
        <section class='main-content__song'>
            <h3>${song.name}</h3>
        </section>
        <section class='update-song'>
            <input class="update-song__name" value="${song.name}">
            <input class="update-song__duration" value="${song.duration}">
            <button class="update-song__submit" id="buttonCrud">Save Changes</button>
            <input class="update-song__id" type='hidden' value="${song.id}">
            <input class="update-song__albumid" type='hidden' value="${song.albumsID}">
        </section>
    `;
}