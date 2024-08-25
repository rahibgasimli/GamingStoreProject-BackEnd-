
let products = document.getElementById('products');
let games = window.localStorage.getItem('cartGames');

if (games != null) {

	let gameArr = Array.from(JSON.parse(games));
	let totalPrice = 0.0;

	for (let game of gameArr) {
		totalPrice += parseFloat(game.price);
		let product = document.createElement('div');
		product.classList.add('product');
		product.innerHTML = `
						<div class="row">
								<div class="col-md-3">
									<img class="img-fluid mx-auto d-block image" src="${game.photo}">
								</div>
								<div class="col-md-8">
									<div class="info">
										<div class="row">
											<div class="col-md-5 product-name">
												<div class="product-name">
													<a href="https://localhost:7161/Games/Single?gameId=${game.Id}">${game.name}</a>
													<div class="product-info">
														<div>Genres: <span class="value">${game.genre}</span></div>
														<div>Tags: <span class="value">${game.tag}</span></div>
													</div>
												</div>
											</div>
											<div class="col-md-7 price d-flex justify-content-end">
												<span>$ ${game.price}</span>
											</div>
										</div>
									</div>
								</div>
							</div>
            
            `
		products.appendChild(product);
	}

	document.getElementById("totalPrice").innerText = `$${totalPrice}`;

}