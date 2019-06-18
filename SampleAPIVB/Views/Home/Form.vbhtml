@ModelType Models.MyModel

@If String.IsNullOrEmpty(Model.Name) Then
    Dim variabile As String
    @<span>Testo vuoto</span>
Else
    @<span>@Model.Name</span>
End If

<table id="itemList" class="table">
</table>

<button type="button" id="changeColorBtn">Change Color</button>


