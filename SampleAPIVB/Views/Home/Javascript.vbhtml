
@*Scope section*@
<section>
    <h1>Scope</h1>

    <pre>
        <code class="js">
            var variable = 'Test'; // globale

            function localScopeExample() {
                console.log(variable);
            }
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   Test
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
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            ReferenceError: variable is not defined
        </code>
    </pre>

    <pre>
        <code class="js">
            function func1() {
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

    <span type="text">* I browser più recenti supportano le ultime sintassi javascript e creando una variabile con <b>let</b> anche i blocchi fanno scope</span>
    </pre>

    <h3>Namespaces in JS</h3>
    <h4>Problema</h4>
    <pre>
        <code class="js">
            function fun1() {
                console.log("I am first fun1");

            }
            function fun1() {
                console.log("I am second fun1");
            }
            fun1();
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   I am second func1
        </code>
    </pre>

    <h4>Utilizzare namespace per risolvere il problema</h4>
    <h4><b>1.Utilizzare Object Literal Notation</b></h4>
    <pre>
        <code class="js">
            var myfunctionCollection1 = {
                fun1: function () {
                    console.log("I am first fun1");             
                }        
            }
            var myfunctionCollection2 = {
                fun1: function () {
                    console.log("I am second fun1");

                }
            }
            myfunctionCollection1.fun1();
            myfunctionCollection2.fun1();
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   I am first fun1
            2   I am second fun1
        </code>
    </pre>

    <h4><b>2.Utilizzare IIFE (Immediately invoked function expression)</b></h4>
    <pre>
        <code class="js">
            //or self-invoked  ( /*function*/ )();

            (function() {
                function fun1(){
                    console.log("I am first fun1");
                } fun1();
            }());

            (function() {
                function fun1(){
                    console.log("I am second fun1");
                } fun1();
            }());
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   I am first fun1
            2
            3   I am second fun1
        </code>
    </pre>

</section>

@*Scope scripts*@
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

<br />
@*Truly/Falsy section*@
<section>
    <h1>Truly / Falsy value</h1>

    <h4>True values</h4>
    <ul>
        <li>false</li>
        <li>(zero)</li>
        <li>Infinity</li>
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

    <h3>Attenzione! Casi particolari:</h3>
    <pre>
        <code class="js">
            console.log( typeof(NaN) );
            console.log( NaN == NaN );
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   number
            2   false
        </code>
    </pre>
    <pre>
        <code class="js">
            console.log( Infinity ? true : false );
            console.log( Infinity == true );
            console.log( Infinity == false );
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   true
            2   false
            3   false
        </code>
    </pre>
    <pre>
        <code class="js">
            console.log( [] ? true : false );
            console.log( [] == true );
            console.log( [] == false );
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   true
            2   false
            3   true
        </code>
    </pre>

    <h4>Equals Operator ( == ) vs Strict Equals Operator ( === )</h4>
    <pre>
        <code class="js">
            if(1 == "1") { // usando == ritorna true usando === ritorna false
                alert('true')
            } else alert('false')
        </code>
        <label>esempio:</label>
        <code class="js">
            console.log( [] === true );
            console.log( [] === false );
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   false
            2   false
        </code>
    </pre>

    <a rel="noopener noreferrer" target="_blank" href="http://devhumor.com/content/uploads/images/June2018/thanks_javascript.png">More fun facts about javascript.</a>

</section>

<br />
@*This section*@
<section>
    <h1>This</h1>

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
        <button onclick="testThis2()">Prova</button>
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
        <button onclick="testThis3()">Prova</button>
    </pre>

    <h3>Uso di That</h3>
    <pre>
        <span>Il grosso problema con "this" è che ogni funzione usa lo stesso nome di variabile per il parametro "this".</span>
        <span>Quindi, quando hai funzioni annidate, non c'è modo di accedere all'argomento "this" esterno.</span>
        <code class="js">
            var object = {
              list: [1, 2, 3],
              increment: 1,
              doSomething: function doSomething(xs) {
                return this.list.map(function(x) {
                  return x + this.increment;
                })
              }
            }
             
            object.doSomething();
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   [NaN, NaN, NaN]
        </code>
        <span>Questo non funziona perché la funzione passata a "map" introduce la sua variabile "this",</span>
        <span>  quindi invece di vedere "object" che stiamo passando a "doSomething", vede "undefined".</span>
        <br />
        <span>In precedenza, le persone lo aggiustavano semplicemente assegnando quel valore ad una variabile</span>
        <span>  con un nome diverso, che non viene riutilizzato in un ambito interno, quindi:</span>
        <code class="js">
            var object = {
              list: [1, 2, 3],
              increment: 1,
              doSomething: function doSomething(xs) {
                var that = this;
                return this.list.map(function(x) {
                  return x + that.increment;
                })
              }
            }
             
            object.doSomething();
        </code>
        <label>output:</label>
        <code style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            // => [2, 3, 4]
        </code>
        <span>Con le versioni più recenti, un modo migliore (e più conciso) di scrivere sarebbe:</span>
        <code class="js">
            const object = {
              list: [1, 2, 3],
              increment: 1,
              doSomething(xs) {
                return this.list.map(x => x + this.increment)
              }
            }
             
            object.doSomething();
        </code>
        <label>output:</label>
        <code style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            // => [2, 3, 4]
        </code>
    </pre>

    <h4>SetTimeout()</h4>
    <pre>
        <code class="js">
            // a ThingOne constructor
            function ThingOne() {
            	this.name = 'One'
            	this.sayName = function() { console.log('My name is', this.name) }
            	return this
            }
             
            // a ThingTwo constructor
            function ThingTwo() {
            	this.name = 'Two'
            	var that = this
            	this.sayName = function() { console.log('My name is', that.name) }
            	return this
            }
             
            var thing1 = new ThingOne()
            var thing2 = new ThingTwo()
             
            thing1.sayName() // output line 1
            thing2.sayName() // output line 2

            setTimeout(thing1.sayName, 1000) // output line 3
            setTimeout(thing2.sayName, 1000) // output line 4
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   My name is One
            2   My name is Two
            3
            4   My name is undefined
            5   My name is Two
        </code>
    </pre>

    <h3>I metodi bind(), call() & apply() in JavaScript</h3>
    <h4><b>BIND()</b></h4>
    <pre>
        <span>Ricordiamo che..</span>
        <code class="js">
            var car = { 
                registrationNumber: "GA12345",
                brand: "Toyota",
            
                displayDetails: function(){
                    console.log(this.registrationNumber + " " + this.brand);
                }
            }

            car.displayDetails(); //output line 1

            //invece con il seguente condice...
            var myCarDetails =  car.displayDetails;
            myCarDetails(); //output line 2
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   GA12345 Toyota
            2   undefined undefined
        </code>
        <span>Per tali casi, è possibile utilizzare il metodo 'bind()' di ECMAScript 5 della proprietà Function.prototype.</span>
        <span>Ciò significa che bind () può essere utilizzato da ogni singola funzione.</span>
        <code class="js">
            var myCarDetails = car.displayDetails.bind(car);
            myCarDetails(); // Ok!
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   GA12345 Toyota
        </code>
        <span>Il metodo bind() crea una nuova funzione in cui "this" si riferisce al parametro tra parentesi nel caso precedente "car".</span>
        <span>In questo modo il metodo bind() consente di chiamare una funzione con un valore "this" specificato.</span>
        <br />
        <span>E se volessimo passare un parametro alla funzione displayDetails? Possiamo usare di nuovo il metodo bind.</span>
        <span>Il seguente argomento del metodo bind () fornirà un argomento alla funzione bind().</span>
        <br />
        <span>Riscriviamo l'oggetto Car:</span>
        <code class="js">
            var car = { 
                registrationNumber: "GA12345",
                brand: "Toyota",
            
                displayDetails: function(ownerName){
                    console.log(ownerName + ", this is your car: " + this.registrationNumber + " " + this.brand);
                }
            }
        </code>
        <span>Esempio di passaggio di argomenti con bind():</span>
        <code class="js">
            var myCarDetails = car.displayDetails.bind(car, "Vivian");
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   Vivian, this is your car: GA12345 Toyota
        </code>
    </pre>
    <h4><b>CALL() & APPLY()</b></h4>
    <pre>
        <span>Questa volta c'è un oggetto Car senza la funzione displayDetails, che si trova nel contesto globale.</span>
        <code class="js">
            var car = { 
                registrationNumber: "GA12345",
                brand: "Toyota"
            }
            
            function displayDetails(ownerName) {
                console.log(ownerName + ", this is your car: " + this.registrationNumber + " " + this.brand);
            }
        </code>
        <span>...</span>
        <code class="js">
            displayDetails.apply(car, ["Vivian"]);
            displayDetails.call(car, "Vivian");
        </code>
        <label>output:</label>
        <code class="js" style="background-color:#454545; color:#EEEEEE; margin-top:0;">
            1   Vivian, this is your car: GA12345 Toyota
            2   Vivian, this is your car: GA12345 Toyota
        </code>
        <span>Si nota che quando si utilizza la funzione apply() il parametro deve essere inserito in parentesi quadre.</span>
        <span>Call() accetta sia un array di parametri che un parametro stesso. Entrambi sono ottimi strumenti per prendere in prestito funzioni in JavaScript.</span>
        <br />
        <span>.bind ti permette di impostare il valore di 'this' ora, mentre ti permette di eseguire la funzione nel futuro;</span>
        <span>  perché restituisce un nuovo oggetto funzione.</span>
        <br />
        <a rel="noopener noreferrer" target="_blank" href="https://i.stack.imgur.com/WHlX0.jpg">Tabella tempi di esecuzione.</a>
    </pre>
</section>

@*This scripts*@
<script>
    var name = "Name";

    function testThis() {
        alert(this.name); // se non bindato this va sul global scope, cioè window
    }

    function testThis2() {
        var persona = {
            nome: "Alberto",
            cognome: "Bottarini",

            stampaNomeCognome: function () {
                alert(this.nome + "n" + this.cognome)
            }
        }
        persona.stampaNomeCognome();
    }

    function testThis3() {
        var persona = function (nome, cognome) {
            this.nome = nome;
            this.cognome = cognome;
            this.stampaNomeCognome = function () {
                alert(this.nome + "n" + this.cognome)
            }
        }
        var a = new persona("Alberto", "Bottarini");
        a.stampaNomeCognome();
    }
</script>

<br />
@*AJAX section*@
<section>
    <h1>Ajax</h1>
    <h4>GET</h4>
    <pre>
        <span>GET all Items: /api/Item</span>
        <code class="js">
            function getAllItem() {
                $.ajax({ url: '/api/Item', method: 'GET', dataType: 'JSON' })
                    .then(function (data) {
                        let content = 'I GOT:';
                        if (data != '') {
                            data.forEach(e => {
                                content += `\n--- -- ---\nItemId: ${e.ItemID}\nItemName: ${e.NamaItem}`;
                            });
                            alert(content);
                        }
                    });
            }
        </code>
        <button type="button" onclick="getAllItem()">Prova</button>
    </pre>

    <pre>
        <span>GET Item by id: /api/Item/id  id= <input type="number" id="itemid" style="width:50px;" /></span>
        <code class="js">
            function getItemByID() {
                var itemid = document.getElementById('itemid').value;

                $.ajax({
                    url: `/api/Item/${itemid}`, method: 'GET', dataType: 'JSON',
                    error: function (xhr, textStatus, errorThrown) {
                        alert(`Error: ${errorThrown}\nSomething went wrong!`);
                    }
                })
                    .then(function (data) {
                        let content = 'I GOT:';
                        if (data != '') {
                            content += `\n--- -- ---\nItemId: ${data.ItemID}\nItemName: ${data.NamaItem}`;
                            alert(content);
                        }
                    });
            }
        </code>
        <button type="button" onclick="getItemByID()">Prova</button>
    </pre>
    <h4>POST</h4>
    <pre>
        <span>Create new Item: /api/Item</span>
        <span>New Item Id= <input type="number" id="newItemId" style="width:50px;" />     New Item Name= <input type="text" id="newItemName" /></span>
        <code class="js">
            function createNewItem() {
                var newItemId = document.getElementById('newItemId').value;
                var newItemName = document.getElementById('newItemName').value;
                var newItem = { NamaItem: newItemName, ItemID: newItemId };

                $.ajax({
                    url: `/api/Item/`,
                    method: 'POST',
                    data: newItem,
                    error: function (xhr, textStatus, errorThrown) {
                        alert(`Error: ${errorThrown}\nSomething went wrong!`);
                    }
                })
                    .then(function (data) {
                        let content = 'I POSTed:';
                        if (data != '') {
                            content += `\n--- -- ---\nItemId: ${data.ItemID}\nItemName: ${data.NamaItem}`;
                            alert(content);
                        }
                    });
            }
        </code>
        <button type="button" onclick="createNewItem()">Prova</button>
    </pre>
    <h4>PUT</h4>
    <pre>
        <span>Edit Item: /api/Item/id</span>
        <span>Item Id= <input onchange="getMyItemName('editItemId', 'editItemName')" type="number" id="editItemId" style="width:50px;" />     Item Name= <input type="text" id="editItemName" /></span>
        <code class="js">
            function getMyItemName(deleteItemid, setValueForId) { // onchange (Item id input)
                var itemId = document.getElementById(deleteItemid).value;

                $.ajax({
                    url: `/api/Item/${itemId}`, method: 'GET',
                    error: function (xhr, textStatus, errorThrown) {
                        alert(`Error: ${errorThrown}\nSomething went wrong!`);
                    }
                })
                    .then(function (data) {
                        if (data != '') {
                            document.getElementById(setValueForId).value = data.NamaItem;
                        }
                    });
            }

            function editItem() {
                var itemId = document.getElementById('editItemId').value;
                var itemName = document.getElementById('editItemName').value;
                var updateItem = { NamaItem: itemName, ItemID: itemId };

                $.ajax({
                    url: `/api/Item/${itemId}`,
                    method: 'PUT',
                    data: updateItem,
                    error: function (xhr, textStatus, errorThrown) {
                        alert(`Error: ${errorThrown}\nSomething went wrong!`);
                    }
                })
                    .then(function (data) {
                        let content = 'I PUT (updated):';
                        if (data != '') {
                            content += `\n--- -- ---\nItemId: ${data.ItemID}\nItemName: ${data.NamaItem}`;
                            alert(content);
                        }
                    });
            }
        </code>
        <button type="button" onclick="editItem()">Prova</button>
    </pre>
    <h4>DELETE</h4>
    <pre>
        <span>DELETE Item by id: /api/Item/id   id= <input onchange="getMyItemName('deleteItemid' ,'deleteItemName')" type="number" id="deleteItemid" style="width:50px;" /></span>
        <span>Delete the Item with name: <input disabled id="deleteItemName" style="width:129px;"/></span>
        <code class="js">
            function getMyItemName(getItemIdFrom, setValueForId) { // onchange (Item id input)
                var itemId = document.getElementById(getItemIdFrom).value;

                $.ajax({
                    url: `/api/Item/${itemId}`, method: 'GET',
                    error: function (xhr, textStatus, errorThrown) {
                        alert(`Error: ${errorThrown}\nSomething went wrong!`);
                    }
                })
                    .then(function (data) {
                        if (data != '') {
                            document.getElementById(setValueForId).value = data.NamaItem;
                        }
                    });
            }

            function deleteItemByID() {
                var itemId = document.getElementById('deleteItemid').value;

                $.ajax({
                    url: `/api/Item/${itemId}`, method: 'DELETE',
                    error: function (xhr, textStatus, errorThrown) {
                        alert(`Error: ${errorThrown}\nSomething went wrong!`);
                    }
                })
                    .then(function (data) {
                        let content = 'I DELETEd:';
                        if (data != '') {
                            content += `\n--- -- ---\nItemId: ${data.ItemID}\nItemName: ${data.NamaItem}`;
                            alert(content);
                        }
                    });
            }
        </code>
        <button type="button" onclick="deleteItemByID()">Prova</button>
    </pre>

</section>

@*AJAX scripts*@
<script>

    function getAllItem() {
        $.ajax({ url: '/api/Item', method: 'GET' })
            .then(function (data) {
                let content = 'I GOT:';
                if (data != '') {
                    data.forEach(e => {
                        content += `\n--- -- ---\nItemId: ${e.ItemID}\nItemName: ${e.NamaItem}`;
                    });
                    alert(content);
                }
            });
    }

    function getItemByID() {
        var itemId = document.getElementById('itemid').value;

        $.ajax({
            url: `/api/Item/${itemId}`, method: 'GET',
            error: function (xhr, textStatus, errorThrown) {
                alert(`Error: ${errorThrown}\nSomething went wrong!`);
            }
        })
            .then(function (data) {
                let content = 'I GOT:';
                if (data != '') {
                    content += `\n--- -- ---\nItemId: ${data.ItemID}\nItemName: ${data.NamaItem}`;
                    alert(content);
                }
            });
    }

    function createNewItem() {
        var newItemId = document.getElementById('newItemId').value;
        var newItemName = document.getElementById('newItemName').value;
        var newItem = { NamaItem: newItemName, ItemID: newItemId };
 
        $.ajax({
            url: `/api/Item/`,
            method: 'POST',
            data: newItem,
            error: function (xhr, textStatus, errorThrown) {
                alert(`Error: ${errorThrown}\nSomething went wrong!`);
            }
        })
            .then(function (data) {
                let content = 'I POSTed:';
                if (data != '') {
                    content += `\n--- -- ---\nItemId: ${data.ItemID}\nItemName: ${data.NamaItem}`;
                    alert(content);
                }
            });
    }
    
    function getMyItemName(getItemIdFrom, setValueForId) {
        var itemId = document.getElementById(getItemIdFrom).value;

        $.ajax({
            url: `/api/Item/${itemId}`, method: 'GET',
            error: function (xhr, textStatus, errorThrown) {
                alert(`Error: ${errorThrown}\nSomething went wrong!`);
            }
        })
            .then(function (data) {
                if (data != '') {
                    document.getElementById(setValueForId).value = data.NamaItem;
                }
            });
    }

    function editItem() {
        var itemId = document.getElementById('editItemId').value;
        var itemName = document.getElementById('editItemName').value;
        var updateItem = { NamaItem: itemName, ItemID: itemId };

        $.ajax({
            url: `/api/Item/${itemId}`,
            method: 'PUT',
            data: updateItem,
            error: function (xhr, textStatus, errorThrown) {
                alert(`Error: ${errorThrown}\nSomething went wrong!`);
            }
        })
            .then(function (data) {
                let content = 'I PUT (updated):';
                if (data != '') {
                    content += `\n--- -- ---\nItemId: ${data.ItemID}\nItemName: ${data.NamaItem}`;
                    alert(content);
                }
            });
    }

    function deleteItemByID() {
        var itemId = document.getElementById('deleteItemid').value;

        $.ajax({
            url: `/api/Item/${itemId}`, method: 'DELETE',
            error: function (xhr, textStatus, errorThrown) {
                alert(`Error: ${errorThrown}\nSomething went wrong!`);
            }
        })
            .then(function (data) {
                let content = 'Item DELETEd!';
                if (data) {
                    alert(content);
                }
            });
    }

</script>


<style type="text/css">
    code:active
    {
        font-size: 135%;
        height: 135%;
    }
    code:hover
    {
        cursor:zoom-in;
    }
</style>