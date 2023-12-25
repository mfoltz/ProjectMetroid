// Decompiled with JetBrains decompiler
// Type: ProjectM.ZoomModifierAreaAuthoring
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
  public class ZoomModifierAreaAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Radius;
    private static readonly IntPtr NativeFieldInfoPtr_KeepZoomBonusDistance;
    private static readonly IntPtr NativeFieldInfoPtr_LerpDuration;
    private static readonly IntPtr NativeFieldInfoPtr_Importance;
    private static readonly IntPtr NativeFieldInfoPtr_MinZoomBonus;
    private static readonly IntPtr NativeFieldInfoPtr_MaxZoomBonus;
    private static readonly IntPtr NativeFieldInfoPtr_MinPitchBonus;
    private static readonly IntPtr NativeFieldInfoPtr_MaxPitchBonus;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002317, XrefRangeEnd = 1002320, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ZoomModifierAreaAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnDrawGizmos()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ZoomModifierAreaAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1002320, XrefRangeEnd = 1002321, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ZoomModifierAreaAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ZoomModifierAreaAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ZoomModifierAreaAuthoring()
    {
      Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ZoomModifierAreaAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr);
      ZoomModifierAreaAuthoring.NativeFieldInfoPtr_Radius = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, nameof (Radius));
      ZoomModifierAreaAuthoring.NativeFieldInfoPtr_KeepZoomBonusDistance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, nameof (KeepZoomBonusDistance));
      ZoomModifierAreaAuthoring.NativeFieldInfoPtr_LerpDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, nameof (LerpDuration));
      ZoomModifierAreaAuthoring.NativeFieldInfoPtr_Importance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, nameof (Importance));
      ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MinZoomBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, nameof (MinZoomBonus));
      ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MaxZoomBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, nameof (MaxZoomBonus));
      ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MinPitchBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, nameof (MinPitchBonus));
      ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MaxPitchBonus = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, nameof (MaxPitchBonus));
      ZoomModifierAreaAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, 100677648);
      ZoomModifierAreaAuthoring.NativeMethodInfoPtr_OnDrawGizmos_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, 100677649);
      ZoomModifierAreaAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ZoomModifierAreaAuthoring>.NativeClassPtr, 100677650);
    }

    public ZoomModifierAreaAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Radius
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_Radius));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_Radius)) = value;
      }
    }

    public unsafe float KeepZoomBonusDistance
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_KeepZoomBonusDistance));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_KeepZoomBonusDistance)) = value;
      }
    }

    public unsafe float LerpDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_LerpDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_LerpDuration)) = value;
      }
    }

    public unsafe int Importance
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_Importance));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_Importance)) = value;
      }
    }

    public unsafe float MinZoomBonus
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MinZoomBonus));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MinZoomBonus)) = value;
      }
    }

    public unsafe float MaxZoomBonus
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MaxZoomBonus));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MaxZoomBonus)) = value;
      }
    }

    public unsafe float MinPitchBonus
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MinPitchBonus));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MinPitchBonus)) = value;
      }
    }

    public unsafe float MaxPitchBonus
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MaxPitchBonus));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ZoomModifierAreaAuthoring.NativeFieldInfoPtr_MaxPitchBonus)) = value;
      }
    }
  }
}
