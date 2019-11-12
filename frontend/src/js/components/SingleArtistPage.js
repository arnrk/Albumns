export default function SingleArtistPage(artist){
    return`
    <div id="detail">
    <article>
      <img src=${artist.image} class='artistImage'>
      <input id="artistIm" class="artist__id" type="hidden" value="${artist.id}"></img>
    </article>
    <article>
      <li>
          <h3>${artist.name}</h3>
          <h4>${artist.age}</h4>
          <h4>${artist.hometown}</h4>
          <h4>${artist.recordlabel}</h4>
        
          <input id="artistIm" class="artist__id" type="hidden" value="${artist.id}">
          <button class="edit-artist__submit" id = "buttonCrud">Edit</button>
          <button class="delete-artist__submit" id = "buttonCrud">Delete</button>
        </li>
      </article>
      <ul> 
      ${artist.albums
        .map(album => {
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
        })
        .join("")}
    </ul>
    </ul>
  
    <section class='add-album'>
      <input class="artist__id" type="hidden" value="${artist.id}">
      <input class='add-album__albumName' type='text' placeholder='Album Name'>
      <input class='add-album__albumRecordLabel' type='text' placeholder='Recordlabel Name'>
      <button class='add-album__submit'id ="buttonCrud">Submit</button>
    </section>
  
      </div>
    `;
}