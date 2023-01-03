var isSpeechSupported = false;

if ('speechSynthesis' in window) {
    isSpeechSupported = true;
    speechSynthesis.onvoiceschanged = () => populateVoiceList();
}


window.getAllVoices = function () {

    if (isSpeechSupported) {
        var voices = speechSynthesis.getVoices();
        voices = speechSynthesis.getVoices();

        return voices.map(x => { return { "Lang": x.lang, "Name": x.name }; });
    }

    return null;
}

function populateVoiceList() {
    speechSynthesis.getVoices(); // now should have an array of all voices
}

function getVoice(name) {

    if (isSpeechSupported) {
        var voices = speechSynthesis.getVoices();
        const result = voices.filter(voice => voice.name.toLowerCase() == name.toLowerCase());
        return result;
    }
    return null;
}

window.speakText = function (textToSpeak, rate, pitch, langName) {

    let speakData = new SpeechSynthesisUtterance();
    speakData.volume = 1; // From 0 to 1
    speakData.rate = rate; // From 0.1 to 10
    speakData.pitch = pitch; // From 0 to 2
    speakData.text = textToSpeak;
    speakData.lang = 'en';
    speakData.voice = getVoice(langName)[0];

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