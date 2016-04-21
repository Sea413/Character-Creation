$(document).ready(function () {
    $("#hairId").change(function () {
        $('#hair').html("<img src='/images/hair/" + this.value+ ".png'/>")
    });
    $("#skinId").change(function () {
        $('#skin').html("<img src='/images/skin/" + this.value + ".png'/>")
    });
    $("#personalitiesId").change(function () {
        $('#dave').html("<img src='/personalities/" + this.value + ".png'/>")
    });
    $("#outfitId").change(function () {
        $('#outfits').html("<img src='/images/outfits/" + this.value + ".png'/>")
    });
});
