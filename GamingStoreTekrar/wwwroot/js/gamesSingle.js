const btnAddToCart = document.getElementById('btnAddToCart');

btnAddToCart.addEventListener('click', () => {

    let photo = document.getElementById('gamePhoto').src;
    let name = document.getElementById('gameName').innerText;
    let genre = document.getElementById('gameGenre').innerText;
    let tag = document.getElementById('gameTag').innerText;
    let price = document.getElementById('gamePrice').innerText.replace("$", "");
    let id = document.getElementById('gameId').value;

    let gameObj = {
        "id": id,
        "photo": photo,
        "name": name,
        "genre": genre,
        "tag": tag,
        "price": price
    };

    let games = window.localStorage.getItem("cartGames");

    if (games == null || games === "" || games === " ") {
        games = [gameObj];
        window.localStorage.setItem("cartGames", JSON.stringify(games));
    } else {
        console.log(games);
        let gamesArr = Array.from(JSON.parse(games));
        //games = [gameObj];
        //for (let obj of gamesArr) {
        gamesArr.push(gameObj);
        window.localStorage.setItem("cartGames", JSON.stringify(gamesArr));
        //}
        //    gamesArr.append(gameObj);
    }
});