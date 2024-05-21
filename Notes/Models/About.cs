using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models;

internal class About
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
    public string MoreInfoUrl => "https://github.com/Romsesito";
    public string Message => "-Jordan Alejandro ";

    public string MessageD => "Soy una persona alegre, creativa y me gusta llevarme bien con la gente :D";

}