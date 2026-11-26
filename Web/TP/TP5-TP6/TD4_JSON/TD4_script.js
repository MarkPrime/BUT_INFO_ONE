// Tableau de films
let films = [];

// Charger les données
async function etape1() {
	// Charger les données et remplir les selects
	await chargerDonnees();
	remplirSelects();
	document.getElementById('resultatEt1').textContent = `Nombre total de films : ${films.length}`;
}

// Exemple 1
function exemple1() {
	let resultat = "";
	for (let i = 0; i < films.length; i++) {
		resultat = resultat + films[i].titre + "\n";
	}
	document.getElementById('resultatExemple1').textContent = resultat;	
}       

// Exemple 1bis
function exemple1bis() {
	let resultat = "";
	films.forEach((unFilm) => {
		resultat = resultat + unFilm.titre + "\n";
	});
	document.getElementById('resultatExemple1bis').textContent = resultat;
}     
// Exemple 2		
function exemple2() {
	let resultat = "";
	films.forEach((unFilm) => {
		if(unFilm.annee === 2020){
			resultat = resultat + unFilm.titre + " - " + unFilm.genre +  "\n";
		}
	});
	document.getElementById('resultatExemple2').textContent = resultat;
}         

// Exemple 3
function exemple3(){
	let resultat = []; //Déclaration d'un tableau
	films.forEach ((unFilm) => {
		if(unFilm.langue === 'Portugais'){
			resultat.push(unFilm);
		}
	});
	afficherResultats(resultat, 'resultatExemple3');
}

// Exercice 1
function exercice1() {
	let resultat = []; //Déclaration d'un tableau
	films.forEach ((unFilm) => {
		if(unFilm.genre === 'Science-fiction' && unFilm.annee <= 2000){
			resultat.push(unFilm);
		}
	});
	afficherResultats(resultat, 'resultatEx1');
}

// Exercice 2
function exercice2() {
	//** Code à compléter **
	let resultat = "";
	let trouve = false;
	let i = 0;
	while (i < films.length && !trouve) {
		if (films[i].titre === "La nuit et l'argile") {
			trouve = true;
		}
		else {
			i++;
		}
	}
	if (!trouve) {
		resultat = "Film non trouvée...";
	}
	else {
		resultat = "Les acteurs :\n";
		films[i].acteurs.forEach((unActeur) => {
			resultat = resultat + unActeur + "\n"
		});
		resultat = resultat + "\nCinema : " + films[i].cinema + "\n";
		films[i].seances.forEach((uneSeance) => {
			resultat = resultat + uneSeance + "\n"
		});
	}
	document.getElementById('resultatEx2').textContent = resultat;

}		

// Exercice 3
function exercice3() {
	//** Code à compléter **
	let saisie = document.getElementById('titreRecherche').value;
	saisie = saisie.toLowerCase();
	let resultat = []; //Déclaration d'un tableau
	films.forEach ((unFilm) => {
		if(unFilm.titre.toLowerCase().includes(saisie) == true){
			resultat.push(unFilm);
		}
	});
	afficherResultats(resultat, 'resultatEx3');
}

// Exercice 4
function exercice4() {
	//** Code à compléter **		
}

// Exemple 4
function exemple4() {
	const resultats = films.filter(film =>
		film.cinema === "UGC Les Halles"
	);
	afficherResultats(resultats, 'resultatExemple4');
}

// Exemple 5
function exemple5() {
	const unFilm = films.find(film =>
		film.titre === "Le rêve et le cristal"
	);
	let resultat = [];
	if (unFilm !== undefined){
		resultat.push(unFilm);
	}
	afficherResultats(resultat, 'resultatExemple5');
}

// Exemple 6
function exemple6() {
	const reponsePositive = films.some(film =>
		film.acteurs.includes("Anaïs Demoustier")
	);
	let resultat; 
	if(reponsePositive){ 
		resultat = "Oui, Anaïs Demoustier joue dans 1 ou plusieurs films"; 
	} else{ 
		resultat = "Non, Anaïs Demoustier ne joue dans aucun film"; 
	} 
	document.getElementById('resultatExemple6').textContent = resultat; 
}

// Exemple 7
function exemple7() {

	let caCumule = films.reduce((ca,film) =>{
			return ca + film.recettes;
		  },0);

	const resultat = `Chiffre d'affaires cumulé de tous les films : ${caCumule.toFixed(2)} M€`;
	document.getElementById('resultatExemple7').textContent = resultat;
}

// Exercice 5
function exercice6() {
	//** Code à compléter **
}

// Exercice 7
function exercice7() {
	//** Code à compléter **
}

// Exercice 8
function exercice8() {
	//** Code à compléter **
}

// Exercice 9
function exercice9() {
	//** Code à compléter **
}

// Exercice 10
function exercice10() {
	//** Code à compléter **	
}

///////////////////////////////////////////////////////////////////////////////////////////////////////////
//Fonctions pour charger le flux JSON, pour charger les comboBox et afficher le résultats, ne pas modifier
///////////////////////////////////////////////////////////////////////////////////////////////////////////

// Charger les données
async function chargerDonnees() {
	try {
		const response = await fetch('http://localhost:8080/films');
		films = await response.json();
	}
	catch (error) {// Gérer les erreurs (réseau, réponse non correcte, etc.)    
		console.error('Une erreur est survenue :', error);  
	}				
}

function remplirSelects() {
	const genres = [...new Set(films.flatMap(f => f.genres))].sort();
	const pays = [...new Set(films.flatMap(f => f.pays))].sort();
	const plateformes = [...new Set(films.filter(f => f.disponible).map(f => f.streaming))].sort();

	const genreSelect = document.getElementById('genreRecherche');	
	genres.forEach(g => {
		const option = document.createElement('option');
		option.value = g;
		option.textContent = g;
		genreSelect.appendChild(option);
	});
	
	const genreSelect2 = document.getElementById('genreRecherche2');	
	genres.forEach(g => {
		const option = document.createElement('option');
		option.value = g;
		option.textContent = g;
		genreSelect2.appendChild(option);
	});	


	const paysSelect = document.getElementById('paysRecherche');
	pays.forEach(p => {
		const option = document.createElement('option');
		option.value = p;
		option.textContent = p;
		paysSelect.appendChild(option);
	});

}

function afficherResultats(resultats, id) {
	const div = document.getElementById(id);
	if (resultats.length === 0) {
		div.textContent = 'Aucun film trouvé.';
		return;
	}
	div.innerHTML = `
		<p><strong>${resultats.length} film(s) trouvé(s) :</strong></p>
		<table>
			<tr>
				<th>ID</th>
				<th>Titre</th>
				<th>Année</th>
				<th>Note</th>
				<th>Budget (M€)</th>
				<th>Recettes (M€)</th>
				<th>Genre</th>
				<th>Durée</th>
			</tr>
			${resultats.map(f => `
				<tr>
					<td>${f.id}</td>
					<td>${f.titre}</td>
					<td>${f.annee}</td>
					<td>${f.note}</td>
					<td>${f.budget}</td>
					<td>${f.recettes}</td>
					<td>${f.genre}</td>
					<td>${f.duree} min</td>
				</tr>
			`).join('')}
		</table>
	`;
}

