const WGHT_RANGE = [100, 700];
const WDTH_RANGE = [100, 75];

const FALLOFF_RADIUS = 40;

let horizontalMousePercentage = 0;

function buildLetterSpans(el) {
    const text = el.dataset.text || el.textContent.trim();
    const uppercase = el.dataset.uppercase === 'true';
    el.innerHTML = '';

    const displayText = uppercase ? text.toUpperCase() : text;
    const letters = [...displayText];

    letters.forEach((letter) => {
        const span = document.createElement('span');
        span.textContent = letter === ' ' ? '\u00A0' : letter;
        span.dataset.letter = 'true';
        el.appendChild(span);
    });
}

function calculateFontSettings(i, c, mousePercent) {
    const paddingInPercentage = 0.5;

    const interval = Math.round((100 / c) * 100) / 100;
    const letterPercentage = (paddingInPercentage * 100) / 2 + i * interval * paddingInPercentage - interval * (paddingInPercentage / 2);

    const weight = (FALLOFF_RADIUS - Math.abs(letterPercentage - mousePercent)) / FALLOFF_RADIUS;

    const calculatedWght = WGHT_RANGE[0] + (WGHT_RANGE[1] - WGHT_RANGE[0]) * weight;
    const calculatedWdth = WDTH_RANGE[0] + (WDTH_RANGE[1] - WDTH_RANGE[0]) * (1 - weight);

    let result = `"wdth" ${Math.round(calculatedWdth)}`;// `, "wght" ${Math.round(calculatedWght)}`;
    return result;
}

function updateAll() {
    document.querySelectorAll('.variable-font').forEach((el) => {
        const spans = el.querySelectorAll('span[data-letter]');
        const c = spans.length;
        spans.forEach((span, i) => {
            span.style.fontVariationSettings = calculateFontSettings(i, c, horizontalMousePercentage);
        });
    });
}

window.addEventListener('pointermove', (e) => {
    horizontalMousePercentage = Math.round((e.clientX / document.body.clientWidth) * 100);
    updateAll();
});

document.querySelectorAll('.variable-font').forEach(buildLetterSpans);
updateAll();
