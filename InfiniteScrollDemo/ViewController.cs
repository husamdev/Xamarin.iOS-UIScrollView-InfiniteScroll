using Foundation;
using System;
using ScrollViewInfiniteScroll;
using UIKit;

namespace InfiniteScrollDemo
{
    public class ViewController : UIViewController
    {
        readonly UITableView tableView = new UITableView
        {
            TranslatesAutoresizingMaskIntoConstraints = false
        };

        readonly DataSource dataSource = new DataSource();

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupTable();
            SetupInfinityScroll();
        }

        public void SetupTable()
        {
            this.tableView.RegisterClassForCellReuse(typeof(UITableViewCell), "id");
            this.View.AddSubview(tableView);
            NSLayoutConstraint.ActivateConstraints(new NSLayoutConstraint[]
            {
                this.tableView.LeadingAnchor.ConstraintEqualTo(this.View.LeadingAnchor),
                this.tableView.TrailingAnchor.ConstraintEqualTo(this.View.TrailingAnchor),
                this.tableView.TopAnchor.ConstraintEqualTo(this.View.TopAnchor),
                this.tableView.BottomAnchor.ConstraintEqualTo(this.View.BottomAnchor)
            });

            this.tableView.DataSource = dataSource;
        }

        private void SetupInfinityScroll()
        {
            this.tableView.SetInfiniteScrollIndicatorView(new UIActivityIndicatorView(UIActivityIndicatorViewStyle.Gray));

            this.tableView.AddInfiniteScrollWithHandler((scrollView) =>
            {
                // update table view
                this.dataSource.NumberOfRows += 35;
                this.tableView.ReloadData();

                // finish infinite scroll animation
                this.tableView.FinishInfiniteScroll();
            });
        }
    }
}