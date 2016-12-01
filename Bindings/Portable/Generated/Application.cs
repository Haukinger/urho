// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// Application.cs
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
	/// Base class for creating applications which initialize the Urho3D engine and run a main loop until exited.
	/// </summary>
	public partial class Application : UrhoObject
	{
		unsafe partial void OnApplicationCreated ();

		[Preserve]
		public Application (IntPtr handle) : base (handle)
		{
			OnApplicationCreated ();
		}

		[Preserve]
		protected Application (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnApplicationCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Application_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (Application_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Application_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (Application_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Application_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(Application));
			return new StringHash (Application_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr Application_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(Application));
			return Marshal.PtrToStringAnsi (Application_GetTypeNameStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int Application_Run (IntPtr handle);

		/// <summary>
		/// Initialize the engine and run the main loop, then return the application exit code. Catch out-of-memory exceptions while running.
		/// </summary>
		public int Run ()
		{
			return Application_Run (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void Application_ErrorExit (IntPtr handle, string message);

		/// <summary>
		/// Show an error message (last log message if empty), terminate the main loop, and set failure exit code.
		/// </summary>
		public void ErrorExit (string message)
		{
			Runtime.ValidateRefCounted (this);
			Application_ErrorExit (handle, message);
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
		public static StringHash TypeStatic {
			get {
				return GetTypeStatic ();
			}
		}

		public static string TypeNameStatic {
			get {
				return GetTypeNameStatic ();
			}
		}
	}
}
