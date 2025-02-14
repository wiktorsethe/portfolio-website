mergeInto(LibraryManager.library, {
    OpenNewTab: function(url) {
        var win = window.open(Pointer_stringify(url), '_blank');
        if (win) {
            win.focus();
        } else {
            console.log("Blokada popupów w przeglądarce");
        }
    }
});
