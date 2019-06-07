

<section>
    <h1>Scope</h1>
    <pre>
    <code class="js">
        var variable = 'Test'; // globale

        function localScopeExample(){
                console.log(variable);
        }
        </code>
    </pre>

    <pre>
    <code class="js">
       function localScopeExample() { // una function crea Scope
            // LOCAL SCOPE
            var variable = 'Test';
            console.log(variable);
       }

       console.log(variable); // Uncaught ReferenceError
        </code>
    </pre>

    <pre>
    <code class="js">
            function func1(){
                var cat = 'Jerry';
                console.log(cat); // Jerry
            }

            function func2(){
                var cat = 'Tom';
                console.log(cat); // Tom
            }
            </code>
</pre>

    <pre>
    <code class="js">
        var a = 1;

        function four() {
        if (true) {
            var a = 4;
        }

            alert(a); // 4 non 1. In javascript solo le Function creano scope
        }
 </code>
</pre>

</section>
<section>
    <h1>Truly / Falsy value</h1>
</section>
<section>
    <h1>This</h1>
</section>
<section>
    <h1>Ajax</h1>
</section>