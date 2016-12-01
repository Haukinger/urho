// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// CollisionBox2D.cs
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

namespace Urho.Urho2D
{
	/// <summary>
	/// 2D box collision component.
	/// </summary>
	public unsafe partial class CollisionBox2D : CollisionShape2D
	{
		unsafe partial void OnCollisionBox2DCreated ();

		[Preserve]
		public CollisionBox2D (IntPtr handle) : base (handle)
		{
			OnCollisionBox2DCreated ();
		}

		[Preserve]
		protected CollisionBox2D (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnCollisionBox2DCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int CollisionBox2D_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (CollisionBox2D_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr CollisionBox2D_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (CollisionBox2D_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int CollisionBox2D_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(CollisionBox2D));
			return new StringHash (CollisionBox2D_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr CollisionBox2D_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(CollisionBox2D));
			return Marshal.PtrToStringAnsi (CollisionBox2D_GetTypeNameStatic ());
		}

		[Preserve]
		public CollisionBox2D () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr CollisionBox2D_CollisionBox2D (IntPtr context);

		[Preserve]
		public CollisionBox2D (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(CollisionBox2D));
			handle = CollisionBox2D_CollisionBox2D ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnCollisionBox2DCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CollisionBox2D_RegisterObject (IntPtr context);

		/// <summary>
		/// Register object factory.
		/// </summary>
		public new static void RegisterObject (Context context)
		{
			Runtime.Validate (typeof(CollisionBox2D));
			CollisionBox2D_RegisterObject ((object)context == null ? IntPtr.Zero : context.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CollisionBox2D_SetSize (IntPtr handle, ref Urho.Vector2 size);

		/// <summary>
		/// Set size.
		/// </summary>
		private void SetSize (Urho.Vector2 size)
		{
			Runtime.ValidateRefCounted (this);
			CollisionBox2D_SetSize (handle, ref size);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CollisionBox2D_SetSize0 (IntPtr handle, float width, float height);

		/// <summary>
		/// Set size.
		/// </summary>
		public void SetSize (float width, float height)
		{
			Runtime.ValidateRefCounted (this);
			CollisionBox2D_SetSize0 (handle, width, height);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CollisionBox2D_SetCenter (IntPtr handle, ref Urho.Vector2 center);

		/// <summary>
		/// Set center.
		/// </summary>
		private void SetCenter (Urho.Vector2 center)
		{
			Runtime.ValidateRefCounted (this);
			CollisionBox2D_SetCenter (handle, ref center);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CollisionBox2D_SetCenter1 (IntPtr handle, float x, float y);

		/// <summary>
		/// Set center.
		/// </summary>
		public void SetCenter (float x, float y)
		{
			Runtime.ValidateRefCounted (this);
			CollisionBox2D_SetCenter1 (handle, x, y);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void CollisionBox2D_SetAngle (IntPtr handle, float angle);

		/// <summary>
		/// Set angle.
		/// </summary>
		private void SetAngle (float angle)
		{
			Runtime.ValidateRefCounted (this);
			CollisionBox2D_SetAngle (handle, angle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector2 CollisionBox2D_GetSize (IntPtr handle);

		/// <summary>
		/// Return size.
		/// </summary>
		private Urho.Vector2 GetSize ()
		{
			Runtime.ValidateRefCounted (this);
			return CollisionBox2D_GetSize (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern Urho.Vector2 CollisionBox2D_GetCenter (IntPtr handle);

		/// <summary>
		/// Return center.
		/// </summary>
		private Urho.Vector2 GetCenter ()
		{
			Runtime.ValidateRefCounted (this);
			return CollisionBox2D_GetCenter (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern float CollisionBox2D_GetAngle (IntPtr handle);

		/// <summary>
		/// Return angle.
		/// </summary>
		private float GetAngle ()
		{
			Runtime.ValidateRefCounted (this);
			return CollisionBox2D_GetAngle (handle);
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
		/// Return size.
		/// Or
		/// Set size.
		/// </summary>
		public Urho.Vector2 Size {
			get {
				return GetSize ();
			}
			set {
				SetSize (value);
			}
		}

		/// <summary>
		/// Return center.
		/// Or
		/// Set center.
		/// </summary>
		public Urho.Vector2 Center {
			get {
				return GetCenter ();
			}
			set {
				SetCenter (value);
			}
		}

		/// <summary>
		/// Return angle.
		/// Or
		/// Set angle.
		/// </summary>
		public float Angle {
			get {
				return GetAngle ();
			}
			set {
				SetAngle (value);
			}
		}
	}
}
