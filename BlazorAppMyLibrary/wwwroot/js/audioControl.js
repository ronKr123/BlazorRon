window.audioControl = {
    play: function (element) {
        if (element && element.play instanceof Function) {
            element.play();
        } else {
            console.error("playAudio: The provided element does not have a play function.");
        }
    },
    pause: function (element) {
        if (element && element.pause instanceof Function) {
            element.pause();
        } else {
            console.error("pauseAudio: The provided element does not have a pause function.");
        }
    },
    resume: function (element) {
        if (element && element.play instanceof Function) {
            element.play();
        } else {
            console.error("resumeAudio: The provided element does not have a play function.");
        }
    },
    stop: function (element) {
        if (element && element.pause instanceof Function) {
            element.pause();
            element.currentTime = 0;
        } else {
            console.error("stopAudio: The provided element does not have pause or currentTime functions.");
        }
    },
    seek: function (element, time) {
        if (element && element.currentTime instanceof Function) {
            element.currentTime = time;
        } else {
            console.error("seekAudio: The provided element does not have a currentTime function.");
        }
    },
    getDuration: function (element) {
        if (element && typeof element.duration === 'number' && !isNaN(element.duration)) {
            return element.duration.toString();
        } else {
            console.error("getAudioDuration: The provided element does not have a valid duration property.");
            return "0";
        }
    }
};
