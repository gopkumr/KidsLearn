var isSpeechSupported = false;

if ('speechSynthesis' in window) {
    isSpeechSupported = true;
} else {
    isSpeechSupported = false;
}

function getVoices(locale) {

    if (isSpeechSupported) {
        let voices = speechSynthesis.getVoices();
        const result = voices.filter(voice => voice.lang.toLowerCase() == locale.toLowerCase());
        return result;
    }

    return null;
}

window.speakText = function (textToSpeak, rate) {

    let speakData = new SpeechSynthesisUtterance();
    speakData.volume = 1; // From 0 to 1
    speakData.rate = rate; // From 0.1 to 10
    speakData.pitch = 2; // From 0 to 2
    speakData.text = textToSpeak;
    speakData.lang = 'en';
    speakData.voice = getVoices("en-AU")[0];

    if (speechSynthesis.paused) {
        speechSynthesis.resume();
    }
    else {
        speechSynthesis.speak(speakData);
    }
}

window.stopSpeaking = function () {
    if (speechSynthesis.speaking)
        speechSynthesis.cancel();
}

window.pauseSpeaking = function () {
    if (speechSynthesis.speaking)
        speechSynthesis.pause();
}