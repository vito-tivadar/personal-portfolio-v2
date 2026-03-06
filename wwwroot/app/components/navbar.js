const toggle = document.getElementById('navbar-toggle');
const drawer = document.getElementById('drawer');
const overlay = document.getElementById('drawer-overlay');
const closeBtn = document.getElementById('drawer-close');

/* ── Drawer open / close ────────────────────────────────── */
function openDrawer() {
    drawer.classList.add('is-open');
    overlay.classList.add('is-visible');
    document.body.style.overflow = 'hidden';
}

function closeDrawer() {
    drawer.classList.remove('is-open');
    overlay.classList.remove('is-visible');
    document.body.style.overflow = '';
}

toggle.addEventListener('click', openDrawer);
closeBtn.addEventListener('click', closeDrawer);
overlay.addEventListener('click', closeDrawer);

drawer.querySelectorAll('.drawer_link, .drawer_cta').forEach(link => {
    link.addEventListener('click', closeDrawer);
});

/* ── Active link on scroll (IntersectionObserver) ───────── */

// Grab all nav + drawer links — use link.hash so hrefs like "/#skills" and "#skills" both match
const allNavLinks = document.querySelectorAll('.navbar_link, .drawer_link');

function setActiveLink(id) {
    allNavLinks.forEach(link => {
        link.classList.toggle('active', link.hash === `#${id}`);
    });
}

// Build a unique ordered list of section IDs from link hashes
const sectionIds = [...new Set(
    [...allNavLinks]
        .map(link => link.hash.slice(1))  // strip the leading #
        .filter(Boolean)                   // drop empty hashes (logo links etc.)
)];

const sections = sectionIds
    .map(id => document.getElementById(id))
    .filter(Boolean); // drop any that don't exist in the DOM

// Track which sections are currently visible
const visibleSections = new Set();

const observer = new IntersectionObserver(entries => {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            visibleSections.add(entry.target.id);
        } else {
            visibleSections.delete(entry.target.id);
        }
    });

    // Pick the first visible section in document order
    const activeId = sectionIds.find(id => visibleSections.has(id));
    if (activeId) setActiveLink(activeId);

}, {
    // Trigger when a section enters/leaves the top 30% of the viewport
    rootMargin: '0px 0px -70% 0px',
    threshold: 0
});

sections.forEach(section => observer.observe(section));

/* ── Initial state on page load ── */
if (window.scrollY < 50) {
    setActiveLink('home');
}

/* ── Edge case: snap to "home" when scrolled back to very top ── */
window.addEventListener('scroll', () => {
    if (window.scrollY < 50) {
        setActiveLink('home');
    }
}, { passive: true });