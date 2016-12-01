// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// LogicComponent.cs
// 
// Copyright 2015 Xamarin Inc. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using Urho.Urho2D;
using Urho.Gui;
using Urho.Resources;
using Urho.IO;
using Urho.Navigation;
using Urho.Network;

namespace Urho
{
	/// <summary>
	/// Helper base class for user-defined game logic components that hooks up to update events and forwards them to virtual functions similar to ScriptInstance class.
	/// </summary>
	public unsafe partial class LogicComponent : Component
	{
		unsafe partial void OnLogicComponentCreated ();

		[Preserve]
		public LogicComponent (IntPtr handle) : base (handle)
		{
			OnLogicComponentCreated ();
		}

		[Preserve]
		protected LogicComponent (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnLogicComponentCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int LogicComponent_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (LogicComponent_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr LogicComponent_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (LogicComponent_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int LogicComponent_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(LogicComponent));
			return new StringHash (LogicComponent_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr LogicComponent_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(LogicComponent));
			return Marshal.PtrToStringAnsi (LogicComponent_GetTypeNameStatic ());
		}

		[Preserve]
		public LogicComponent () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr LogicComponent_LogicComponent (IntPtr context);

		[Preserve]
		public LogicComponent (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(LogicComponent));
			handle = LogicComponent_LogicComponent ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnLogicComponentCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void LogicComponent_OnSetEnabled (IntPtr handle);

		/// <summary>
		/// Handle enabled/disabled state change. Changes update event subscription.
		/// </summary>
		public override void OnSetEnabled ()
		{
			Runtime.ValidateRefCounted (this);
			LogicComponent_OnSetEnabled (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void LogicComponent_Start (IntPtr handle);

		/// <summary>
		/// Called when the component is added to a scene node. Other components may not yet exist.
		/// </summary>
		public void Start ()
		{
			Runtime.ValidateRefCounted (this);
			LogicComponent_Start (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void LogicComponent_DelayedStart (IntPtr handle);

		/// <summary>
		/// Called before the first update. At this point all other components of the node should exist. Will also be called if update events are not wanted; in that case the event is immediately unsubscribed afterward.
		/// </summary>
		public void DelayedStart ()
		{
			Runtime.ValidateRefCounted (this);
			LogicComponent_DelayedStart (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void LogicComponent_Stop (IntPtr handle);

		/// <summary>
		/// Called when the component is detached from a scene node, usually on destruction. Note that you will no longer have access to the node and scene at that point.
		/// </summary>
		public void Stop ()
		{
			Runtime.ValidateRefCounted (this);
			LogicComponent_Stop (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void LogicComponent_Update (IntPtr handle, float timeStep);

		/// <summary>
		/// Called on scene update, variable timestep.
		/// </summary>
		public void Update (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			LogicComponent_Update (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void LogicComponent_PostUpdate (IntPtr handle, float timeStep);

		/// <summary>
		/// Called on scene post-update, variable timestep.
		/// </summary>
		public void PostUpdate (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			LogicComponent_PostUpdate (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void LogicComponent_FixedUpdate (IntPtr handle, float timeStep);

		/// <summary>
		/// Called on physics update, fixed timestep.
		/// </summary>
		public void FixedUpdate (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			LogicComponent_FixedUpdate (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void LogicComponent_FixedPostUpdate (IntPtr handle, float timeStep);

		/// <summary>
		/// Called on physics post-update, fixed timestep.
		/// </summary>
		public void FixedPostUpdate (float timeStep)
		{
			Runtime.ValidateRefCounted (this);
			LogicComponent_FixedPostUpdate (handle, timeStep);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void LogicComponent_SetUpdateEventMask (IntPtr handle, byte mask);

		/// <summary>
		/// Set what update events should be subscribed to. Use this for optimization: by default all are in use. Note that this is not an attribute and is not saved or network-serialized, therefore it should always be called eg. in the subclass constructor.
		/// </summary>
		private void SetUpdateEventMask (byte mask)
		{
			Runtime.ValidateRefCounted (this);
			LogicComponent_SetUpdateEventMask (handle, mask);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte LogicComponent_GetUpdateEventMask (IntPtr handle);

		/// <summary>
		/// Return what update events are subscribed to.
		/// </summary>
		private byte GetUpdateEventMask ()
		{
			Runtime.ValidateRefCounted (this);
			return LogicComponent_GetUpdateEventMask (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool LogicComponent_IsDelayedStartCalled (IntPtr handle);

		/// <summary>
		/// Return whether the DelayedStart() function has been called.
		/// </summary>
		private bool IsDelayedStartCalled ()
		{
			Runtime.ValidateRefCounted (this);
			return LogicComponent_IsDelayedStartCalled (handle);
		}

		public override StringHash Type {
			get {
				return UrhoGetType ();
			}
		}

		public override string TypeName {
			get {
				return GetTypeName ();
			}
		}

		[Preserve]
		public new static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public new static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}

		/// <summary>
		/// Return what update events are subscribed to.
		/// Or
		/// Set what update events should be subscribed to. Use this for optimization: by default all are in use. Note that this is not an attribute and is not saved or network-serialized, therefore it should always be called eg. in the subclass constructor.
		/// </summary>
		public byte UpdateEventMask {
			get {
				return GetUpdateEventMask ();
			}
			set {
				SetUpdateEventMask (value);
			}
		}

		/// <summary>
		/// Return whether the DelayedStart() function has been called.
		/// </summary>
		public bool DelayedStartCalled {
			get {
				return IsDelayedStartCalled ();
			}
		}
	}
}
