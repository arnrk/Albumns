export default function Album(albums) {
    return `
    <ul> 
    ${albums
      .map(album => {
        return `
            <li>
                <h3>${album.name}</h3>

                <input class="album__id" type="hidden" value="${album.id}">
                    <button class="edit-album__submit">Edit</button>
                    <button class="delete-album__submit">Delete</button>

            </li>
        `;
      })
      .join("")}
  </ul>
  
  <section class='add-album'>
    <input class='add-album__albumName' type='text' placeholder='Add a album!'>
    <button class='add-album__submit'id = "button">Submit</button>
  </section>
  `;
}