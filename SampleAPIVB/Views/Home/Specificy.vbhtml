<style>
    #greenDiv {
        background-color: green;
    }

    .lastDiv .redDiv {
        background-color: yellow;
    }

    .redDiv {
        background-color: red;
    }

    .right pre {
        margin: 10px;
    }

    .right div {
        background-color: #70aff2;
    }
</style>

<div class="container">
    <div class="row">
        <div class="col-md-6">
            <img src="~/Content/specificity-table1.jpg" />
        </div>
        <div class="col-md-6 right">
            <div class="row">
                <div class="col-md-12">
                    <pre> 
                        <code class="css">
                            #greenDiv {
                                    background-color: green;
                            }

                            .lastDiv .redDiv {
                                  background-color: yellow;
                            }

                            .redDiv {
                                   background-color: red;
                            }

                            .right div {
                                 background-color: #70aff2;
                            }
                        </code>
</pre>
                    <pre>&lt;div id=&quot;greenDiv&quot; style=&quot;color: red&quot;&gt;</pre>
                    <div id="greenDiv" style="background-color: red">.</div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-12">
                    <pre>&lt;div id=&quot;greenDiv&quot; class=&quot;redDiv&quot;&gt;</pre>
                    <div id="greenDiv" class="redDiv">.</div>
                </div>
            </div>

            <div class="row">
                <div class="col-md-12 lastDiv">
                    <pre>&lt;div class=&quot;col-md-12 lastDiv&quot;&gt;
                    &lt;div class=&quot;redDiv&quot;&gt;.&lt;/div&gt;
                &lt;/div&gt;</pre>
                    <div class="redDiv">.</div>
                </div>
            </div>
        </div>
    </div>
</div>