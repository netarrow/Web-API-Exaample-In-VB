﻿@Section Scripts
    <script src="nonesiste.js" type="text/javascript"></script>
End Section

<style>
    span.a {
        display: inline; /* the default for span */
        width: 100px;
        height: 100px;
        padding: 5px;
        border: 1px solid blue;
        background-color: yellow;
    }

    span.b {
        display: inline-block;
        width: 100px;
        height: 100px;
        padding: 5px;
        border: 1px solid blue;
        background-color: yellow;
    }

    span.c {
        display: block;
        width: 100px;
        height: 100px;
        padding: 5px;
        border: 1px solid blue;
        background-color: yellow;
    }
</style>

<h1>The display Property</h1>

<h2>display: inline</h2>
<div>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum consequat scelerisque elit sit amet consequat. Aliquam erat volutpat. <span class="a">Aliquam</span> <span class="a">venenatis</span> gravida nisl sit amet facilisis. Nullam cursus fermentum velit sed laoreet. </div>

<h2>display: inline-block</h2>
<div>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum consequat scelerisque elit sit amet consequat. Aliquam erat volutpat. <span class="b">Aliquam</span> <span class="b">venenatis</span> gravida nisl sit amet facilisis. Nullam cursus fermentum velit sed laoreet. </div>

<h2>display: block</h2>
<div>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum consequat scelerisque elit sit amet consequat. Aliquam erat volutpat. <span class="c">Aliquam</span> <span class="c">venenatis</span> gravida nisl sit amet facilisis. Nullam cursus fermentum velit sed laoreet. </div>
