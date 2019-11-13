export default function Artist(artists) {
  return `
  <ul> 
  ${artists
    .map(artist => {
      return `
      <div id="detail">
        <article>
          <img class='artistImage' src=${artist.image}>
            <input class="artist__id" type="hidden" value="${artist.id}">
          </img>
        </article>
        <article>
          <li>
            <h3>${artist.name}</h3>
            <h4>${artist.age}</h4>
            <h4>${artist.hometown}</h4>
            <h4>${artist.recordlabel}</h4>
          </li>
            <input class="artist__id" type="hidden" value="${artist.id}">
            <button class="edit-artist__submit" id ="buttonCrud">Edit</button>
            <button class="delete-artist__submit" id ="buttonCrud">Delete</button>
          </article>
        </div>
      `;
    })
    .join("")}   
  </ul>
  <div class="fourm">
    <section class='add-artist'>
      <h1>Add Artist!</h1>
        <input class='add-artist__artistName' type='text' placeholder='Artist Name'>
        <input class='add-artist__artistAge' type='text' placeholder='Age'>
        <input class='add-artist__artistHometown' type='text' placeholder='Hometown'>
        <input class='add-artist__artistRecordLabel' type='text' placeholder='Recordlabel'>
        <button class='add-artist__submit' id ="buttonCrud">Submit</button>
    </section>
  </div>
  `;
}