const MainPage = document.getElementById('Pagina');

const numberIngresado = document.getElementById('txtNumero');
const guess = document.getElementById('txtAdivinar');
const reboot = document.getElementById('txtReiniciar');

const lblPista = document.getElementById('pista');
const lblMensaje = document.getElementById('mensajeDinamico');
const lblScore = document.getElementById('puntaje');
const lblPuntacionAlta = document.getElementById('puntajeAlto');

const btnCerrar = document.getElementById('btnCerrar')
const btnCerrar2 = document.getElementById('btnCerrar2')

const mdlModal1 = document.getElementById('modal1');
const mdlModal2 = document.getElementById('modal2')

let nroGenerado = Math.floor(Math.random() * 20) + 1;
let puntaje = 20;
InicialSocre();
let puntajeMax = 0;
InicialMaxScore();
mdlModal.style.display = "none";
mdlModal2.style.display = "none";

function GuessNumber() {
    if (numberIngresado.Value.trim() === "") {
        MsgCampoVacio();
    }
    else {
        MayorMenor();
        WinOrLose();
    }
    
    Focus();
}

function Mayor() {

    lblMensaje.textContent = 'El numero es muy alto!';
    puntaje--;
    lblScore.textContent = puntaje;
}

function Menor() {

    lblMensaje.textContent = 'El numero es muy bajo!';
    puntaje--;
    lblScore.textContent = puntaje;
}

function MayorMenor() {
    if (numberIngresado.Value > nroGenerado) {
        Mayor();
    }
    else if (numberIngresado < nroGenerado) {
        Menor();
    }
}

function WinOrLose() {

    if (numberIngresado.value == nroGenerado) {

        YouWin();

        if (puntaje > puntajeMax) {

            puntajeMax = puntaje;
            MaxScore();
        }
    }

    if (puntaje == 0) {

        YouLost();
    }
}

function YouWin() {
    MainPage.style.background = "greem",
    lblMensaje.textContent = "Adivinaste el número."
    lblScore.textContent = puntaje;
    mdlModal1.showModal();
    DisableButtons();
    mdlModal1.style.display = "flex";
    btnCerrar();
}

function YouLost() {
    MainPage.style.background = "red";
    lblMensaje.textContent = "Perdiste"
    lblScore.textContent = 0;
    puntaje = 20;
    mdlModal2.showModal();
    DisableButtons();
    mdlModal2.style.display = "flex";
    btnCerrar2();
}

function InicialSocre() {
    lblScore.innerHTML = puntaje;
}

function InicialMaxScore() {
    lblPuntacionAlta.innerHTML = puntajeMax;
}

function MaxScore() {
    lblPuntacionAlt.textContent = puntajeMax;
}

function MsgCampoVacio() {
    lblMensaje.textContent = "No se permiten espacios vacios ni simbolos";
}

function Focus() {
    numberIngresado.focus();
}

function EnabledButtons() {

    guess.disabled = false;
}

function DisableButtons() {

    guess.disabled = true;
}

function Reboot() {
    MainPage.style.background = "grey";
    numberIngresado.Value = "";
    Focus();
    lblMensaje.textContent = "";
    puntaje = 20;
    lblScore.textContent = puntaje;
    nroGenerado = Math.floor(Math.random() * 3) + 1;
    EnabledButtons(); 
}

guess.addEventListener('click', () => {
    GuessNumber();
});

reboot.addEventListener('click', () => {
    Reboot();
});

btnCerrar.addEventListener('click', () => {
    mdlModal.close();
    mdlModal.style.display = "none";
    mdlModal2.style.display = "none";
});

btnCerrar2.addEventListener('click', () => {
    mdlModal.close();
    mdlModal.style.display = "none";
    mdlModal2.style.display = "none";
});
