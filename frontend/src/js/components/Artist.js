export default function Artist(artists) {
    return `
    <ul> 
    ${artists
      .map(artist => {
        return `
            <li>
                <h3>${artist}</h3>
            </li>
        `;
      })
      .join("")}
  </ul>
  
  <section class='add-artist'>
    <input class='add-artist__artistName' type='text' placeholder='Add a artist!'>
    <button class='add-artist__submit'>Submit</button>
  </section>
  `;
}