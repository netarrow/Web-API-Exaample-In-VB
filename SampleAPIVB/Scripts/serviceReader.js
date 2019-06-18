(function (context) {
    var myVar;
        
    context.milazzoNS = context.milazzoNS || {};
    context.milazzoNS.name = 'Test';
    
    $(function() {

        $.ajax({
            url: '/api/values',
            method: 'GET'
        }).then(function (data) {

            $.each(data, function (key, value) {
                $('#itemList').append('<tr><td>' + value.ItemID + '</td><td>' + value.NamaItem + '</td></tr>');
            });

        });
    });
    
})(window);