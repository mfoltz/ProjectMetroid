// Decompiled with JetBrains decompiler
// Type: ProjectM.MinionMasterAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class MinionMasterAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MaxMinions;
    private static readonly IntPtr NativeFieldInfoPtr_MaxMinionsPerPlayer;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723134, XrefRangeEnd = 723144, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(MinionMasterAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 723144, XrefRangeEnd = 723145, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MinionMasterAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinionMasterAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinionMasterAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MinionMasterAuthoring()
    {
      Il2CppClassPointerStore<MinionMasterAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MinionMasterAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinionMasterAuthoring>.NativeClassPtr);
      MinionMasterAuthoring.NativeFieldInfoPtr_MaxMinions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinionMasterAuthoring>.NativeClassPtr, nameof (MaxMinions));
      MinionMasterAuthoring.NativeFieldInfoPtr_MaxMinionsPerPlayer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinionMasterAuthoring>.NativeClassPtr, nameof (MaxMinionsPerPlayer));
      MinionMasterAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinionMasterAuthoring>.NativeClassPtr, 100663915);
      MinionMasterAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinionMasterAuthoring>.NativeClassPtr, 100663916);
    }

    public MinionMasterAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int MaxMinions
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinionMasterAuthoring.NativeFieldInfoPtr_MaxMinions));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinionMasterAuthoring.NativeFieldInfoPtr_MaxMinions)) = value;
      }
    }

    public unsafe Il2CppStructArray<int> MaxMinionsPerPlayer
    {
      get
      {
        IntPtr nativeObject = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(MinionMasterAuthoring.NativeFieldInfoPtr_MaxMinionsPerPlayer));
        return nativeObject == IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(MinionMasterAuthoring.NativeFieldInfoPtr_MaxMinionsPerPlayer), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
