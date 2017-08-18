//datetime editor template set date&time input values to datetime now
$(document).ready(function () {
    $(".btnTimeNow").click(function () {
        //new Date().toISOString() returns 2011-10-05T14:48:00.000Z
        //input type date accepts "yyyy-MM-dd" format
        $(this).parent().find('input.date').val((new Date()).toISOString().substring(0, 10));
        //input type time accepts "hh:mm:ss" format
        $(this).parent().find('input.time').val((new Date()).toTimeString().split(' ')[0]);
    });
});