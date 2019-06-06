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

</style>


<div class="example static"><b>Static</b> valore di default, lascia l'elemento in modalità "non posizionato" seguendo il Flow del documento</div>

<div class="example relative1">
    Contenitore con position <b>Relative</b>, relative vuol dire elemento shiftato di N pixel rispetto la posizione dove normalmente l'element finirebbe. Un elemento relativa senza specificare top e left rimane posizionato nelle stessa posizione dove verrebbe messo in position: static
</div>

<div class="example relative2"><b>Relative</b> questo div è relative ed è shiftato di qualche pixel rispetto la posizione naturale che il Flow del document gli avrebbe dato</div>

<div class="example fixed">Questo div è <b>Fixed</b> in un angolo e rimane in quella posizione anche se si scrolla</div>