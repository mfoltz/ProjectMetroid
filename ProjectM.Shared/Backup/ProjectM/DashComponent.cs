// Decompiled with JetBrains decompiler
// Type: ProjectM.DashComponent
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
  public class DashComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Speed;
    private static readonly IntPtr NativeFieldInfoPtr_Curve;
    private static readonly IntPtr NativeFieldInfoPtr_UseMinMaxRange;
    private static readonly IntPtr NativeFieldInfoPtr_MinRange;
    private static readonly IntPtr NativeFieldInfoPtr_MaxRange;
    private static readonly IntPtr NativeFieldInfoPtr_Range;
    private static readonly IntPtr NativeFieldInfoPtr_StopOnHit;
    private static readonly IntPtr NativeFieldInfoPtr_RotationMode;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726643, XrefRangeEnd = 726659, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(DashComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726659, XrefRangeEnd = 726668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DashComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726668, XrefRangeEnd = 726669, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DashComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DashComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DashComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DashComponent()
    {
      Il2CppClassPointerStore<DashComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DashComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DashComponent>.NativeClassPtr);
      DashComponent.NativeFieldInfoPtr_Speed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, nameof (Speed));
      DashComponent.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, nameof (Curve));
      DashComponent.NativeFieldInfoPtr_UseMinMaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, nameof (UseMinMaxRange));
      DashComponent.NativeFieldInfoPtr_MinRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, nameof (MinRange));
      DashComponent.NativeFieldInfoPtr_MaxRange = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, nameof (MaxRange));
      DashComponent.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, nameof (Range));
      DashComponent.NativeFieldInfoPtr_StopOnHit = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, nameof (StopOnHit));
      DashComponent.NativeFieldInfoPtr_RotationMode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, nameof (RotationMode));
      DashComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, 100664227);
      DashComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, 100664228);
      DashComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DashComponent>.NativeClassPtr, 100664229);
    }

    public DashComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Speed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_Speed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_Speed)) = value;
      }
    }

    public unsafe CurveReference Curve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_Curve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_Curve)) = value;
      }
    }

    public unsafe bool UseMinMaxRange
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_UseMinMaxRange));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_UseMinMaxRange)) = value;
      }
    }

    public unsafe float MinRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_MinRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_MinRange)) = value;
      }
    }

    public unsafe float MaxRange
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_MaxRange));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_MaxRange)) = value;
      }
    }

    public unsafe float Range
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_Range));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_Range)) = value;
      }
    }

    public unsafe bool StopOnHit
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_StopOnHit));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_StopOnHit)) = value;
      }
    }

    public unsafe MovementCurveRotationMode RotationMode
    {
      get
      {
        return *(MovementCurveRotationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_RotationMode));
      }
      [param: In] set
      {
        *(MovementCurveRotationMode*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DashComponent.NativeFieldInfoPtr_RotationMode)) = value;
      }
    }
  }
}
