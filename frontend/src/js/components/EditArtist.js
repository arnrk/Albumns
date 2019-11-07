export default function Artist(artist){
    return`
        <section class='main-content__artist'>
            <h3>${artist.name}</h3>
        </section>

        <section class='update-artist'>
            <input class="update-artist__name" value="${artist.name}">
            <input class='update-artist__age' type='text' value="${artist.age}">
            <input class='update-artist__hometown' type='text' value="${artist.hometown}">
            <input class='update-artist__RecordLabel' type='text' value="${artist.recordlabel}">
            <button class="update-artist__submit" id="buttonCrud">Save Changes</button>
            <input class="update-artist__id" type='hidden' value="${artist.id}">
            <input class="update-artist__image" type='hidden' value="${artist.image}">
        </section>
    `;
}