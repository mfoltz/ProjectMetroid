// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.RecursiveComponentAttaching
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using UnityEngine;

#nullable disable
namespace ProjectM.Terrain
{
  public static class RecursiveComponentAttaching : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_AttachRecursiveComponent_Public_Static_Void_GameObjectConversionSystem_Transform_TComp_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AttachRecursiveSharedComponent_Public_Static_Void_GameObjectConversionSystem_Transform_TComp_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766968, XrefRangeEnd = 767019, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AttachRecursiveComponent<TComp>(
      GameObjectConversionSystem conversionSystem,
      Transform transform,
      TComp valueToAttach)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TComp& local1;
      if (!typeof (TComp).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TComp> local2 = (object) valueToAttach;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TComp&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TComp&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref valueToAttach;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecursiveComponentAttaching.MethodInfoStoreGeneric_AttachRecursiveComponent_Public_Static_Void_GameObjectConversionSystem_Transform_TComp_0<TComp>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 767067, RefRangeEnd = 767068, XrefRangeStart = 767019, XrefRangeEnd = 767067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void AttachRecursiveSharedComponent<TComp>(
      GameObjectConversionSystem conversionSystem,
      Transform transform,
      TComp valueToAttach)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) transform);
      System.IntPtr num = (System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr));
      // ISSUE: variable of a reference type
      TComp& local1;
      if (!typeof (TComp).IsValueType)
      {
        // ISSUE: variable of a boxed type
        __Boxed<TComp> local2 = (object) valueToAttach;
        // ISSUE: cast to a reference type
        // ISSUE: cast to a reference type
        local1 = local2 is string ? (TComp&) IL2CPP.ManagedStringToIl2Cpp(local2 as string) : (TComp&) IL2CPP.Il2CppObjectBaseToPtr(local2 as Il2CppObjectBase);
      }
      else
        local1 = ref valueToAttach;
      *(System.IntPtr*) num = (System.IntPtr) ref local1;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(RecursiveComponentAttaching.MethodInfoStoreGeneric_AttachRecursiveSharedComponent_Public_Static_Void_GameObjectConversionSystem_Transform_TComp_0<TComp>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static RecursiveComponentAttaching()
    {
      Il2CppClassPointerStore<RecursiveComponentAttaching>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (RecursiveComponentAttaching));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RecursiveComponentAttaching>.NativeClassPtr);
      RecursiveComponentAttaching.NativeMethodInfoPtr_AttachRecursiveComponent_Public_Static_Void_GameObjectConversionSystem_Transform_TComp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecursiveComponentAttaching>.NativeClassPtr, 100667834);
      RecursiveComponentAttaching.NativeMethodInfoPtr_AttachRecursiveSharedComponent_Public_Static_Void_GameObjectConversionSystem_Transform_TComp_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RecursiveComponentAttaching>.NativeClassPtr, 100667835);
    }

    public RecursiveComponentAttaching(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_AttachRecursiveComponent_Public_Static_Void_GameObjectConversionSystem_Transform_TComp_0<TComp>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(RecursiveComponentAttaching.NativeMethodInfoPtr_AttachRecursiveComponent_Public_Static_Void_GameObjectConversionSystem_Transform_TComp_0, Il2CppClassPointerStore<RecursiveComponentAttaching>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComp>.NativeClassPtr))
      }))));
    }

    private sealed class MethodInfoStoreGeneric_AttachRecursiveSharedComponent_Public_Static_Void_GameObjectConversionSystem_Transform_TComp_0<TComp>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(RecursiveComponentAttaching.NativeMethodInfoPtr_AttachRecursiveSharedComponent_Public_Static_Void_GameObjectConversionSystem_Transform_TComp_0, Il2CppClassPointerStore<RecursiveComponentAttaching>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComp>.NativeClassPtr))
      }))));
    }
  }
}
