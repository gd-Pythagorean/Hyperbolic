function toggleDarkTheme()
{
    let element = document.body;

    if (element.style.backgroundColor == null || element.style.backgroundColor === "white")
    {
        element.style.backgroundColor = "#262626";
        element.classList.add("dark-theme");
    }
    else
    {
        element.style.backgroundColor = "white";
        element.classList.remove("dark-theme");
    }

    toggled = !toggled;
}