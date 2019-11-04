export default function Song(songs) {
    return `
    <ul> 
    ${songs
      .map(song => {
        return `
            <li>
                <h3>${song.name}</h3>
            </li>
        `;
      })
      .join("")}
  </ul>
  
  <section class='add-song'>
    <input class='add-song__songName' type='text' placeholder='Add a song!'>
    <button class='add-song__submit'>Submit</button>
  </section>
  `;
}