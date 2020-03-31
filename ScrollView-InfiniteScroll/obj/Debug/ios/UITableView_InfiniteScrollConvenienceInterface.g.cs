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
	public unsafe static partial class UITableView_InfiniteScrollConvenienceInterface  {
		
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("UITableView");
		
		[Export ("addInfiniteScrollWithHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void AddInfiniteScrollWithHandler (this global::UIKit.UITableView This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::UIKit.UITableView> handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlockUnsafe (Trampolines.SDActionArity1V2.Handler, handler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("addInfiniteScrollWithHandler:"), (IntPtr) block_ptr_handler);
			block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("finishInfiniteScrollWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void FinishInfiniteScrollWithCompletion (this global::UIKit.UITableView This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V2))]global::System.Action<global::UIKit.UITableView> handler)
		{
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			if (handler == null){
				block_ptr_handler = null;
			} else {
				block_handler = new BlockLiteral ();
				block_ptr_handler = &block_handler;
				block_handler.SetupBlockUnsafe (Trampolines.SDActionArity1V2.Handler, handler);
			}
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("finishInfiniteScrollWithCompletion:"), (IntPtr) block_ptr_handler);
			if (block_ptr_handler != null)
				block_ptr_handler->CleanupBlock ();
			
		}
		
		[Export ("setShouldShowInfiniteScrollHandler:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void SetShouldShowInfiniteScrollHandler (this global::UIKit.UITableView This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDFuncArity2V2))]global::System.Func<global::UIKit.UITableView, bool> handler)
		{
			if (handler == null)
				throw new ArgumentNullException ("handler");
			BlockLiteral *block_ptr_handler;
			BlockLiteral block_handler;
			block_handler = new BlockLiteral ();
			block_ptr_handler = &block_handler;
			block_handler.SetupBlockUnsafe (Trampolines.SDFuncArity2V2.Handler, handler);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setShouldShowInfiniteScrollHandler:"), (IntPtr) block_ptr_handler);
			block_ptr_handler->CleanupBlock ();
			
		}
		
	} /* class UITableView_InfiniteScrollConvenienceInterface */
}
