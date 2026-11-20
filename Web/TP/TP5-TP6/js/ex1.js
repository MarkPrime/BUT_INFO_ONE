function exo1() 
{
    let nom;
    let annee;
    let anneeOk;
    let age;
    const MAINTENANT = 2026;

    nom = prompt("Quelle est votre nom?");

    do 
    {
        annee = prompt("Entrer votre année de naissance :");
        anneeOk = confirm("Bonjour " + nom + ", Comfirmer-vous l'année");
    } while (!anneeOk);
    age = MAINTENANT - annee;
    alert(nom + " : vous avez " + age + " ans");
    alert(`${nom} : vous avez ${age} ans`);
}

function exo2() 
{
    let tab = [];
    let nombre;

    for (let index = 0; index < 50; index++) {
        nombre = Math.round(Math.random() * 100);
        tab.push(nombre);
    }
    alert(tab);
}
function exo3() 
{
    // Créer les élements
    const section = document.createElement('section');
    const h1 = document.createElement('h1');
    const ul = document.createElement('ul');
    const li1 = document.createElement('li');
    const li2 = document.createElement('li');
    const li3 = document.createElement('li');

    const h1Text = document.createTextNode('Le cours W11');
    const li1Text = document.createTextNode('HTML');
    const li2Text = document.createTextNode('CSS');
    li3.textContent = "Javascript";

    h1.appendChild(h1Text);
    li1.appendChild(li1Text);
    li2.appendChild(li2Text);

    ul.appendChild(li1);
    ul.appendChild(li2);
    ul.appendChild(li3);

    section.appendChild(h1);
    section.appendChild(ul);

    document.body.appendChild(section);
    
    ul.innerHTML += "<li>Les API Json</li>"
}
function exo6()
{
    const paragraph = document.getElementById('parEx6');
    paragraph.addEventListener('click', modifTexte(paragraph));
}
function modifTexte(paragraph)
{
    let texte = paragraph.innerHTML;
    const zoneSaisie = document.createElement('textarea');
    zoneSaisie.value = texte;
    document.body.appendChild(zoneSaisie);
    const bouton = document.createElement('button');
    bouton.textContent = "Valider"

    bouton.onclick = function () 
    {
        paragraph.innerHTML = zoneSaisie.value;
        zoneSaisie.remove();
        bouton.remove();    
    }

    document.body.appendChild(bouton)
}
function exo7()
{
    let nb = Math.round(Math.random() * 826 + 1);

    const getUnPersonnage = async () => {
        try {
            const response = await fetch(`https://rickandmortyapi.com/api/character/${nb}`);

            if (!response.ok) {
                throw new Error("Error de réseau !");
            }

            const data = await response.json();

            const ContainerPersonnage = document.getElementById('ContainerPersonnage');

            codeHTML = `
                <p>Id: ${data.id}</p>
                <p>Name: ${data.name}</p>
                <p>Status: ${data.status}</p>
                <p>Species: ${data.species}</p>
                <img src="${data.image}" alt="${data.name}">
                <ul>
                    <li>Episode ${data.episode}</li>
                </ul>
                `;

                ContainerPersonnage.innerHTML = codeHTML;

        } catch (error) {
            console.error('Une erreur est survenue :', error);
        }
    };
    getUnPersonnage();
}