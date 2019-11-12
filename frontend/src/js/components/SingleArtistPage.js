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
    </div>
    `;
}