// WARNING - AUTOGENERATED - DO NOT EDIT
// 
// Generated using `sharpie urho`
// 
// ResourceCache.cs
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

namespace Urho.Resources
{
	/// <summary>
	/// %Resource cache subsystem. Loads resources on demand and stores them for later access.
	/// </summary>
	public unsafe partial class ResourceCache : UrhoObject
	{
		unsafe partial void OnResourceCacheCreated ();

		[Preserve]
		public ResourceCache (IntPtr handle) : base (handle)
		{
			OnResourceCacheCreated ();
		}

		[Preserve]
		protected ResourceCache (UrhoObjectFlag emptyFlag) : base (emptyFlag)
		{
			OnResourceCacheCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ResourceCache_GetType (IntPtr handle);

		private StringHash UrhoGetType ()
		{
			Runtime.ValidateRefCounted (this);
			return new StringHash (ResourceCache_GetType (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_GetTypeName (IntPtr handle);

		private string GetTypeName ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ResourceCache_GetTypeName (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ResourceCache_GetTypeStatic ();

		private static StringHash GetTypeStatic ()
		{
			Runtime.Validate (typeof(ResourceCache));
			return new StringHash (ResourceCache_GetTypeStatic ());
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_GetTypeNameStatic ();

		private static string GetTypeNameStatic ()
		{
			Runtime.Validate (typeof(ResourceCache));
			return Marshal.PtrToStringAnsi (ResourceCache_GetTypeNameStatic ());
		}

		[Preserve]
		public ResourceCache () : this (Application.CurrentContext)
		{
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_ResourceCache (IntPtr context);

		[Preserve]
		public ResourceCache (Context context) : base (UrhoObjectFlag.Empty)
		{
			Runtime.Validate (typeof(ResourceCache));
			handle = ResourceCache_ResourceCache ((object)context == null ? IntPtr.Zero : context.Handle);
			Runtime.RegisterObject (this);
			OnResourceCacheCreated ();
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceCache_AddResourceDir (IntPtr handle, string pathName, uint priority);

		/// <summary>
		/// Add a resource load directory. Optional priority parameter which will control search order.
		/// </summary>
		public bool AddResourceDir (string pathName, uint priority)
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_AddResourceDir (handle, pathName, priority);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceCache_AddPackageFile (IntPtr handle, IntPtr package, uint priority);

		/// <summary>
		/// Add a package file for loading resources from. Optional priority parameter which will control search order.
		/// </summary>
		public bool AddPackageFile (PackageFile package, uint priority)
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_AddPackageFile (handle, (object)package == null ? IntPtr.Zero : package.Handle, priority);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceCache_AddPackageFile0 (IntPtr handle, string fileName, uint priority);

		/// <summary>
		/// Add a package file for loading resources from by name. Optional priority parameter which will control search order.
		/// </summary>
		public bool AddPackageFile (string fileName, uint priority)
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_AddPackageFile0 (handle, fileName, priority);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceCache_AddManualResource (IntPtr handle, IntPtr resource);

		/// <summary>
		/// Add a manually created resource. Must be uniquely named.
		/// </summary>
		public bool AddManualResource (Resource resource)
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_AddManualResource (handle, (object)resource == null ? IntPtr.Zero : resource.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_RemoveResourceDir (IntPtr handle, string pathName);

		/// <summary>
		/// Remove a resource load directory.
		/// </summary>
		public void RemoveResourceDir (string pathName)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_RemoveResourceDir (handle, pathName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_RemovePackageFile (IntPtr handle, IntPtr package, bool releaseResources, bool forceRelease);

		/// <summary>
		/// Remove a package file. Optionally release the resources loaded from it.
		/// </summary>
		public void RemovePackageFile (PackageFile package, bool releaseResources, bool forceRelease)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_RemovePackageFile (handle, (object)package == null ? IntPtr.Zero : package.Handle, releaseResources, forceRelease);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_RemovePackageFile1 (IntPtr handle, string fileName, bool releaseResources, bool forceRelease);

		/// <summary>
		/// Remove a package file by name. Optionally release the resources loaded from it.
		/// </summary>
		public void RemovePackageFile (string fileName, bool releaseResources, bool forceRelease)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_RemovePackageFile1 (handle, fileName, releaseResources, forceRelease);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_ReleaseResource (IntPtr handle, int type, string name, bool force);

		/// <summary>
		/// Release a resource by name.
		/// </summary>
		public void ReleaseResource (StringHash type, string name, bool force)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_ReleaseResource (handle, type.Code, name, force);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_ReleaseResources (IntPtr handle, int type, bool force);

		/// <summary>
		/// Release all resources of a specific type.
		/// </summary>
		public void ReleaseResources (StringHash type, bool force)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_ReleaseResources (handle, type.Code, force);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_ReleaseResources2 (IntPtr handle, int type, string partialName, bool force);

		/// <summary>
		/// Release resources of a specific type and partial name.
		/// </summary>
		public void ReleaseResources (StringHash type, string partialName, bool force)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_ReleaseResources2 (handle, type.Code, partialName, force);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_ReleaseResources3 (IntPtr handle, string partialName, bool force);

		/// <summary>
		/// Release resources of all types by partial name.
		/// </summary>
		public void ReleaseResources (string partialName, bool force)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_ReleaseResources3 (handle, partialName, force);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_ReleaseAllResources (IntPtr handle, bool force);

		/// <summary>
		/// Release all resources. When called with the force flag false, releases all currently unused resources.
		/// </summary>
		public void ReleaseAllResources (bool force)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_ReleaseAllResources (handle, force);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceCache_ReloadResource (IntPtr handle, IntPtr resource);

		/// <summary>
		/// Reload a resource. Return true on success. The resource will not be removed from the cache in case of failure.
		/// </summary>
		public bool ReloadResource (Resource resource)
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_ReloadResource (handle, (object)resource == null ? IntPtr.Zero : resource.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_ReloadResourceWithDependencies (IntPtr handle, string fileName);

		/// <summary>
		/// Reload a resource based on filename. Causes also reload of dependent resources if necessary.
		/// </summary>
		public void ReloadResourceWithDependencies (string fileName)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_ReloadResourceWithDependencies (handle, fileName);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_SetMemoryBudget (IntPtr handle, int type, ulong budget);

		/// <summary>
		/// Set memory budget for a specific resource type, default 0 is unlimited.
		/// </summary>
		public void SetMemoryBudget (StringHash type, ulong budget)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_SetMemoryBudget (handle, type.Code, budget);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_SetAutoReloadResources (IntPtr handle, bool enable);

		/// <summary>
		/// Enable or disable automatic reloading of resources as files are modified. Default false.
		/// </summary>
		private void SetAutoReloadResources (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_SetAutoReloadResources (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_SetReturnFailedResources (IntPtr handle, bool enable);

		/// <summary>
		/// Enable or disable returning resources that failed to load. Default false. This may be useful in editing to not lose resource ref attributes.
		/// </summary>
		private void SetReturnFailedResources (bool enable)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_SetReturnFailedResources (handle, enable);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_SetSearchPackagesFirst (IntPtr handle, bool value);

		/// <summary>
		/// Define whether when getting resources should check package files or directories first. True for packages, false for directories.
		/// </summary>
		private void SetSearchPackagesFirst (bool value)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_SetSearchPackagesFirst (handle, value);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_SetFinishBackgroundResourcesMs (IntPtr handle, int ms);

		/// <summary>
		/// Set how many milliseconds maximum per frame to spend on finishing background loaded resources.
		/// </summary>
		private void SetFinishBackgroundResourcesMs (int ms)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_SetFinishBackgroundResourcesMs (handle, ms);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_AddResourceRouter (IntPtr handle, IntPtr router, bool addAsFirst);

		/// <summary>
		/// Add a resource router object. By default there is none, so the routing process is skipped.
		/// </summary>
		public void AddResourceRouter (ResourceRouter router, bool addAsFirst)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_AddResourceRouter (handle, (object)router == null ? IntPtr.Zero : router.Handle, addAsFirst);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_RemoveResourceRouter (IntPtr handle, IntPtr router);

		/// <summary>
		/// Remove a resource router object.
		/// </summary>
		public void RemoveResourceRouter (ResourceRouter router)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_RemoveResourceRouter (handle, (object)router == null ? IntPtr.Zero : router.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_GetFile (IntPtr handle, string name, bool sendEventOnFailure);

		/// <summary>
		/// Open and return a file from the resource load paths or from inside a package file. If not found, use a fallback search with absolute path. Return null if fails. Can be called from outside the main thread.
		/// </summary>
		public File GetFile (string name, bool sendEventOnFailure)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupRefCounted<File> (ResourceCache_GetFile (handle, name, sendEventOnFailure));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_GetResource (IntPtr handle, int type, string name, bool sendEventOnFailure);

		/// <summary>
		/// Return a resource by type and name. Load if not loaded yet. Return null if not found or if fails, unless SetReturnFailedResources(true) has been called. Can be called only from the main thread.
		/// </summary>
		public Resource GetResource (StringHash type, string name, bool sendEventOnFailure)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Resource> (ResourceCache_GetResource (handle, type.Code, name, sendEventOnFailure));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_GetTempResource (IntPtr handle, int type, string name, bool sendEventOnFailure);

		/// <summary>
		/// Load a resource without storing it in the resource cache. Return null if not found or if fails. Can be called from outside the main thread if the resource itself is safe to load completely (it does not possess for example GPU data.)
		/// </summary>
		public Resource GetTempResource (StringHash type, string name, bool sendEventOnFailure)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupRefCounted<Resource> (ResourceCache_GetTempResource (handle, type.Code, name, sendEventOnFailure));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceCache_BackgroundLoadResource (IntPtr handle, int type, string name, bool sendEventOnFailure, IntPtr caller);

		/// <summary>
		/// Background load a resource. An event will be sent when complete. Return true if successfully stored to the load queue, false if eg. already exists. Can be called from outside the main thread.
		/// </summary>
		public bool BackgroundLoadResource (StringHash type, string name, bool sendEventOnFailure, Resource caller)
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_BackgroundLoadResource (handle, type.Code, name, sendEventOnFailure, (object)caller == null ? IntPtr.Zero : caller.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint ResourceCache_GetNumBackgroundLoadResources (IntPtr handle);

		/// <summary>
		/// Return number of pending background-loaded resources.
		/// </summary>
		private uint GetNumBackgroundLoadResources ()
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_GetNumBackgroundLoadResources (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_GetExistingResource (IntPtr handle, int type, string name);

		/// <summary>
		/// Return an already loaded resource of specific type
		/// &
		/// name, or null if not found. Will not load if does not exist.
		/// </summary>
		public Resource GetExistingResource (StringHash type, string name)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<Resource> (ResourceCache_GetExistingResource (handle, type.Code, name));
		}

		private IReadOnlyList<PackageFile> _GetPackageFiles_cache;

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_GetPackageFiles (IntPtr handle);

		/// <summary>
		/// Return added package files.
		/// </summary>
		private IReadOnlyList<PackageFile> GetPackageFiles ()
		{
			Runtime.ValidateRefCounted (this);
			return _GetPackageFiles_cache != null ? _GetPackageFiles_cache : _GetPackageFiles_cache = Runtime.CreateVectorSharedPtrProxy<PackageFile> (ResourceCache_GetPackageFiles (handle));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceCache_Exists (IntPtr handle, string name);

		/// <summary>
		/// Return whether a file exists by name.
		/// </summary>
		public bool Exists (string name)
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_Exists (handle, name);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong ResourceCache_GetMemoryBudget (IntPtr handle, int type);

		/// <summary>
		/// Return memory budget for a resource type.
		/// </summary>
		public ulong GetMemoryBudget (StringHash type)
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_GetMemoryBudget (handle, type.Code);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong ResourceCache_GetMemoryUse (IntPtr handle, int type);

		/// <summary>
		/// Return total memory use for a resource type.
		/// </summary>
		public ulong GetMemoryUse (StringHash type)
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_GetMemoryUse (handle, type.Code);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong ResourceCache_GetTotalMemoryUse (IntPtr handle);

		/// <summary>
		/// Return total memory use for all resources.
		/// </summary>
		private ulong GetTotalMemoryUse ()
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_GetTotalMemoryUse (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_GetResourceFileName (IntPtr handle, string name);

		/// <summary>
		/// Return full absolute file name of resource if possible, or empty if not found.
		/// </summary>
		public string GetResourceFileName (string name)
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ResourceCache_GetResourceFileName (handle, name));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceCache_GetAutoReloadResources (IntPtr handle);

		/// <summary>
		/// Return whether automatic resource reloading is enabled.
		/// </summary>
		private bool GetAutoReloadResources ()
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_GetAutoReloadResources (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceCache_GetReturnFailedResources (IntPtr handle);

		/// <summary>
		/// Return whether resources that failed to load are returned.
		/// </summary>
		private bool GetReturnFailedResources ()
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_GetReturnFailedResources (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool ResourceCache_GetSearchPackagesFirst (IntPtr handle);

		/// <summary>
		/// Return whether when getting resources should check package files or directories first.
		/// </summary>
		private bool GetSearchPackagesFirst ()
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_GetSearchPackagesFirst (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern int ResourceCache_GetFinishBackgroundResourcesMs (IntPtr handle);

		/// <summary>
		/// Return how many milliseconds maximum to spend on finishing background loaded resources.
		/// </summary>
		private int GetFinishBackgroundResourcesMs ()
		{
			Runtime.ValidateRefCounted (this);
			return ResourceCache_GetFinishBackgroundResourcesMs (handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_GetResourceRouter (IntPtr handle, uint index);

		/// <summary>
		/// Return a resource router by index.
		/// </summary>
		public ResourceRouter GetResourceRouter (uint index)
		{
			Runtime.ValidateRefCounted (this);
			return Runtime.LookupObject<ResourceRouter> (ResourceCache_GetResourceRouter (handle, index));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_GetPreferredResourceDir (IntPtr handle, string path);

		/// <summary>
		/// Return either the path itself or its parent, based on which of them has recognized resource subdirectories.
		/// </summary>
		public string GetPreferredResourceDir (string path)
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ResourceCache_GetPreferredResourceDir (handle, path));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_SanitateResourceName (IntPtr handle, string name);

		/// <summary>
		/// Remove unsupported constructs from the resource name to prevent ambiguity, and normalize absolute filename to resource path relative if possible.
		/// </summary>
		public string SanitateResourceName (string name)
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ResourceCache_SanitateResourceName (handle, name));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_SanitateResourceDirName (IntPtr handle, string name);

		/// <summary>
		/// Remove unnecessary constructs from a resource directory name and ensure it to be an absolute path.
		/// </summary>
		public string SanitateResourceDirName (string name)
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ResourceCache_SanitateResourceDirName (handle, name));
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_StoreResourceDependency (IntPtr handle, IntPtr resource, string dependency);

		/// <summary>
		/// Store a dependency for a resource. If a dependency file changes, the resource will be reloaded.
		/// </summary>
		public void StoreResourceDependency (Resource resource, string dependency)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_StoreResourceDependency (handle, (object)resource == null ? IntPtr.Zero : resource.Handle, dependency);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern void ResourceCache_ResetDependencies (IntPtr handle, IntPtr resource);

		/// <summary>
		/// Reset dependencies for a resource.
		/// </summary>
		public void ResetDependencies (Resource resource)
		{
			Runtime.ValidateRefCounted (this);
			ResourceCache_ResetDependencies (handle, (object)resource == null ? IntPtr.Zero : resource.Handle);
		}

		[DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr ResourceCache_PrintMemoryUsage (IntPtr handle);

		/// <summary>
		/// Returns a formatted string containing the memory actively used.
		/// </summary>
		public string PrintMemoryUsage ()
		{
			Runtime.ValidateRefCounted (this);
			return Marshal.PtrToStringAnsi (ResourceCache_PrintMemoryUsage (handle));
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

		/// <summary>
		/// Return whether automatic resource reloading is enabled.
		/// Or
		/// Enable or disable automatic reloading of resources as files are modified. Default false.
		/// </summary>
		public bool AutoReloadResources {
			get {
				return GetAutoReloadResources ();
			}
			set {
				SetAutoReloadResources (value);
			}
		}

		/// <summary>
		/// Return whether resources that failed to load are returned.
		/// Or
		/// Enable or disable returning resources that failed to load. Default false. This may be useful in editing to not lose resource ref attributes.
		/// </summary>
		public bool ReturnFailedResources {
			get {
				return GetReturnFailedResources ();
			}
			set {
				SetReturnFailedResources (value);
			}
		}

		/// <summary>
		/// Return whether when getting resources should check package files or directories first.
		/// Or
		/// Define whether when getting resources should check package files or directories first. True for packages, false for directories.
		/// </summary>
		public bool SearchPackagesFirst {
			get {
				return GetSearchPackagesFirst ();
			}
			set {
				SetSearchPackagesFirst (value);
			}
		}

		/// <summary>
		/// Return how many milliseconds maximum to spend on finishing background loaded resources.
		/// Or
		/// Set how many milliseconds maximum per frame to spend on finishing background loaded resources.
		/// </summary>
		public int FinishBackgroundResourcesMs {
			get {
				return GetFinishBackgroundResourcesMs ();
			}
			set {
				SetFinishBackgroundResourcesMs (value);
			}
		}

		/// <summary>
		/// Return number of pending background-loaded resources.
		/// </summary>
		public uint NumBackgroundLoadResources {
			get {
				return GetNumBackgroundLoadResources ();
			}
		}

		/// <summary>
		/// Return added package files.
		/// </summary>
		public IReadOnlyList<PackageFile> PackageFiles {
			get {
				return GetPackageFiles ();
			}
		}

		/// <summary>
		/// Return total memory use for all resources.
		/// </summary>
		public ulong TotalMemoryUse {
			get {
				return GetTotalMemoryUse ();
			}
		}
	}
}
