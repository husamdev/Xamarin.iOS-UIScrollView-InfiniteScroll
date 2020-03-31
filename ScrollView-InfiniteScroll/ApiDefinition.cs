using System;

using ObjCRuntime;
using Foundation;
using UIKit;

namespace ScrollViewInfiniteScroll
{
    // @interface InfiniteScroll (UIScrollView)
    [Category]
    [BaseType(typeof(UIScrollView))]
    interface UIScrollView_InfiniteScroll
    {
        // @property (nonatomic) InfiniteScrollDirection infiniteScrollDirection;
        [Export("infiniteScrollDirection")]
        InfiniteScrollDirection InfiniteScrollDirection();

        [Export("setInfiniteScrollDirection:")]
        void InfiniteScrollDirection(InfiniteScrollDirection direction);

        // @property (readonly, getter = isAnimatingInfiniteScroll, nonatomic) BOOL animatingInfiniteScroll;
        //[Export("animatingInfiniteScroll")]
        [Export("isAnimatingInfiniteScroll")]
        bool AnimatingInfiniteScroll(); //{ [Bind("isAnimatingInfiniteScroll")] get; }

        // @property (nonatomic) UIActivityIndicatorViewStyle infiniteScrollIndicatorStyle;
        [Export("infiniteScrollIndicatorStyle")]
        UIActivityIndicatorViewStyle InfiniteScrollIndicatorStyle();

        [Export("setInfiniteScrollIndicatorStyle:")]
        void InfiniteScrollIndicatorStyle(UIActivityIndicatorViewStyle style);

        // @property (nonatomic) UIView * _Nullable infiniteScrollIndicatorView;
        [Export("infiniteScrollIndicatorView")]
        UIView InfiniteScrollIndicatorView();

        [Export("setInfiniteScrollIndicatorView:")]
        void InfiniteScrollIndicatorView(UIView indicator);

        // @property (nonatomic) CGFloat infiniteScrollIndicatorMargin;
        [Export("infiniteScrollIndicatorMargin")]
        nfloat InfiniteScrollIndicatorMargin();

        [Export("setInfiniteScrollIndicatorMargin:")]
        void InfiniteScrollIndicatorMargin(nfloat margin);

        // @property (nonatomic) CGFloat infiniteScrollTriggerOffset;
        [Export("infiniteScrollTriggerOffset")]
        nfloat InfiniteScrollTriggerOffset();

        [Export("setInfiniteScrollTriggerOffset:")]
        void InfiniteScrollTriggerOffset(nfloat offset);

        // -(void)addInfiniteScrollWithHandler:(void (^ _Nonnull)(UIScrollView * _Nonnull))handler;
        [Export("addInfiniteScrollWithHandler:")]
        void AddInfiniteScrollWithHandler(Action<UIScrollView> handler);

        // -(void)setShouldShowInfiniteScrollHandler:(BOOL (^ _Nullable)(UIScrollView * _Nonnull))handler;
        [Export("setShouldShowInfiniteScrollHandler:")]
        void SetShouldShowInfiniteScrollHandler([NullAllowed] Func<UIScrollView, bool> handler);

        // -(void)removeInfiniteScroll;
        [Export("removeInfiniteScroll")]
        void RemoveInfiniteScroll();

        // -(void)beginInfiniteScroll:(BOOL)forceScroll;
        [Export("beginInfiniteScroll:")]
        void BeginInfiniteScroll(bool forceScroll);

        // -(void)finishInfiniteScrollWithCompletion:(void (^ _Nullable)(UIScrollView * _Nonnull))handler;
        [Export("finishInfiniteScrollWithCompletion:")]
        void FinishInfiniteScrollWithCompletion([NullAllowed] Action<UIScrollView> handler);

        // -(void)finishInfiniteScroll;
        [Export("finishInfiniteScroll")]
        void FinishInfiniteScroll();
    }

    // @interface InfiniteScrollConvenienceInterface (UITableView)
    [Category]
    [BaseType(typeof(UITableView))]
    interface UITableView_InfiniteScrollConvenienceInterface
    {
        // -(void)addInfiniteScrollWithHandler:(void (^ _Nonnull)(UITableView * _Nonnull))handler;
        [Export("addInfiniteScrollWithHandler:")]
        void AddInfiniteScrollWithHandler(Action<UITableView> handler);

        // -(void)setShouldShowInfiniteScrollHandler:(BOOL (^ _Nonnull)(UITableView * _Nonnull))handler;
        [Export("setShouldShowInfiniteScrollHandler:")]
        void SetShouldShowInfiniteScrollHandler(Func<UITableView, bool> handler);

        // -(void)finishInfiniteScrollWithCompletion:(void (^ _Nullable)(UITableView * _Nonnull))handler;
        [Export("finishInfiniteScrollWithCompletion:")]
        void FinishInfiniteScrollWithCompletion([NullAllowed] Action<UITableView> handler);
    }

    // @interface InfiniteScrollConvenienceInterface (UICollectionView)
    [Category]
    [BaseType(typeof(UICollectionView))]
    interface UICollectionView_InfiniteScrollConvenienceInterface
    {
        // -(void)addInfiniteScrollWithHandler:(void (^ _Nonnull)(UICollectionView * _Nonnull))handler;
        [Export("addInfiniteScrollWithHandler:")]
        void AddInfiniteScrollWithHandler(Action<UICollectionView> handler);

        // -(void)setShouldShowInfiniteScrollHandler:(BOOL (^ _Nonnull)(UICollectionView * _Nonnull))handler;
        [Export("setShouldShowInfiniteScrollHandler:")]
        void SetShouldShowInfiniteScrollHandler(Func<UICollectionView, bool> handler);

        // -(void)finishInfiniteScrollWithCompletion:(void (^ _Nullable)(UICollectionView * _Nonnull))handler;
        [Export("finishInfiniteScrollWithCompletion:")]
        void FinishInfiniteScrollWithCompletion([NullAllowed] Action<UICollectionView> handler);
    }
}

