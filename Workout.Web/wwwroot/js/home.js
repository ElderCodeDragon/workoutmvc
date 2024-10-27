const testApiParagraph = document.querySelector("#apiResult");

async function GetTestApi(){
    let response = await fetch("REST/Workout/test");
    let obj = await response.json();
    testApiParagraph.innerText = obj.message;
}

GetTestApi();
