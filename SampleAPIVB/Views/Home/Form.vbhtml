@ModelType Models.MyModel

@If String.IsNullOrEmpty(Model.Name) Then
    Dim variabile As String
    @<span>Testo vuoto</span>
Else
    @<span>@Model.Name</span>
End If

<table id="itemList" class="table @Model.ClassToUseForTable">
    @For Each item In Model.MyList
        @<tr>
            <td>@item.ItemID</td>
            <td>@item.NamaItem</td>
        </tr>
    Next
</table>
<button type="button" id="toggleColorBtn">ToggleColor</button>

@Using Html.BeginForm("PostData", "Home")
    @<p>Your name: @Html.TextBoxFor(Function(m) m.Name)</p>
    @Html.HiddenFor(Function(m) m.IsAltered)
    @<button type="submit">Invia</button>
End Using


