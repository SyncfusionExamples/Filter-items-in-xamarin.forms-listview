# Filtering the ListView

The [ListView](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.SfListView.XForms~Syncfusion.ListView.XForms.SfListView.html) supports to filter the data by setting the [SfListView.DataSource.Filter](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.DataSource.Portable~Syncfusion.DataSource.DataSource~Filter.html) property. You have to call the [SfListView.DataSource.RefreshFilter()](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.DataSource.Portable~Syncfusion.DataSource.DataSource~RefreshFilter.html) method after assigning the `Filter` property for refreshing the view.

The [FilterChanged](https://help.syncfusion.com/cr/cref_files/xamarin/Syncfusion.DataSource.Portable~Syncfusion.DataSource.DataSource~FilterChanged_EV.html) event is raised once filtering is applied to the SfListView.

The `FilterContacts` method filters the data contains the filter text value. Assign `FilterContacts` method to `SfListView.DataSource.Filter` predicate to filter the `ContactName`. To apply filtering in the SfListView, follow the code example:

```
<ContentPage xmlns:syncfusion="clr-namespace:Syncfusion.ListView.XForms;assembly=Syncfusion.SfListView.XForms">
 <Grid>
	 <Grid.RowDefinitions>
                <RowDefinition Height="Auto"/>
                <RowDefinition Height="Auto"/>
   </Grid.RowDefinitions>
      <SearchBar x:Name="filterText" HeightRequest="40"
           Placeholder="Search here to filter"
           TextChanged="OnFilterTextChanged" Grid.Row="0"/>
      <syncfusion:SfListView x:Name="listView" Grid.Row="1" ItemSize="60" ItemsSource="{Binding customerDetails}"/>
  </Grid>
</ContentPage>
```
The following code example illustrates code for filtering the data using `FilterContacts` method in the ViewModel:

```
SearchBar searchBar = null;
private void OnFilterTextChanged(object sender, TextChangedEventArgs e)
{
  searchBar = (sender as SearchBar);
  if (listView.DataSource != null)
  {
    this.listView.DataSource.Filter = FilterContacts;
    this.listView.DataSource.RefreshFilter();
  }
}
 
private bool FilterContacts(object obj)
{
  if (searchBar == null || searchBar.Text == null)
     return true;

  var contacts = obj as Contacts;
  if (contacts.ContactName.ToLower().Contains(searchBar.Text.ToLower())
       || contacts.ContactName.ToLower().Contains(searchBar.Text.ToLower()))
      return true;
  else
      return false;
}
```

To know more about filtering ListView, please refer our documentation [here](https://help.syncfusion.com/xamarin/sflistview/filtering)