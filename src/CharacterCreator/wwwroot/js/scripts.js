$(document).ready(function () {
    $("#hairId").change(function () {
        $('#dave').html("<img src='/hairs/" + this.value+ ".jpg'/>")
    });
    $("#skinId").change(function () {
        $('#dave').html("<img src='/skins/" + this.value + ".jpg'/>")
    });
    $("#personalitiesId").change(function () {
        $('#dave').html("<img src='/personalities/" + this.value + ".jpg'/>")
    });
    $("#outfitsId").change(function () {
        $('#dave').html("<img src='/outfits/" + this.value + ".jpg'/>")
    });
});