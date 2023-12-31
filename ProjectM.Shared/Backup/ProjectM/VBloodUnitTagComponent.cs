// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodUnitTagComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class VBloodUnitTagComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_CanBeTracked;
    private static readonly IntPtr NativeFieldInfoPtr_CustomVBloodTrackUnit;
    private static readonly IntPtr NativeFieldInfoPtr_OverrideLockedVBloodUnit;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732396, XrefRangeEnd = 732400, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(VBloodUnitTagComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodUnitTagComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodUnitTagComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodUnitTagComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodUnitTagComponent()
    {
      Il2CppClassPointerStore<VBloodUnitTagComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (VBloodUnitTagComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodUnitTagComponent>.NativeClassPtr);
      VBloodUnitTagComponent.NativeFieldInfoPtr_CanBeTracked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodUnitTagComponent>.NativeClassPtr, nameof (CanBeTracked));
      VBloodUnitTagComponent.NativeFieldInfoPtr_CustomVBloodTrackUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodUnitTagComponent>.NativeClassPtr, nameof (CustomVBloodTrackUnit));
      VBloodUnitTagComponent.NativeFieldInfoPtr_OverrideLockedVBloodUnit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodUnitTagComponent>.NativeClassPtr, nameof (OverrideLockedVBloodUnit));
      VBloodUnitTagComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodUnitTagComponent>.NativeClassPtr, 100664712);
      VBloodUnitTagComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodUnitTagComponent>.NativeClassPtr, 100664713);
    }

    public VBloodUnitTagComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool CanBeTracked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitTagComponent.NativeFieldInfoPtr_CanBeTracked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitTagComponent.NativeFieldInfoPtr_CanBeTracked)) = value;
      }
    }

    public unsafe WeakAssetReference<VBloodUnitTagComponent> CustomVBloodTrackUnit
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitTagComponent.NativeFieldInfoPtr_CustomVBloodTrackUnit));
        return pointer == IntPtr.Zero ? (WeakAssetReference<VBloodUnitTagComponent>) null : new WeakAssetReference<VBloodUnitTagComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitTagComponent.NativeFieldInfoPtr_CustomVBloodTrackUnit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe WeakAssetReference<VBloodUnitTagComponent> OverrideLockedVBloodUnit
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitTagComponent.NativeFieldInfoPtr_OverrideLockedVBloodUnit));
        return pointer == IntPtr.Zero ? (WeakAssetReference<VBloodUnitTagComponent>) null : new WeakAssetReference<VBloodUnitTagComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodUnitTagComponent.NativeFieldInfoPtr_OverrideLockedVBloodUnit), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
