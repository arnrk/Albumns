export default function SingleAlbumPage(album) {
    return `
    <div class="albumDetails" id="albumDetail">
        <article>
            <img class ="albumImage" src=${album.image}>
                <input class="album__id" type="hidden" value="${album.id}">
            </img>
                 <ul> 
        ${album.songs
          .map(song => {
            return `
                <li>
                    <h3>${song.name}</h3>
                    <h4>${song.duration}</h4>
                    <input class="song__id" type="hidden" value="${song.id}">
                          <button class="edit-song__submit" id="buttonCrud">Edit</button>
                          <button class="delete-song__submit" id="buttonCrud">Delete</button>
                </li>
            `;
          })
          .join("")}
      </ul>
      
      <section class='add-song'>
        <input class="album__id" type="hidden" value="${album.id}">
        <input class='add-song__songName' type='text' placeholder='Add a song!'>
        <input class='add-song__songDuration' type='text' placeholder='Add song duration'>
        <button class='add-song__submit' id = "buttonCrud">Submit</button>
      </section>    
   
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