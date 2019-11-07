export default function Album(albums) {
    return `
    <ul> 
    ${albums
      .map(album => {
        return `
        <div class= "albumDetails" id="detail"><li>
        <article>
                <h3>${album.name}</h3>
        </article>
        <article>
                <h4>${album.recordlabel}</h4>
                <img class ="image" id="detail article img" src=${album.image}></img>
                <input class="album__id" type="hidden" value="${album.id}">
                    <button class="edit-album__submit" id="buttonCrud">Edit</button>
                    <button class="delete-album__submit"id="buttonCrud">Delete</button>
            </li>
        </article>
        </div>    
        `;
      })
      .join("")}
  </ul>
  
  <section class='add-album'>
    <input class='add-album__albumName' type='text' placeholder='Add a album!'>

    <input class='add-album__albumRecordLabel' type='text' placeholder='Add recordlabel'>

    <button class='add-album__submit'id = "buttonCrud">Submit</button>

  </section>
  `;
}