export default function Album(albums) {
    return `
    <ul> 
    ${albums
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
  <div class="fourm">
    <section class='add-album'>
      <h1>Add Album!</h1>
      <input class='add-album__albumName' type='text' placeholder='Add a album!'>
      <input class='add-album__albumRecordLabel' type='text' placeholder='Add recordlabel'>
      <button class='add-album__submit'id = "buttonCrud">Submit</button>
    </section>
  </div>
  `;
}