
//Data
const now = new Date();

const dataFormatada = now.getFullYear('Pt-Br', { dateStyle: 'short' });

let data = document.getElementById("dateFooter");
data.innerText = dataFormatada;


//
