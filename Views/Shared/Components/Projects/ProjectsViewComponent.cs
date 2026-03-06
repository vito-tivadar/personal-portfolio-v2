using Microsoft.AspNetCore.Mvc;
using personal_portfolio_v2.Models;

namespace personal_portfolio_v2.Views.Shared.Components.Footer
{
    public class ProjectsViewComponent : ViewComponent
    {
        public ProjectsViewComponent()
        {
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(GetProjects());
        }

        private List<ProjectDto> GetProjects()
        {
            return new List<ProjectDto>
            {


                // ── Software / Web ────────────────────────────────────────
                
                //new ProjectDto
                //{
                //    Slug = "auth-backend",
                //    Title = "Auth Backend Service",
                //    Subtitle = "Central authorization and authentication API usable across multiple self-hosted services. Built on ASP.NET and MySQL.",
                //    ImageUrl = "https://assets.vitotivadar.com/software/auth.png",
                //    ImageAlt = "Auth backend service screenshot",
                //    Badges = new List<string> { "Backend", "Database" },
                //    Tags = new List<string> { "C#", "ASP.NET", "MySQL", "MIT Licence" },
                //    ViewUrl = "",
                //},
                new ProjectDto
                {
                    Slug = "dashboard",
                    Title = "Dashboard",
                    Subtitle = "A full-stack web application, featuring a complete authentication system with email integration, 2FA authentication, and account management.",
                    ImageUrl = "https://assets.vitotivadar.com/software/auth-dashboard.png",
                    ImageAlt = "Dashboard screenshot",
                    Badges = new List<string> { "Frontend", "Backend", "Database" },
                    Tags = new List<string> { "Angular", "ASP.NET", "PostgreSQL", "AGPL-3.0" },
                    ViewUrl = "https://github.com/vito-tivadar/aspnet-angular-dashboard",
                },
                new ProjectDto
                {
                    Slug = "docker-backend",
                    Title = "Docker Backend",
                    Subtitle = "ASP.NET Web API backend for the Dashboard project. Full support for containers and images; partial support for volumes and networks.",
                    ImageUrl = "https://assets.vitotivadar.com/software/docker.png",
                    ImageAlt = "Docker backend screenshot",
                    Badges = new List<string> { "Frontend", "Backend" },
                    Tags = new List<string> { "C#", "ASP.NET", "Docker", "MIT Licence" },
                    ViewUrl = "https://github.com/vito-tivadar/ServerRESTInterfaceApp",
                },
                new ProjectDto
                {
                    Slug = "truss-fem",
                    Title = "Truss FEM Software",
                    Subtitle = "Desktop app for truss structure analysis with a custom solver and MVVM framework. Built as a bachelor's degree thesis.",
                    ImageUrl = "https://assets.vitotivadar.com/software/fem.png",
                    ImageAlt = "Truss FEM software screenshot",
                    Badges = new List<string> { "Desktop" },
                    Tags = new List<string> { "C#", "WPF", "Inactive development", "MIT Licence" },
                    ViewUrl = "https://github.com/vito-tivadar/PalicneKonstrukcijeMKE",
                },
                new ProjectDto
                {
                    Slug = "navigation-simulator",
                    Title = "Navigation Simulator",
                    Subtitle = "Angular app for testing GPS tile rendering and position calculation — a starting point for a custom cycling computer.",
                    ImageUrl = "https://assets.vitotivadar.com/software/navigation.png",
                    ImageAlt = "Navigation simulator screenshot",
                    Badges = new List<string> { "Frontend" },
                    Tags = new List<string> { "Angular", "TypeScript", "Inactive development", "MIT Licence" },
                    ViewUrl = "https://github.com/vito-tivadar/Various-Angular-Projects/tree/main/projects/gps-simulator",
                },
                new ProjectDto
                {
                    Slug = "personal-portfolio",
                    Title = "Personal Portfolio",
                    Subtitle = "Portfolio frontend built with ASP.NET 10 - MVC, running on Docker",
                    ImageUrl = "https://assets.vitotivadar.com/software/portfolio_v2.png",
                    ImageAlt = "Personal portfolio screenshot",
                    Badges = new List<string> { "Frontend", "Backend" },
                    Tags = new List<string> { "ASP.NET MVC", "AGPL-3.0" },
                    ViewUrl = "https://github.com/vito-tivadar/personal-portfolio-v2",
                },
                //new ProjectDto
                //{
                //    Slug = "angular-modal",
                //    Title = "Angular Modal",
                //    Subtitle = "Simple, customizable Angular modal component library built primarily for the Dashboard project.",
                //    ImageUrl = "https://assets.vitotivadar.com/software/modal.png",
                //    ImageAlt = "Angular modal library screenshot",
                //    Badges = new List<string> { "Frontend" },
                //    Tags = new List<string> { "Angular", "TypeScript" },
                //    ViewUrl = "",
                //},
                //new ProjectDto
                //{
                //    Slug = "radio-player",
                //    Title = "Radio Player",
                //    Subtitle = "Desktop app for listening to online radios. One of my first projects from 2015 — still in daily use.",
                //    ImageUrl = "https://assets.vitotivadar.com/software/radio.png",
                //    ImageAlt = "Radio player screenshot",
                //    Badges = new List<string> { "Desktop" },
                //    Tags = new List<string> { "C#", "WPF", "Finished", "MIT Licence" },
                //    ViewUrl = "",
                //},
                //new ProjectDto
                //{
                //    Slug = "discord-bots",
                //    Title = "Discord Bots",
                //    Subtitle = "A collection of bots — some are useful, some were built just for fun. Written in Discord.js v11/v12.",
                //    ImageUrl = "https://assets.vitotivadar.com/software/discord.png",
                //    ImageAlt = "Discord bots screenshot",
                //    Badges = new List<string> { "Backend", "Database" },
                //    Tags = new List<string> { "Node.js", "MongoDB", "MIT Licence" },
                //    ViewUrl = "",
                //},
                new ProjectDto
                {
                    Slug = "web-utility-tools",
                    Title = "Web Utility Tools",
                    Subtitle = "A collection of simple web utility tools. Main use of these tools is getting device info on devices that don't support dev tools.",
                    ImageUrl = "https://assets.vitotivadar.com/software/web-utility-tools.png",
                    ImageAlt = "Web Utility Tools logo",
                    Badges = new List<string> { "Frontend" },
                    Tags = new List<string> { "HTML, CSS & JS", "MIT Licence" },
                    ViewUrl = "https://github.com/vito-tivadar/web-tools/tree/main",
                },


                                // ── Mechanical ────────────────────────────────────────────
                new ProjectDto
                {
                    Slug = "inline-engine",
                    Title = "Inline Engine",
                    Subtitle = "4-cylinder inline engine with over 130 parts made in PTC Creo 5. Can be displayed in Vuforia Augmented reality. Audax 2019 winning 3D model",
                    ImageUrl = "https://assets.vitotivadar.com/mechanical/engine_ar.png",
                    ImageAlt = "Inline engine 3D model",
                    Badges = new List<string> { "Mechanical", "CAD" },
                    Tags = new List<string> { "PTC Creo", "Vuforia AR" },
                    ViewUrl = "https://www.youtube.com/watch?v=jRADIyhKcrc",
                },
                new ProjectDto
                {
                    Slug = "cyberbike",
                    Title = "Cyberbike",
                    Subtitle = "Motorbike based on the Tesla Cybertruck, made as part of a Virtual Engineering course at university.",
                    ImageUrl = "https://assets.vitotivadar.com/mechanical/cyberbike.png",
                    ImageAlt = "Cyberbike 3D model",
                    Badges = new List<string> { "Mechanical", "3D Modeling" },
                    Tags = new List<string> { "Blender" },
                    ViewUrl = "https://drive.google.com/drive/folders/1YqScS8_czKemjk2XbMYMk7N3KpwbV46z?usp=sharing",
                },

                //new ProjectDto
                //{
                //    Slug = "custom-mouse-shell",
                //    Title = "Custom Mouse",
                //    Subtitle = "Mouse shell inspired by Logitech MX Master 3S, designed from a clay model as part of a surface modelling course.",
                //    ImageUrl = "https://assets.vitotivadar.com/mechanical/mouse.png",
                //    ImageAlt = "Custom mouse 3D model",
                //    Badges = new List<string> { "Mechanical", "CAD" },
                //    Tags = new List<string> { "Solidworks" },
                //    ViewUrl = "",
                //},
                //new ProjectDto
                //{
                //    Slug = "server-rack",
                //    Title = "Server Rack",
                //    Subtitle = "Custom 9U server rack designed and built for personal use, including a fixed 1U power distribution unit.",
                //    ImageUrl = "https://assets.vitotivadar.com/mechanical/rack.png",
                //    ImageAlt = "Custom server rack 3D model",
                //    Badges = new List<string> { "Mechanical", "CAD", "Hardware" },
                //    Tags = new List<string> { "Solidworks", "MIT Licence" },
                //    ViewUrl = "",
                //},

                // ── Embedded ──────────────────────────────────────────────
                new ProjectDto
                {
                    Slug = "dial-gauge-reader",
                    Title = "Dial Gauge Reader",
                    Subtitle = "Middleware device that reads a dial gauge's serial port to replace BL-Touch on a 3D printer and improve bed levelling accuracy.",
                    ImageUrl = "https://assets.vitotivadar.com/embedded/gauge.png",
                    ImageAlt = "Dial gauge reader device",
                    Badges = new List<string> { "Embedded", "Hardware" },
                    Tags = new List<string> { "C", "STM32", "MIT Licence" },
                    ViewUrl = "https://drive.google.com/drive/folders/1RP4yzxO-AoZUYAJ88KewBQO3DI9KE5mt?usp=sharing",
                },
                new ProjectDto
                {
                    Slug = "ender3-firmware",
                    Title = "Ender 3 Firmware",
                    Subtitle = "Configured Marlin firmware with custom-written menus for various tasks on the Ender 3.",
                    ImageUrl = "https://assets.vitotivadar.com/embedded/ender3.png",
                    ImageAlt = "Ender 3 3D printer",
                    Badges = new List<string> { "Embedded", "Firmware" },
                    Tags = new List<string> { "C++", "Marlin" },
                    ViewUrl = "https://github.com/vito-tivadar/Marlin-bugfix-2.0.x",
                },
                //new ProjectDto
                //{
                //    Slug = "server-controller",
                //    Title = "Server Controller",
                //    Subtitle = "Raspberry Pi controlled display in a server rack for temperature monitoring and cooling fan control.",
                //    ImageUrl = "https://assets.vitotivadar.com/embedded/server.png",
                //    ImageAlt = "Server rack controller",
                //    Badges = new List<string> { "Embedded", "Hardware" },
                //    Tags = new List<string> { "Raspberry Pi", "Python" },
                //    ViewUrl = "",
                //},
                new ProjectDto
                {
                    Slug = "barcode-scanner-hub",
                    Title = "Barcode Scanner Hub",
                    Subtitle = "ESP32 firmware that bridges a Bluetooth LE barcode scanner to any HTTP/HTTPS webhook. Configurable through its own web interface.",
                    ImageUrl = "https://assets.vitotivadar.com/embedded/netum_scanner.png",
                    ImageAlt = "netum barcode scanner",
                    Badges = new List<string> { "Embedded", "Hardware" },
                    Tags = new List<string> { "Barcode scanner", "ESP32" },
                    ViewUrl = "https://github.com/vito-tivadar/BarcodeScannerHub",
                },
            };
        }
    }
}
