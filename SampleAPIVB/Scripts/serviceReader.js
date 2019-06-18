(function (context) {
    var myVar;
        
    context.milazzoNS = context.milazzoNS || {};
    context.milazzoNS.name = 'Test';
    
    $(function() {

        $('#toggleColorBtn').on('click', function () {
            $('#IsAltered').val("true");
            $('form').submit();
        });

    });
    
})(window);