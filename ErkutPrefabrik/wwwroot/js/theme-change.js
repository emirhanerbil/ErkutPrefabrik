const toggleSwitch = document.querySelector('.theme-switch input[type="checkbox"]');
const currentTheme = document.documentElement.setAttribute('data-theme', 'dark');

if (currentTheme) {


    if (currentTheme === 'dark') {
        toggleSwitch.checked = true;
    }
}

function switchTheme(e) {
    if (e.target.checked) {
        document.documentElement.setAttribute('data-theme', 'light');
        localStorage.setItem('theme', 'light');
    }
    else {
        document.documentElement.setAttribute('data-theme', 'dark');
        localStorage.setItem('theme', 'dark');
    }
}

toggleSwitch.addEventListener('change', switchTheme, true
);