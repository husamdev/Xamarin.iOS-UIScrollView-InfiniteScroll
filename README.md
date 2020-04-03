# Xamarin.iOS-UIScrollView-InfiniteScroll
Xamarin.iOS binding for UIScrollView-InfiniteScroll https://github.com/pronebird/UIScrollView-InfiniteScroll

### Installation
Pull or download the project then add reference to ScrollView-InfiniteScroll

### Example
Provided a demo project with UITableView in InfiniteScrollDemo

### Basics
In order to enable infinite scroll you have to provide a handler block using addInfiniteScrollWithHandler. The block you provide is executed each time infinite scroll component detects that more data needs to be provided.

The purpose of the handler block is to perform asynchronous task, typically networking or database fetch, and update your scroll view or scroll view subclass.

The block itself is called on main queue.Once you receive new data, update table view by adding new rows and sections, then call finishInfiniteScroll to complete infinite scroll animations and reset the state of infinite scroll components.

ViewDidLoad is a good place to install handler block.

### Adding Infinite Scroll Handler
```
this.tableView.AddInfiniteScrollWithHandler(table =>
{
    // update table view

    // finish infinite scroll animation
    table.FinishInfiniteScroll();
});
```
### Prevent infinite scroll
```
this.tableView.SetShouldShowInfiniteScrollHandler(table =>
{
    // Only show up to 5 pages then prevent the infinite scroll
    return (this.currentPage < 5);
});
```
### Adding Default Indicator
```
this.tableView.SetInfiniteScrollIndicatorView(new UIActivityIndicatorView(UIActivityIndicatorViewStyle.Gray));
```


