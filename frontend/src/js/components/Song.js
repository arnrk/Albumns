export default function Song(songs) {
    return `
    <ul> 
    ${songs
      .map(song => {
        return `
        <div id="songbox">
            <li>
                <h3>${song.name}</h3>
                <h4>${song.duration}</h4>
                <input class="song__id" type="hidden" value="${song.id}">
                      <button class="edit-song__submit" id="buttonCrud">Edit</button>
                      <button class="delete-song__submit" id="buttonCrud">Delete</button>
            </li>
          </div>
        `;
      })
      .join("")}
  </ul>
  
  `;
}
