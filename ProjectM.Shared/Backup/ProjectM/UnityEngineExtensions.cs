// Decompiled with JetBrains decompiler
// Type: ProjectM.UnityEngineExtensions
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public static class UnityEngineExtensions : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPrefab_Public_Static_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPrefab_Public_Static_Boolean_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsAsset_Public_Static_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsPartOfSamePrefab_Public_Static_Boolean_GameObject_GameObject_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765787, XrefRangeEnd = 765791, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsPrefab(this UnityEngine.Object @this)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @this);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnityEngineExtensions.NativeMethodInfoPtr_IsPrefab_Public_Static_Boolean_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsPrefab(this GameObject @this)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @this);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnityEngineExtensions.NativeMethodInfoPtr_IsPrefab_Public_Static_Boolean_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765791, XrefRangeEnd = 765793, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsAsset(this UnityEngine.Object @this)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @this);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnityEngineExtensions.NativeMethodInfoPtr_IsAsset_Public_Static_Boolean_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765793, XrefRangeEnd = 765796, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsPartOfSamePrefab(this GameObject @this, GameObject targetPrefab)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) @this);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) targetPrefab);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnityEngineExtensions.NativeMethodInfoPtr_IsPartOfSamePrefab_Public_Static_Boolean_GameObject_GameObject_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static UnityEngineExtensions()
    {
      Il2CppClassPointerStore<UnityEngineExtensions>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnityEngineExtensions));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnityEngineExtensions>.NativeClassPtr);
      UnityEngineExtensions.NativeMethodInfoPtr_IsPrefab_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngineExtensions>.NativeClassPtr, 100667658);
      UnityEngineExtensions.NativeMethodInfoPtr_IsPrefab_Public_Static_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngineExtensions>.NativeClassPtr, 100667659);
      UnityEngineExtensions.NativeMethodInfoPtr_IsAsset_Public_Static_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngineExtensions>.NativeClassPtr, 100667660);
      UnityEngineExtensions.NativeMethodInfoPtr_IsPartOfSamePrefab_Public_Static_Boolean_GameObject_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnityEngineExtensions>.NativeClassPtr, 100667661);
    }

    public UnityEngineExtensions(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
