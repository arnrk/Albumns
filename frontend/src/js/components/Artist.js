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
                <img src=${artist.image}></img>

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
    <input class='add-artist__artistAge type='text' placeholder='Add artist age'>
    <input class='add-artist__artistHometown' type='text' placeholder='Add artist hometown'>
    <input class='add-artist__artistRecordLable type= placeholder='Add recordlabel>
    <button class='add-artist__submit' id = "button">Submit</button>
  </section>
  `;
}