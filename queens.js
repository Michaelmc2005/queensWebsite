let cards;

// Fetch the JSON data from the file
fetch('cards.json')
  .then(response => response.json())
  .then(data => {
    cards = data;
  });

// Get the button element


// Add a click event listener to the button
document.addEventListener('DOMContentLoaded', function(){
  // Get a random index between 0 and the number of cards
  const randomIndex = Math.floor(Math.random() * cards.length);
  // Get the card at the random index
  const button = document.getElementById('button1');
  const card = cards[randomIndex];
  // Update the random card div with the card name and description
  const randomCardDiv = document.getElementById('random-card');
  randomCardDiv.innerHTML = `
    <h2>${card.name}</h2>
    <p>${card.description}</p>
  `;
});
