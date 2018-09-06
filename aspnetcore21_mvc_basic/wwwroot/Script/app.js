(function () {    

    $().ready(function () {
        
        setInterval(function () {
            clk();
        }, 1000);

        function clk() {
            $("#time").html(new Date().toLocaleTimeString("da-DK"));
        }
    });
})()