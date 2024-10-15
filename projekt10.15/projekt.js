function elemKeszito(){
    let valasztott = document.getElementById("CustomElemek").value;
    
    let kreal = document.createElement("input");
    kreal.type = valasztott;

    document.body.appendChild(kreal);
}