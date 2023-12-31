// Decompiled with JetBrains decompiler
// Type: ProjectM.EnergyComponent
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
  public class EnergyComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_MaxEnergy;
    private static readonly IntPtr NativeFieldInfoPtr_GainPerSecond;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724083, XrefRangeEnd = 724089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(EnergyComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724089, XrefRangeEnd = 724093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), EnergyComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724093, XrefRangeEnd = 724094, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe EnergyComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnergyComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(EnergyComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static EnergyComponent()
    {
      Il2CppClassPointerStore<EnergyComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (EnergyComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnergyComponent>.NativeClassPtr);
      EnergyComponent.NativeFieldInfoPtr_MaxEnergy = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnergyComponent>.NativeClassPtr, nameof (MaxEnergy));
      EnergyComponent.NativeFieldInfoPtr_GainPerSecond = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnergyComponent>.NativeClassPtr, nameof (GainPerSecond));
      EnergyComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnergyComponent>.NativeClassPtr, 100664046);
      EnergyComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnergyComponent>.NativeClassPtr, 100664047);
      EnergyComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnergyComponent>.NativeClassPtr, 100664048);
    }

    public EnergyComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float MaxEnergy
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnergyComponent.NativeFieldInfoPtr_MaxEnergy));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnergyComponent.NativeFieldInfoPtr_MaxEnergy)) = value;
      }
    }

    public unsafe float GainPerSecond
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnergyComponent.NativeFieldInfoPtr_GainPerSecond));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(EnergyComponent.NativeFieldInfoPtr_GainPerSecond)) = value;
      }
    }
  }
}
