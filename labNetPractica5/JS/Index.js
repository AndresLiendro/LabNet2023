const MainPage = document.getElementById('Pagina');

const numberIngresado = document.getElementById('txtNumero');
const guess = document.getElementById('txtAdivinar');
const reboot = document.getElementById('txtReiniciar');

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

mdlModal1.style.display = "none";
mdlModal2.style.display = "none";

function GuessNumber() {
    if (numberIngresado.value.trim() === "") {
        MsgCampoVacio();
    }
    else {
        const entry = parseInt(numberIngresado.value, 10);
        MayorMenor(entry);
    }
    
    WinOrLose();
    Focus();
}

function MayorMenor(entry) {
    if (entry > nroGenerado) {
        Menor();
    }
    
    if (entry < nroGenerado) {
        Mayor();
    }
}

function Mayor() {

    lblMensaje.textContent = 'El numero es más alto';
    puntaje--;
    lblScore.textContent = puntaje;
}

function Menor() {

    lblMensaje.textContent = 'El numero es más bajo';
    puntaje--;
    lblScore.textContent = puntaje;
}

function WinOrLose() {

    if (numberIngresado.value == nroGenerado) {

        YouWin();

        if (puntaje > puntajeMax) {

            puntajeMax = puntaje;
            MaxScore();
        }
    }

    if (puntaje === 0) {

        YouLost();
    }
}

function YouWin() {
    MainPage.style.background = "green",
    lblMensaje.textContent = "Adivinaste el número."
    lblScore.textContent = puntaje;
    mdlModal1.show();
    DisableButtons();
    mdlModal1.style.display = "flex";
    btnCerrar.addEventListener('click', () => {
        mdlModal1.close();
    });
}

function YouLost() {
    MainPage.style.background = "red";
    lblMensaje.textContent = "Perdiste"
    lblScore.textContent = 0;
    puntaje = 20;
    mdlModal2.show();
    DisableButtons();
    mdlModal2.style.display = "flex";
    btnCerrar2.addEventListener('click', () => {
        mdlModal2.close();
    });
    
}

function InicialSocre() {
    lblScore.innerHTML = puntaje;
}

function InicialMaxScore() {
    lblPuntacionAlta.innerHTML = puntajeMax;
}

function MaxScore() {
    lblPuntacionAlta.textContent = puntajeMax;
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
    nroGenerado = Math.floor(Math.random() * 20) + 1;
    EnabledButtons(); 
}

guess.addEventListener('click', () => {
    GuessNumber();
});

reboot.addEventListener('click', () => {
    Reboot();
    mdlModal1.close();
    mdlModal2.close();
});