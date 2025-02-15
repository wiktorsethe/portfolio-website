mergeInto(LibraryManager.library, {
    OpenNewTab: function(urlPtr) {
        var url = UTF8ToString(urlPtr).trim(); // Pobiera string i usuwa białe znaki

        // Sprawdza, czy URL zaczyna się od "http://" lub "https://"
        if (!/^https?:\/\//i.test(url)) {
            url = "https://" + url; // Jeśli nie, dodaje "https://"
        }

        var win = window.open(url, '_blank');
        if (win) {
            win.focus();
        } else {
            console.log("Blokada popupów w przeglądarce. Użytkownik musi zezwolić na otwieranie nowych okien.");
        }
    }
});
