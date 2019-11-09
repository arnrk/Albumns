export default function SingleAlbumPage(album) {
    return `
    <div class="albumDetails" id="albumDetail">
        <article>
            <img class ="albumImage" src=${album.image}>
                <input class="album__id" type="hidden" value="${album.id}">
            </img>
        </article>
        <article>
            <li>
                <h3>${album.name}</h3>
                <h4>${album.recordlabel}</h4>
            </li>
              <input class="album__id" type="hidden" value="${album.id}">
              <button class="edit-album__submit" id="buttonCrud">Edit</button>
              <button class="delete-album__submit"id="buttonCrud">Delete</button>
        </article>
    </div>
    `;
}