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

namespace ObjCRuntime {
	
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::UIKit.UICollectionView>))]
		internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			static internal readonly DActionArity1V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::UIKit.UICollectionView>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<UICollectionView> (obj));
			}
		} /* class SDActionArity1V0 */
		
		internal sealed class NIDActionArity1V0 : TrampolineBlockBase {
			DActionArity1V0 invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::UIKit.UICollectionView> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::UIKit.UICollectionView>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::UIKit.UICollectionView obj)
			{
				invoker (BlockPointer, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::UIKit.UIScrollView>))]
		internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			static internal readonly DActionArity1V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::UIKit.UIScrollView>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<UIScrollView> (obj));
			}
		} /* class SDActionArity1V1 */
		
		internal sealed class NIDActionArity1V1 : TrampolineBlockBase {
			DActionArity1V1 invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::UIKit.UIScrollView> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::UIKit.UIScrollView>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::UIKit.UIScrollView obj)
			{
				invoker (BlockPointer, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::UIKit.UITableView>))]
		internal delegate void DActionArity1V2 (IntPtr block, IntPtr obj);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V2 {
			static internal readonly DActionArity1V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DActionArity1V2))]
			static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Action<global::UIKit.UITableView>) (descriptor->Target);
				if (del != null)
					del ( Runtime.GetNSObject<UITableView> (obj));
			}
		} /* class SDActionArity1V2 */
		
		internal sealed class NIDActionArity1V2 : TrampolineBlockBase {
			DActionArity1V2 invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V2 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V2> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::UIKit.UITableView> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::UIKit.UITableView>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V2 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::UIKit.UITableView obj)
			{
				invoker (BlockPointer, obj == null ? IntPtr.Zero : obj.Handle);
			}
		} /* class NIDActionArity1V2 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Func<global::UIKit.UICollectionView, bool>))]
		internal delegate bool DFuncArity2V0 (IntPtr block, IntPtr arg);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V0 {
			static internal readonly DFuncArity2V0 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity2V0))]
			static unsafe bool Invoke (IntPtr block, IntPtr arg) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<global::UIKit.UICollectionView, bool>) (descriptor->Target);
				System.Boolean retval = del ( Runtime.GetNSObject<UICollectionView> (arg));
				return retval;
			}
		} /* class SDFuncArity2V0 */
		
		internal sealed class NIDFuncArity2V0 : TrampolineBlockBase {
			DFuncArity2V0 invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDFuncArity2V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DFuncArity2V0> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Func<global::UIKit.UICollectionView, bool> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Func<global::UIKit.UICollectionView, bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDFuncArity2V0 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe bool Invoke (global::UIKit.UICollectionView arg)
			{
				var ret = invoker (BlockPointer, arg == null ? IntPtr.Zero : arg.Handle);
				return ret;
			}
		} /* class NIDFuncArity2V0 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Func<global::UIKit.UIScrollView, bool>))]
		internal delegate bool DFuncArity2V1 (IntPtr block, IntPtr arg);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V1 {
			static internal readonly DFuncArity2V1 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity2V1))]
			static unsafe bool Invoke (IntPtr block, IntPtr arg) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<global::UIKit.UIScrollView, bool>) (descriptor->Target);
				System.Boolean retval = del ( Runtime.GetNSObject<UIScrollView> (arg));
				return retval;
			}
		} /* class SDFuncArity2V1 */
		
		internal sealed class NIDFuncArity2V1 : TrampolineBlockBase {
			DFuncArity2V1 invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDFuncArity2V1 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DFuncArity2V1> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Func<global::UIKit.UIScrollView, bool> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Func<global::UIKit.UIScrollView, bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDFuncArity2V1 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe bool Invoke (global::UIKit.UIScrollView arg)
			{
				var ret = invoker (BlockPointer, arg == null ? IntPtr.Zero : arg.Handle);
				return ret;
			}
		} /* class NIDFuncArity2V1 */
		
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Func<global::UIKit.UITableView, bool>))]
		internal delegate bool DFuncArity2V2 (IntPtr block, IntPtr arg);
		
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDFuncArity2V2 {
			static internal readonly DFuncArity2V2 Handler = Invoke;
			
			[MonoPInvokeCallback (typeof (DFuncArity2V2))]
			static unsafe bool Invoke (IntPtr block, IntPtr arg) {
				var descriptor = (BlockLiteral *) block;
				var del = (global::System.Func<global::UIKit.UITableView, bool>) (descriptor->Target);
				System.Boolean retval = del ( Runtime.GetNSObject<UITableView> (arg));
				return retval;
			}
		} /* class SDFuncArity2V2 */
		
		internal sealed class NIDFuncArity2V2 : TrampolineBlockBase {
			DFuncArity2V2 invoker;
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDFuncArity2V2 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DFuncArity2V2> ();
			}
			
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Func<global::UIKit.UITableView, bool> Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Func<global::UIKit.UITableView, bool>) GetExistingManagedDelegate (block);
				return del ?? new NIDFuncArity2V2 ((BlockLiteral *) block).Invoke;
			}
			
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe bool Invoke (global::UIKit.UITableView arg)
			{
				var ret = invoker (BlockPointer, arg == null ? IntPtr.Zero : arg.Handle);
				return ret;
			}
		} /* class NIDFuncArity2V2 */
	}
}
