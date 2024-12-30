var val = 0;
var val2 = 0;
document.getElementById("plu").onclick = function () {
    val++;
    document.getElementById("inp").value = val;
    document.getElementById("inp2").value = val;
}

document.getElementById("min").onclick = function () {
    val--;
    document.getElementById("inp").value = val;
    document.getElementById("inp2").value = val;
}

document.getElementById("plu2").onclick = function () {
    val++;
    document.getElementById("inp").value = val;
    document.getElementById("inp2").value = val;
}

document.getElementById("min2").onclick = function () {
    val--;
    document.getElementById("inp").value = val;
    document.getElementById("inp2").value = val;
}


document.getElementById("plu3").onclick = function () {
    val2++;
    document.getElementById("inp3").value = val2;
}

document.getElementById("min3").onclick = function () {
    val2--;
    document.getElementById("inp3").value = val2;
}


function translatePage(lang) {
    const googleTranslateElement = document.querySelector('#google_translate_element');

    // Eğer #google_translate_element içinde id="languages" olan bir öğe varsa, notranslate sınıfı ekle
    const languagesElement = googleTranslateElement ? googleTranslateElement.querySelector('#languages') : null;

    if (languagesElement) {
        languagesElement.classList.add('notranslate');
        console.log('Languages öğesine notranslate sınıfı eklendi.');
    }

    const googleTranslateSelect = googleTranslateElement ? googleTranslateElement.querySelector('select') : null;
    if (googleTranslateSelect) {
        googleTranslateSelect.value = lang; // Seçilen dili ayarla
        googleTranslateSelect.dispatchEvent(new Event('change')); // Değişikliği bildir
    } else {
        console.error("Google Translate widget bulunamadı.");
    }
}

