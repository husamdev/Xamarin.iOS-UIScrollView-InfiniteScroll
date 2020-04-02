using System;
using Foundation;
using UIKit;

namespace InfiniteScrollDemo
{
    public class DataSource : UITableViewDataSource
    {
        public int NumberOfRows { get; set; } = 20;

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell("id", indexPath);
            cell.TextLabel.Text = indexPath.Row.ToString();
            return cell;
        }

        public override nint RowsInSection(UITableView tableView, nint section)
        {
            return NumberOfRows;
        }
    }
}
