function elemKeszito() {
    let checkbox = document.getElementsByClassName("check");

    for (let i = 0; i < checkbox.length; i++) {
        if (checkbox[i].checked === true) {
            let temp = checkbox[i].parentElement.dataset.nev + ': <input type="' + checkbox[i].parentElement.dataset.tipus + '">';
            kozep.push(temp);
        }
    }

    html = eleje + kozep.join("<br>") + vege;

    // Start file download.
    // Generate download of hello.txt file with some content
    var text = html;
    var filename = "teszt.html";

    download(filename, text);
}

function download(filename, text) {
    var element = document.createElement('a');
    element.setAttribute('href', 'data:text/html;charset=utf-8,' + encodeURIComponent(html));
    element.setAttribute('download', filename);

    element.style.display = 'none';
    document.body.appendChild(element);

    element.click();

    document.body.removeChild(element);
}

function hozzaad() {
    let valasztott = document.getElementById("CustomElemek").value;

    let kreal = document.createElement("input");
    kreal.type = valasztott;

    document.getElementById("hozzaadott").innerHTML += document.getElementById("customNev").value;

    document.getElementById("hozzaadott").appendChild(kreal);
    document.getElementById("hozzaadott").innerHTML += "<br>";
}

let eleje = '<!DOCTYPE html><html lang="en"><head><meta charset="UTF-8"><meta name="viewport" content="width=device-width, initial-scale=1.0"></head><body><form>';
let kozep = [];
let vege = '</form></body></html>';
let html = "";