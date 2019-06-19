@ModelType Models.MyModel

<script>
    milazzoNS.poplateTable('@Model.WebApiUrl');
</script>

<h3>Lista Item</h3>

<div class="container" id="itemPage">
    <div class="row">
        <div class="col-md-12">
            <table id="itemList" class="table"></table>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4 col-md-offset-2">
            <div class="form-group">
                <label for="itemIdToAlter">ItemID to change</label>
                <input type="number" id="itemIdToAlter" class="form-control" />
            </div>
            <button type="button" id="changeColorBtn" class="btn btn-default">Change Color</button>
        </div>
        <div class="col-md-4">
            <div class="form-group">
                <label for="itemIdInput">ItemID</label>
                <input type="number" class="form-control" id="itemIdInput">
            </div>
            <div class="form-group">
                <label for="itemNameInput">ItemName</label>
                <input type="text" class="form-control" id="itemNameInput">
            </div>
            <div class="checkbox">
                <label>
                    <input type="checkbox"> Is Row Altered
                </label>
            </div>

            <button type="button" id="addRow" class="btn btn-default">Add Row</button>
        </div>
    </div>
</div>

