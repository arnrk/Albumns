export default function Album(album){
    return`
        <section class='main-content__album'>
            <h3>${album.name}</h3>
        </section>
        <section class='update-album'>
            <input class="update-album__name" value="${album.name}">
            <input class='update-album__RecordLabel' type='text' value="${album.recordlabel}">
            <button class="update-album__submit" id="buttonCrud">Save Changes</button>
            <input class="update-album__id" type='hidden' value="${album.id}">
            <input class="update-album__image" type='hidden' value="${album.image}">
        </section>
    `;
}