using Microsoft.AspNetCore.Mvc;
using personal_portfolio_v2.Models;

namespace personal_portfolio_v2.Views.Shared.Components.Footer
{
    public class SkillsViewComponent : ViewComponent
    {
        public SkillsViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(GetSkills());
        }


        private List<Skill> GetSkills() => new List<Skill>
        {
            // Row 1
            //new Skill { Name = "HTML",       ImagePath = "/assets/skills/html.png",       Accent = "#e34c26", RowNumber = 1, },
            //new Skill { Name = "CSS",        ImagePath = "/assets/skills/css.png",        Accent = "#264de4", RowNumber = 1, },
            //new Skill { Name = "SASS",       ImagePath = "/assets/skills/sass.png",       Accent = "#cd6799", RowNumber = 1, },
            //new Skill { Name = "JavaScript", ImagePath = "/assets/skills/javascript.png", Accent = "#f7df1e", RowNumber = 1, },
            //new Skill { Name = "React JS",   ImagePath = "/assets/skills/reactjs.png",    Accent = "#61dafb", RowNumber = 1, },
            //new Skill { Name = "TypeScript", ImagePath = "/assets/skills/typescript.png", Accent = "#3178c6", RowNumber = 1, },
                                                                                                            

            //new Skill { Name = "GitHub",     ImagePath = "/assets/skills/github.png",     Accent = "#ffffff", RowNumber = 2, },
            //new Skill { Name = "Node JS",    ImagePath = "/assets/skills/nodejs.png",     Accent = "#68a063", RowNumber = 2, },
            //new Skill { Name = "Firebase",   ImagePath = "/assets/skills/firebase.png",   Accent = "#ffca28", RowNumber = 2, },
            //new Skill { Name = "MongoDB",    ImagePath = "/assets/skills/mongodb.png",    Accent = "#4db33d", RowNumber = 2, },
            //new Skill { Name = "Docker",     ImagePath = "/assets/skills/docker.png",     Accent = "#2496ed", RowNumber = 2, },
            //new Skill { Name = "Python",     ImagePath = "/assets/skills/python.png",     Accent = "#ffd43b", RowNumber = 2, },




            new Skill { Name = "Angular",            RowNumber = 1, Accent = "#dd0031", AccentInteinsity = 255, ImagePath = "/assets/skills/angular.svg" },
            new Skill { Name = "JavaScript",         RowNumber = 1, Accent = "#f7df1e", AccentInteinsity = 150, ImagePath = "/assets/skills/javascript.svg" },
            new Skill { Name = "TypeScript",         RowNumber = 1, Accent = "#3178c6", AccentInteinsity = 150, ImagePath = "/assets/skills/typescript.svg" },
            new Skill { Name = "HTML",               RowNumber = 1, Accent = "#e34c26", AccentInteinsity = 200, ImagePath = "/assets/skills/html5.svg" },
            new Skill { Name = "CSS",                RowNumber = 1, Accent = "#264de4", AccentInteinsity = 255, ImagePath = "/assets/skills/css3.svg" },
            new Skill { Name = "Sass",               RowNumber = 1, Accent = "#cd6799", AccentInteinsity = 255, ImagePath = "/assets/skills/sass.svg" },
            new Skill { Name = "Bootstrap",          RowNumber = 1, Accent = "#7952b3", AccentInteinsity = 255, ImagePath = "/assets/skills/bootstrap.svg" },
            new Skill { Name = "Tailwind CSS",       RowNumber = 1, Accent = "#38bdf8", AccentInteinsity = 255, ImagePath = "/assets/skills/tailwindcss.svg" },
            new Skill { Name = "Astro",              RowNumber = 1, Accent = "#ff5d01", AccentInteinsity = 150, ImagePath = "/assets/skills/astro.svg" },
            new Skill { Name = "C#",                 RowNumber = 1, Accent = "#953dac", AccentInteinsity = 255, ImagePath = "/assets/skills/csharp.svg" },
            new Skill { Name = ".NET Core",          RowNumber = 1, Accent = "#512bd4", AccentInteinsity = 255, ImagePath = "/assets/skills/dotnetcore.svg" },
            new Skill { Name = "Node.js",            RowNumber = 1, Accent = "#68a063", AccentInteinsity = 200, ImagePath = "/assets/skills/nodejs.svg" },
            new Skill { Name = "PostgreSQL",         RowNumber = 1, Accent = "#336791", AccentInteinsity = 255, ImagePath = "/assets/skills/postgresql.svg" },
            new Skill { Name = "MongoDB",            RowNumber = 1, Accent = "#4db33d", AccentInteinsity = 255, ImagePath = "/assets/skills/mongodb.svg" },
            new Skill { Name = "MS SQL Server",      RowNumber = 1, Accent = "#cc2927", AccentInteinsity = 255, ImagePath = "/assets/skills/microsoftsqlserver.svg" },
                                                                                        
            
            new Skill { Name = "Docker",             RowNumber = 2, Accent = "#2496ed", AccentInteinsity = 255, ImagePath = "/assets/skills/docker.svg" },
            new Skill { Name = "Azure",              RowNumber = 2, Accent = "#0089d6", AccentInteinsity = 150, ImagePath = "/assets/skills/azure.svg" },
            new Skill { Name = "Ansible",            RowNumber = 2, Accent = "#358e9f", AccentInteinsity = 200, ImagePath = "/assets/skills/ansible.svg" },
            new Skill { Name = "Proxmox",            RowNumber = 2, Accent = "#e57000", AccentInteinsity = 255, ImagePath = "/assets/skills/proxmox.svg" }, // not in devicons
            new Skill { Name = "GitHub Actions",     RowNumber = 2, Accent = "#ffffff", AccentInteinsity = 200, ImagePath = "/assets/skills/githubactions.svg" },
            new Skill { Name = "Git",                RowNumber = 2, Accent = "#f34f29", AccentInteinsity = 200, ImagePath = "/assets/skills/git.svg" },
            new Skill { Name = "Bash",               RowNumber = 2, Accent = "#4eaa25", AccentInteinsity = 255, ImagePath = "/assets/skills/bash.svg" },
            new Skill { Name = "PowerShell",         RowNumber = 2, Accent = "#5391fe", AccentInteinsity = 255, ImagePath = "/assets/skills/powershell.svg" },
            new Skill { Name = "Arduino",            RowNumber = 2, Accent = "#00979d", AccentInteinsity = 255, ImagePath = "/assets/skills/arduino.svg" },
            new Skill { Name = "KiCad",              RowNumber = 2, Accent = "#314cb0", AccentInteinsity = 255, ImagePath = "/assets/skills/kicad.svg" }, // not in devicons
            new Skill { Name = "Playwright",         RowNumber = 2, Accent = "#2ead33", AccentInteinsity = 200, ImagePath = "/assets/skills/playwright.svg" },
            new Skill { Name = "SolidWorks",         RowNumber = 2, Accent = "#e2001a", AccentInteinsity = 255, ImagePath = "/assets/skills/solidworks.svg" }, // not in devicons
            new Skill { Name = "PTC Creo",           RowNumber = 2, Accent = "#40aa1d", AccentInteinsity = 100, ImagePath = "/assets/skills/ptccreo.svg" }, // not in devicons
            new Skill { Name = "Keyshot",            RowNumber = 2, Accent = "#009cfd", AccentInteinsity = 255, ImagePath = "/assets/skills/keyshot.svg" }, // not in devicons
            new Skill { Name = "Blender",            RowNumber = 2, Accent = "#f5792a", AccentInteinsity = 200, ImagePath = "/assets/skills/blender.svg" },
            new Skill { Name = "Photoshop",          RowNumber = 2, Accent = "#31a8ff", AccentInteinsity = 100, ImagePath = "/assets/skills/photoshop.svg" },
            new Skill { Name = "After Effects",      RowNumber = 2, Accent = "#9999ff", AccentInteinsity = 100, ImagePath = "/assets/skills/aftereffects.svg" },



        };

    }
}
