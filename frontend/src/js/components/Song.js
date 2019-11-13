export default function Song(songs) {
    return `
    <div class="songDetail">
      <ul> 
      ${songs
        .map(song => {
          return `
          <div>
            <li>Title: ${song.name}</li>
            <li>Duration: ${song.duration}</li>
            <input class="song__id" type="hidden" value="${song.id}">
              <button class="edit-song__submit" id="buttonCrud">Edit</button>
              <button class="delete-song__submit" id="buttonCrud">Delete</button>
          </div>
          `;
        })
        .join("")}
      </ul>
    </div>
    <div class="fourm">
      <section class='add-song'>
      <h1>Add Song!</h1>
        <input class='add-song__songName' type='text' placeholder='Add a song!'>
        <input class='add-song__songDuration' type='text' placeholder='Add song duration'>
        <button class='add-song__submit' id = "buttonCrud">Submit</button>
      </section>
    </div>
  `;
}
