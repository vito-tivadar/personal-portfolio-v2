(function () {
    'use strict';

    const form = document.getElementById('contact-form');
    if (!form) return;

    const submitBtn = form.querySelector('.contact-submit');
    const statusEl = document.getElementById('contact-status');
    const btnText = submitBtn.innerHTML;

    form.addEventListener('submit', async function (e) {
        e.preventDefault();

        // Clear previous status
        statusEl.style.display = 'none';
        statusEl.className = 'contact-status';

        // Clear input error styles
        form.querySelectorAll('.input-error').forEach(el => el.classList.remove('input-error'));

        // Gather form data
        const name = form.querySelector('#contact-name').value.trim();
        const email = form.querySelector('#contact-email').value.trim();
        const message = form.querySelector('#contact-message').value.trim();

        // Client-side validation
        let hasError = false;

        if (!name) {
            form.querySelector('#contact-name').classList.add('input-error');
            hasError = true;
        }

        if (!email || !email.match(/^[^\s@]+@[^\s@]+\.[^\s@]+$/)) {
            form.querySelector('#contact-email').classList.add('input-error');
            hasError = true;
        }

        if (!message || message.length < 10) {
            form.querySelector('#contact-message').classList.add('input-error');
            hasError = true;
        }

        if (hasError) {
            showStatus('Please fill in all fields correctly.', 'error');
            return;
        }

        // Disable button
        submitBtn.disabled = true;
        submitBtn.innerHTML = '<i class="ti ti-loader-2 spin"></i> Sending...';

        try {
            const response = await fetch('/api/contact', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ name, email, message })
            });

            const data = await response.json();

            if (response.ok && data.success) {
                showStatus(data.message, 'success');
                form.reset();
            } else if (response.status === 429) {
                showStatus('Too many requests. Please wait a moment and try again.', 'error');
            } else {
                let errorMsg = 'Something went wrong.';
                if (data.errors) {
                    if (Array.isArray(data.errors)) {
                        errorMsg = data.errors.join(' ');
                    } else {
                        errorMsg = Object.values(data.errors).flat().join(' ');
                    }
                }
                showStatus(errorMsg, 'error');
            }
        } catch {
            showStatus('Failed to send message. Please try again later.', 'error');
        } finally {
            submitBtn.disabled = false;
            submitBtn.innerHTML = btnText;
        }
    });

    function showStatus(message, type) {
        statusEl.textContent = message;
        statusEl.className = 'contact-status contact-status--' + type;
        statusEl.style.display = 'block';
    }
})();
