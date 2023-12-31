// Decompiled with JetBrains decompiler
// Type: ProjectM.TileModelQueryDesc
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Reflection;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class TileModelQueryDesc : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryEnabledTileModels_Public_Static_EntityQueryDesc_Il2CppStructArray_1_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_QueryDisabledTileModels_Public_Static_Il2CppReferenceArray_1_EntityQueryDesc_Il2CppStructArray_1_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Method_Internal_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_0;

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 732212, RefRangeEnd = 732220, XrefRangeStart = 732186, XrefRangeEnd = 732212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQueryDesc QueryEnabledTileModels(
      [Optional] Il2CppStructArray<ComponentType> componentTypes)
    {
      if (componentTypes == null)
        componentTypes = new Il2CppStructArray<ComponentType>(0L);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentTypes);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelQueryDesc.NativeMethodInfoPtr_QueryEnabledTileModels_Public_Static_EntityQueryDesc_Il2CppStructArray_1_ComponentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EntityQueryDesc) null : new EntityQueryDesc(pointer);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 732243, RefRangeEnd = 732245, XrefRangeStart = 732220, XrefRangeEnd = 732243, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppReferenceArray<EntityQueryDesc> QueryDisabledTileModels(
      [Optional] Il2CppStructArray<ComponentType> componentTypes)
    {
      if (componentTypes == null)
        componentTypes = new Il2CppStructArray<ComponentType>(0L);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentTypes);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelQueryDesc.NativeMethodInfoPtr_QueryDisabledTileModels_Public_Static_Il2CppReferenceArray_1_EntityQueryDesc_Il2CppStructArray_1_ComponentType_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr nativeObject = num;
      return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<EntityQueryDesc>) null : new Il2CppReferenceArray<EntityQueryDesc>(nativeObject);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 732285, RefRangeEnd = 732286, XrefRangeStart = 732245, XrefRangeEnd = 732285, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe EntityQueryDesc Method_Internal_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_0<T>(
      EntityQueryOptions options,
      Il2CppStructArray<ComponentType> types)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &options;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) types);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TileModelQueryDesc.MethodInfoStoreGeneric_Method_Internal_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_0<T>.Pointer, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EntityQueryDesc) null : new EntityQueryDesc(pointer);
    }

    public static EntityQueryDesc QueryEnabledTileModels(params ComponentType[] componentTypes)
    {
      return TileModelQueryDesc.QueryEnabledTileModels(new Il2CppStructArray<ComponentType>(componentTypes));
    }

    public static Il2CppReferenceArray<EntityQueryDesc> QueryDisabledTileModels(
      params ComponentType[] componentTypes)
    {
      return TileModelQueryDesc.QueryDisabledTileModels(new Il2CppStructArray<ComponentType>(componentTypes));
    }

    static TileModelQueryDesc()
    {
      Il2CppClassPointerStore<TileModelQueryDesc>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TileModelQueryDesc));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelQueryDesc>.NativeClassPtr);
      TileModelQueryDesc.NativeMethodInfoPtr_QueryEnabledTileModels_Public_Static_EntityQueryDesc_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelQueryDesc>.NativeClassPtr, 100664691);
      TileModelQueryDesc.NativeMethodInfoPtr_QueryDisabledTileModels_Public_Static_Il2CppReferenceArray_1_EntityQueryDesc_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelQueryDesc>.NativeClassPtr, 100664692);
      TileModelQueryDesc.NativeMethodInfoPtr_Method_Internal_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelQueryDesc>.NativeClassPtr, 100664693);
    }

    public TileModelQueryDesc(System.IntPtr pointer)
      : base(pointer)
    {
    }

    private sealed class MethodInfoStoreGeneric_Method_Internal_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_0<T>
    {
      internal static System.IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) new MethodInfo(IL2CPP.il2cpp_method_get_object(TileModelQueryDesc.NativeMethodInfoPtr_Method_Internal_Static_EntityQueryDesc_EntityQueryOptions_Il2CppStructArray_1_ComponentType_0, Il2CppClassPointerStore<TileModelQueryDesc>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr))
      }))));
    }
  }
}
