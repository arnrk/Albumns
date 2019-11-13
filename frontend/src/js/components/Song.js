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

  `;
}
