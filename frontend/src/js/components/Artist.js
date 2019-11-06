export default function Artist(artists) {
    return `
    <ul> 
    ${artists
      .map(artist => {
        return `
            <li>
                <h3>${artist.name}</h3>
                <h4>${artist.age}</h4>
                <h4>${artist.hometown}</h4>
                <h4>${artist.recordlabel}</h4>
                <h4>${artist.image}</h4>

                <input class="artist__id" type="hidden" value="${artist.id}">
                      <button class="edit-artist__submit">Edit</button>
                      <button class="delete-artist__submit">Delete</button>
            </li>
        `;
      })
      .join("")}
  </ul>
  
  <section class='add-artist'>
    <input class='add-artist__artistName' type='text' placeholder='Add a artist!'>
    <button class='add-artist__submit' id = "button">Submit</button>
  </section>
  `;
}