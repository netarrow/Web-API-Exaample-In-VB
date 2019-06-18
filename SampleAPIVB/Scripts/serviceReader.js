(function (context) {
    var myVar;
        
    context.milazzoNS = context.milazzoNS || {};
    context.milazzoNS.name = 'Test';
    
    $(function() {

        $('#toggleColorBtn').on('click', function () {
            $("#itemList").toggleClass('alteredTable');
        });

    });
    
})(window);