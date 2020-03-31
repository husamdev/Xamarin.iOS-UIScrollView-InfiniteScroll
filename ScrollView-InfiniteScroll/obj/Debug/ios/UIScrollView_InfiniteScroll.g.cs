//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;

namespace ScrollViewInfiniteScroll {
	public unsafe static partial class UIScrollView_InfiniteScroll  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIScrollView");
		
		[Export ("addInfiniteScrollWithHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AddInfiniteScrollWithHandler (this global::UIKit.UIScrollView This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::UIKit.UIScrollView> handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, handler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("addInfiniteScrollWithHandler:"), (IntPtr) block_ptr_handler);
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("isAnimatingInfiniteScroll")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool AnimatingInfiniteScroll (this global::UIKit.UIScrollView This)
		{
			return global::ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("isAnimatingInfiniteScroll"));
		}
		
		[Export ("beginInfiniteScroll:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void BeginInfiniteScroll (this global::UIKit.UIScrollView This, bool forceScroll)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("beginInfiniteScroll:"), forceScroll);
		}
		
		[Export ("finishInfiniteScroll")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void FinishInfiniteScroll (this global::UIKit.UIScrollView This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("finishInfiniteScroll"));
		}
		
		[Export ("finishInfiniteScrollWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void FinishInfiniteScrollWithCompletion (this global::UIKit.UIScrollView This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<global::UIKit.UIScrollView> handler)
		{
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlockUnsafe (Trampolines.SDActionArity1V1.Handler, handler);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("finishInfiniteScrollWithCompletion:"), (IntPtr) block_ptr_handler);
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("infiniteScrollDirection")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static InfiniteScrollDirection InfiniteScrollDirection (this global::UIKit.UIScrollView This)
		{
			InfiniteScrollDirection ret;
			if (IntPtr.Size == 8) {
				ret = (InfiniteScrollDirection) global::ApiDefinition.Messaging.UInt64_objc_msgSend (This.Handle, Selector.GetHandle ("infiniteScrollDirection"));
			} else {
				ret = (InfiniteScrollDirection) global::ApiDefinition.Messaging.UInt32_objc_msgSend (This.Handle, Selector.GetHandle ("infiniteScrollDirection"));
			}
			return ret;
		}
		
		[Export ("infiniteScrollIndicatorMargin")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat InfiniteScrollIndicatorMargin (this global::UIKit.UIScrollView This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("infiniteScrollIndicatorMargin"));
		}
		
		[Export ("infiniteScrollIndicatorStyle")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIActivityIndicatorViewStyle InfiniteScrollIndicatorStyle (this global::UIKit.UIScrollView This)
		{
			global::UIKit.UIActivityIndicatorViewStyle ret;
			if (IntPtr.Size == 8) {
				ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.Int64_objc_msgSend (This.Handle, Selector.GetHandle ("infiniteScrollIndicatorStyle"));
			} else {
				ret = (global::UIKit.UIActivityIndicatorViewStyle) global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("infiniteScrollIndicatorStyle"));
			}
			return ret;
		}
		
		[Export ("infiniteScrollIndicatorView")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::UIKit.UIView InfiniteScrollIndicatorView (this global::UIKit.UIScrollView This)
		{
			return  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("infiniteScrollIndicatorView")));
		}
		
		[Export ("infiniteScrollTriggerOffset")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static nfloat InfiniteScrollTriggerOffset (this global::UIKit.UIScrollView This)
		{
			return global::ApiDefinition.Messaging.nfloat_objc_msgSend (This.Handle, Selector.GetHandle ("infiniteScrollTriggerOffset"));
		}
		
		[Export ("removeInfiniteScroll")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RemoveInfiniteScroll (this global::UIKit.UIScrollView This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("removeInfiniteScroll"));
		}
		
		[Export ("setInfiniteScrollDirection:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInfiniteScrollDirection (this global::UIKit.UIScrollView This, InfiniteScrollDirection direction)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (This.Handle, Selector.GetHandle ("setInfiniteScrollDirection:"), (UInt64)direction);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt32 (This.Handle, Selector.GetHandle ("setInfiniteScrollDirection:"), (UInt32)direction);
			}
		}
		
		[Export ("setInfiniteScrollIndicatorMargin:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInfiniteScrollIndicatorMargin (this global::UIKit.UIScrollView This, nfloat margin)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setInfiniteScrollIndicatorMargin:"), margin);
		}
		
		[Export ("setInfiniteScrollIndicatorStyle:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInfiniteScrollIndicatorStyle (this global::UIKit.UIScrollView This, global::UIKit.UIActivityIndicatorViewStyle style)
		{
			if (IntPtr.Size == 8) {
				global::ApiDefinition.Messaging.void_objc_msgSend_Int64 (This.Handle, Selector.GetHandle ("setInfiniteScrollIndicatorStyle:"), (Int64)style);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setInfiniteScrollIndicatorStyle:"), (int)style);
			}
		}
		
		[Export ("setInfiniteScrollIndicatorView:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInfiniteScrollIndicatorView (this global::UIKit.UIScrollView This, global::UIKit.UIView indicator)
		{
			if (indicator == null)
				throw new ArgumentNullException ("indicator");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setInfiniteScrollIndicatorView:"), indicator.Handle);
		}
		
		[Export ("setInfiniteScrollTriggerOffset:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void SetInfiniteScrollTriggerOffset (this global::UIKit.UIScrollView This, nfloat offset)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (This.Handle, Selector.GetHandle ("setInfiniteScrollTriggerOffset:"), offset);
		}
		
		[Export ("setShouldShowInfiniteScrollHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetShouldShowInfiniteScrollHandler (this global::UIKit.UIScrollView This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V1))]global::System.Func<global::UIKit.UIScrollView, bool> handler)
		{
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlockUnsafe (Trampolines.SDFuncArity2V1.Handler, handler);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setShouldShowInfiniteScrollHandler:"), (IntPtr) block_ptr_handler);
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
		}
		
	} /* class UIScrollView_InfiniteScroll */
}
