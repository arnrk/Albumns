export default function Song(songs) {
    return `
    <ul> 
    ${songs
      .map(song => {
        return `
            <li>

                <h3>${song.name}</h3>
                <h4>${song.duration}</h4>
                <input class="song__id" type="hidden" value="${song.id}">
                      <button class="edit-song__submit" id="buttonCrud">Edit</button>
                      <button class="delete-song__submit" id="buttonCrud">Delete</button>

                

            </li>
        `;
      })
      .join("")}
  </ul>
  
  <section class='add-song'>
    <input class='add-song__songName' type='text' placeholder='Add a song!'>
    <input class='add-song__songDuration' type='text' placeholder='Add song duration'>
    <button class='add-song__submit' id = "buttonCrud">Submit</button>
  </section>
  `;
}