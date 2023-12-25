// Decompiled with JetBrains decompiler
// Type: ProjectM.Tiles.TileModelCleanupNetworkedChildrenInSubsceneSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Tiles
{
  public class TileModelCleanupNetworkedChildrenInSubsceneSystem : SystemBase
  {
    private static readonly IntPtr NativeFieldInfoPtr__ChildNetworkedTileModelsToDestroy;
    private static readonly IntPtr NativeFieldInfoPtr__TileModelsWithNetworkedChildren;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087490, XrefRangeEnd = 1087519, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1087519, XrefRangeEnd = 1087572, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TileModelCleanupNetworkedChildrenInSubsceneSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TileModelCleanupNetworkedChildrenInSubsceneSystem>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TileModelCleanupNetworkedChildrenInSubsceneSystem()
    {
      Il2CppClassPointerStore<TileModelCleanupNetworkedChildrenInSubsceneSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Tiles", nameof (TileModelCleanupNetworkedChildrenInSubsceneSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TileModelCleanupNetworkedChildrenInSubsceneSystem>.NativeClassPtr);
      TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeFieldInfoPtr__ChildNetworkedTileModelsToDestroy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelCleanupNetworkedChildrenInSubsceneSystem>.NativeClassPtr, nameof (_ChildNetworkedTileModelsToDestroy));
      TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeFieldInfoPtr__TileModelsWithNetworkedChildren = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TileModelCleanupNetworkedChildrenInSubsceneSystem>.NativeClassPtr, nameof (_TileModelsWithNetworkedChildren));
      TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelCleanupNetworkedChildrenInSubsceneSystem>.NativeClassPtr, 100685608);
      TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelCleanupNetworkedChildrenInSubsceneSystem>.NativeClassPtr, 100685609);
      TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelCleanupNetworkedChildrenInSubsceneSystem>.NativeClassPtr, 100685610);
      TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TileModelCleanupNetworkedChildrenInSubsceneSystem>.NativeClassPtr, 100685611);
    }

    public TileModelCleanupNetworkedChildrenInSubsceneSystem(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe EntityQuery _ChildNetworkedTileModelsToDestroy
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeFieldInfoPtr__ChildNetworkedTileModelsToDestroy));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeFieldInfoPtr__ChildNetworkedTileModelsToDestroy)) = value;
      }
    }

    public unsafe EntityQuery _TileModelsWithNetworkedChildren
    {
      get
      {
        return *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeFieldInfoPtr__TileModelsWithNetworkedChildren));
      }
      [param: In] set
      {
        *(EntityQuery*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TileModelCleanupNetworkedChildrenInSubsceneSystem.NativeFieldInfoPtr__TileModelsWithNetworkedChildren)) = value;
      }
    }
  }
}
