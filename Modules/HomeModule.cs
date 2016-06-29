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
      Post["/tamagotchi"] = _ => {
        string name = Request.Form["tamaName"];
        Tama tama = new Tama();
        tama.SetName(name);
        return View["tamagotchi_status.cshtml", tama];
      };
      Post["/sleep"] = _ => {
        Tama currentTama =  Tama.CurrentTama();
        currentTama.Sleep();
        return View["tamagotchi_status.cshtml",currentTama];
      };
      Post["/eat"] = _ => {
        Tama currentTama =  Tama.CurrentTama();
        currentTama.Eat();
        return View["tamagotchi_status.cshtml",currentTama];
      };
      Post["/clean"] = _ => {
      Tama currentTama =  Tama.CurrentTama();
      currentTama.Clean();
        return View["tamagotchi_status.cshtml",currentTama];
      };
      Post["/play"] = _ => {
        Tama currentTama =  Tama.CurrentTama();
        currentTama.Play();
        return View["tamagotchi_status.cshtml",currentTama];
      };


    }
  }
}
