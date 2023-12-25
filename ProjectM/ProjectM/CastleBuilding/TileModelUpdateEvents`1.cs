// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.TileModelUpdateEvents`1
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class TileModelUpdateEvents<TComponent> : EntityUpdateEventSystem<TComponent, TilePosition>
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_MakeEnabledQuery_Protected_Virtual_EntityQuery_Il2CppStructArray_1_ComponentType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetBarrier_Protected_Virtual_EntityCommandBufferSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129065, XrefRangeEnd = 1129072, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe EntityQuery MakeEnabledQuery(
      [Optional] Il2CppStructArray<ComponentType> componentTypes)
    {
      if (componentTypes == null)
        componentTypes = new Il2CppStructArray<ComponentType>(0L);
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) componentTypes);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelUpdateEvents<TComponent>.NativeMethodInfoPtr_MakeEnabledQuery_Protected_Virtual_EntityQuery_Il2CppStructArray_1_ComponentType_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(EntityQuery*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129072, XrefRangeEnd = 1129087, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe EntityCommandBufferSystem GetBarrier()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelUpdateEvents<TComponent>.NativeMethodInfoPtr_GetBarrier_Protected_Virtual_EntityCommandBufferSystem_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (EntityCommandBufferSystem) null : new EntityCommandBufferSystem(pointer);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 137652, RefRangeEnd = 137661, XrefRangeStart = 137652, XrefRangeEnd = 137661, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileModelUpdateEvents()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileModelUpdateEvents<TComponent>>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelUpdateEvents<TComponent>.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(8)]
    [CachedScanResults(RefRangeStart = 159697, RefRangeEnd = 159705, XrefRangeStart = 159697, XrefRangeEnd = 159705, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelUpdateEvents<TComponent>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    public override EntityQuery MakeEnabledQuery(params ComponentType[] componentTypes)
    {
      // ISSUE: explicit non-virtual call
      return __nonvirtual (((TileModelUpdateEvents<>) this).MakeEnabledQuery(new Il2CppStructArray<ComponentType>(componentTypes)));
    }

    static TileModelUpdateEvents()
    {
      // ISSUE: explicit non-virtual call
      // ISSUE: explicit non-virtual call
      Il2CppClassPointerStore<TileModelUpdateEvents<TComponent>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(__nonvirtual (__nonvirtual (Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", "TileModelUpdateEvents`1"))).MakeGenericType(new Il2CppReferenceArray<Il2CppSystem.Type>(new Il2CppSystem.Type[1]
      {
        Il2CppSystem.Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TComponent>.NativeClassPtr))
      }))).TypeHandle).value);
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelUpdateEvents<TComponent>>.NativeClassPtr);
      TileModelUpdateEvents<TComponent>.NativeMethodInfoPtr_MakeEnabledQuery_Protected_Virtual_EntityQuery_Il2CppStructArray_1_ComponentType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelUpdateEvents<TComponent>>.NativeClassPtr, 100689729);
      TileModelUpdateEvents<TComponent>.NativeMethodInfoPtr_GetBarrier_Protected_Virtual_EntityCommandBufferSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelUpdateEvents<TComponent>>.NativeClassPtr, 100689730);
      TileModelUpdateEvents<TComponent>.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelUpdateEvents<TComponent>>.NativeClassPtr, 100689731);
      TileModelUpdateEvents<TComponent>.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelUpdateEvents<TComponent>>.NativeClassPtr, 100689732);
    }

    public TileModelUpdateEvents(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
