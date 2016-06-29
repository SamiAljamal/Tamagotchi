using Nancy;
using Tamagotchi.Objects;
using System.Collections.Generic;

namespace Tamagotchi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["create_new_tamagotchi.cshtml"];
      Post["/Tamagotchi"] = _ => {
        string name = Request.Form["tamaName"];
        Tama tama = new Tama(name);
        return View["tamagotchi_status.cshtml", tama];
      };
    }
  }
}
