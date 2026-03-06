// ── Scroll-reveal ────────────────────────────────────────
(function () {
    const observer = new IntersectionObserver(
        (entries) => {
            entries.forEach((entry) => {
                if (!entry.isIntersecting) return;
                entry.target.classList.add("revealed");
                observer.unobserve(entry.target); // fire once only
            });
        },
        { threshold: 0.12 }
    );

    // ── Project-row appear ───────────────────────────────
    const rowObserver = new IntersectionObserver(
        (entries) => {
            entries.forEach((entry) => {
                if (!entry.isIntersecting) return;
                entry.target.classList.add("appear");
                rowObserver.unobserve(entry.target); // fire once only
            });
        },
        { threshold: 0.1 }
    );

    document.addEventListener("DOMContentLoaded", () => {
        //document
        //    .querySelectorAll("section:not(#hero):not(#projects)") // skip hero — already visible
        //    .forEach((section) => {
        //        section.classList.add("reveal");
        //        observer.observe(section);
        //    });

        document.querySelectorAll(".project-row").forEach((row, i) => {
            row.style.setProperty("--row-i", i);
            rowObserver.observe(row);
        });
    });
})();