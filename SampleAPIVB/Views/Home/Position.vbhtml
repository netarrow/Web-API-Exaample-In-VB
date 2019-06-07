<style>

    .example {
        border: 2px dashed black;
        margin: 10px
    }

    .static {
        position: static;
    }

    .relative1 {
        position: relative;
    }

    .relative2 {
        position: relative;
        top: 10px;
        left: 20px;
        background-color: white;
        width: 500px;
    }

    .fixed {
        position: fixed;
        bottom: 0;
        right: 0;
        width: 200px;
        background-color: white;
    }

    .relative {
        position: relative;
        width: 600px;
        height: 400px;
    }

    .absolute {
        position: absolute;
        top: 130px;
        right: 0;
        width: 300px;
        height: 200px;
    }

</style>

<div class="example static"><b>Static</b> valore di default, lascia l'elemento in modalità "non posizionato" seguendo il Flow del documento</div>

<div class="example relative1">
    Contenitore con position <b>Relative</b>, relative vuol dire elemento shiftato di N pixel rispetto la posizione dove normalmente l'element finirebbe. Un elemento relativa senza specificare top e left rimane posizionato nelle stessa posizione dove verrebbe messo in position: static
</div>

<div class="example relative2"><b>Relative</b> questo div è relative ed è shiftato di qualche pixel rispetto la posizione naturale che il Flow del document gli avrebbe dato</div>

<div class="example fixed">Questo div è <b>Fixed</b> in un angolo e rimane in quella posizione anche se si scrolla</div>

<div class="example relative">Questo elemento è posizionato con <b>relative</b>. Se questo elemento avesse position: static; il suo figlio posizionato in maniera assoluta sarebbe scappato via e sarebbe stato posizionato relativamente al body del documento.<div class="example absolute">Questo elemento è posizionato in maniera assoluta. È posizionato relativamente all'elemento che lo contiene.</div></div>

<div class="example">Questo elemento è posizionato con <b>static</b>.<div class="example absolute">Questo elemento è posizionato in maniera assoluta ma il padre non è relative quindi "scappa" e si aggancia relativamente al body</div></div>

