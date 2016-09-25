﻿using DotNetify;
using DotNetify.Routing;
using Service.Interfaces;

namespace ViewModels
{
   public class HomeVM : BaseVM, IRoutable
   {
      private readonly IShoppingCartService _shoppingCartService;

      public string PageTitle => "My Fake App";

      public Route CartRoute => this.Redirect("app", "cart");

      public int OrderCount => _shoppingCartService.GetShoppingCart().OrderCount;

      public Route MenuRoute => this.Redirect("app", "menu");

      public RoutingState RoutingState { get; set; }

      public HomeVM( IShoppingCartService shoppingCartService )
      {
         _shoppingCartService = shoppingCartService;
      }
   }
}
