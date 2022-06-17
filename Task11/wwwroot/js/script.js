var submitionPage;

async function show(ID) {
    submitionPage = document.getElementById('submition-' + ID);
    submitionPage.style.display = 'block';
}

async function confirm() {
    submitionPage.style.display = 'none';
}

async function decline() {
    submitionPage.style.display = 'none';
}