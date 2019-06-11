

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

            function testIfScope() {
            if (true) {
                var a = 4;
            }

            alert(a); // 4 non 1. In javascript solo le Function creano scope
            }
        </code>
<button type="button" onclick="testLocalOverride()">Prova</button>
<h5>Gli ultimi browser supportano le ultime sintassi javascript e creando una variabile con <b>let</b> anche i blocchi fanno scope</h5>
</pre>
    <script>
        function testLocalOverride() {
            var a = 1;

            alert('variabile a globale parte da ' + a)

            function testIfScope() {
                if (true) {
                    var a = 4;
                    alert('sono la variabile a nel ramo true e sono stata reinizializzata con valore ' + a)
                }

                alert('sono la variabile a fuori dal if e ho come valore ' + a) // 4 non 1. In javascript solo le Function creano scope
            }

            testIfScope();
        }
    </script>

</section>
<section>
    <h1>Truly / Falsy value</h1>
    <h4>True values</h4>
    <ul>
        <li>false</li>
        <li>(zero)</li>
        <li>'' or "" (empty string)</li>
        <li>null</li>
        <li>undefined</li>
        <li>NaN</li>
    </ul>
    <h4>False values</h4>
    <ul>
        <li>0</li>
        <li>false</li>
        <li>[]</li>
        <li>{}</li>
        <li>function() {}</li>
    </ul>
    <h4>Casi particolari in caso di confronti</h4>
    <h5>
        Il valore NaN è considerato True, ma è diverso da qualsiasi altro valore, perfino se confrontato da un altro NaN<br />
        Il valore di Infinity o una operazione che ritorna Infinity è considerata vera, ma se confrontata con true o con false ritorna sempre false<br />
        Un if su un array vuoto ritorna true – ma se confrontato con un true ritorna false e se confrontato con false ritorna true<br />
    </h5>
    <h4>== vs ===</h4>
    <pre>
    <code class="js">
            if(1 == "1") { // usando == ritorna true usando === ritorna false
                alert('true')
            } else alert('false')
        </code>
    </pre>

</section>
<section>
    <h1>This</h1>
    <script>
        var name = "Name";

        function testThis() {
            alert(this.name); // se non bindato this va sul global scope, cioè window
        }
    </script>
    <pre>
    <code class="js">
        var name = "Name";

        function testThis() {
            alert( this.name ); // se non bindato this va sul global scope, cioè window
        }
    </code>
    <button onclick="testThis()">Prova</button>
    </pre>
    <pre>
    <code class="js">
        var persona = {
            nome: "Alberto",
            cognome: "Bottarini",

            stampaNomeCognome: function() {
            alert(this.nome + "n" + this.cognome)
            }
        }
        persona.stampaNomeCognome();
    </code>
</pre>
    <pre>
    <code class="js">
        var persona = function(nome, cognome) {
            this.nome = nome;
            this.cognome = cognome;
            this.stampaNomeCognome = function() {
                alert(this.nome + "n" + this.cognome)
            }
        }
        var a = new persona("Alberto", "Bottarini");
        a.stampaNomeCognome();
     </code>
</pre>
</section>
<section>
    <h1>Ajax</h1>
</section>