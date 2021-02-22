class Navbar {
    constructor() {
        this.navBtn = document.querySelector('#formBtn');
        this.navlink = document.querySelector('.form');
        this.navbarLinkContainer = document.querySelector('.form-link-container');
        this.navContainer = document.querySelector('.form-container');
    }
}

const navbar = new Navbar();

const handleWithNavbarApper = () => {
    navbar.navContainer
        .classList
        .toggle('form-container-active');
    navbar.navbarLinkContainer
        .classList
        .toggle('form-link-container-active');
    navbar.navBtn
        .classList
        .toggle('active')
    navbar.navlink
        .classList
        .toggle('form-active');
};


navbar.navBtn
    .addEventListener('click', handleWithNavbarApper);
