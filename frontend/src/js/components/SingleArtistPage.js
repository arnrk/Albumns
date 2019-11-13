export default function SingleArtistPage(artist){
    return`
    <div id="detail">
      <article>
        <img src=${artist.image} class='artistImage'>
        <input id="artistIm" class="artist__id" type="hidden" value="${artist.id}"></img>
      </article>
      <article>
        <ul>
          <li>${artist.name}</li>
          <li>${artist.age}</li>
          <li>${artist.hometown}</li>
          <li>${artist.recordlabel}</li>          
            <input id="artistIm" class="artist__id" type="hidden" value="${artist.id}">
            <button class="edit-artist__submit" id = "buttonCrud">Edit</button>
            <button class="delete-artist__submit" id = "buttonCrud">Delete</button>
        </ul>
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
        <div class="fourm">
          <section class='add-album'>
            <h1>Add Album</h1>
            <input class="artist__id" type="hidden" value="${artist.id}">
            <input class='add-album__albumName' type='text' placeholder='Album Name'>
            <input class='add-album__albumRecordLabel' type='text' placeholder='Recordlabel Name'>
            <button class='add-album__submit'id ="buttonCrud">Submit</button>
          </section>
        </div>
    </div>
  `;
}