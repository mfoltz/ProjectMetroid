// Decompiled with JetBrains decompiler
// Type: ProjectM.ScreenEdgeIconAuthoring
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ScreenEdgeIconAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_IconData;
    private static readonly IntPtr NativeFieldInfoPtr_OnlyShowIfOwner;
    private static readonly IntPtr NativeFieldInfoPtr_OnlyShowIfAlly;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211491, XrefRangeEnd = 1211512, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1211512, XrefRangeEnd = 1211516, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ScreenEdgeIconAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScreenEdgeIconAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScreenEdgeIconAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScreenEdgeIconAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScreenEdgeIconAuthoring()
    {
      Il2CppClassPointerStore<ScreenEdgeIconAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (ScreenEdgeIconAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenEdgeIconAuthoring>.NativeClassPtr);
      ScreenEdgeIconAuthoring.NativeFieldInfoPtr_IconData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconAuthoring>.NativeClassPtr, nameof (IconData));
      ScreenEdgeIconAuthoring.NativeFieldInfoPtr_OnlyShowIfOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconAuthoring>.NativeClassPtr, nameof (OnlyShowIfOwner));
      ScreenEdgeIconAuthoring.NativeFieldInfoPtr_OnlyShowIfAlly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIconAuthoring>.NativeClassPtr, nameof (OnlyShowIfAlly));
      ScreenEdgeIconAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconAuthoring>.NativeClassPtr, 100663763);
      ScreenEdgeIconAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconAuthoring>.NativeClassPtr, 100663764);
      ScreenEdgeIconAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScreenEdgeIconAuthoring>.NativeClassPtr, 100663765);
    }

    public ScreenEdgeIconAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ScreenEdgeIconData IconData
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconAuthoring.NativeFieldInfoPtr_IconData));
        return pointer == IntPtr.Zero ? (ScreenEdgeIconData) null : new ScreenEdgeIconData(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconAuthoring.NativeFieldInfoPtr_IconData), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool OnlyShowIfOwner
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconAuthoring.NativeFieldInfoPtr_OnlyShowIfOwner));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconAuthoring.NativeFieldInfoPtr_OnlyShowIfOwner)) = value;
      }
    }

    public unsafe bool OnlyShowIfAlly
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconAuthoring.NativeFieldInfoPtr_OnlyShowIfAlly));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScreenEdgeIconAuthoring.NativeFieldInfoPtr_OnlyShowIfAlly)) = value;
      }
    }
  }
}
