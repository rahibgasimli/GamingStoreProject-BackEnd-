let pageSize = document.getElementById('pageSize');

pageSize.addEventListener('change', () => {
    let path = window.location.pathname;        ;
    window.location = `https://localhost:7221${path}?pageSize=${pageSize.value}`;
});