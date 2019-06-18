(function (context) {

    context.milazzoNS = context.milazzoNS || {}

    context.milazzoNS.poplateTable = function () {
        $(function () {
            $.ajax({
                url: '/api/values',
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
                        url: '/api/values/1/true',
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
        });
    }
})(window);