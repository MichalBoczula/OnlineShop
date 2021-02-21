class Navbar {
    constructor() {
        this.navBtn = document.querySelector('#navBtn');
        this.navlinks = document.querySelectorAll('.navbar-link');
        this.navbarLinksContainer = document.querySelector('.navbar-links-container');
        this.navContainer = document.querySelector('.navbar-container');
        this.navIcons = document.querySelectorAll('.navbar-icon');
    }
}

const navbar = new Navbar();

const handleWithNavbarApper = () => {
    navbar.navContainer
        .classList
        .toggle('navbar-container-active');
    navbar.navbarLinksContainer
        .classList
        .toggle('navbar-links-container-active');
    navbar.navBtn
        .classList
        .toggle('active')
    navbar.navlinks
        .forEach(navlink => {
            navlink.classList
                .toggle('navbar-link-active');
            setTimeout(() => {
                navlink.classList
                    .toggle('navbar-link-active-appear')
            }, 400)
        });
    navbar.navIcons
        .forEach(icon => {
            icon.classList
                .toggle('navbar-link-icon-appear')
        });
}

navbar.navBtn
    .addEventListener('click', handleWithNavbarApper);

console.log('active');