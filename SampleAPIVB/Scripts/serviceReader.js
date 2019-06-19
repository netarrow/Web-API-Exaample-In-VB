(function (context) {

    context.milazzoNS = context.milazzoNS || {};

    context.milazzoNS.poplateTable = function (webApiUrl) {
        $(function () {
            $.ajax({
                url: webApiUrl + '/values',
                method: 'GET'
            }).then(function (data) {

                $.each(data,
                    function (key, value) {
                        $('#itemList').append('<tr><td>' + value.ItemID + '</td><td>' + value.NamaItem + '</td></tr>');
                    });
            });

            $('#changeColorBtn').on('click',
                function () {
                    $.ajax({
                        url: webApiUrl + '/values/1/true',
                        method: 'PUT'
                    }).then(function (data) {
                        $('#itemList').html('');
                        $.each(data,
                            function (key, value) {
                                $('#itemList').append('<tr data-isaltered="' +
                                    value.IsAltered +
                                    '"><td>' +
                                    value.ItemID +
                                    '</td><td>' +
                                    value.NamaItem +
                                    '</td></tr>');
                            });
                    });
                });

            $('#addRow').on('click',
                function () {

                    var itemId = $('#itemIdInput').val();
                    var itemName = $('#itemNameInput').val();

                    $.ajax({
                        url: webApiUrl + '/values',
                        method: 'POST',
                        data: { ItemID: itemId, NamaItem: itemName },
                    }).then(function (data) {
                        $('#itemList').append('<tr data-isaltered="' +
                            data.IsAltered +
                            '"><td>' +
                            data.ItemID +
                            '</td><td>' +
                            data.NamaItem +
                            '</td></tr>');
                    }).fail(function (errorInfo) {
                        console.log(errorInfo);
                    });
                });
        });
    }
})(window);