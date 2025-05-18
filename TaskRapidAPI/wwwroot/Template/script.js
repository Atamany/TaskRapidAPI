// Yenile butonu animasyonu
document.querySelector('.btn-outline-primary').addEventListener('click', function() {
    this.classList.add('rotate-animation');
    setTimeout(() => {
        this.classList.remove('rotate-animation');
    }, 1000);
}); 