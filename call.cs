public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.toolbar_menu, menu); // path to menue
            return base.OnCreateOptionsMenu(menu);
        }
 
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            string textToShow;
 
            if (item.ItemId == Resource.Id.menu_info)
                textToShow = "whatever:)"; 
            else
                textToShow = "Overfloooow";
 // here display msg botom
            Android.Widget.Toast.MakeText(this, item.TitleFormatted + ": " + textToShow,
                Android.Widget.ToastLength.Long).Show();
 
            return base.OnOptionsItemSelected(item);
        }
