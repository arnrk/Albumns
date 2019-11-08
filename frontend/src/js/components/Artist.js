export default function Artist(artists) {
  return `
  <ul> 
  ${artists
    .map(artist => {
      return `
      <div id="detail">
        <article>
          <img src=${artist.image} class='artistAlbums'></img>
        </article>
        <article>
          <li>
              <h3>${artist.name}</h3>
              <h4>${artist.age}</h4>
              <h4>${artist.hometown}</h4>
              <h4>${artist.recordlabel}</h4>


              <input class="artist__id" type="hidden" value="${artist.id}">
                    <button class="edit-artist__submit" id = "buttonCrud">Edit</button>
                    <button class="delete-artist__submit" id = "buttonCrud">Delete</button>
          </li>
          </article>
        </div>
      `;
    })
    .join("")}
</ul>

<section class='add-artist'>
  <input class='add-artist__artistName' type='text' placeholder='Add a artist!'>
  <input class='add-artist__artistAge' type='text' placeholder='Add artist age'>
  <input class='add-artist__artistHometown' type='text' placeholder='Add artist hometown'>
  <input class='add-artist__artistRecordLabel' type='text' placeholder='Add recordlabel'>
  <button class='add-artist__submit' id = "buttonCrud">Submit</button>
</section>
`;
}