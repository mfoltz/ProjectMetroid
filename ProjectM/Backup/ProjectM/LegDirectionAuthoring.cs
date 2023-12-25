// Decompiled with JetBrains decompiler
// Type: ProjectM.LegDirectionAuthoring
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
namespace ProjectM
{
  public class LegDirectionAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_RotationSpeed;
    private static readonly IntPtr NativeFieldInfoPtr_FullSpeedAngle;
    private static readonly IntPtr NativeFieldInfoPtr_MinSpeedAngle;
    private static readonly IntPtr NativeFieldInfoPtr_MinSpeedMultiplier;
    private static readonly IntPtr NativeFieldInfoPtr_OnlyUseCharacterRotation;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023101, XrefRangeEnd = 1023107, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(LegDirectionAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1023107, XrefRangeEnd = 1023111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LegDirectionAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LegDirectionAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LegDirectionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LegDirectionAuthoring()
    {
      Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LegDirectionAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr);
      LegDirectionAuthoring.NativeFieldInfoPtr_RotationSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr, nameof (RotationSpeed));
      LegDirectionAuthoring.NativeFieldInfoPtr_FullSpeedAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr, nameof (FullSpeedAngle));
      LegDirectionAuthoring.NativeFieldInfoPtr_MinSpeedAngle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr, nameof (MinSpeedAngle));
      LegDirectionAuthoring.NativeFieldInfoPtr_MinSpeedMultiplier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr, nameof (MinSpeedMultiplier));
      LegDirectionAuthoring.NativeFieldInfoPtr_OnlyUseCharacterRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr, nameof (OnlyUseCharacterRotation));
      LegDirectionAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr, 100679892);
      LegDirectionAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr, 100679893);
      LegDirectionAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LegDirectionAuthoring>.NativeClassPtr, 100679894);
    }

    public LegDirectionAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float RotationSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegDirectionAuthoring.NativeFieldInfoPtr_RotationSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegDirectionAuthoring.NativeFieldInfoPtr_RotationSpeed)) = value;
      }
    }

    public unsafe float FullSpeedAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegDirectionAuthoring.NativeFieldInfoPtr_FullSpeedAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegDirectionAuthoring.NativeFieldInfoPtr_FullSpeedAngle)) = value;
      }
    }

    public unsafe float MinSpeedAngle
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegDirectionAuthoring.NativeFieldInfoPtr_MinSpeedAngle));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegDirectionAuthoring.NativeFieldInfoPtr_MinSpeedAngle)) = value;
      }
    }

    public unsafe float MinSpeedMultiplier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegDirectionAuthoring.NativeFieldInfoPtr_MinSpeedMultiplier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegDirectionAuthoring.NativeFieldInfoPtr_MinSpeedMultiplier)) = value;
      }
    }

    public unsafe bool OnlyUseCharacterRotation
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegDirectionAuthoring.NativeFieldInfoPtr_OnlyUseCharacterRotation));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LegDirectionAuthoring.NativeFieldInfoPtr_OnlyUseCharacterRotation)) = value;
      }
    }
  }
}
