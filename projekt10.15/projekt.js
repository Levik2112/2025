function elemKeszito(){
    let valasztott = document.getElementById("CustomElemek").value;
    
    let kreal = document.createElement("input");
    kreal.type = valasztott;

    document.body.appendChild(kreal);
    let checkbox = document.getElementsByClassName("check");
    
    console.log(document.getElementById("asd").checked)
    for(let i =0;i<checkbox.length;i++){
        if(checkbox[i].checked === true){
            
        }
    }
    console.log(checkbox[0].checked)
}