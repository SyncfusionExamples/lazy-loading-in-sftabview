# Xamarin Tabbed View (SfTabView) 

The Tabbed View control is available in Xamarin.Forms, Xamarin.Android, Xamarin.iOS and Xamarin.UWP. It helps you to create the customizable features that are used to explore and switch among the different views. 

For know more details about TabView: https://www.syncfusion.com/xamarin-ui-controls/xamarin-tabbed-view

TabView user guide documentation: https://help.syncfusion.com/xamarin/tabbed-view/getting-started

# Lazy loading JSON data manually in Xamarin.Forms ListView
To load more items manually in the ListView, set the LoadMoreOption as Manual using the LoadMoreCommand and LoadMoreCommandParameter properties. Doing this will load more items on tapping the Load More button at the end of the list.

Refer to the following code example to bind the ViewModel.LoadMoreItemsCommand to the Xamarin.Forms ListView.

**[XAML]**
```
<syncfusion:SfListView x:Name="listView"
                         ItemSize="{OnPlatform Android=115, Default=100}"
                         ItemsSource="{Binding Items}"
                         LoadMoreOption="Auto"
                         LoadMoreCommand="{Binding LoadMoreItemsCommand}"
                         IsBusy="{Binding IsBusy}"
                         ItemSpacing="5"
                         LoadMoreCommandParameter="{Binding Source={x:Reference Name=listView}}">
```
Refer to the following code definition for LoadMoreItemsCommand in the ViewModel.
**[C#]**
```
private bool CanLoadMoreItems(object obj)
{
  if (Items.Count >= totalItems)
  return false;
  return true;
}
 
private async void LoadMoreItems(object obj)
{
   var listview = obj as SfListView;
   try
   {
      IsBusy = true;
      await Task.Delay(1000);
      var index = Items.Count;
      var count = index + 3 >= totalItems ? totalItems - index : 3;
      AddProducts(index, count);
   }
   catch
   {
 
   }
   finally
   {
      IsBusy = false;
   }
}
 
private void AddProducts(int index, int count)
{
  for (int i = index; i < index + count; i++)
  {
     Items.Add(JSONCollection[i]);
  }
}

```
# Lazy loading JSON data automatically in Xamarin.Forms ListView
To load more items automatically in the ListView, set the LoadMoreOption as Auto using the LoadMoreCommand and LoadMoreCommandParameter properties. This will load more items when the scrollbar reaches the end of the list.

Refer to the following code example.

**[XAML]**

```
<syncfusion:SfListView x:Name="listView"
                         ItemSize="{OnPlatform Android=105, Default=100}"
                         ItemsSource="{Binding Items}"
                         LoadMoreOption="Auto"
                         LoadMoreCommand="{Binding LoadMoreItemsCommand}"
                         IsBusy="{Binding IsBusy}"
                         ScrollBarVisibility="Always"
                         LoadMoreCommandParameter="{Binding Source={x:Reference Name=listView}}"/>
```
## How to run this application?

To run this application, you need to first clone the lazy-loading-in-sftabview repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.